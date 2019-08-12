using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Clarion_Security;
using System.Collections;

namespace CIS_411
{
    public partial class AdminPanel : Form
    {
        ClarionSecurity Security;
        SqlConnection connCln;

        String connectionString;
        SqlConnection connection;
        SqlCommand command;
        String dateFilter;
        String workerFilter;
        String membershipFilter;
        String nameFilter;
        String checkFilter;
        String phoneFilter;
        //lists for workers and memberships
        List<StudentWorker> workers;
        List<Memberships> memberships;
        String dateFormat = "yyyy-MM-dd HH:mm:ss ";

        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        int iCount = 0;

        public AdminPanel(ClarionSecurity sec)
        {
            InitializeComponent();
            Security = sec;
            //instantiate connection objects
            connectionString = Properties.Settings.Default.ClarionRecCenterConnectionString1;
            connection = new SqlConnection(connectionString);
            workers = new List<StudentWorker>();
            memberships = new List<Memberships>();
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            dateFilter = "";
            workerFilter = "";
            membershipFilter = "";
            nameFilter = "";
            phoneFilter = "";
            populateDataGrid();
            loadMembershipCombo();
            loadWorkerCombo();
        }

        private void btnLaunchReports_Click(object sender, EventArgs e)
        {
            if(Security.Authorized("DailyReport"))
            {
                //instantiate an object of type DayPassForm called frmDayPass
                ReportsForm frmReports = new ReportsForm();
                //Display the day pass form
                frmReports.ShowDialog();
            }
        }
        
        private void btnEditMembership_Click(object sender, EventArgs e)
        {
            if(Security.Authorized("EditMemberships"))
            {
                //instantiate an object of type DayPassForm called frmDayPass
                EditMemberships editMemberships = new EditMemberships();
                //Display the Edit Memberships form
                editMemberships.ShowDialog();
            }
        }

        private void btnEditWorkers_Click(object sender, EventArgs e)
        {
            if (Security.Authorized("EditWorkers"))
            {
                //instantiate an object of type DayPassForm called frmDayPass
                EditStudents editStudents = new EditStudents(Security);
                //Display the day pass form
                editStudents.ShowDialog();
            }
        }

        private void populateDataGrid()
        {
            //clear previous data
            dgvAdminReport.Rows.Clear();

            //sql statement to generate report for student task times
            string selectString = "SELECT        [TRANSACTION].ID, [TRANSACTION].DATE, [TRANSACTION].NAME, [TRANSACTION].PHONE_NUMBER, MEMBERSHIP_TYPE.DESCRIPTION, " +
                                        "[TRANSACTION].EXPIRATION, [TRANSACTION].PAYMENT_TYPE, [TRANSACTION].COST, [TRANSACTION].CARD_NUM, " +
                                        "[TRANSACTION].NEW, [TRANSACTION].NEEDS_TO_SYNC, WORKER.LAST_NAME, [TRANSACTION].IS_VOID " +
                                        "FROM            MEMBERSHIP_TYPE INNER JOIN " +
                                        "[TRANSACTION] ON MEMBERSHIP_TYPE.MEMBERSHIP_ID = [TRANSACTION].MEMBERSHIP_ID INNER JOIN " +
                                        "WORKER ON[TRANSACTION].WORKER_ID = WORKER.S_NAME " +
                                        "WHERE ([TRANSACTION].PHONE_NUMBER IS NOT NULL " + checkFilter + nameFilter + dateFilter + workerFilter + membershipFilter + phoneFilter + ")";

            command = new SqlCommand(selectString, connection);
            //open connection to db
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string date = reader["DATE"].ToString();
                    string cName = reader["NAME"].ToString();
                    string cPhone = reader["PHONE_NUMBER"].ToString();
                    string mDesc = reader["DESCRIPTION"].ToString();
                    string expiration = reader["EXPIRATION"].ToString();
                    string pType = reader["PAYMENT_TYPE"].ToString();
                    string tCost = reader["COST"].ToString();
                    string cardNum = reader["CARD_NUM"].ToString();
                    string newStat = reader["NEW"].ToString();
                    string syncStat = reader["NEEDS_TO_SYNC"].ToString();
                    string wName = reader["LAST_NAME"].ToString();
                    string isVoid = reader["IS_VOID"].ToString();
             
                    //add info to datagrid
                    dgvAdminReport.Rows.Add(id, date, cName, cPhone, mDesc, expiration, pType, "$" + tCost, cardNum, newStat, wName, isVoid, syncStat);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Selected Report, ERROR CODE: " + ex);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            nameFilter = "";
            populateDataGrid();
            txtSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            nameFilter = " AND [TRANSACTION].NAME LIKE '%" + txtSearch.Text + "%' ";
            populateDataGrid();
        }

