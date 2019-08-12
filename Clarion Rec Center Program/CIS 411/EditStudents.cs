using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clarion_Security;


namespace CIS_411
{
    public partial class EditStudents : Form
    {
        String connectionString;
        SqlConnection connection;
        SqlCommand command;
        ClarionSecurity Security;

        //List of workers for display in combo box
        List<StudentWorker> workers;

        //Class for worker info
        StudentWorker worker = new StudentWorker();

        //This string is used to track different if statements below
        string cancelStatus = "close";
        string saveStatus = "";
        public EditStudents(ClarionSecurity sec)
        {
            InitializeComponent();
            Security = sec;
            connectionString = Properties.Settings.Default.ClarionRecCenterConnectionString1;
            connection = new SqlConnection(connectionString);
            workers = new List<StudentWorker>();
            this.CenterToScreen();

        }

        //Cancel button, if user has clicked edit or add then it will reset the form
        //If the form is reset or unchanged it will close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cancelStatus == "close")
            {
                this.Close();
            }
            else if (cancelStatus == "started")
            {
                clearTxt();
                disableTxt();
                enableStart();
                btnSave.Enabled = false;
                cancelStatus = "close";
                btnCancel.Text = "Close";
                selectWorker();
                cboStudentSelect.SelectedIndex = 0;
            }
        }

        //Clears the txt boxes
        private void clearTxt()
        {
            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
        }

        //Enables the txt boxes
        private void enableTxt()
        {
            txtUsername.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPassword.Enabled = true;
        }

        //Disables the txt boxes
        private void disableTxt()
        {
            txtUsername.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPassword.Enabled = false;
        }

