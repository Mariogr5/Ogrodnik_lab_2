namespace Ogrodnik_lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DancerCheckBox = new System.Windows.Forms.CheckedListBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Update = new System.Windows.Forms.Button();
            this.Id_filter_text = new System.Windows.Forms.TextBox();
            this.FiltrId_label = new System.Windows.Forms.Label();
            this.DanceClassComboBox = new System.Windows.Forms.ComboBox();
            this.DanceClass_selected_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(190, 24);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(588, 353);
            this.textBoxResponse.TabIndex = 0;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(12, 369);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(101, 57);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "Get Datas";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dancer Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(374, 403);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(89, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear Results";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DancerCheckBox
            // 
            this.DancerCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.DancerCheckBox.CheckOnClick = true;
            this.DancerCheckBox.FormattingEnabled = true;
            this.DancerCheckBox.Items.AddRange(new object[] {
            "Id",
            "DanceClass"});
            this.DancerCheckBox.Location = new System.Drawing.Point(3, 98);
            this.DancerCheckBox.Name = "DancerCheckBox";
            this.DancerCheckBox.Size = new System.Drawing.Size(181, 94);
            this.DancerCheckBox.TabIndex = 10;
            this.DancerCheckBox.Visible = false;
            this.DancerCheckBox.SelectedIndexChanged += new System.EventHandler(this.DancerCheckBox_SelectedIndexChanged);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(7, 30);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(100, 23);
            this.IdBox.TabIndex = 2;
            this.IdBox.TextChanged += new System.EventHandler(this.IdBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dancer Data Tool";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 19);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Filter by";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(505, 403);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(164, 23);
            this.Update.TabIndex = 13;
            this.Update.Text = "Get Actual Data From URL";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Id_filter_text
            // 
            this.Id_filter_text.Location = new System.Drawing.Point(3, 216);
            this.Id_filter_text.Name = "Id_filter_text";
            this.Id_filter_text.Size = new System.Drawing.Size(121, 23);
            this.Id_filter_text.TabIndex = 14;
            this.Id_filter_text.Text = "<";
            this.Id_filter_text.Visible = false;
            // 
            // FiltrId_label
            // 
            this.FiltrId_label.AutoSize = true;
            this.FiltrId_label.Location = new System.Drawing.Point(4, 198);
            this.FiltrId_label.Name = "FiltrId_label";
            this.FiltrId_label.Size = new System.Drawing.Size(83, 15);
            this.FiltrId_label.TabIndex = 15;
            this.FiltrId_label.Text = "(= < > <= >=)";
            this.FiltrId_label.Visible = false;
            // 
            // DanceClassComboBox
            // 
            this.DanceClassComboBox.FormattingEnabled = true;
            this.DanceClassComboBox.Items.AddRange(new object[] {
            "H",
            "G",
            "F",
            "E",
            "D",
            "C",
            "B",
            "A",
            "S"});
            this.DanceClassComboBox.Location = new System.Drawing.Point(3, 262);
            this.DanceClassComboBox.Name = "DanceClassComboBox";
            this.DanceClassComboBox.Size = new System.Drawing.Size(121, 23);
            this.DanceClassComboBox.TabIndex = 16;
            this.DanceClassComboBox.Visible = false;
            // 
            // DanceClass_selected_label
            // 
            this.DanceClass_selected_label.AutoSize = true;
            this.DanceClass_selected_label.Location = new System.Drawing.Point(4, 244);
            this.DanceClass_selected_label.Name = "DanceClass_selected_label";
            this.DanceClass_selected_label.Size = new System.Drawing.Size(104, 15);
            this.DanceClass_selected_label.TabIndex = 19;
            this.DanceClass_selected_label.Text = "Select Dance Class";
            this.DanceClass_selected_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DanceClass_selected_label);
            this.Controls.Add(this.DanceClassComboBox);
            this.Controls.Add(this.FiltrId_label);
            this.Controls.Add(this.Id_filter_text);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DancerCheckBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.textBoxResponse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxResponse;
        private Button buttonDownload;
        private Label label1;
        private Button ClearButton;
        private CheckedListBox DancerCheckBox;
        private TextBox IdBox;
        private Label label2;
        private CheckBox checkBox1;
        private Button Update;
        private TextBox Id_filter_text;
        private Label FiltrId_label;
        private ComboBox DanceClassComboBox;
        private Label DanceClass_selected_label;
    }
}