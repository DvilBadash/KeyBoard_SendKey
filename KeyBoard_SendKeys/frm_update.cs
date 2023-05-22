using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoard_SendKeys
{
    public partial class frm_update : Form
    {
        bool is_new = true;
        string str_p_KeyStrokes;
        string str_p_text;
        string str_p_name;
        string str_p_Color;
        frm_Update_buttons frm_p_frm_Update_buttons;


        Dictionary<string, string> keyDictionary = new Dictionary<string, string>()
        {
            {"", ""},
            {"A", "A"},
            {"B", "B"},
            {"C", "C"},
            {"D", "D"},
            {"E", "E"},
            {"F", "F"},
            {"G", "G"},
            {"H", "H"},
            {"I", "I"},
            {"J", "J"},
            {"K", "K"},
            {"L", "L"},
            {"M", "M"},
            {"N", "N"},
            {"O", "O"},
            {"P", "P"},
            {"Q", "Q"},
            {"R", "R"},
            {"S", "S"},
            {"T", "T"},
            {"U", "U"},
            {"V", "V"},
            {"W", "W"},
            {"X", "X"},
            {"Y", "Y"},
            {"Z", "Z"},
            {"0", "0"},
            {"1", "1"},
            {"2", "2"},
            {"3", "3"},
            {"4", "4"},
            {"5", "5"},
            {"6", "6"},
            {"7", "7"},
            {"8", "8"},
            {"9", "9"},
            {"F1", "{F1}"},
            {"F2", "{F2}"},
            {"F3", "{F3}"},
            {"F4", "{F4}"},
            {"F5", "{F5}"},
            {"F6", "{F6}"},
            {"F7", "{F7}"},
            {"F8", "{F8}"},
            {"F9", "{F9}"},
            {"F10", "{F10}"},
            {"F11", "{F11}"},
            {"F12", "{F12}"},
            {"Shift", "+"},
            {"Ctrl", "^"},
            {"Alt", "%"},
            {"Esc", "{ESC}"},
            {"Space", " "},
            {"Enter", "{ENTER}"},
            {"Tab", "{TAB}"},
            {"Backspace", "{BACKSPACE}"},
            {"Delete", "{DELETE}"},
            {"Insert", "{INSERT}"},
            {"Home", "{HOME}"},
            {"End", "{END}"},
            {"PageUp", "{PGUP}"},
            {"PageDown", "{PGDN}"},
            {"Up", "{UP}"},
            {"Down", "{DOWN}"},
            {"Left", "{LEFT}"},
            {"Right", "{RIGHT}"},
            {"PrintScreen", "{PRTSC}"},
            {"ScrollLock", "{SCROLLLOCK}"},
            {"Pause", "{PAUSE}"},
            {"NumLock", "{NUMLOCK}"},
            {"CapsLock", "{CAPSLOCK}"},
            {"Plus", "{ADD}"},
            {"Minus", "{SUBTRACT}"},
            {"Multiply", "{MULTIPLY}"},
            {"Divide", "{DIVIDE}"},
            {"WinKey", "{windows}"},
            {"Help", "{HELP}"}
        };


        public frm_update(bool p_is_new, string p_KeyStrokes, string p_text, string p_name, string p_Color, frm_Update_buttons p_frm_Update_buttons)
        {
            frm_p_frm_Update_buttons = p_frm_Update_buttons;
            is_new = p_is_new;
            InitializeComponent();
        }
        
        private void frm_update_Load(object sender, EventArgs e)
        {
            FillComboBoxWithKeys(cmbKeys1);
            FillComboBoxWithKeys(cmbKeys2);
            FillComboBoxWithKeys(cmbKeys3);

            if (is_new == false)
            {
                txtText.Text = str_p_text;
                txtName.Text = str_p_name;
                cmb_Color.Text = str_p_Color;

            }
        }




        public void FillComboBoxWithKeys(ComboBox comboBox)
        {
            // Clear the existing items in the ComboBox
            comboBox.Items.Clear();
            comboBox.DataSource = new BindingSource(keyDictionary, null);
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";


            //// Get all keys defined in the Keys class
            //Keys[] keys = (Keys[])Enum.GetValues(typeof(Keys));

            //// Add each key to the ComboBox
            //foreach (Keys key in keys)
            //{
            //    comboBox.Items.Add(key);
            //}

            //// Get all keys defined in the Keys class
            //Keys[] keys = (Keys[])Enum.GetValues(typeof(Keys));

            //// Add each key to the ComboBox
            //foreach (Keys key in keys)
            //{
            //    // Exclude modifier keys and mouse buttons
            //    if (key >= Keys.A && key <= Keys.Z || key >= Keys.D0 && key <= Keys.D9)
            //    {
            //        comboBox.Items.Add(key);
            //    }
            //}
        }
        private void set_txt()
        {
            if (cmbKeys1.Text == "" && cmbKeys2.Text == "" && cmbKeys3.Text == "")
            {
                txtText.Text = "";
            }
            if (cmbKeys1.Text != "" && cmbKeys2.Text == "" && cmbKeys3.Text == "")
            {
                txtText.Text = cmbKeys1.Text;
            }
            if (cmbKeys1.Text != "" && cmbKeys2.Text != "" && cmbKeys3.Text == "")
            {
                txtText.Text = cmbKeys1.Text + " + " + cmbKeys2.Text;
            }
            if (cmbKeys1.Text != "" && cmbKeys2.Text != "" && cmbKeys3.Text != "")
            {
                txtText.Text = cmbKeys1.Text + " + " + cmbKeys2.Text + " + " + cmbKeys3.Text;
            }
        }

        private void cmbKeys3_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_txt();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (is_new == false)
            {
                frm_p_frm_Update_buttons.dataGridView1.CurrentRow.Cells["KeyStrokes"].Value = cmbKeys1.SelectedValue.ToString() + cmbKeys2.SelectedValue.ToString() + cmbKeys3.SelectedValue.ToString();
                frm_p_frm_Update_buttons.dataGridView1.CurrentRow.Cells["text"].Value = txtText.Text;
                frm_p_frm_Update_buttons.dataGridView1.CurrentRow.Cells["Name"].Value = txtName.Text;
                frm_p_frm_Update_buttons.dataGridView1.CurrentRow.Cells["color"].Value = cmb_Color.Text.ToString();
            }
            else
            {
                frm_p_frm_Update_buttons.dataGridView1.Rows.Add(cmbKeys1.SelectedValue.ToString() + cmbKeys2.SelectedValue.ToString() + cmbKeys3.SelectedValue.ToString(), txtText.Text, txtName.Text, cmb_Color.Text.ToString());
                
            }
            this.Close();
        }

        private void cmbKeys1_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_txt();
        }

        private void cmbKeys2_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_txt();
        }
    }
}