        private void chkFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilterDate.Checked)
            {
                dtStart.Enabled = true;
                dtEnd.Enabled = true;
                dateFilter = " AND [TRANSACTION].DATE BETWEEN '" + dtStart.Value.ToString(dateFormat) + "' AND '" + dtEnd.Value.ToString(dateFormat) + "'";
                populateDataGrid();
            }
            else
            {
                dtStart.Enabled = false;
                dtEnd.Enabled = false;
                dateFilter = "";
                populateDataGrid();
            }
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            dateFilter = " AND [TRANSACTION].DATE BETWEEN '" + dtStart.Value.ToString(dateFormat) + "' AND '" + dtEnd.Value.ToString(dateFormat) + "'";
            populateDataGrid();
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            dateFilter = " AND [TRANSACTION].DATE BETWEEN '" + dtStart.Value.ToString(dateFormat) + "' AND '" + dtEnd.Value.ToString(dateFormat) + "'";
            populateDataGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEditPrivileges_Click(object sender, EventArgs e)
        {
            Security.OpenControlPanel();
        }

        private void btnPhoneSearch_Click(object sender, EventArgs e)
        {
            phoneFilter = " AND [TRANSACTION].PHONE_NUMBER LIKE '%" + txtPhoneSearch.Text + "%' ";
            populateDataGrid();
        }

