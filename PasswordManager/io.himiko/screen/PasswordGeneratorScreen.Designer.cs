namespace PasswordManager
{
    partial class Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.siticonePictureBox1 = new ns1.SiticonePictureBox();
            this.passwordTextBox = new ns1.SiticoneTextBox();
            this.LenghtComboBox = new ns1.SiticoneComboBox();
            this.siticoneLabel1 = new ns1.SiticoneLabel();
            this.PasswordProviderTextBox = new ns1.SiticoneTextBox();
            this.siticoneLabel2 = new ns1.SiticoneLabel();
            this.siticoneLabel3 = new ns1.SiticoneLabel();
            this.siticoneRoundedGradientButton1 = new ns1.SiticoneRoundedGradientButton();
            this.savePathTextBox = new ns1.SiticoneTextBox();
            this.siticoneLabel4 = new ns1.SiticoneLabel();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticonePictureBox1.Image = global::PasswordManager.Properties.Resources.Dragon_Sniper_logo;
            this.siticonePictureBox1.Location = new System.Drawing.Point(400, 12);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(233, 160);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.Parent = this.passwordTextBox;
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.FocusedState.Parent = this.passwordTextBox;
            this.passwordTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.HoveredState.Parent = this.passwordTextBox;
            this.passwordTextBox.Location = new System.Drawing.Point(304, 178);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
            this.passwordTextBox.Size = new System.Drawing.Size(501, 40);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // LenghtComboBox
            // 
            this.LenghtComboBox.BackColor = System.Drawing.Color.Transparent;
            this.LenghtComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LenghtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LenghtComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LenghtComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.LenghtComboBox.FormattingEnabled = true;
            this.LenghtComboBox.HoveredState.Parent = this.LenghtComboBox;
            this.LenghtComboBox.ItemHeight = 30;
            this.LenghtComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.LenghtComboBox.ItemsAppearance.Parent = this.LenghtComboBox;
            this.LenghtComboBox.Location = new System.Drawing.Point(912, 182);
            this.LenghtComboBox.Name = "LenghtComboBox";
            this.LenghtComboBox.ShadowDecoration.Parent = this.LenghtComboBox;
            this.LenghtComboBox.Size = new System.Drawing.Size(140, 36);
            this.LenghtComboBox.TabIndex = 17;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(150, 178);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(148, 40);
            this.siticoneLabel1.TabIndex = 18;
            this.siticoneLabel1.Text = "Password:";
            // 
            // PasswordProviderTextBox
            // 
            this.PasswordProviderTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordProviderTextBox.DefaultText = "";
            this.PasswordProviderTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordProviderTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordProviderTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordProviderTextBox.DisabledState.Parent = this.PasswordProviderTextBox;
            this.PasswordProviderTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordProviderTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordProviderTextBox.FocusedState.Parent = this.PasswordProviderTextBox;
            this.PasswordProviderTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordProviderTextBox.HoveredState.Parent = this.PasswordProviderTextBox;
            this.PasswordProviderTextBox.Location = new System.Drawing.Point(304, 224);
            this.PasswordProviderTextBox.Name = "PasswordProviderTextBox";
            this.PasswordProviderTextBox.PasswordChar = '\0';
            this.PasswordProviderTextBox.PlaceholderText = "";
            this.PasswordProviderTextBox.SelectedText = "";
            this.PasswordProviderTextBox.ShadowDecoration.Parent = this.PasswordProviderTextBox;
            this.PasswordProviderTextBox.Size = new System.Drawing.Size(501, 40);
            this.PasswordProviderTextBox.TabIndex = 19;
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.Location = new System.Drawing.Point(12, 224);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(286, 40);
            this.siticoneLabel2.TabIndex = 20;
            this.siticoneLabel2.Text = "Password providers:";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.Location = new System.Drawing.Point(927, 136);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(108, 40);
            this.siticoneLabel3.TabIndex = 21;
            this.siticoneLabel3.Text = "Lenght:";
            // 
            // siticoneRoundedGradientButton1
            // 
            this.siticoneRoundedGradientButton1.CheckedState.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.CustomImages.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.FillColor = System.Drawing.Color.Gray;
            this.siticoneRoundedGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneRoundedGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedGradientButton1.HoveredState.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.Location = new System.Drawing.Point(400, 353);
            this.siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
            this.siticoneRoundedGradientButton1.ShadowDecoration.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.Size = new System.Drawing.Size(230, 45);
            this.siticoneRoundedGradientButton1.TabIndex = 22;
            this.siticoneRoundedGradientButton1.Text = "Generate Password";
            this.siticoneRoundedGradientButton1.Click += new System.EventHandler(this.siticoneRoundedGradientButton1_Click);
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.savePathTextBox.DefaultText = "";
            this.savePathTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.savePathTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.savePathTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.savePathTextBox.DisabledState.Parent = this.savePathTextBox;
            this.savePathTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.savePathTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.savePathTextBox.FocusedState.Parent = this.savePathTextBox;
            this.savePathTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.savePathTextBox.HoveredState.Parent = this.savePathTextBox;
            this.savePathTextBox.Location = new System.Drawing.Point(304, 298);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.PasswordChar = '\0';
            this.savePathTextBox.PlaceholderText = "";
            this.savePathTextBox.SelectedText = "";
            this.savePathTextBox.ShadowDecoration.Parent = this.savePathTextBox;
            this.savePathTextBox.Size = new System.Drawing.Size(501, 40);
            this.savePathTextBox.TabIndex = 23;
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.Location = new System.Drawing.Point(150, 298);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(155, 40);
            this.siticoneLabel4.TabIndex = 24;
            this.siticoneLabel4.Text = "Save Path:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 410);
            this.Controls.Add(this.siticoneLabel4);
            this.Controls.Add(this.savePathTextBox);
            this.Controls.Add(this.siticoneRoundedGradientButton1);
            this.Controls.Add(this.siticoneLabel3);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.PasswordProviderTextBox);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.LenghtComboBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.siticonePictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "KHA Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.SiticonePictureBox siticonePictureBox1;
        private ns1.SiticoneTextBox passwordTextBox;
        private ns1.SiticoneComboBox LenghtComboBox;
        private ns1.SiticoneLabel siticoneLabel1;
        private ns1.SiticoneTextBox PasswordProviderTextBox;
        private ns1.SiticoneLabel siticoneLabel2;
        private ns1.SiticoneLabel siticoneLabel3;
        private ns1.SiticoneRoundedGradientButton siticoneRoundedGradientButton1;
        private ns1.SiticoneTextBox savePathTextBox;
        private ns1.SiticoneLabel siticoneLabel4;
    }
}

