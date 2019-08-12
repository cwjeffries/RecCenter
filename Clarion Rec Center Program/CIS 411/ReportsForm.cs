using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CIS_411
{
    public partial class ReportsForm : Form
    {
        String connectionString;
        SqlConnection connection;
        SqlCommand command;
        String dateFilter = "";
        String dateFormat = "yyyy-MM-dd";
        //variable to create total row at bottom
        double checkTotal = 0;
        double cashTotal = 0;
        double grandTotal = 0;

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

        public ReportsForm()
        {
            InitializeComponent();
            lblActiveUser.Text = "Current User: " + Program.currentUser.name;
            labelUser.Text = "Current User: " + Program.currentUser.name;
            connectionString = Properties.Settings.Default.ClarionRecCenterConnectionString1;
            connection = new SqlConnection(connectionString);
            this.CenterToScreen();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            populateDataGrid();
            dtEnd.Value = dtEnd.Value.AddDays(1);
            dateFilter = " AND [TRANSACTION].DATE BETWEEN '" + dtStart.Value.ToString(dateFormat) + "' AND '" + dtEnd.Value.ToString(dateFormat) + "'";
        }

        private void populateDataGrid()
        {
            //clear previous data
            dgvDailyReport.Rows.Clear();
            //variable to create total row at bottom
            checkTotal = 0;
            cashTotal = 0;
            grandTotal = 0;
            //sql statement to generate report for student task times
            string selectString = "SELECT [TRANSACTION].ID, [TRANSACTION].DATE, [TRANSACTION].NAME, [TRANSACTION].PHONE_NUMBER, MEMBERSHIP_TYPE.DESCRIPTION, " +
                                        "[TRANSACTION].PAYMENT_TYPE, [TRANSACTION].COST, [TRANSACTION].CARD_NUM, [TRANSACTION].NEW, " +
                                        "[TRANSACTION].NEEDS_TO_SYNC, WORKER.LAST_NAME , [TRANSACTION].IS_VOID " +
                                        "FROM MEMBERSHIP_TYPE INNER JOIN " +
                                        "[TRANSACTION] ON MEMBERSHIP_TYPE.MEMBERSHIP_ID = [TRANSACTION].MEMBERSHIP_ID INNER JOIN " +
                                        "WORKER ON[TRANSACTION].WORKER_ID = WORKER.S_NAME " +
                                        "WHERE ([TRANSACTION].PHONE_NUMBER IS NOT NULL) " + dateFilter +
                                        "ORDER BY DATE DESC";

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
                    string pType = reader["PAYMENT_TYPE"].ToString();
                    string tCost = reader["COST"].ToString();
                    string cardNum = reader["CARD_NUM"].ToString();
                    string newStat = reader["NEW"].ToString();
                    string syncStat = reader["NEEDS_TO_SYNC"].ToString();
                    string wName = reader["LAST_NAME"].ToString();
                    string isVoid = reader["IS_VOID"].ToString();

                    //add transaction cost to total variables
                    if (pType == "Check" && isVoid == "N")
                    {
                        checkTotal += Double.Parse(tCost);
                    }
                    else if (pType != "Check" && isVoid == "N")
                    {
                        cashTotal += Double.Parse(tCost);
                    }
                    if (isVoid == "N")
                    {
                        grandTotal += Double.Parse(tCost);
                    }
                    //add info to datagrid
                    dgvDailyReport.Rows.Add(id, date, cName, cPhone, mDesc, pType, "$" + tCost, cardNum, newStat, syncStat, wName, isVoid);
                }
                connection.Close();
                //add row to dgv for totals
                dgvDailyReport.Rows.Add(" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ");
                dgvDailyReport.Rows.Add("Totals:", "Cash Total: ", "$" + cashTotal, "Check Total:", "$" + checkTotal, "Grand Total: ", "$" + grandTotal);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Selected Report, ERROR CODE: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        //Closes the current window
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            exportDGV();
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
                //Add or subtract from the count to determine which portion of the datagrid view is exported
                for (int i = 0; i < dgvDailyReport.Columns.Count - 1; i++)
                {
                    worksheet.Cells[1, i + 1] = dgvDailyReport.Columns[i].HeaderText;
                }
                chartRange = worksheet.get_Range("a1", "l1");
                chartRange.Font.Bold = true;
                chartRange.Font.Size = 15;
                chartRange.Columns.AutoFit();
                chartRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                //Loop through each row and read value from each column. 
                for (int worksheetrow = 2, ddgrow = 0; ddgrow < dgvDailyReport.Rows.Count; worksheetrow++, ddgrow++)
                {
                    //Add or subtract from the count to determine which portion of the datagrid view is exported, this should most likely match to the above one
                    for (int dgvcolumn = 0; dgvcolumn < dgvDailyReport.Columns.Count - 1; dgvcolumn++)
                    {
                        worksheet.Cells[worksheetrow, dgvcolumn + 1] = dgvDailyReport.Rows[ddgrow].Cells[dgvcolumn].Value.ToString();

                        if (ddgrow == dgvDailyReport.Rows.Count - 1)
                        {
                            if (dgvcolumn < 6)
                            {
                                worksheet.Cells[worksheetrow, dgvcolumn + 1] = dgvDailyReport.Rows[ddgrow].Cells[dgvcolumn].Value.ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    wrkRow = worksheetrow;
                }

                //gets range of cells and autosizes the data columns
                string cell2 = "l" + wrkRow.ToString();
                chartRange = worksheet.get_Range("a2", cell2);
                chartRange.Font.Size = 11;

                chartRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.PeachPuff);

                //Puts a border around the actual data
                chartRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

                //Totals Row Changes
                cell2 = "l" + wrkRow.ToString();
                string cell1 = "a" + wrkRow.ToString();
                chartRange = worksheet.get_Range(cell1, cell2);

                //Borders to separate and organize the totals row
                chartRange = worksheet.get_Range("b" + wrkRow.ToString(), "c" + wrkRow.ToString());
                chartRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Peru);
                chartRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                chartRange = worksheet.get_Range("d" + wrkRow.ToString(), "e" + wrkRow.ToString());
                chartRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Salmon);
                chartRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                chartRange = worksheet.get_Range("f" + wrkRow.ToString(), "g" + wrkRow.ToString());
                chartRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSalmon);
                chartRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd  hh_mm") + "  " + "Daily Report.xlsx";

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

        private void dgvDailyReport_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            int id;
            string memName;
            string memPhone;
            int cardNum;
            string memType;
            string voided;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    //gets transaction id
                    int columnIndexID = e.ColumnIndex - 12;
                    //gets membership name
                    int columnIndexMemName = e.ColumnIndex - 10;
                    //gets membership phone
                    int columnIndexPhone = e.ColumnIndex - 9;
                    //gets membership card number
                    int columnIndexCardNum = e.ColumnIndex - 5;
                    //gets membership type
                    int columnIndexMemType = e.ColumnIndex - 8;
                    //gets void status
                    int columnIndexVoid = e.ColumnIndex - 1;

                    int rowIndex = e.RowIndex;

                    //Selects values from datagrid view relating to membership type, but keeping description visible for users
                    id = int.Parse(dgvDailyReport.Rows[rowIndex].Cells[columnIndexID].Value.ToString());
                    memName = dgvDailyReport.Rows[rowIndex].Cells[columnIndexMemName].Value.ToString();
                    memPhone = dgvDailyReport.Rows[rowIndex].Cells[columnIndexPhone].Value.ToString();
                    memType = dgvDailyReport.Rows[rowIndex].Cells[columnIndexMemType].Value.ToString();
                    voided = dgvDailyReport.Rows[rowIndex].Cells[columnIndexVoid].Value.ToString();


                    if (dgvDailyReport.Rows[rowIndex].Cells[columnIndexCardNum].Value == "" || dgvDailyReport.Rows[rowIndex].Cells[columnIndexCardNum].Value == null)
                    {
                        cardNum = 0;
                    }
                    else
                    {
                        string temp = dgvDailyReport.Rows[rowIndex].Cells[columnIndexCardNum].Value.ToString();
                        cardNum = int.Parse(temp);
                    }

                    //instantiate an object of type EntryEditForm called frmEntryEdit
                    EntryEditForm frmEntryEdit = new EntryEditForm(id, cardNum, memPhone, memName, memType, voided);
                    //Display the Edit Entry form in modal format
                    frmEntryEdit.ShowDialog();
                    if (frmEntryEdit.DialogResult == DialogResult.OK)
                    {
                        populateDataGrid();
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to edit this row");
                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            printDocument1.DefaultPageSettings.Landscape = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Daily Report";
                printDocument1.Print();
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
                foreach (DataGridViewColumn dgvGridCol in dgvDailyReport.Columns)
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
                    foreach (DataGridViewColumn GridCol in dgvDailyReport.Columns)
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
                    e.Graphics.DrawString("Daily Report",
                        new Font(dgvDailyReport.Font, FontStyle.Bold),
                        Brushes.Black, e.MarginBounds.Left,
                        e.MarginBounds.Top - e.Graphics.MeasureString("Daily Report",
                        new Font(dgvDailyReport.Font, FontStyle.Bold),
                        e.MarginBounds.Width).Height - 13);

                    //Draw signature line
                    e.Graphics.DrawString("Signature:___________________________________",
                        new Font(dgvDailyReport.Font, FontStyle.Bold),
                        Brushes.Black, e.MarginBounds.Left + 300,
                        e.MarginBounds.Top - e.Graphics.MeasureString("Signature:___________________________________",
                        new Font(dgvDailyReport.Font, FontStyle.Bold),
                        e.MarginBounds.Width).Height - 13);

                    //draw cash and grand total
                    e.Graphics.DrawString("Cash total: $" + cashTotal,
                        new Font(dgvDailyReport.Font, FontStyle.Bold),
                        Brushes.Black, e.MarginBounds.Left + 75,
                        e.MarginBounds.Top - e.Graphics.MeasureString("Cash total: $" + cashTotal,
                        new Font(dgvDailyReport.Font, FontStyle.Bold),
                        e.MarginBounds.Width).Height - 13);

                    e.Graphics.DrawString("Grand total: $" + grandTotal,
                        new Font(dgvDailyReport.Font, FontStyle.Bold),
                        Brushes.Black, e.MarginBounds.Left + 180,
                        e.MarginBounds.Top - e.Graphics.MeasureString("Grand total: $" + grandTotal,
                        new Font(dgvDailyReport.Font, FontStyle.Bold),
                        e.MarginBounds.Width).Height - 13);
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dgvDailyReport.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgvDailyReport.Rows[iRow];
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
                                new Font(dgvDailyReport.Font, FontStyle.Bold), Brushes.Black,
                                e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font(dgvDailyReport.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString("Daily Report",
                                new Font(new Font(dgvDailyReport.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dgvDailyReport.Columns)
                            {
                                if (GridCol.Name != "btnEditRow")
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
                            //Removes cells related to column header when printing
                            if (Cel.ColumnIndex != 12)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateFilter = " AND [TRANSACTION].DATE BETWEEN '" + dtStart.Value.ToString(dateFormat) + "' AND '" + dtEnd.Value.ToString(dateFormat) + "'";
            populateDataGrid();
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            dateFilter = " AND [TRANSACTION].DATE BETWEEN '" + dtStart.Value.ToString(dateFormat) + "' AND '" + dtEnd.Value.ToString(dateFormat) + "'";
            populateDataGrid();
        }
    }
}