        private void btnPhoneClear_Click(object sender, EventArgs e)
        {
            phoneFilter = "";
            populateDataGrid();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Security.Authorized("ExportCurrent"))
            {
                exportDGV();
            }
        }

        private void exportDGV()
        {
            // Creating a Excel object. 
            Excel._Application excel = new Excel.Application();
            Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = null;
            Excel.Range chartRange;

            int wrkRow = 0;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";
                for (int i = 0; i < dgvAdminReport.Columns.Count - 1; i++)
                {
                    worksheet.Cells[1, i + 1] = dgvAdminReport.Columns[i].HeaderText;
                }
                chartRange = worksheet.get_Range("a1", "m1");
                chartRange.Font.Bold = true;
                chartRange.Font.Size = 15;
                chartRange.Columns.AutoFit();
                chartRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                //Loop through each row and read value from each column. 
                for (int worksheetrow = 2, ddgrow = 0; ddgrow < dgvAdminReport.Rows.Count; worksheetrow++, ddgrow++)
                {
                    for (int dgvcolumn = 0; dgvcolumn < dgvAdminReport.Columns.Count - 1; dgvcolumn++)
                    {
                        worksheet.Cells[worksheetrow, dgvcolumn + 1] = dgvAdminReport.Rows[ddgrow].Cells[dgvcolumn].Value.ToString();
                    }
                    wrkRow = worksheetrow;
                }
                //gets range of cells and autosizes the data columns
                string cell2 = "m" + wrkRow.ToString();
                chartRange = worksheet.get_Range("a2", cell2);
                chartRange.Font.Size = 11;

                chartRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.PeachPuff);

                //Puts a border around the actual data
                chartRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd  hh_mm") + "  " + "Report.xlsx";

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void btnPhoneClear_Click_1(object sender, EventArgs e)
        {
            phoneFilter = "";
            populateDataGrid();
            txtPhoneSearch.Clear();
        }

        private void loadMembershipCombo()
        {
            string membSelect = "SELECT        MEMBERSHIP_ID, DESCRIPTION " +
                                "FROM            MEMBERSHIP_TYPE";
            command = new SqlCommand(membSelect, connection);
            //open the connection to the database
            try
            {
                connection.Open();
                //create the SqlDataReader object using the command object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //use loop to read data
                while (reader.Read())
                {
                    //create temp object and call constructor
                    Memberships tempMemb = new Memberships();
                    //read the rows and save in tempMemb
                    tempMemb.MembershipID = reader["MEMBERSHIP_ID"].ToString();
                    tempMemb.Description = reader["DESCRIPTION"].ToString();
                    //add tempMemb object to the list
                    memberships.Add(tempMemb);
                }
                //close the database
                connection.Close();
                //load the name in the combo box
                foreach (Memberships aMembership in memberships)
                {
                    string membDesc = aMembership.Description;
                    cboMembType.Items.Add(membDesc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Memberships: " + ex);
            }
        }

        private void loadWorkerCombo()
        {
            string workerSelect = "SELECT        S_NAME, FIRST_NAME, LAST_NAME " +
                                  "FROM            WORKER";
            command = new SqlCommand(workerSelect, connection);
            //open the connection to the database
            try
            {
                connection.Open();
                //create the SqlDataReader object using the command object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //use loop to read data
                while (reader.Read())
                {
                    //create temp object and call constructor
                    StudentWorker tempWorker = new StudentWorker();
                    //read the rows and save in tempMemb
                    tempWorker.WUserName = reader["S_NAME"].ToString();
                    tempWorker.WFirstName = reader["FIRST_NAME"].ToString();
                    tempWorker.WLastName = reader["LAST_NAME"].ToString();

                    //add tempWorker object to the list
                    workers.Add(tempWorker);
                }
                //close the database
                connection.Close();
                //load the name in the combo box
                foreach (StudentWorker aWorker in workers)
                {
                    string workerName = aWorker.WFirstName + " " + aWorker.WLastName;
                    cboStudWorker.Items.Add(workerName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Workers: " + ex);
            }
        }

        private void cboStudWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWorker = cboStudWorker.SelectedItem.ToString();

            if (selectedWorker == "View All")
            {
                workerFilter = "";
            }
            else
            {
                foreach (StudentWorker aWorker in workers)
                {
                    if (aWorker.WFirstName + " " + aWorker.WLastName == selectedWorker)
                    {
                        workerFilter = " AND [TRANSACTION].WORKER_ID LIKE '" + aWorker.WUserName + "'";
                    }
                }
            }
            populateDataGrid();
        }

        private void cboMembType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMemb = cboMembType.SelectedItem.ToString();
            if (selectedMemb == "View All")
            {
                membershipFilter = "";
            }
            else
            {
                foreach (Memberships aMemb in memberships)
                {
                    if (aMemb.Description == selectedMemb)
                    {
                        membershipFilter = " AND [TRANSACTION].MEMBERSHIP_ID = " + aMemb.MembershipID;
                    }
                 
                }
            }
            populateDataGrid();
        }

        private void dgvAdminReport_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Checks datagridview to see which button was pressed
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {
                
                
                //gets transactionID
                int rowIndex = e.RowIndex;
                int TransactID = int.Parse(dgvAdminReport.Rows[rowIndex].Cells[0].Value.ToString());

                //needs update statement
                string transactUpdate = "UPDATE [TRANSACTION] " +
                                        "SET NEEDS_TO_SYNC = 'N' " +
                                        "WHERE ID =  @pTransactID";

                command = new SqlCommand(transactUpdate, connection);
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@pTransactID", TransactID);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not update transaction! ERROR CODE: " + ex);
                }
                populateDataGrid();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
            {
                if (Security.Authorized("Print"))
                {
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument1;
                    printDialog.UseEXDialog = true;
                    printDocument1.DefaultPageSettings.Landscape = true;
                    //Get the document
                    if (DialogResult.OK == printDialog.ShowDialog())
                    {
                        printDocument1.DocumentName = "Admin Report";
                        printDocument1.Print();
                    } 
                }

            }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iCount = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgvAdminReport.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgvAdminReport.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                            (double)iTotalWidth * (double)iTotalWidth *
                            ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                            GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headers
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }

                    //Draw Header
                    e.Graphics.DrawString("Admin Report",
                        new Font(dgvAdminReport.Font, FontStyle.Bold),
                        Brushes.Black, e.MarginBounds.Left,
                        e.MarginBounds.Top - e.Graphics.MeasureString("Admin Report",
                        new Font(dgvAdminReport.Font, FontStyle.Bold),
                        e.MarginBounds.Width).Height - 13);

                    //Draw signature line
                    e.Graphics.DrawString("Signature:___________________________________",
                        new Font(dgvAdminReport.Font, FontStyle.Bold),
                        Brushes.Black, e.MarginBounds.Left + 150,
                        e.MarginBounds.Top - e.Graphics.MeasureString("Signature:___________________________________",
                        new Font(dgvAdminReport.Font, FontStyle.Bold),
                        e.MarginBounds.Width).Height - 13);
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dgvAdminReport.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgvAdminReport.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 20;
                    int iCount = 0;
                    //Check whether the current page settings allows more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Get and Draw Date
                            String strDate = DateTime.Now.ToLongDateString() + " " +
                                DateTime.Now.ToShortTimeString();
                            e.Graphics.DrawString(strDate,
                                new Font(dgvAdminReport.Font, FontStyle.Bold), Brushes.Black,
                                e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font(dgvAdminReport.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString("Admin Report",
                                new Font(new Font(dgvAdminReport.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dgvAdminReport.Columns)
                            {
                                //Removes the column header from datagridview when printing 
                                if (GridCol.Name != "ConfirmSync")
                                {
                                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight));

                                    e.Graphics.DrawRectangle(Pens.Black,
                                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight));

                                    e.Graphics.DrawString(GridCol.HeaderText,
                                        GridCol.InheritedStyle.Font,
                                        new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                        new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                    iCount++;
                                }
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            //Removes last column cells from the datagridview in printing, ConfirmSync
                            if (Cel.ColumnIndex != 13)
                            {
                                if (Cel.Value != null)
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(),
                                        Cel.InheritedStyle.Font,
                                        new SolidBrush(Cel.InheritedStyle.ForeColor),
                                        new RectangleF((int)arrColumnLefts[iCount],
                                        (float)iTopMargin,
                                        (int)arrColumnWidths[iCount], (float)iCellHeight),
                                        strFormat);
                                }
                                //Drawing Cells Borders 
                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iCellHeight));
                            }
                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }
                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void chkFilters_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {

                checkFilter = "";
                if (chkFilters.CheckedItems.Count != 0)
                {
                    int i;

                    for (i = 0; i <= (chkFilters.Items.Count - 1); i++)
                    {
                        if (chkFilters.GetItemChecked(i))
                        {
                            switch (i)
                            {
                                //new customer
                                case 0:
                                    checkFilter += " AND [TRANSACTION].NEW = 'Y' ";
                                    break;
                                //existing customer
                                case 1:
                                    checkFilter += " AND [TRANSACTION].NEW = 'N' ";
                                    break;
                                //cash payment
                                case 2:
                                    checkFilter += " AND [TRANSACTION].PAYMENT_TYPE = 'Cash' ";
                                    break;
                                //check payment
                                case 3:
                                    checkFilter += " AND [TRANSACTION].PAYMENT_TYPE = 'Check' ";
                                    break;
                                //expired membership
                                case 4:
                                    checkFilter += " AND [TRANSACTION].EXPIRATION < '" + DateTime.Today + "'  ";
                                    break;
                                //not expired membership
                                case 5:
                                    checkFilter += " AND [TRANSACTION].EXPIRATION > '" + DateTime.Today + "'  ";
                                    break;
                                //needs synced
                                case 6:
                                    checkFilter += " AND [TRANSACTION].NEEDS_TO_SYNC = 'Y' ";
                                    break;
                            }
                        }
                    }
                }
                populateDataGrid();
            });
        }
        //auto inserts dashes in phone number
        private void txtPhoneSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string sVal = txtPhoneSearch.Text;
            if (!string.IsNullOrEmpty(sVal) && e.KeyCode != Keys.Back)
            {
                if (txtPhoneSearch.Text.Length < 8)
                {
                    sVal = sVal.Replace("-", "");
                    string newst = Regex.Replace(sVal, ".{3}", "$0-");

                    txtPhoneSearch.Text = newst;
                    txtPhoneSearch.SelectionStart = txtPhoneSearch.Text.Length;
                }
            }
        }
    }
}