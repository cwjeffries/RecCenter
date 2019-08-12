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
    public partial class SplashForm : Form
    {
        ClarionSecurity Security;
        //SqlConnection connCln;
        String connectionSecurityString;
        SqlConnection connectionSecuritySql;

        public SplashForm()
        {
            InitializeComponent();
            lblCurrentUser.Text = Program.currentUser.name;

            connectionSecurityString = Properties.Settings.Default.ClarionSecurityConnectionString1;
            connectionSecuritySql = new SqlConnection(connectionSecurityString);
            Security = new ClarionSecurity(connectionSecuritySql);
            this.CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

            if (Program.currentUser.name == "No Current User")
            {
                MessageBox.Show("Please Sign In!");
            }
            else
            {
                //instantiate an object of type SignInForm called frmSignIn
                SignInForm frmSignIn = new SignInForm();
                //Display the day pass form in modal format
                frmSignIn.ShowDialog();
            }
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            if (Program.currentUser.name != "No Current User")
            {
                if (Security.Authorized("AdminPanel"))
                {
                    AdminPanel frmAdminPanel = new AdminPanel(Security);
                    frmAdminPanel.ShowDialog();
                }
                else
                {
                    ReportsForm frmReports = new ReportsForm();
                    frmReports.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please Sign In!");
            }
        }

        public void updateUser(string currentUser)
        {
            lblCurrentUser.Text = "Current User: " + currentUser;
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            //instantiate an object of type WorkerSignIn called frmWorkerSignIn
            WorkerSignIn frmWorkerSignIn = new WorkerSignIn(this, Security);
            //Display the wroker sign in form in modal format
            frmWorkerSignIn.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            {
                Program.currentUser.name = "No Current User";
                Program.currentUser.role = "No Current Role";
                this.updateUser(Program.currentUser.name);
            }
        }
    }
}
