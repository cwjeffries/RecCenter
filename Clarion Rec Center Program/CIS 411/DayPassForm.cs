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
    public partial class DayPassForm : Form
    {
        //instantiate DataPass class to carry stored data
        DataPass dataPass = new DataPass();

        String connectionString;
        SqlConnection connection;
        SqlCommand command;

        String restricted;

        //will need passed vars from SignInForm
        public DayPassForm(string userName, string name, string phone)
        {
            InitializeComponent();
            //set passed values
            dataPass.ActiveUser = userName;
            dataPass.CustomerName = name;
            dataPass.CustomerPhone = phone;

            connectionString = Properties.Settings.Default.ClarionRecCenterConnectionString1;
            connection = new SqlConnection(connectionString);
            this.CenterToScreen();
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Checks datagridview to see which button was pressed
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int membID;
                
                //gets membership type column ID
                int columnIndexID = e.ColumnIndex - 3;
                int rowIndex = e.RowIndex;

                try
                {
                    //Selects values from datagrid view relating to membership type, but keeping description visible for users
                    membID = int.Parse(dgvMemSelect.Rows[rowIndex].Cells[columnIndexID].Value.ToString());
                    //passes in the type and cost to the dataPass file
                    dataPass.SelectedMembership = membID;
                    dataPass.TransactCost = getMembershipCost(membID);
                    dataPass.NewMemb = "Y";
                    dataPass.NeedsSync = "N";
                    loadLiability();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Could Not Select Membership. \n Error: " + ex);
                }
            }
        }

        private void loadLiability()
        {
            dataPass.CardNum = 0;
            LiabilityWaiver frmLiabilityWaiver = new LiabilityWaiver(dataPass.ActiveUser, dataPass.CustomerName, dataPass.CustomerPhone, dataPass.CardNum,
                dataPass.SelectedMembership, dataPass.NewMemb, dataPass.NeedsSync, dataPass.TransactCost);
            this.Close();
            frmLiabilityWaiver.ShowDialog();
        }

        private void DayPassForm_Load(object sender, EventArgs e)
        {
            //check if the time of day allows restricted day pass to be purchased
            TimeSpan start = new TimeSpan(11, 0, 0); //11 o'clock
            TimeSpan end = new TimeSpan(13, 0, 0); //1 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > start) && (now < end))
            {
                //restricted += " AND (RESTRICTED = 'Y') ";
            }
            else
            {
                restricted = " AND (RESTRICTED = 'N') ";
            }

            populateDataGrid();
        }

        private void populateDataGrid()
        {
            string selectMem = "SELECT MEMBERSHIP_ID, COST, DESCRIPTION, ACTIVE, DAY_PASS " +
                                "FROM MEMBERSHIP_TYPE " +
                                "WHERE (ACTIVE = 'Y') AND (DAY_PASS = 'Y')" + restricted;

            command = new SqlCommand(selectMem, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    string memID = reader["MEMBERSHIP_ID"].ToString();
                    string cost = reader["COST"].ToString();
                    string descr = reader["DESCRIPTION"].ToString();

                    dgvMemSelect.Rows.Add(memID, descr, "$" + cost);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in selecting Day Passes: " + "\n" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             lblCurrentDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        private double getMembershipCost(int membID)
        {
            string selectMem = "SELECT COST " +
                                "FROM MEMBERSHIP_TYPE " +
                                "WHERE (MEMBERSHIP_ID = " + membID + ")";
            double cost = 0;
            command = new SqlCommand(selectMem, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    cost = Double.Parse(reader["COST"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Membership: " + "\n" + ex);
            }
            finally
            {
                connection.Close();
            }
            return cost;
        }
    }
}
