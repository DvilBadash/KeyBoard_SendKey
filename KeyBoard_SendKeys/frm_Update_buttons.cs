using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KeyBoard_SendKeys
{
    public partial class frm_Update_buttons : Form
    {
        private    DataTable table_buttons = new DataTable();

        public frm_Update_buttons(DataTable table_buttons_to_set)
        {
            table_buttons = table_buttons_to_set;
            InitializeComponent();
        }

        private void frm_Update_buttons_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Create columns based on DataTable schema
            foreach (DataColumn column in table_buttons.Columns)
            {
                dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
            }
            // Add data rows to the grid
            for (int rowIndex = 0; rowIndex < table_buttons.Rows.Count; rowIndex++)
            {
                DataRow row = table_buttons.Rows[rowIndex];

                // Create an array to hold cell values for the current row
                object[] cellValues = new object[table_buttons.Columns.Count];

                // Copy cell values from DataRow to the array
                for (int columnIndex = 0; columnIndex < table_buttons.Columns.Count; columnIndex++)
                {
                    cellValues[columnIndex] = row[columnIndex];
                }

                // Add the row to the DataGridView
                dataGridView1.Rows.Add(cellValues);
            }

            // Optional: Auto-resize columns to fit content
            dataGridView1.AutoResizeColumns();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_update frm_update = new frm_update(true, dataGridView1.CurrentRow.Cells["KeyStrokes"].Value.ToString(), dataGridView1.CurrentRow.Cells["text"].Value.ToString(), dataGridView1.CurrentRow.Cells["Name"].Value.ToString() ,dataGridView1.CurrentRow.Cells["color"].Value.ToString(),this);
            frm_update.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frm_update frm_update = new frm_update(false, dataGridView1.CurrentRow.Cells["KeyStrokes"].Value.ToString(), dataGridView1.CurrentRow.Cells["text"].Value.ToString(), dataGridView1.CurrentRow.Cells["Name"].Value.ToString(), dataGridView1.CurrentRow.Cells["color"].Value.ToString(), this);
            frm_update.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            
           
        }



                private void SaveDataGridViewToXml(DataGridView dataGridView, string fileName)
        {
            // Create a new XML document
            XmlDocument xmlDocument = new XmlDocument();

            // Create the root element
            XmlElement rootElement = xmlDocument.CreateElement("Data");
            xmlDocument.AppendChild(rootElement);

            // Iterate through the rows of the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Create a new element for each row
                XmlElement rowElement = xmlDocument.CreateElement("Row");

                // Iterate through the cells of the row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Get the column name as the element name
                    string columnName = dataGridView.Columns[cell.ColumnIndex].Name;

                    // Create a new element for each cell and set its value
                    XmlElement cellElement = xmlDocument.CreateElement(columnName);
                    cellElement.InnerText = cell.Value.ToString();
                    
                    // Append the cell element to the row element
                    rowElement.AppendChild(cellElement);
                }

                // Append the row element to the root element
                rootElement.AppendChild(rowElement);
            }

            // Save the XML document to a file
            xmlDocument.Save(fileName);

            MessageBox.Show("DataGridView saved as XML successfully!");
        }

                private void btn_up_Click(object sender, EventArgs e)
                {
                    try
                    {


                        // Get the selected row index
                        int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;

                        if (selectedIndex == 0) return;
                        // Get the selected row
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedIndex];

                        // Remove the selected row from the DataGridView
                        dataGridView1.Rows.Remove(selectedRow);

                        // Insert the selected row at the desired position (e.g., move it up one position)
                        int desiredIndex = selectedIndex - 1;
                        if (desiredIndex >= 0)
                        {
                            dataGridView1.Rows.Insert(desiredIndex, selectedRow);
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[desiredIndex].Selected = true;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }

                private void button1_Click(object sender, EventArgs e)
                {
                    try
                    {



                        // Get the selected row index
                        int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;

                        if (selectedIndex == dataGridView1.Rows.Count-1) return;
                        // Get the selected row
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedIndex];

                        // Remove the selected row from the DataGridView
                        dataGridView1.Rows.Remove(selectedRow);

                        // Insert the selected row at the desired position (e.g., move it up one position)
                        int desiredIndex = selectedIndex + 1;
                        if (desiredIndex >= 0)
                        {
                            dataGridView1.Rows.Insert(desiredIndex, selectedRow);
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[desiredIndex].Selected = true;
                        }
                    }
                    catch (Exception)
                    {

                    }
                }

                private void btnSave_Click(object sender, EventArgs e)
                {
                    try
                    {
                        SaveDataGridViewToXml(dataGridView1, "XMLFile_config.xml");

                    }
                    catch (Exception)
                    {
                        
                        
                    }
                    
                }
    }
}
