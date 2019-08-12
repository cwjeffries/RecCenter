using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_411
{
    public partial class LiabilityWaiver : Form
    {
        //connection setup
        string connectionString;
        SqlConnection connection;
        SqlCommand command;

        DataPass dataPass = new DataPass();
        CultureInfo provider;

        public LiabilityWaiver(string activeUser, string customerName, string custPhone, Nullable<int> cardNum,
            int membershipID, string newCust, string needSync, double transactCost)
        {
            InitializeComponent();
            //set datapass values to passed values
            dataPass.CustomerName = customerName;
            dataPass.CustomerPhone = custPhone;
            dataPass.CardNum = cardNum;
            dataPass.SelectedMembership = membershipID;
            dataPass.NewMemb = newCust;
            dataPass.NeedsSync = needSync;
            dataPass.ActiveUser = activeUser;
            dataPass.TransactCost = transactCost;
            provider = CultureInfo.InvariantCulture;
            //instantiate connection objects
            connectionString = Properties.Settings.Default.ClarionRecCenterConnectionString1;
            connection = new SqlConnection(connectionString);
            this.CenterToScreen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //grab current time
            dataPass.TransactDate = DateTime.Now;
            //determine which payment type is selected
            if (rdoCash.Checked)
            {
                dataPass.PaymentType = "Cash";
                InsertTransaction();
                this.Close();
            }
            else if (rdoCheck.Checked)
            {
                dataPass.PaymentType = "Check";
                InsertTransaction();
                this.Close();
            }
            else if (dataPass.TransactCost == 0)
            {
                dataPass.PaymentType = "Cash";
                InsertTransaction();
                this.Close();
            }
            else
            {
                MessageBox.Show("Select A Payment Type");
            }
        }

        private void InsertTransaction()
        {
            expirationCalc(dataPass.SelectedMembership);

            //set up insert statement
            string transactString = "INSERT INTO [TRANSACTION] " +
                                     "(NAME, PHONE_NUMBER, CARD_NUM, DATE, PAYMENT_TYPE, COST, " +
                                     "MEMBERSHIP_ID, WORKER_ID, NEW, EXPIRATION, NEEDS_TO_SYNC, IS_VOID) " +
                                     "VALUES(@pName, @pPhoneNum, @pCardNum, @pDate, @pPaymentType, " +
                                     "@pCost, @pMembershipID, @pWorkerID, @pNew, @pExpiration, @pNeedSync, @pVoid)";

            //instantiate command object
            command = new SqlCommand(transactString, connection);
            //try_catch
            try
            {
                //open connection
                connection.Open();
                //add the values
                command.Parameters.AddWithValue("@pName", dataPass.CustomerName);
                command.Parameters.AddWithValue("@pPhoneNum", dataPass.CustomerPhone);
                if (dataPass.CardNum != 0)
                {
                    command.Parameters.AddWithValue("@pCardNum", dataPass.CardNum);

                }
                else
                {
                    command.Parameters.AddWithValue("@pCardNum", DBNull.Value);

                }
                command.Parameters.AddWithValue("@pDate", dataPass.TransactDate);
                command.Parameters.AddWithValue("@pPaymentType", dataPass.PaymentType);
                command.Parameters.AddWithValue("@pCost", dataPass.TransactCost);
                command.Parameters.AddWithValue("@pMembershipID", dataPass.SelectedMembership);
                command.Parameters.AddWithValue("@pWorkerID", dataPass.ActiveUser);
                command.Parameters.AddWithValue("@pNew", dataPass.NewMemb);
                command.Parameters.AddWithValue("@pExpiration", dataPass.ExpireDate);
                if (dataPass.NeedsSync != "")
                {
                    command.Parameters.AddWithValue("@pNeedSync", dataPass.NeedsSync);
                }
                else
                {
                    command.Parameters.AddWithValue("@pNeedSync", DBNull.Value);

                }
                command.Parameters.AddWithValue("@pVoid","N");
                //do the things and close the connection
                command.ExecuteNonQuery();
                connection.Close();
                //yay you did it
                MessageBox.Show("Thank You For Your Purchase!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Error! ERROR CODE: " + ex);
            }
        }
        //running clock
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }
        //function to calculate expiration date for each transaction
        private void expirationCalc(int membershipID)
        {
            DateTime now = DateTime.Now;
            double addedDays;
            string selectMembershipString = "SELECT        DURATION, EXP_DATE, EXP_TYPE " +
                                            "FROM            MEMBERSHIP_TYPE " +
                                            "WHERE(MEMBERSHIP_ID = @pMembID) ";
            command = new SqlCommand(selectMembershipString, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pMembID", membershipID);
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                //Reads the usernames and stores them
                while (reader.Read())
                {
                    //if the membership has a duration, add from today
                    string expType = reader["EXP_TYPE"].ToString();
                    if (expType == "DURA")
                    {
                        addedDays = Double.Parse(reader["DURATION"].ToString());
                        dataPass.ExpireDate = now.AddDays(addedDays);
                    }
                    //or if the membership has an expiration date, use it.
                    else
                    {
                        dataPass.ExpireDate = reader.GetDateTime(1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LiabilityWaiver_Load(object sender, EventArgs e)
        {
            lblFullName.Text = lblFullName.Text + " " + dataPass.CustomerName;
            lblPhoneNumber.Text = lblPhoneNumber.Text + " " + dataPass.CustomerPhone;
            lblMemTypeDisplay.Visible = true;
            lblCostDisplay.Visible = true;
            lblMemTypeDisplay.Text = getMembershipCost(dataPass.SelectedMembership);
            lblCostDisplay.Text = "$" + dataPass.TransactCost;

            if (dataPass.TransactCost == 0)
            {
                rdoCheck.Visible = false;
                rdoCash.Visible = false;
                lblPayment.Visible = false;
            }
        }

        private String getMembershipCost(int membID)
        {
            string selectMem = "SELECT DESCRIPTION " +
                                "FROM MEMBERSHIP_TYPE " +
                                "WHERE (MEMBERSHIP_ID = " + membID + ")";
            string descr = "";
            command = new SqlCommand(selectMem, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    descr = reader["DESCRIPTION"].ToString();
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
            return descr;
        }
    }
}
