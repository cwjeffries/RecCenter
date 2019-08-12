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
    public partial class EntryEditForm : Form
    {
        //connection setup
        string connectionString;
        SqlConnection connection;
        SqlCommand command;
        ReportsForm frmReports = new ReportsForm();

        //List of memberships for display in combobox
        List<Memberships> memberships;

        int id;
        int membID;
        int cost;
        int cardNum;
        string phone;
        string name;
        string memType;
        string voided;

        public EntryEditForm(int pID, int pCardNum, string pPhone, string pName, string pMemType, string pVoid)
        {
            InitializeComponent();
            //instantiate connection objects
            connectionString = Properties.Settings.Default.ClarionRecCenterConnectionString1;
            connection = new SqlConnection(connectionString);
            memberships = new List<Memberships>();
            id = pID;
            cardNum = pCardNum;
            phone = pPhone;
            name = pName;
            memType = pMemType;
            voided = pVoid;
            membID = findMembershipID(id);
            cost = getMembCost(id);
            this.CenterToScreen();
        }

        private void EntryEditForm_Load(object sender, EventArgs e)
        {
            populateData(id, cardNum, phone, name, memType, voided);
            populateCboBox();
        }

        private void populateData(int pID, int pCardNum, string pPhone, string pName, string pMemType, string pVoid)
        {
            txtID.Text = pID.ToString();
            txtCard.Text = pCardNum.ToString();
            txtName.Text = pName;
            txtPhone.Text = pPhone;
            
            int memIndex = cboSelectedMemb.FindString(pMemType);
            cboSelectedMemb.SelectedIndex = memIndex;

            if (pVoid == "Y")
            {
                chkVoid.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string updateRows = "UPDATE [TRANSACTION] " +
                                "SET CARD_NUM = @CARD_NUM, PHONE_NUMBER = @PHONE_NUMBER, NAME = @NAME, IS_VOID = @IS_VOID, MEMBERSHIP_ID = @MEMB_ID, COST = @COST, WORKER_ID = @WORKER_ID " +
                                "WHERE (ID = @Original_ID)";

            command = new SqlCommand(updateRows, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@Original_ID", txtID.Text);

                if (txtCard.Text == null)
                {
                    command.Parameters.AddWithValue("@CARD_NUM", cardNum);
                }
                else if (txtCard.Text == 0.ToString())
                {
                    command.Parameters.AddWithValue("@CARD_NUM", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@CARD_NUM", int.Parse(txtCard.Text));
                }
                if (txtPhone.Text == null)
                {
                    command.Parameters.AddWithValue("@PHONE_NUMBER", phone);
                }
                else
                {
                    command.Parameters.AddWithValue("@PHONE_NUMBER", txtPhone.Text);
                }
                if (txtName.Text == null)
                {
                    command.Parameters.AddWithValue("@NAME", name);
                }
                else
                {
                    command.Parameters.AddWithValue("@NAME", txtName.Text);
                }
                if (chkVoid.Checked == true)
                {
                    command.Parameters.AddWithValue("@IS_VOID", "Y");
                }
                else
                {
                    command.Parameters.AddWithValue("@IS_VOID", "N");
                }
                
                command.Parameters.AddWithValue("@MEMB_ID",membID);
                command.Parameters.AddWithValue("@COST", cost);
                command.Parameters.AddWithValue("@WORKER_ID", Program.currentUser.name);
                command.ExecuteNonQuery();

                MessageBox.Show("Transaction has been updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1 Transaction Update: \n" + ex);
            }
            finally
            {
                connection.Close();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSelectedMemb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cost = getMembCostByDescription(cboSelectedMemb.SelectedItem.ToString());
            membID = findMembershipIDByDescription(cboSelectedMemb.SelectedItem.ToString());
        }

        private void populateCboBox()
        {
            //Clears cbobox for new items
            cboSelectedMemb.Items.Clear();
            //Clears list to remove duplication when updated
            memberships = new List<Memberships>();
            //Calls function that does the SELECT statement
            collectMemberships();
        }

        private void collectMemberships()
        {
            //Query to get memberships table
            string membershipSelect = "SELECT MEMBERSHIP_ID, DURATION, COST, RESTRICTED, " +
                                      "DESCRIPTION, ACTIVE FROM MEMBERSHIP_TYPE";

            command = new SqlCommand(membershipSelect, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                //Reads the usernames and stores them
                while (reader.Read())
                {
                    Memberships tempMember = new Memberships();

                    tempMember.MembershipID = reader["MEMBERSHIP_ID"].ToString();
                    tempMember.Duration = reader["DURATION"].ToString();
                    tempMember.Cost = reader["COST"].ToString();
                    tempMember.Description = reader["DESCRIPTION"].ToString();
                    tempMember.Active = reader["ACTIVE"].ToString();
                    tempMember.Restricted = reader["RESTRICTED"].ToString();

                    memberships.Add(tempMember);
                }
                connection.Close();
                loadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1 Membership Display: \n" + ex);
            }
            finally
            {
            }
        }

        //adds memberships into the cbobox for display and ease of use when editing
        private void loadMembers()
        {
            foreach (Memberships aMember in memberships)
            {
                string cboItem = aMember.Description.ToString();
                cboSelectedMemb.Items.Add(cboItem);
                if (aMember.MembershipID == membID.ToString())
                {
                    cboSelectedMemb.SelectedItem = cboItem;
                }
            }
        }

        private int findMembershipID( int id)
        {
            //Query to get memberships table
            string transactSelect = "SELECT MEMBERSHIP_ID FROM [TRANSACTION] "+ 
                                    " WHERE ID = '" + id +"'";

            command = new SqlCommand(transactSelect, connection);
            int membID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                //Reads the usernames and stores them
                while (reader.Read())
                {
                    membID = int.Parse(reader["MEMBERSHIP_ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Finding Membership Type: \n" + ex);
            }
            finally
            {
                connection.Close();
            }
            return membID;
        }

        private int getMembCost(int id)
        {
            //Query to get memberships table
            string costSelect = "SELECT COST FROM MEMBERSHIP_TYPE " +
                                    " WHERE MEMBERSHIP_ID = '" + id + "'";

            command = new SqlCommand(costSelect, connection);
            int cost = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                //Reads the usernames and stores them
                while (reader.Read())
                {
                    cost = int.Parse(reader["COST"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Finding Membership Cost: \n" + ex);
            }
            finally
            {
                connection.Close();
            }
            return cost;
        }

        private int findMembershipIDByDescription(string name)
        {
            //Query to get memberships table
            string transactSelect = "SELECT MEMBERSHIP_ID FROM [MEMBERSHIP_TYPE] " +
                                    " WHERE DESCRIPTION = '" + name + "'";

            command = new SqlCommand(transactSelect, connection);
            int membID = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                //Reads the usernames and stores them
                while (reader.Read())
                {
                    membID = int.Parse(reader["MEMBERSHIP_ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Finding Membership Type: \n" + ex);
            }
            finally
            {
                connection.Close();
            }
            return membID;
        }

        private int getMembCostByDescription(string name)
        {
            //Query to get memberships table
            string costSelect = "SELECT COST FROM MEMBERSHIP_TYPE " +
                                    " WHERE DESCRIPTION = '" + name + "'";

            command = new SqlCommand(costSelect, connection);
            int cost = 0;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                //Reads the usernames and stores them
                while (reader.Read())
                {
                    cost = int.Parse(reader["COST"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Finding Membership Cost: \n" + ex);
            }
            finally
            {
                connection.Close();
            }
            return cost;
        }
    }
}
