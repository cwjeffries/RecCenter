using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clarion_Security;

namespace CIS_411
{
    public partial class WorkerSignIn : Form
    {
        SplashForm parentForm;
        ClarionSecurity Security;

        public WorkerSignIn(SplashForm splashForm, ClarionSecurity sec)
        {
            InitializeComponent();
            parentForm = splashForm;
            this.AcceptButton = btnLogin;
            Security = sec; 
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 4;
            lblCurrentUser.Text = "Current User: " + Program.currentUser.name;
            this.CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new ClarionRecCenterDataSet())
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM WORKER");
                string connectionString = Properties.Settings.Default.ClarionRecCenterConnectionString1;
                SqlConnection conn = new SqlConnection(connectionString);

                adapter.SelectCommand = command;
                adapter.SelectCommand.Connection = conn;
                adapter.Fill(db.WORKER);

                var workers = db.WORKER.ToArray();

                //runs through worker db list
                for (int i = 0; i < workers.Length; i++)
                {
                    //if text box has db match..
                    if (workers[i].S_NAME == txtBoxUserName.Text)
                    {
                        if (workers[i].PASSWORD != txtPassword.Text)
                        {
                            MessageBox.Show("Incorrect Username or Password. Please try again.");
                        }
                        else
                        {
                            Program.currentUser.name = workers[i].S_NAME;
                            Program.currentUser.role = "Admin";
                            parentForm.updateUser(Program.currentUser.name);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            using (var db = new ClarionRecCenterDataSet())
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM WORKER");
                string connectionString = Properties.Settings.Default.ClarionRecCenterConnectionString1;
                SqlConnection conn = new SqlConnection(connectionString);

                bool valid = false;
                adapter.SelectCommand = command;
                adapter.SelectCommand.Connection = conn;
                adapter.Fill(db.WORKER);

                var workers = db.WORKER.ToArray();

                //runs through worker db list
                for (int i = 0; i < workers.Length; i++)
                {
                    //if text box has db match..
                    if (workers[i].S_NAME == txtBoxUserName.Text)
                    {
                        if (workers[i].PASSWORD != txtPassword.Text)
                        {
                            MessageBox.Show("Incorrect Username or Password. Please try again.");
                        }
                        else
                        {
                            Program.currentUser.name = workers[i].S_NAME;
                            Program.currentUser.role = "Admin";
                            parentForm.updateUser(Program.currentUser.name);
                            if (Security.FakeAuthenticateUser(Program.currentUser.name, workers[i].FIRST_NAME, workers[i].LAST_NAME, ""))
                            {
                                valid = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Please try again.");
                                
                            }
                        }
                    }
                }
                if (valid == false)
                {
                    MessageBox.Show("Incorrect Username! Please Try Again.");
                }
            }
        }
    }
}
