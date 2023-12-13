namespace PIYU_SecureID
{
    partial class ControlCreateId
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxLastName = new TextBox();
            textBoxGivenName = new TextBox();
            label2 = new Label();
            textBoxMiddleName = new TextBox();
            label3 = new Label();
            textBoxSuffix = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxSex = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            pictureBoxIdPhoto = new PictureBox();
            buttonBrowse = new Button();
            label8 = new Label();
            label9 = new Label();
            buttonCreate = new Button();
            buttonClearAll = new Button();
            comboBoxBloodType = new ComboBox();
            comboBoxMaritalStatus = new ComboBox();
            comboBoxProvince = new ComboBox();
            label10 = new Label();
            comboBoxCity = new ComboBox();
            label11 = new Label();
            comboBoxBarangay = new ComboBox();
            label12 = new Label();
            buttonCamera = new Button();
            buttonClearPhoto = new Button();
            buttonSignature = new Button();
            pictureBoxSignature = new PictureBox();
            buttonClearSign = new Button();
            comboBoxCameras = new ComboBox();
            comboBoxDay = new ComboBox();
            comboBoxMonth = new ComboBox();
            textBoxYear = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIdPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSignature).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.CharacterCasing = CharacterCasing.Upper;
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(54, 57);
            textBoxLastName.MaxLength = 64;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(404, 29);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxGivenName
            // 
            textBoxGivenName.CharacterCasing = CharacterCasing.Upper;
            textBoxGivenName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGivenName.Location = new Point(54, 118);
            textBoxGivenName.MaxLength = 64;
            textBoxGivenName.Name = "textBoxGivenName";
            textBoxGivenName.Size = new Size(404, 29);
            textBoxGivenName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 94);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 2;
            label2.Text = "Given Name";
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.CharacterCasing = CharacterCasing.Upper;
            textBoxMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMiddleName.Location = new Point(54, 179);
            textBoxMiddleName.MaxLength = 64;
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(404, 29);
            textBoxMiddleName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 155);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 4;
            label3.Text = "Middle Name";
            // 
            // textBoxSuffix
            // 
            textBoxSuffix.CharacterCasing = CharacterCasing.Upper;
            textBoxSuffix.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSuffix.Location = new Point(54, 240);
            textBoxSuffix.MaxLength = 32;
            textBoxSuffix.Name = "textBoxSuffix";
            textBoxSuffix.Size = new Size(109, 29);
            textBoxSuffix.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 216);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 6;
            label4.Text = "Suffix";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 277);
            label5.Name = "label5";
            label5.Size = new Size(36, 21);
            label5.TabIndex = 8;
            label5.Text = "Sex";
            // 
            // comboBoxSex
            // 
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Items.AddRange(new object[] { "MALE", "FEMALE" });
            comboBoxSex.Location = new Point(54, 296);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(109, 29);
            comboBoxSex.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(40, 343);
            label6.Name = "label6";
            label6.Size = new Size(103, 21);
            label6.TabIndex = 10;
            label6.Text = "Date of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(40, 410);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 12;
            label7.Text = "Address";
            // 
            // pictureBoxIdPhoto
            // 
            pictureBoxIdPhoto.Location = new Point(839, 33);
            pictureBoxIdPhoto.Name = "pictureBoxIdPhoto";
            pictureBoxIdPhoto.Size = new Size(215, 215);
            pictureBoxIdPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIdPhoto.TabIndex = 14;
            pictureBoxIdPhoto.TabStop = false;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(946, 254);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(109, 38);
            buttonBrowse.TabIndex = 15;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(207, 277);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 16;
            label8.Text = "Blood Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(40, 476);
            label9.Name = "label9";
            label9.Size = new Size(110, 21);
            label9.TabIndex = 18;
            label9.Text = "Marital Status";
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCreate.Location = new Point(970, 553);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(125, 56);
            buttonCreate.TabIndex = 20;
            buttonCreate.Text = "CREATE";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonClearAll
            // 
            buttonClearAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClearAll.Location = new Point(839, 553);
            buttonClearAll.Name = "buttonClearAll";
            buttonClearAll.Size = new Size(125, 56);
            buttonClearAll.TabIndex = 21;
            buttonClearAll.Text = "CLEAR";
            buttonClearAll.UseVisualStyleBackColor = true;
            buttonClearAll.Click += buttonClearAll_Click;
            // 
            // comboBoxBloodType
            // 
            comboBoxBloodType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBloodType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxBloodType.FormattingEnabled = true;
            comboBoxBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            comboBoxBloodType.Location = new Point(222, 296);
            comboBoxBloodType.Margin = new Padding(3, 2, 3, 2);
            comboBoxBloodType.Name = "comboBoxBloodType";
            comboBoxBloodType.Size = new Size(109, 29);
            comboBoxBloodType.TabIndex = 22;
            // 
            // comboBoxMaritalStatus
            // 
            comboBoxMaritalStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaritalStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMaritalStatus.FormattingEnabled = true;
            comboBoxMaritalStatus.Items.AddRange(new object[] { "SINGLE", "MARRIED", "ANNULLED", "SEPARATED", "WIDOWED" });
            comboBoxMaritalStatus.Location = new Point(59, 499);
            comboBoxMaritalStatus.Margin = new Padding(3, 2, 3, 2);
            comboBoxMaritalStatus.Name = "comboBoxMaritalStatus";
            comboBoxMaritalStatus.Size = new Size(104, 29);
            comboBoxMaritalStatus.TabIndex = 23;
            // 
            // comboBoxProvince
            // 
            comboBoxProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProvince.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProvince.FormattingEnabled = true;
            comboBoxProvince.Location = new Point(54, 429);
            comboBoxProvince.Margin = new Padding(3, 2, 3, 2);
            comboBoxProvince.Name = "comboBoxProvince";
            comboBoxProvince.Size = new Size(224, 29);
            comboBoxProvince.TabIndex = 24;
            comboBoxProvince.SelectedIndexChanged += comboBoxProvince_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(129, 460);
            label10.Name = "label10";
            label10.Size = new Size(61, 13);
            label10.TabIndex = 25;
            label10.Text = "PROVINCE";
            // 
            // comboBoxCity
            // 
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(284, 429);
            comboBoxCity.Margin = new Padding(3, 2, 3, 2);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(224, 29);
            comboBoxCity.TabIndex = 26;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(384, 460);
            label11.Name = "label11";
            label11.Size = new Size(29, 13);
            label11.TabIndex = 27;
            label11.Text = "CITY";
            // 
            // comboBoxBarangay
            // 
            comboBoxBarangay.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBarangay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxBarangay.FormattingEnabled = true;
            comboBoxBarangay.Location = new Point(514, 429);
            comboBoxBarangay.Margin = new Padding(3, 2, 3, 2);
            comboBoxBarangay.Name = "comboBoxBarangay";
            comboBoxBarangay.Size = new Size(224, 29);
            comboBoxBarangay.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(594, 460);
            label12.Name = "label12";
            label12.Size = new Size(65, 13);
            label12.TabIndex = 29;
            label12.Text = "BARANGAY";
            // 
            // buttonCamera
            // 
            buttonCamera.Location = new Point(838, 254);
            buttonCamera.Name = "buttonCamera";
            buttonCamera.Size = new Size(109, 38);
            buttonCamera.TabIndex = 30;
            buttonCamera.Text = "Take a Photo";
            buttonCamera.UseVisualStyleBackColor = true;
            buttonCamera.Click += buttonCamera_Click;
            // 
            // buttonClearPhoto
            // 
            buttonClearPhoto.Location = new Point(946, 292);
            buttonClearPhoto.Name = "buttonClearPhoto";
            buttonClearPhoto.Size = new Size(109, 38);
            buttonClearPhoto.TabIndex = 31;
            buttonClearPhoto.Text = "Clear";
            buttonClearPhoto.UseVisualStyleBackColor = true;
            buttonClearPhoto.Click += buttonClearPhoto_Click;
            // 
            // buttonSignature
            // 
            buttonSignature.Location = new Point(550, 254);
            buttonSignature.Name = "buttonSignature";
            buttonSignature.Size = new Size(109, 38);
            buttonSignature.TabIndex = 32;
            buttonSignature.Text = "Signature";
            buttonSignature.UseVisualStyleBackColor = true;
            buttonSignature.Click += buttonSignature_Click;
            // 
            // pictureBoxSignature
            // 
            pictureBoxSignature.Location = new Point(550, 33);
            pictureBoxSignature.Name = "pictureBoxSignature";
            pictureBoxSignature.Size = new Size(215, 215);
            pictureBoxSignature.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSignature.TabIndex = 33;
            pictureBoxSignature.TabStop = false;
            // 
            // buttonClearSign
            // 
            buttonClearSign.Location = new Point(656, 254);
            buttonClearSign.Name = "buttonClearSign";
            buttonClearSign.Size = new Size(109, 38);
            buttonClearSign.TabIndex = 34;
            buttonClearSign.Text = "Clear";
            buttonClearSign.UseVisualStyleBackColor = true;
            buttonClearSign.Click += buttonClearSign_Click;
            // 
            // comboBoxCameras
            // 
            comboBoxCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCameras.FormattingEnabled = true;
            comboBoxCameras.Location = new Point(838, 292);
            comboBoxCameras.Name = "comboBoxCameras";
            comboBoxCameras.Size = new Size(109, 23);
            comboBoxCameras.TabIndex = 35;
            // 
            // comboBoxDay
            // 
            comboBoxDay.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBoxDay.Location = new Point(54, 366);
            comboBoxDay.Margin = new Padding(3, 2, 3, 2);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(68, 29);
            comboBoxDay.TabIndex = 38;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" });
            comboBoxMonth.Location = new Point(128, 365);
            comboBoxMonth.Margin = new Padding(3, 2, 3, 2);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(150, 29);
            comboBoxMonth.TabIndex = 39;
            // 
            // textBoxYear
            // 
            textBoxYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYear.Location = new Point(284, 365);
            textBoxYear.Margin = new Padding(3, 2, 3, 2);
            textBoxYear.MaxLength = 4;
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(69, 29);
            textBoxYear.TabIndex = 40;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(74, 396);
            label13.Name = "label13";
            label13.Size = new Size(28, 13);
            label13.TabIndex = 41;
            label13.Text = "DAY";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(180, 396);
            label14.Name = "label14";
            label14.Size = new Size(47, 13);
            label14.TabIndex = 42;
            label14.Text = "MONTH";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(298, 396);
            label15.Name = "label15";
            label15.Size = new Size(33, 13);
            label15.TabIndex = 43;
            label15.Text = "YEAR";
            // 
            // ControlCreateId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(textBoxYear);
            Controls.Add(comboBoxMonth);
            Controls.Add(comboBoxDay);
            Controls.Add(comboBoxCameras);
            Controls.Add(buttonClearSign);
            Controls.Add(pictureBoxSignature);
            Controls.Add(buttonSignature);
            Controls.Add(buttonClearPhoto);
            Controls.Add(buttonCamera);
            Controls.Add(label12);
            Controls.Add(comboBoxBarangay);
            Controls.Add(label11);
            Controls.Add(comboBoxCity);
            Controls.Add(label10);
            Controls.Add(comboBoxProvince);
            Controls.Add(comboBoxMaritalStatus);
            Controls.Add(comboBoxBloodType);
            Controls.Add(buttonClearAll);
            Controls.Add(buttonCreate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(buttonBrowse);
            Controls.Add(pictureBoxIdPhoto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxSex);
            Controls.Add(label5);
            Controls.Add(textBoxSuffix);
            Controls.Add(label4);
            Controls.Add(textBoxMiddleName);
            Controls.Add(label3);
            Controls.Add(textBoxGivenName);
            Controls.Add(label2);
            Controls.Add(textBoxLastName);
            Controls.Add(label1);
            Name = "ControlCreateId";
            Size = new Size(1116, 633);
            Enter += ControlCreateId_Enter;
            Leave += ControlCreateId_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIdPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSignature).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxLastName;
        private TextBox textBoxGivenName;
        private Label label2;
        private TextBox textBoxMiddleName;
        private Label label3;
        private TextBox textBoxSuffix;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxSex;
        private Label label6;
        private Label label7;
        public PictureBox pictureBoxIdPhoto;
        private Button buttonBrowse;
        private Label label8;
        private Label label9;
        private Button buttonCreate;
        private Button buttonClearAll;
        private ComboBox comboBoxBloodType;
        private ComboBox comboBoxMaritalStatus;
        private ComboBox comboBoxProvince;
        private Label label10;
        private ComboBox comboBoxCity;
        private Label label11;
        private ComboBox comboBoxBarangay;
        private Label label12;
        private Button buttonCamera;
        private Button buttonClearPhoto;
        private Button buttonSignature;
        public PictureBox pictureBoxSignature;
        private Button buttonClearSign;
        public ComboBox comboBoxCameras;
        private ComboBox comboBoxDay;
        private ComboBox comboBoxMonth;
        private TextBox textBoxYear;
        private Label label13;
        private Label label14;
        private Label label15;
        private System.Windows.Forms.Timer timer1;
    }
}
