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

namespace CIS_411
{
    public partial class EditMemberships : Form
    {
        String connectionString;
        SqlConnection connection;
        SqlCommand command;

        //List of memberships for display in combobox
        List<Memberships> memberships;

        //Class for membership info
        Memberships member = new Memberships();

        //Strings use to track status of if statements
        string cancelStatus = "close";
        string saveStatus = "";
        String dateFormat = "yyyy-MM-dd";

        public EditMemberships()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.ClarionRecCenterConnectionString1;
            connection = new SqlConnection(connectionString);
            memberships = new List<Memberships>();
            this.CenterToScreen();
        }

        //Cancel button, if actively updating or adding memberships then it resets form
        //If no option has been selected or it has been reset it will close the form
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
                selectMember();
                cboMembershipSelect.SelectedIndex = 0;
            }
        }

        //Clears the txt and chk boxes
        private void clearTxt()
        {
            txtDuration.Text = "";
            txtCost.Text = "";
            txtDescription.Text = "";
            cboExpType.SelectedIndex = -1;
            chkDayPass.Checked = false;
            chkActive.Checked = false;
            chkRestricted.Checked = false;
        }

        //enables the txt and chk boxes
        private void enableTxt()
        {
            txtDuration.Enabled = true;
            txtCost.Enabled = true;
            txtDescription.Enabled = true;
            cboExpType.Enabled = true;
            chkDayPass.Enabled = true;
            chkActive.Enabled = true;
            chkRestricted.Enabled = true;
            dtpExp.Enabled = true;
        }

        //disables the txt and chk boxes
        private void disableTxt()
        {
            txtDuration.Enabled = false;
            txtCost.Enabled = false;
            txtDescription.Enabled = false;
            cboExpType.Enabled = false;
            chkDayPass.Enabled = false;
            chkActive.Enabled = false;
            chkRestricted.Enabled = false;
            btnSave.Enabled = false;
            dtpExp.Enabled = false;
        }

        //enables default view of form so user can choose edit and which user to edit from cbobox or add new
        private void enableStart()
        {
            cboMembershipSelect.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void EditMemberships_Load(object sender, EventArgs e)
        {
            //Calls function to populate the combobox
            populateCboBox();
        }

        private void populateCboBox()
        {
            //Clears cbobox for new items
            cboMembershipSelect.Items.Clear();
            //Clears list to remove duplication when updated
            memberships = new List<Memberships>();
            //Calls function that does the SELECT statement
            collectMemberships();
        }

        private void collectMemberships()
        {
            //Query to get memberships table
            string membershipSelect = "SELECT MEMBERSHIP_ID, DURATION, COST, RESTRICTED, " +
                                      "DESCRIPTION, ACTIVE, EXP_DATE, EXP_TYPE, DAY_PASS FROM MEMBERSHIP_TYPE ";
            command = new SqlCommand(membershipSelect, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                //Reads the memberships and stores them
                while (reader.Read())
                {
                    Memberships tempMember = new Memberships();

                    tempMember.MembershipID = reader["MEMBERSHIP_ID"].ToString();
                    tempMember.Duration = reader["DURATION"].ToString();
                    tempMember.Cost = reader["COST"].ToString();
                    tempMember.Description = reader["DESCRIPTION"].ToString();
                    tempMember.Active = reader["ACTIVE"].ToString();
                    tempMember.Restricted = reader["RESTRICTED"].ToString();
                    tempMember.ExpirationType = reader["EXP_TYPE"].ToString();
                    tempMember.Daypass = reader["DAY_PASS"] is DBNull ? "N" : reader["DAY_PASS"].ToString();
                    tempMember.Expiration = reader["EXP_DATE"] is DBNull ? DateTime.Now : Convert.ToDateTime(reader["EXP_DATE"]);

                    memberships.Add(tempMember);
                }
                loadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1 Membership Display: \n" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        //adds memberships into the cbobox for display and ease of use when editing
        private void loadMembers()
        {
            foreach (Memberships aMember in memberships)
            {
                cboMembershipSelect.Items.Add(aMember.MembershipID.ToString().Replace(" ", String.Empty) + " " + "--" + " " + aMember.Description.ToString());
            }
            cboMembershipSelect.SelectedIndex = 0;
        }

        //Edit button used to enable the options and controls for actually editing
        private void btnEdit_Click(object sender, EventArgs e)
        {
            saveStatus = "edit";
            cancelStatus = "started";
            btnCancel.Text = "Cancel";
            enableTxt();
            cboMembershipSelect.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            this.ActiveControl = txtDuration;
        }

        //Query for editing a record in the database
        private void editMember(string originalID)
        {
            string updateMember = "UPDATE MEMBERSHIP_TYPE " +
                                  "SET DURATION = @DURATION, COST = @COST, RESTRICTED = @RESTRICTED, " +
                                  "DESCRIPTION = @DESCRIPTION, ACTIVE = @ACTIVE, " +
                                  "EXP_DATE = @EXP_DATE, EXP_TYPE = @EXP_TYPE, DAY_PASS = @DAY_PASS " +
                                  "WHERE(MEMBERSHIP_ID = @Original_MEMBERSHIP_ID) OR (MEMBERSHIP_ID = @Original_MEMBERSHIP_ID) ";

            command = new SqlCommand(updateMember, connection);

            try
            {
                connection.Open();

                string active = "N";
                string rest = "N";
                string day = "N";
                //int duration = 0;

                if (chkActive.Checked == true)
                {
                    active = "Y";
                }
                else
                {
                    active = "N";
                }

                if (chkRestricted.Checked == true)
                {
                    rest = "Y";
                }
                else
                {
                    rest = "N";
                }

                if (chkDayPass.Checked == true)
                {
                    day = "Y";
                }
                else
                {
                    day = "N";
                }

                command.Parameters.AddWithValue("@Original_MEMBERSHIP_ID", originalID);
                command.Parameters.AddWithValue("@COST", txtCost.Text);
                command.Parameters.AddWithValue("@RESTRICTED", rest.ToString());
                command.Parameters.AddWithValue("@ACTIVE", active.ToString());
                command.Parameters.AddWithValue("@DESCRIPTION", txtDescription.Text);
                if (cboExpType.SelectedItem.ToString() == "Duration")
                {
                    command.Parameters.AddWithValue("@EXP_DATE", DBNull.Value);
                    command.Parameters.AddWithValue("@EXP_TYPE", "DURA");

                    if (txtDuration.Text == "")
                    {
                        command.Parameters.AddWithValue("@DURATION", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@DURATION", txtDuration.Text);
                    }

                }
                else
                {
                    command.Parameters.AddWithValue("@EXP_DATE", dtpExp.Value.ToString(dateFormat));
                    command.Parameters.AddWithValue("@EXP_TYPE", "DATE");
                    command.Parameters.AddWithValue("@DURATION", DBNull.Value);
                }
                var varr = dtpExp.Value.ToString(dateFormat);
                command.Parameters.AddWithValue("@DAY_PASS", day.ToString());

                command.ExecuteNonQuery();

                MessageBox.Show("Membership has been updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2 Membership Update: \n" + ex);
            }
            finally
            {
                connection.Close();
            }
            populateCboBox();
        }

        //Button that allows add function/controls to be used
        private void btnAdd_Click(object sender, EventArgs e)
        {
            saveStatus = "add";
            cancelStatus = "started";
            btnCancel.Text = "Cancel";
            enableTxt();
            clearTxt();
            cboMembershipSelect.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            this.ActiveControl = txtDuration;
        }

        //Query for adding a new member to database
        private void addMembership()
        {
            string memberAdd = "INSERT INTO MEMBERSHIP_TYPE " +
                               "(DURATION, COST, RESTRICTED, DESCRIPTION, ACTIVE, " +
                               "EXP_DATE, EXP_TYPE, DAY_PASS) " +
                               "VALUES(@DURATION, @COST, @RESTRICTED, @DESCRIPTION, @ACTIVE, " +
                               "@EXP_DATE, @EXP_TYPE, @DAY_PASS)";

            command = new SqlCommand(memberAdd, connection);

            try
            {
                connection.Open();
                //Calls function that takes info from textbox for INSERT query
                getMemberInfo();
                //Adds the stored parameters to a record in the database
                command.Parameters.AddWithValue("@COST", member.Cost);
                command.Parameters.AddWithValue("@RESTRICTED", member.Restricted);
                command.Parameters.AddWithValue("@ACTIVE", member.Active);
                command.Parameters.AddWithValue("@DESCRIPTION", member.Description);
                command.Parameters.AddWithValue("@EXP_TYPE", member.ExpirationType);
                command.Parameters.AddWithValue("@DAY_PASS", member.Daypass);

                if (cboExpType.SelectedItem.ToString() == "Duration")
                {
                    command.Parameters.AddWithValue("@EXP_DATE", DBNull.Value);

                    if (txtDuration.Text == "")
                    {
                        command.Parameters.AddWithValue("@DURATION", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@DURATION", txtDuration.Text);
                    }
                }
                else
                {
                    command.Parameters.AddWithValue("@EXP_DATE", dtpExp.Value.ToString(dateFormat));
                    command.Parameters.AddWithValue("@DURATION", DBNull.Value);
                }

                command.ExecuteNonQuery();

                MessageBox.Show("Membership has been added to the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 3 Membership Insert: \n" + ex);
            }
            finally
            {
                connection.Close();
            }

            populateCboBox();
        }

        //Gets information from form
        private void getMemberInfo()
        {
            member.Duration = txtDuration.Text;
            member.Cost = txtCost.Text;

            string active = "N";
            string rest = "N";
            string day = "N";

            if (chkActive.Checked == true)
            {
                active = "Y";
            }
            else
            {
                active = "N";
            }

            if (chkRestricted.Checked == true)
            {
                rest = "Y";
            }
            else
            {
                rest = "N";
            }

            if (chkDayPass.Checked == true)
            {
                day = "Y";
            }
            else
            {
                day = "N";
            }

            member.Active = active;
            member.Restricted = rest;
            member.Description = txtDescription.Text;
            member.Daypass = day;
            member.Expiration = dtpExp.Value;
            if (cboExpType.SelectedItem.ToString() == "Duration")
            {
                member.ExpirationType = "DURA";            }
            else
            {
                member.ExpirationType = "DATE";
            }
        }

        //Main query for use in updating the cbobox of memberships
        private void selectMember()
        {
            connection.Close();
            string selectMember = "SELECT MEMBERSHIP_ID, DURATION, COST, RESTRICTED, " +
                                  "DESCRIPTION, ACTIVE, EXP_DATE, EXP_TYPE, DAY_PASS FROM MEMBERSHIP_TYPE " +
                                  "WHERE (MEMBERSHIP_ID = @MEMBERSHIP_ID)";

            command = new SqlCommand(selectMember, connection);

            string id = cboMembershipSelect.SelectedItem.ToString();
            id = id.Substring(0, id.IndexOf(" "));

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@MEMBERSHIP_ID", id);

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    txtDuration.Text = reader["DURATION"].ToString();
                    txtCost.Text = reader["COST"].ToString();
                    txtDescription.Text = reader["DESCRIPTION"].ToString();
                    string active = reader["ACTIVE"].ToString();
                    string rest = reader["RESTRICTED"].ToString();
                    string day = reader["DAY_PASS"] is DBNull ? "N" : reader["DAY_PASS"].ToString();
                    dtpExp.Value = reader["EXP_DATE"] is DBNull ? DateTime.Now : Convert.ToDateTime(reader["EXP_DATE"]);
                    if (reader["EXP_TYPE"].ToString() == "DURA")
                    {
                        cboExpType.Text = "Duration";
                    }
                    else
                    {
                        cboExpType.Text = "Date";
                    }
                    chkBoxes(active, rest, day);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 4 Select Membership from combobox: \n" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        //Sets the status of the check boxes for each membership type when it is selected in the cbobox
        private void chkBoxes(string active, string rest, string day)
        {
            if (active == "Y")
            {
                chkActive.Checked = true;
            }
            else
            {
                chkActive.Checked = false;
            }
            if (rest == "Y")
            {
                chkRestricted.Checked = true;
            }
            else
            {
                chkRestricted.Checked = false;
            }
            if (day == "Y")
            {
                chkDayPass.Checked = true;
            }
            else
            {
                chkDayPass.Checked = false;
            }
        }

        //Calls info for when cbobox selected item changes
        private void cboMembershipSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectMember();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            saveStatus = "add";
            cancelStatus = "started";
            btnCancel.Text = "Cancel";
            enableTxt();
            clearTxt();
            cboMembershipSelect.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            this.ActiveControl = txtDuration;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //Checks which button was initially clicked and then runs the appropriate function
            if (saveStatus == "edit")
            {
                string id = cboMembershipSelect.SelectedItem.ToString();
                id = id.Substring(0, id.IndexOf(' '));
                editMember(id);
            }
            else if (saveStatus == "add")
            {
                addMembership();
            }

            clearTxt();
            disableTxt();
            btnCancel.Text = "Close";
            cancelStatus = "close";
            enableStart();
            cboMembershipSelect.Enabled = true;
            selectMember();
            cboMembershipSelect.SelectedIndex = 0;
        }

        private void cboMembershipSelect_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectMember();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            saveStatus = "edit";
            cancelStatus = "started";
            btnCancel.Text = "Cancel";
            enableTxt();
            cboMembershipSelect.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            this.ActiveControl = txtDuration;
        }
    }
}
