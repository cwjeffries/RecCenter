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

namespace CIS_411
{
    public partial class SelectMembership : Form
    {
        String connectionString;
        SqlConnection connection;
        SqlCommand command;

        //instantiate DataPass class to carry stored data
        DataPass dataPass = new DataPass();

        //check for membership type selected or not
        bool memSelected = false;

        public SelectMembership(string userName, string name, string phone)
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
            //closes the form
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
                    lblCost.Text = "Cost: $" + dataPass.TransactCost.ToString();
                    memSelected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could Not Select Membership. \n Error: " + ex);
                }
            }
        }

        private void SelectMembership_Load(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void populateDataGrid()
        {
            string selectMem = "SELECT MEMBERSHIP_ID, COST, DESCRIPTION, ACTIVE, DAY_PASS " +
                                "FROM MEMBERSHIP_TYPE " +
                                "WHERE (ACTIVE = 'Y') AND (DAY_PASS <> 'Y')";

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
                MessageBox.Show("Error in selecting memberships: " + "\n" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            //if user is existing member, check textbox for valid integer
            if (dataPass.NewMemb == "N")
            {
                int cardNum;
                dataPass.NeedsSync = "Y";

                if ((int.TryParse(txtCardNum.Text.Trim(), out cardNum)) && cardNum < 10000 && cardNum > 999)
                {
                    //textBox value is a number and within proper range
                    dataPass.CardNum = cardNum;

                    //If statement that checks whether the user has selected a membership type yet
                    if (memSelected)
                    {
                        LiabilityWaiver frmLiabilityWaiver = new LiabilityWaiver(dataPass.ActiveUser, dataPass.CustomerName, dataPass.CustomerPhone, dataPass.CardNum,
                            dataPass.SelectedMembership, dataPass.NewMemb, dataPass.NeedsSync, dataPass.TransactCost);
                        this.Close();
                        frmLiabilityWaiver.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please select a membership type by clicking one of the boxes");
                    }
                }
                else
                {
                    //not a number
                    MessageBox.Show("Please enter a valid card number.");
                }
            }
            else //new member
            {
                dataPass.CardNum = 0;
                dataPass.NeedsSync = "N";
                //If statement that checks whether the user has selected a membership type yet
                if (memSelected)
                {
                    LiabilityWaiver frmLiabilityWaiver = new LiabilityWaiver(dataPass.ActiveUser, dataPass.CustomerName, dataPass.CustomerPhone, dataPass.CardNum,
                        dataPass.SelectedMembership, dataPass.NewMemb, dataPass.NeedsSync, dataPass.TransactCost);
                    this.Close();
                    frmLiabilityWaiver.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a membership type by clicking one of the boxes");
                }
            }
        }

        //Enables the card number txtbox for an existing user and enables the purchase button
        private void rdoExisting_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExisting.Checked)
            {
                txtCardNum.Enabled = true;
                txtCardNum.Focus();
                dataPass.NewMemb = "N";
                btnPurchase.Enabled = true;
            }
        }

        //Disables card num txtbox for new members and enables purchase button
        private void rdoNewMember_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNewMember.Checked)
            {
                txtCardNum.Enabled = false;
                dataPass.CardNum = null;
                dataPass.NewMemb = "Y";
                btnPurchase.Enabled = true;
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