        //Enables the initial form
        private void enableStart()
        {
            cboStudentSelect.Enabled = true;
            btnAddWorker.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void EditStudents_Load(object sender, EventArgs e)
        {
            //Calls function to put usernames into combobox
            populateCboBox();
        }

        private void populateCboBox()
        {
            //Empties the combobox
            cboStudentSelect.Items.Clear();

            // Clears list so combobox repopulates with fresh List
            workers = new List<StudentWorker>();

            //Calls the function to SELECT info from WORKERS table
            collectWorkers();
        }

        //Gets all workers from WORKERS table
        private void collectWorkers()
        {
            //Query to get all student worker usernames
            string workerSelect = "SELECT S_NAME, FIRST_NAME, LAST_NAME, PASSWORD FROM WORKER";
            command = new SqlCommand(workerSelect, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                //Reads the usernames and stores them
                while (reader.Read())
                {
                    StudentWorker tempWork = new StudentWorker();

                    tempWork.WUserName = reader["S_NAME"].ToString();
                    tempWork.WFirstName = reader["FIRST_NAME"].ToString();
                    tempWork.WLastName = reader["LAST_NAME"].ToString();
                    tempWork.Password = reader["PASSWORD"].ToString();

                    workers.Add(tempWork);
                }

                loadWorkers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1 Worker Display: \n" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        //Uses a loop to put each worker collected in the above function into the combobox 
        private void loadWorkers()
        {
            foreach (StudentWorker aWorker in workers)
            {
                cboStudentSelect.Items.Add(aWorker.WFirstName.Replace(" ", String.Empty) + " " + aWorker.WLastName.Replace(" ", String.Empty));
            }

            cboStudentSelect.SelectedIndex = 0;
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            saveStatus = "add";
            cancelStatus = "started";
            btnCancel.Text = "Cancel";
            enableTxt();
            clearTxt();
            btnAddWorker.Enabled = false;
            cboStudentSelect.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            this.ActiveControl = txtPassword;
        }

        private void addWorker()
        {
            //Query for inserting a new worker
            string workerAdd = "INSERT INTO WORKER " +
                               "(S_NAME, FIRST_NAME, LAST_NAME, PASSWORD, ACTIVE) " +
                               "VALUES(@S_NAME, @FIRST_NAME, @LAST_NAME, @PASSWORD, 'Y')";

            command = new SqlCommand(workerAdd, connection);

            try
            {
                connection.Open();
                //Calls function that takes info from textbox for INSERT query
                getWorkerInfo();
                //Adds the stored parameters to a record in the database
                command.Parameters.AddWithValue("S_NAME", worker.WUserName);
                command.Parameters.AddWithValue("FIRST_NAME", worker.WFirstName);
                command.Parameters.AddWithValue("LAST_NAME", worker.WLastName);
                command.Parameters.AddWithValue("PASSWORD", worker.Password);

                command.ExecuteNonQuery();
                //add student worker to Security module
                Security.AddUser(worker.WUserName, worker.WFirstName, worker.WLastName);

                MessageBox.Show("Student worker has been addedd to the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2 Worker Insert: \n" + ex);
            }
            finally
            {
                connection.Close();
            }

            populateCboBox();
        }

        //Grabs textbox strings
        private void getWorkerInfo()
        {
            worker.WUserName = txtUsername.Text.ToLower();
            worker.WFirstName = txtFirstName.Text;
            worker.WLastName = txtLastName.Text;
            worker.Password = txtPassword.Text;
        }

        //Button to determine which function is going to be used
        private void btnEdit_Click(object sender, EventArgs e)
        {
            saveStatus = "edit";
            cancelStatus = "started";
            btnCancel.Text = "Cancel";
            enableTxt();
            txtUsername.Enabled = false;
            cboStudentSelect.Enabled = false;
            btnAddWorker.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            chkActive.Enabled = true;
            this.ActiveControl = txtPassword;
        }

        //Function to update workers
        private void editWorker(string originalUser)
        {
            string updateWorker = "UPDATE WORKER " +
                                  "SET S_NAME = @S_NAME, FIRST_NAME = @FIRST_NAME, LAST_NAME = @LAST_NAME, PASSWORD = @PASSWORD, ACTIVE = @ACTIVE " +
                                  "WHERE(S_NAME = @Original_S_NAME)";
            //check for active status
            string active = "";
            if (chkActive.Checked)
            {
                active = "Y";
            }
            else
            {
                active = "N";
            }

            command = new SqlCommand(updateWorker, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@Original_S_NAME", originalUser);
                command.Parameters.AddWithValue("@S_NAME", txtUsername.Text);
                command.Parameters.AddWithValue("@FIRST_NAME", txtFirstName.Text);
                command.Parameters.AddWithValue("@LAST_NAME", txtLastName.Text);
                command.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);
                command.Parameters.AddWithValue("@ACTIVE", active);

                command.ExecuteNonQuery();

                MessageBox.Show("Student Worker has been updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 3 Update Worker: \n" + ex);
            }
            finally
            {
                connection.Close();
            }

            populateCboBox();
        }

        //Function used to select workers from database and populate list
        private void selectWorker()
        {
            connection.Close();
            string selectWorker = "SELECT S_NAME, FIRST_NAME, LAST_NAME, PASSWORD, ACTIVE " +
                                  "FROM WORKER " +
                                  "WHERE (FIRST_NAME = @FIRST_NAME) AND (LAST_NAME = @LAST_NAME)";

            command = new SqlCommand(selectWorker, connection);

            string fullname = cboStudentSelect.SelectedItem.ToString();

            var name = fullname.Split(' ');
            string first = name[0];
            string last = name[1];

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@FIRST_NAME", first);
                command.Parameters.AddWithValue("@LAST_NAME", last);

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    txtUsername.Text = reader["S_NAME"].ToString();
                    txtFirstName.Text = reader["FIRST_NAME"].ToString();
                    txtLastName.Text = reader["LAST_NAME"].ToString();
                    txtPassword.Text = reader["PASSWORD"].ToString();
                    if (reader["ACTIVE"].ToString() == "Y")
                    {
                        chkActive.Checked = true;
                    }
                    else
                    {
                        chkActive.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 4 Select Worker from combobox: \n" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void cboStudentSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectWorker();
        }

        //Saves the work done into the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Does the edit functions if the edit button was selected
            if (saveStatus == "edit")
            {
                editWorker(txtUsername.Text);
            }
            //Does insert/add function if add was selected
            else if (saveStatus == "add")
            {
                addWorker();
            }

            clearTxt();
            disableTxt();
            btnCancel.Text = "Close";
            cancelStatus = "close";
            btnSave.Enabled = false;
            chkActive.Enabled = false;
            enableStart();
            selectWorker();
            cboStudentSelect.SelectedIndex = 0;
        }
    }
}
