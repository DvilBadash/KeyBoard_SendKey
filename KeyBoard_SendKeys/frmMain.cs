using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KeyBoard_SendKeys
{
    public partial class frmMain : Form
    {
        private int int_btn_height = 25;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem SetButtonsToolStripMenuItem;

        private DataTable table_buttons = new DataTable();


        private void SetContexMenu()
        {
            try
            {



                // Create the ContextMenuStrip
                contextMenuStrip = new ContextMenuStrip();

                // Create the Close menu item
                closeToolStripMenuItem = new ToolStripMenuItem();
                closeToolStripMenuItem.Text = "Close";
                closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;

                // Add the Close menu item to the ContextMenuStrip
                contextMenuStrip.Items.Add(closeToolStripMenuItem);


                // Create the Close menu item
                SetButtonsToolStripMenuItem = new ToolStripMenuItem();
                SetButtonsToolStripMenuItem.Text = "Set Buttons";
                SetButtonsToolStripMenuItem.Click += SetButtonsToolStripMenuItem_Click;

                // Add the Close menu item to the ContextMenuStrip
                contextMenuStrip.Items.Add(SetButtonsToolStripMenuItem);

                // Assign the ContextMenuStrip to the NotifyIcon
                notifyIcon1.ContextMenuStrip = contextMenuStrip;

            
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_buttons frm_Update_buttons = new frm_Update_buttons(table_buttons);
            frm_Update_buttons.ShowDialog();

            Clear_all_buttons();
            SetButtons();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clean up resources and close the application
            
            contextMenuStrip.Dispose();
            Application.Exit();
        }


        public frmMain()
        {
            this.Top = 0;
            this.Left = 0;
            InitializeComponent();
        }

        private void CreateButton(string Btn_name , string btn_text , int int_num ,string btn_color)
        {
            try
            {
                Button dynamicButton = new Button();
                dynamicButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dynamicButton.Location = new System.Drawing.Point(10, int_num * (int_btn_height + 5));
                dynamicButton.Name = Btn_name;
                dynamicButton.Size = new System.Drawing.Size(155, int_btn_height);
                dynamicButton.TabIndex = int_num;
                dynamicButton.Text = btn_text;
                dynamicButton.UseVisualStyleBackColor = true;
                SetButtonColor(btn_color, dynamicButton);
                dynamicButton.Click += new System.EventHandler(this.dynamicButton_Click);
                this.Controls.Add(dynamicButton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        private const byte VK_LWIN = 0x5B; // Left Windows key
        private const int KEYEVENTF_KEYUP = 0x0002;


        private void dynamicButton_Click(object sender, EventArgs e)
        {
            try
            {

                Button BTN = (Button)sender;
                for (int i = 0; i < table_buttons.Rows.Count; i++)
                {
                    if (table_buttons.Rows[i]["Name"].ToString() == BTN.Name)
                    {
                        string str = table_buttons.Rows[i]["Text"].ToString().ToLower();
                        if (table_buttons.Rows[i]["KeyStrokes"].ToString().ToLower().Contains("{windows}"))
                        {
                        //    SendKeys.SendWait("^{ESC}"); // Presses Ctrl+Esc as an alternative to the Win key
                        //    SendKeys.SendWait("E");
                        //    SendKeys. 
                        //   str = str.Replace("{windows}", "");
                        }

                        SendKeys.Send(table_buttons.Rows[i]["KeyStrokes"].ToString());
                        break;
                    }
                }
                Hide_Bar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendWin_key()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetContexMenu();
            SetButtons();
        }

        private void Clear_all_buttons()
        {
            for (int i = 0; i < 5; i++)
            {


                foreach (Control control in this.Controls)
                {
                    control.Dispose();

                }
            }
        }


        private void SetButtonColor(string color, Button button1)
        {
            try
            {
                switch (color.ToLower())
                {
                    case "red":
                        button1.BackColor = Color.Red;
                        break;
                    case "blue":
                        button1.BackColor = Color.Blue;
                        break;
                    case "green":
                        button1.BackColor = Color.Green;
                        break;
                    case "yellow":
                        button1.BackColor = Color.Yellow;
                        break;
                    case "Orange":
                        button1.BackColor = Color.Orange;
                        break;
                    case "purple":
                        button1.BackColor = Color.Purple;
                        break;
                    case "pink":
                        button1.BackColor = Color.Pink;
                        break;
                    case "brown":
                        button1.BackColor = Color.Brown;
                        break;
                    case "gray":
                        button1.BackColor = Color.Gray;
                        break;
                    case "black":
                        button1.BackColor = Color.Black;
                        break;
                    case "lightgray":
                        button1.BackColor = Color.LightGray;
                        break;
                    case "lightsteelblue":
                        button1.BackColor = Color.LightSteelBlue;
                        break;
                    case "white":
                        button1.BackColor = Color.White;
                        break;
                    case "greenyellow":
                        button1.BackColor = Color.GreenYellow;
                        break;
                    default:
                        button1.BackColor = Color.White;
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SetButtons()
        {
            table_buttons = ReadXML();
            this.Height = (table_buttons.Rows.Count * int_btn_height) + (table_buttons.Rows.Count * 7);

            for (int i = 0; i < table_buttons.Rows.Count ; i++)
            {
                CreateButton(table_buttons.Rows[i]["Name"].ToString(), table_buttons.Rows[i]["text"].ToString(), i, table_buttons.Rows[i]["Color"].ToString());
            }
            
        }
        public DataTable ReadXML()
        {
            //create the DataTable that will hold the data
            DataTable table = new DataTable("XmlData");
            try
            {
                DataSet objDataSet  = new DataSet();  
                objDataSet.ReadXml("XMLFile_config.xml");  

                    //return the results
                    return objDataSet.Tables[0]; 
                
            }
            catch (Exception ex)
            {
                return table;
            }
        }


        private void Form1_Resize_1(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide_Bar();
            }
            
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Show the context menu at the current mouse location
                contextMenuStrip.Show(Cursor.Position);
            }
            Show_Bar();
        }

        private void Show_Bar()
        {

        

            this.Top = 0;
            this.Left = 0;
            Show();
            this.WindowState = FormWindowState.Normal;
            //notifyIcon1.Visible = false;
        }

        private void Hide_Bar()
        {

            Hide();
            notifyIcon1.Visible = true;
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;  // Cancel the close operation

                // Minimize the form instead of closing it
                this.WindowState = FormWindowState.Minimized;
            }
        }

       
    }
}
