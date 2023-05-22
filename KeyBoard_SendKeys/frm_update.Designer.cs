namespace KeyBoard_SendKeys
{
    partial class frm_update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbKeys1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKeys2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKeys3 = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKeys1
            // 
            this.cmbKeys1.BackColor = System.Drawing.Color.White;
            this.cmbKeys1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKeys1.FormattingEnabled = true;
            this.cmbKeys1.Location = new System.Drawing.Point(70, 23);
            this.cmbKeys1.Name = "cmbKeys1";
            this.cmbKeys1.Size = new System.Drawing.Size(121, 24);
            this.cmbKeys1.TabIndex = 0;
            this.cmbKeys1.SelectedIndexChanged += new System.EventHandler(this.cmbKeys1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type2";
            // 
            // cmbKeys2
            // 
            this.cmbKeys2.BackColor = System.Drawing.Color.White;
            this.cmbKeys2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKeys2.FormattingEnabled = true;
            this.cmbKeys2.Location = new System.Drawing.Point(255, 23);
            this.cmbKeys2.Name = "cmbKeys2";
            this.cmbKeys2.Size = new System.Drawing.Size(121, 24);
            this.cmbKeys2.TabIndex = 2;
            this.cmbKeys2.SelectedIndexChanged += new System.EventHandler(this.cmbKeys2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type3";
            // 
            // cmbKeys3
            // 
            this.cmbKeys3.BackColor = System.Drawing.Color.White;
            this.cmbKeys3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKeys3.FormattingEnabled = true;
            this.cmbKeys3.Location = new System.Drawing.Point(443, 23);
            this.cmbKeys3.Name = "cmbKeys3";
            this.cmbKeys3.Size = new System.Drawing.Size(121, 24);
            this.cmbKeys3.TabIndex = 4;
            this.cmbKeys3.SelectedIndexChanged += new System.EventHandler(this.cmbKeys3_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 22);
            this.txtName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Text";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(70, 113);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(120, 22);
            this.txtText.TabIndex = 8;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 157);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 17);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Shortcut";
            // 
            // cmb_Color
            // 
            this.cmb_Color.BackColor = System.Drawing.Color.White;
            this.cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Items.AddRange(new object[] {
            "red",
            "blue",
            "green",
            "yellow",
            "Orange",
            "purple",
            "pink",
            "brown",
            "gray",
            "lightgray",
            "lightsteelblue",
            "white",
            "greenyellow"});
            this.cmb_Color.Location = new System.Drawing.Point(70, 154);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(121, 24);
            this.cmb_Color.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.Location = new System.Drawing.Point(443, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frm_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 241);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmb_Color);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKeys3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKeys2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKeys1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set button";
            this.Load += new System.EventHandler(this.frm_update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKeys1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKeys2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKeys3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Button btnSave;
    }
}