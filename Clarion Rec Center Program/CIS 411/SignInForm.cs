using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace CIS_411
{
    public partial class SignInForm : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlCommand command;

        Regex phoneNumpattern = new Regex(@"[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]$");
        public SignInForm()
        {
            InitializeComponent();
            lblCurrentUser.Text = "Current User: " + Program.currentUser.name;
            //instantiate connection objects
            connectionString = Properties.Settings.Default.ClarionRecCenterConnectionString1;
            connection = new SqlConnection(connectionString);
        }

        private void btnDayPass_Click(object sender, EventArgs e)
        {
            //check for only alphabetical names
            if (!Regex.IsMatch(txtName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Please Enter A Valid Name");
            }
            else
            {
                //check for 10 digit phone number with dashes
                if (!phoneNumpattern.IsMatch(txtPhone.Text))
                {
                    MessageBox.Show("Please enter a valid phone number using this format: 555-555-5555");
                }
                else
                {
                    //set vars for relevant information
                    string userName = Program.currentUser.name;
                    string name = txtName.Text;
                    string phone = txtPhone.Text;
                    //instantiate an object of type DayPassForm called frmDayPass
                    DayPassForm frmDayPass = new DayPassForm(userName, name, phone);
                    //reset text boxes
                    txtName.Text = "";
                    txtPhone.Text = "";
                    //Display the day pass form in modal format
                    frmDayPass.ShowDialog();
                    txtName.Focus();
                }
            }
        }

        private void btnBuyMembership_Click(object sender, EventArgs e)
        {
            //check for only alphabetical names
            if (!Regex.IsMatch(txtName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Please Enter A Valid Name");
            }
            else
            {
                //check for 10 digit phone number with dashes
                if (!phoneNumpattern.IsMatch(txtPhone.Text))
                {
                    MessageBox.Show("Please enter a valid phone number using this format: 555-555-5555");
                }
                else
                {
                    //set vars for relevant information
                    string userName = Program.currentUser.name;
                    string name = txtName.Text;
                    string phone = txtPhone.Text;
                    //instantiate an object of type SelectMembership called frmSelectMembership
                    SelectMembership frmSelectMembership = new SelectMembership(userName, name, phone);
                    //reset text boxes
                    txtName.Text = "";
                    txtPhone.Text = "";
                    //Display the select membership form in modal format
                    frmSelectMembership.ShowDialog();
                    txtName.Focus();
                }
            }
        }

        private void btnForgotID_Click(object sender, EventArgs e)
        {
            //check for only alphabetical names
            if (!Regex.IsMatch(txtName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Please Enter A Valid Name");
            }
            else
            {
                //check for 10 digit phone number with dashes
                if (!phoneNumpattern.IsMatch(txtPhone.Text))
                {
                    MessageBox.Show("Please enter a valid phone number using this format: 555-555-5555");
                }
                else
                {
                    //search for forgotton id membType
                    string selectMembershipString = "SELECT        MEMBERSHIP_ID " +
                                            "FROM            MEMBERSHIP_TYPE " +
                                            "WHERE(DESCRIPTION = 'Forgotton ID') ";
                    command = new SqlCommand(selectMembershipString, connection);
                    int id = 0;
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                        //grabs the id of forgotton id membType
                        while (reader.Read())
                        {
                            id = int.Parse(reader["MEMBERSHIP_ID"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    finally
                    {
                        connection.Close();
                        //set vars for relevant information
                        string userName = Program.currentUser.name;
                        string name = txtName.Text;
                        string phone = txtPhone.Text;
                        //instantiate an object of type LiabilityWaiver called frmLiabilityWaiver
                        LiabilityWaiver frmLiabilityWaiver = new LiabilityWaiver(userName, name, phone, 0,
                        id, "Y", "N", 0);
                        //reset text boxes
                        txtName.Text = "";
                        txtPhone.Text = "";
                        //Displays the select membership form in modal format
                        frmLiabilityWaiver.ShowDialog();
                        txtName.Focus();
                    }
                }
            }
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            string sVal = txtPhone.Text;
            if (!string.IsNullOrEmpty(sVal) && e.KeyCode != Keys.Back)
            {
                if (txtPhone.Text.Length < 8)
                {
                    sVal = sVal.Replace("-", "");
                    string newst = Regex.Replace(sVal, ".{3}", "$0-");

                    txtPhone.Text = newst;
                    txtPhone.SelectionStart = txtPhone.Text.Length;
                }
            }
        }

        private void SignInForm_Enter(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
