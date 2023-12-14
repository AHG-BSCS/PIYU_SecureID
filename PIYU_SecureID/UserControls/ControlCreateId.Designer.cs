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
            lblLastName = new Label();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            lblFirstName = new Label();
            txtBoxMiddleName = new TextBox();
            lblMiddleName = new Label();
            txtBoxSuffix = new TextBox();
            lblSuffix = new Label();
            lblSex = new Label();
            cmbBoxSex = new ComboBox();
            lblDateOfBirth = new Label();
            lblAddress = new Label();
            lblBloodType = new Label();
            lblMaritalStatus = new Label();
            cmbBoxBloodType = new ComboBox();
            cmbBoxMaritalStatus = new ComboBox();
            cmbBoxProvince = new ComboBox();
            lblProvince = new Label();
            cmbBoxCity = new ComboBox();
            lblCity = new Label();
            cmbBoxBarangay = new ComboBox();
            lblBarangay = new Label();
            btnSignature = new Button();
            picBoxSignature = new PictureBox();
            btnClearSign = new Button();
            cmbBoxDay = new ComboBox();
            cmbBoxMonth = new ComboBox();
            textBoxYear = new TextBox();
            lblDay = new Label();
            lblMonth = new Label();
            lblYear = new Label();
            pnlInfoForm = new Panel();
            lblFormTitle = new Label();
            cmbBoxYears = new ComboBox();
            pnlSeparator = new Panel();
            tblPnlProof = new TableLayoutPanel();
            pnlPictureProof = new Panel();
            lblPicture = new Label();
            picBoxPicture = new PictureBox();
            btnCamera = new Button();
            btnBrowse = new Button();
            btnClear = new Button();
            cmbBoxCameraList = new ComboBox();
            pnlSignatureProof = new Panel();
            lblSignature = new Label();
            btnCreateId = new Button();
            btnClearForm = new Button();
            pnlControls = new Panel();
            ((System.ComponentModel.ISupportInitialize)picBoxSignature).BeginInit();
            pnlInfoForm.SuspendLayout();
            tblPnlProof.SuspendLayout();
            pnlPictureProof.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxPicture).BeginInit();
            pnlSignatureProof.SuspendLayout();
            pnlControls.SuspendLayout();
            SuspendLayout();
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(23, 57);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 21);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            lblLastName.Click += ControlCreateId_Click;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.CharacterCasing = CharacterCasing.Upper;
            txtBoxLastName.Cursor = Cursors.IBeam;
            txtBoxLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.Location = new Point(23, 81);
            txtBoxLastName.MaxLength = 64;
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.PlaceholderText = "Required";
            txtBoxLastName.Size = new Size(404, 27);
            txtBoxLastName.TabIndex = 1;
            txtBoxLastName.KeyPress += textBoxLastName_KeyPress;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.CharacterCasing = CharacterCasing.Upper;
            txtBoxFirstName.Cursor = Cursors.IBeam;
            txtBoxFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.Location = new Point(23, 137);
            txtBoxFirstName.MaxLength = 64;
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.PlaceholderText = "Required";
            txtBoxFirstName.Size = new Size(265, 27);
            txtBoxFirstName.TabIndex = 2;
            txtBoxFirstName.KeyPress += textBoxLastName_KeyPress;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(23, 113);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(88, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            lblFirstName.Click += ControlCreateId_Click;
            // 
            // txtBoxMiddleName
            // 
            txtBoxMiddleName.CharacterCasing = CharacterCasing.Upper;
            txtBoxMiddleName.Cursor = Cursors.IBeam;
            txtBoxMiddleName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxMiddleName.Location = new Point(23, 193);
            txtBoxMiddleName.MaxLength = 64;
            txtBoxMiddleName.Name = "txtBoxMiddleName";
            txtBoxMiddleName.PlaceholderText = "Optional";
            txtBoxMiddleName.Size = new Size(404, 27);
            txtBoxMiddleName.TabIndex = 4;
            txtBoxMiddleName.KeyPress += textBoxLastName_KeyPress;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleName.Location = new Point(23, 169);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(109, 21);
            lblMiddleName.TabIndex = 0;
            lblMiddleName.Text = "Middle Name";
            lblMiddleName.Click += ControlCreateId_Click;
            // 
            // txtBoxSuffix
            // 
            txtBoxSuffix.CharacterCasing = CharacterCasing.Upper;
            txtBoxSuffix.Cursor = Cursors.IBeam;
            txtBoxSuffix.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSuffix.Location = new Point(318, 137);
            txtBoxSuffix.MaxLength = 32;
            txtBoxSuffix.Name = "txtBoxSuffix";
            txtBoxSuffix.PlaceholderText = "Optional";
            txtBoxSuffix.Size = new Size(109, 27);
            txtBoxSuffix.TabIndex = 3;
            txtBoxSuffix.KeyPress += textBoxLastName_KeyPress;
            // 
            // lblSuffix
            // 
            lblSuffix.AutoSize = true;
            lblSuffix.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuffix.Location = new Point(318, 113);
            lblSuffix.Name = "lblSuffix";
            lblSuffix.Size = new Size(52, 21);
            lblSuffix.TabIndex = 0;
            lblSuffix.Text = "Suffix";
            lblSuffix.Click += ControlCreateId_Click;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSex.Location = new Point(23, 249);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(36, 21);
            lblSex.TabIndex = 0;
            lblSex.Text = "Sex";
            lblSex.Click += ControlCreateId_Click;
            // 
            // cmbBoxSex
            // 
            cmbBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSex.FlatStyle = FlatStyle.Flat;
            cmbBoxSex.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxSex.FormattingEnabled = true;
            cmbBoxSex.Items.AddRange(new object[] { "MALE", "FEMALE" });
            cmbBoxSex.Location = new Point(23, 273);
            cmbBoxSex.Name = "cmbBoxSex";
            cmbBoxSex.Size = new Size(100, 28);
            cmbBoxSex.TabIndex = 5;
            cmbBoxSex.DropDownClosed += comboBoxSex_DropDownClosed;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(23, 329);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(103, 21);
            lblDateOfBirth.TabIndex = 0;
            lblDateOfBirth.Text = "Date of Birth";
            lblDateOfBirth.Click += ControlCreateId_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(23, 422);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address";
            lblAddress.Click += ControlCreateId_Click;
            // 
            // lblBloodType
            // 
            lblBloodType.AutoSize = true;
            lblBloodType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBloodType.Location = new Point(147, 249);
            lblBloodType.Name = "lblBloodType";
            lblBloodType.Size = new Size(93, 21);
            lblBloodType.TabIndex = 0;
            lblBloodType.Text = "Blood Type";
            lblBloodType.Click += ControlCreateId_Click;
            // 
            // lblMaritalStatus
            // 
            lblMaritalStatus.AutoSize = true;
            lblMaritalStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaritalStatus.Location = new Point(264, 249);
            lblMaritalStatus.Name = "lblMaritalStatus";
            lblMaritalStatus.Size = new Size(110, 21);
            lblMaritalStatus.TabIndex = 0;
            lblMaritalStatus.Text = "Marital Status";
            lblMaritalStatus.Click += ControlCreateId_Click;
            // 
            // cmbBoxBloodType
            // 
            cmbBoxBloodType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxBloodType.FlatStyle = FlatStyle.Flat;
            cmbBoxBloodType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxBloodType.FormattingEnabled = true;
            cmbBoxBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBoxBloodType.Location = new Point(147, 272);
            cmbBoxBloodType.Margin = new Padding(3, 2, 3, 2);
            cmbBoxBloodType.Name = "cmbBoxBloodType";
            cmbBoxBloodType.Size = new Size(93, 28);
            cmbBoxBloodType.TabIndex = 6;
            cmbBoxBloodType.DropDownClosed += comboBoxSex_DropDownClosed;
            // 
            // cmbBoxMaritalStatus
            // 
            cmbBoxMaritalStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxMaritalStatus.FlatStyle = FlatStyle.Flat;
            cmbBoxMaritalStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxMaritalStatus.FormattingEnabled = true;
            cmbBoxMaritalStatus.Items.AddRange(new object[] { "SINGLE", "MARRIED", "ANNULLED", "SEPARATED", "WIDOWED" });
            cmbBoxMaritalStatus.Location = new Point(264, 272);
            cmbBoxMaritalStatus.Margin = new Padding(3, 2, 3, 2);
            cmbBoxMaritalStatus.Name = "cmbBoxMaritalStatus";
            cmbBoxMaritalStatus.Size = new Size(134, 28);
            cmbBoxMaritalStatus.TabIndex = 7;
            cmbBoxMaritalStatus.DropDownClosed += comboBoxSex_DropDownClosed;
            // 
            // cmbBoxProvince
            // 
            cmbBoxProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxProvince.FlatStyle = FlatStyle.Flat;
            cmbBoxProvince.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxProvince.Location = new Point(23, 445);
            cmbBoxProvince.Margin = new Padding(3, 2, 3, 2);
            cmbBoxProvince.Name = "cmbBoxProvince";
            cmbBoxProvince.Size = new Size(280, 28);
            cmbBoxProvince.Sorted = true;
            cmbBoxProvince.TabIndex = 11;
            cmbBoxProvince.SelectedIndexChanged += comboBoxProvince_SelectedIndexChanged;
            cmbBoxProvince.DropDownClosed += comboBoxSex_DropDownClosed;
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblProvince.Location = new Point(128, 482);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(61, 13);
            lblProvince.TabIndex = 0;
            lblProvince.Text = "PROVINCE";
            lblProvince.Click += ControlCreateId_Click;
            // 
            // cmbBoxCity
            // 
            cmbBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCity.FlatStyle = FlatStyle.Flat;
            cmbBoxCity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxCity.Location = new Point(23, 503);
            cmbBoxCity.Margin = new Padding(3, 2, 3, 2);
            cmbBoxCity.Name = "cmbBoxCity";
            cmbBoxCity.Size = new Size(280, 28);
            cmbBoxCity.Sorted = true;
            cmbBoxCity.TabIndex = 12;
            cmbBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            cmbBoxCity.DropDownClosed += comboBoxSex_DropDownClosed;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCity.Location = new Point(144, 540);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(29, 13);
            lblCity.TabIndex = 0;
            lblCity.Text = "CITY";
            lblCity.Click += ControlCreateId_Click;
            // 
            // cmbBoxBarangay
            // 
            cmbBoxBarangay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxBarangay.FlatStyle = FlatStyle.Flat;
            cmbBoxBarangay.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxBarangay.Location = new Point(23, 561);
            cmbBoxBarangay.Margin = new Padding(3, 2, 3, 2);
            cmbBoxBarangay.Name = "cmbBoxBarangay";
            cmbBoxBarangay.Size = new Size(280, 28);
            cmbBoxBarangay.Sorted = true;
            cmbBoxBarangay.TabIndex = 13;
            cmbBoxBarangay.DropDownClosed += comboBoxSex_DropDownClosed;
            // 
            // lblBarangay
            // 
            lblBarangay.AutoSize = true;
            lblBarangay.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBarangay.Location = new Point(126, 598);
            lblBarangay.Name = "lblBarangay";
            lblBarangay.Size = new Size(65, 13);
            lblBarangay.TabIndex = 0;
            lblBarangay.Text = "BARANGAY";
            lblBarangay.Click += ControlCreateId_Click;
            // 
            // btnSignature
            // 
            btnSignature.Anchor = AnchorStyles.None;
            btnSignature.BackColor = Color.White;
            btnSignature.FlatAppearance.BorderSize = 0;
            btnSignature.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignature.ForeColor = Color.FromArgb(53, 69, 93);
            btnSignature.Location = new Point(103, 359);
            btnSignature.Name = "btnSignature";
            btnSignature.Size = new Size(90, 35);
            btnSignature.TabIndex = 14;
            btnSignature.Text = "SIGNATURE";
            btnSignature.UseVisualStyleBackColor = false;
            btnSignature.Click += buttonSignature_Click;
            // 
            // picBoxSignature
            // 
            picBoxSignature.Anchor = AnchorStyles.None;
            picBoxSignature.BackColor = Color.White;
            picBoxSignature.BorderStyle = BorderStyle.FixedSingle;
            picBoxSignature.Location = new Point(46, 43);
            picBoxSignature.Name = "picBoxSignature";
            picBoxSignature.Size = new Size(300, 300);
            picBoxSignature.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxSignature.TabIndex = 33;
            picBoxSignature.TabStop = false;
            picBoxSignature.Click += ControlCreateId_Click;
            // 
            // btnClearSign
            // 
            btnClearSign.Anchor = AnchorStyles.None;
            btnClearSign.BackColor = Color.White;
            btnClearSign.FlatAppearance.BorderSize = 0;
            btnClearSign.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearSign.ForeColor = Color.DarkRed;
            btnClearSign.Location = new Point(199, 359);
            btnClearSign.Name = "btnClearSign";
            btnClearSign.Size = new Size(90, 35);
            btnClearSign.TabIndex = 15;
            btnClearSign.Text = "CLEAR";
            btnClearSign.UseVisualStyleBackColor = false;
            btnClearSign.Click += buttonClearSign_Click;
            // 
            // cmbBoxDay
            // 
            cmbBoxDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxDay.FlatStyle = FlatStyle.Flat;
            cmbBoxDay.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxDay.FormattingEnabled = true;
            cmbBoxDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cmbBoxDay.Location = new Point(23, 354);
            cmbBoxDay.Margin = new Padding(3, 2, 3, 2);
            cmbBoxDay.Name = "cmbBoxDay";
            cmbBoxDay.Size = new Size(65, 28);
            cmbBoxDay.TabIndex = 8;
            cmbBoxDay.DropDownClosed += comboBoxSex_DropDownClosed;
            // 
            // cmbBoxMonth
            // 
            cmbBoxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxMonth.FlatStyle = FlatStyle.Flat;
            cmbBoxMonth.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxMonth.FormattingEnabled = true;
            cmbBoxMonth.Items.AddRange(new object[] { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" });
            cmbBoxMonth.Location = new Point(112, 352);
            cmbBoxMonth.Margin = new Padding(3, 2, 3, 2);
            cmbBoxMonth.Name = "cmbBoxMonth";
            cmbBoxMonth.Size = new Size(128, 28);
            cmbBoxMonth.TabIndex = 9;
            cmbBoxMonth.DropDownClosed += comboBoxSex_DropDownClosed;
            // 
            // textBoxYear
            // 
            textBoxYear.Cursor = Cursors.IBeam;
            textBoxYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYear.Location = new Point(264, 319);
            textBoxYear.Margin = new Padding(3, 2, 3, 2);
            textBoxYear.MaxLength = 4;
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(78, 29);
            textBoxYear.TabIndex = 10;
            textBoxYear.TextChanged += textBoxYear_TextChanged;
            textBoxYear.KeyPress += textBoxYear_KeyPress;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDay.Location = new Point(36, 391);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(28, 13);
            lblDay.TabIndex = 0;
            lblDay.Text = "DAY";
            lblDay.Click += ControlCreateId_Click;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMonth.Location = new Point(148, 389);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(47, 13);
            lblMonth.TabIndex = 0;
            lblMonth.Text = "MONTH";
            lblMonth.Click += ControlCreateId_Click;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblYear.Location = new Point(282, 389);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(33, 13);
            lblYear.TabIndex = 0;
            lblYear.Text = "YEAR";
            lblYear.Click += ControlCreateId_Click;
            // 
            // pnlInfoForm
            // 
            pnlInfoForm.AutoScroll = true;
            pnlInfoForm.BackColor = SystemColors.Control;
            pnlInfoForm.Controls.Add(lblFormTitle);
            pnlInfoForm.Controls.Add(lblLastName);
            pnlInfoForm.Controls.Add(txtBoxLastName);
            pnlInfoForm.Controls.Add(lblFirstName);
            pnlInfoForm.Controls.Add(txtBoxFirstName);
            pnlInfoForm.Controls.Add(lblSuffix);
            pnlInfoForm.Controls.Add(txtBoxSuffix);
            pnlInfoForm.Controls.Add(lblMiddleName);
            pnlInfoForm.Controls.Add(txtBoxMiddleName);
            pnlInfoForm.Controls.Add(lblSex);
            pnlInfoForm.Controls.Add(cmbBoxSex);
            pnlInfoForm.Controls.Add(lblBloodType);
            pnlInfoForm.Controls.Add(cmbBoxBloodType);
            pnlInfoForm.Controls.Add(lblMaritalStatus);
            pnlInfoForm.Controls.Add(cmbBoxMaritalStatus);
            pnlInfoForm.Controls.Add(lblDateOfBirth);
            pnlInfoForm.Controls.Add(cmbBoxDay);
            pnlInfoForm.Controls.Add(lblDay);
            pnlInfoForm.Controls.Add(cmbBoxMonth);
            pnlInfoForm.Controls.Add(lblMonth);
            pnlInfoForm.Controls.Add(textBoxYear);
            pnlInfoForm.Controls.Add(cmbBoxYears);
            pnlInfoForm.Controls.Add(lblYear);
            pnlInfoForm.Controls.Add(lblAddress);
            pnlInfoForm.Controls.Add(cmbBoxProvince);
            pnlInfoForm.Controls.Add(lblProvince);
            pnlInfoForm.Controls.Add(cmbBoxCity);
            pnlInfoForm.Controls.Add(lblCity);
            pnlInfoForm.Controls.Add(cmbBoxBarangay);
            pnlInfoForm.Controls.Add(lblBarangay);
            pnlInfoForm.Dock = DockStyle.Left;
            pnlInfoForm.Location = new Point(0, 0);
            pnlInfoForm.Name = "pnlInfoForm";
            pnlInfoForm.Padding = new Padding(20);
            pnlInfoForm.Size = new Size(453, 637);
            pnlInfoForm.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.Location = new Point(98, 20);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(257, 21);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "PERSONAL INFORMATION FORM";
            // 
            // cmbBoxYears
            // 
            cmbBoxYears.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxYears.FlatStyle = FlatStyle.Flat;
            cmbBoxYears.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxYears.FormattingEnabled = true;
            cmbBoxYears.Items.AddRange(new object[] { "1901", "", "1902", "", "1903", "", "1904", "", "1905", "", "1906", "", "1907", "", "1908", "", "1909", "", "1910", "", "1911", "", "1912", "", "1913", "", "1914", "", "1915", "", "1916", "", "1917", "", "1918", "", "1919", "", "1920", "", "1921", "", "1922", "", "1923", "", "1924", "", "1925", "", "1926", "", "1927", "", "1928", "", "1929", "", "1930", "", "1931", "", "1932", "", "1933", "", "1934", "", "1935", "", "1936", "", "1937", "", "1938", "", "1939", "", "1940", "", "1941", "", "1942", "", "1943", "", "1944", "", "1945", "", "1946", "", "1947", "", "1948", "", "1949", "", "1950", "", "1951", "", "1952", "", "1953", "", "1954", "", "1955", "", "1956", "", "1957", "", "1958", "", "1959", "", "1960", "", "1961", "", "1962", "", "1963", "", "1964", "", "1965", "", "1966", "", "1967", "", "1968", "", "1969", "", "1970", "", "1971", "", "1972", "", "1973", "", "1974", "", "1975", "", "1976", "", "1977", "", "1978", "", "1979", "", "1980", "", "1981", "", "1982", "", "1983", "", "1984", "", "1985", "", "1986", "", "1987", "", "1988", "", "1989", "", "1990", "", "1991", "", "1992", "", "1993", "", "1994", "", "1995", "", "1996", "", "1997", "", "1998", "", "1999", "", "2000", "", "2001", "", "2002", "", "2003", "", "2004", "", "2005", "", "2006", "", "2007", "", "2008", "", "2009", "", "2010", "", "2011", "", "2012", "", "2013", "", "2014", "", "2015", "", "2016", "", "2017", "", "2018", "", "2019", "", "2020", "", "2021", "", "2022", "", "2023", "", "2024" });
            cmbBoxYears.Location = new Point(264, 352);
            cmbBoxYears.Margin = new Padding(3, 2, 3, 2);
            cmbBoxYears.Name = "cmbBoxYears";
            cmbBoxYears.Size = new Size(78, 28);
            cmbBoxYears.TabIndex = 10;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.FromArgb(53, 69, 93);
            pnlSeparator.Dock = DockStyle.Left;
            pnlSeparator.Location = new Point(453, 0);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(5, 637);
            pnlSeparator.TabIndex = 0;
            // 
            // tblPnlProof
            // 
            tblPnlProof.ColumnCount = 3;
            tblPnlProof.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnlProof.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tblPnlProof.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnlProof.Controls.Add(pnlPictureProof, 2, 0);
            tblPnlProof.Controls.Add(pnlSignatureProof, 0, 0);
            tblPnlProof.Dock = DockStyle.Top;
            tblPnlProof.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblPnlProof.Location = new Point(458, 0);
            tblPnlProof.Name = "tblPnlProof";
            tblPnlProof.RowCount = 1;
            tblPnlProof.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlProof.Size = new Size(798, 453);
            tblPnlProof.TabIndex = 48;
            // 
            // pnlPictureProof
            // 
            pnlPictureProof.BackColor = Color.FromArgb(53, 69, 93);
            pnlPictureProof.Controls.Add(lblPicture);
            pnlPictureProof.Controls.Add(picBoxPicture);
            pnlPictureProof.Controls.Add(btnCamera);
            pnlPictureProof.Controls.Add(btnBrowse);
            pnlPictureProof.Controls.Add(btnClear);
            pnlPictureProof.Controls.Add(cmbBoxCameraList);
            pnlPictureProof.Dock = DockStyle.Fill;
            pnlPictureProof.Location = new Point(402, 3);
            pnlPictureProof.Name = "pnlPictureProof";
            pnlPictureProof.Padding = new Padding(20);
            pnlPictureProof.Size = new Size(393, 447);
            pnlPictureProof.TabIndex = 0;
            // 
            // lblPicture
            // 
            lblPicture.Anchor = AnchorStyles.None;
            lblPicture.AutoSize = true;
            lblPicture.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPicture.ForeColor = Color.White;
            lblPicture.Location = new Point(152, 10);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(89, 25);
            lblPicture.TabIndex = 0;
            lblPicture.Text = "PICTURE";
            // 
            // picBoxPicture
            // 
            picBoxPicture.Anchor = AnchorStyles.None;
            picBoxPicture.BackColor = Color.White;
            picBoxPicture.BorderStyle = BorderStyle.FixedSingle;
            picBoxPicture.Location = new Point(46, 43);
            picBoxPicture.Name = "picBoxPicture";
            picBoxPicture.Size = new Size(300, 300);
            picBoxPicture.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxPicture.TabIndex = 14;
            picBoxPicture.TabStop = false;
            picBoxPicture.Click += ControlCreateId_Click;
            // 
            // btnCamera
            // 
            btnCamera.Anchor = AnchorStyles.None;
            btnCamera.BackColor = Color.White;
            btnCamera.FlatAppearance.BorderSize = 0;
            btnCamera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCamera.ForeColor = Color.FromArgb(53, 69, 93);
            btnCamera.Location = new Point(70, 359);
            btnCamera.Name = "btnCamera";
            btnCamera.Size = new Size(80, 35);
            btnCamera.TabIndex = 17;
            btnCamera.Text = "CAMERA";
            btnCamera.UseVisualStyleBackColor = false;
            btnCamera.Click += buttonCamera_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.None;
            btnBrowse.BackColor = Color.White;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.FromArgb(53, 69, 93);
            btnBrowse.Location = new Point(156, 359);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(80, 35);
            btnBrowse.TabIndex = 18;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += buttonBrowse_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.DarkRed;
            btnClear.Location = new Point(242, 359);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 35);
            btnClear.TabIndex = 19;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += buttonClearPhoto_Click;
            // 
            // cmbBoxCameraList
            // 
            cmbBoxCameraList.Anchor = AnchorStyles.None;
            cmbBoxCameraList.BackColor = Color.White;
            cmbBoxCameraList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCameraList.FlatStyle = FlatStyle.Flat;
            cmbBoxCameraList.FormattingEnabled = true;
            cmbBoxCameraList.Location = new Point(70, 402);
            cmbBoxCameraList.Name = "cmbBoxCameraList";
            cmbBoxCameraList.Size = new Size(105, 23);
            cmbBoxCameraList.TabIndex = 16;
            cmbBoxCameraList.DropDownClosed += comboBoxSex_DropDownClosed;
            // 
            // pnlSignatureProof
            // 
            pnlSignatureProof.BackColor = Color.FromArgb(53, 69, 93);
            pnlSignatureProof.Controls.Add(lblSignature);
            pnlSignatureProof.Controls.Add(picBoxSignature);
            pnlSignatureProof.Controls.Add(btnSignature);
            pnlSignatureProof.Controls.Add(btnClearSign);
            pnlSignatureProof.Dock = DockStyle.Fill;
            pnlSignatureProof.Location = new Point(3, 3);
            pnlSignatureProof.Name = "pnlSignatureProof";
            pnlSignatureProof.Padding = new Padding(20);
            pnlSignatureProof.Size = new Size(393, 447);
            pnlSignatureProof.TabIndex = 0;
            // 
            // lblSignature
            // 
            lblSignature.Anchor = AnchorStyles.None;
            lblSignature.AutoSize = true;
            lblSignature.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignature.ForeColor = Color.White;
            lblSignature.Location = new Point(138, 10);
            lblSignature.Name = "lblSignature";
            lblSignature.Size = new Size(117, 25);
            lblSignature.TabIndex = 0;
            lblSignature.Text = "SIGNATURE";
            // 
            // btnCreateId
            // 
            btnCreateId.Anchor = AnchorStyles.Top;
            btnCreateId.BackColor = Color.FromArgb(29, 146, 61);
            btnCreateId.FlatAppearance.BorderSize = 0;
            btnCreateId.FlatStyle = FlatStyle.Flat;
            btnCreateId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateId.ForeColor = Color.White;
            btnCreateId.Location = new Point(403, 30);
            btnCreateId.Name = "btnCreateId";
            btnCreateId.Size = new Size(120, 40);
            btnCreateId.TabIndex = 21;
            btnCreateId.Text = "CREATE ID";
            btnCreateId.UseVisualStyleBackColor = false;
            btnCreateId.Click += buttonCreate_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.Anchor = AnchorStyles.Top;
            btnClearForm.BackColor = Color.DarkRed;
            btnClearForm.FlatAppearance.BorderSize = 0;
            btnClearForm.FlatStyle = FlatStyle.Flat;
            btnClearForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearForm.ForeColor = Color.White;
            btnClearForm.Location = new Point(275, 30);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(120, 40);
            btnClearForm.TabIndex = 20;
            btnClearForm.Text = "CLEAR FORM";
            btnClearForm.UseVisualStyleBackColor = false;
            btnClearForm.Click += buttonClearAll_Click;
            // 
            // pnlControls
            // 
            pnlControls.Controls.Add(btnClearForm);
            pnlControls.Controls.Add(btnCreateId);
            pnlControls.Dock = DockStyle.Top;
            pnlControls.Location = new Point(458, 453);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(798, 100);
            pnlControls.TabIndex = 0;
            // 
            // ControlCreateId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(pnlControls);
            Controls.Add(tblPnlProof);
            Controls.Add(pnlSeparator);
            Controls.Add(pnlInfoForm);
            Name = "ControlCreateId";
            Size = new Size(1256, 637);
            Click += ControlCreateId_Click;
            ((System.ComponentModel.ISupportInitialize)picBoxSignature).EndInit();
            pnlInfoForm.ResumeLayout(false);
            pnlInfoForm.PerformLayout();
            tblPnlProof.ResumeLayout(false);
            pnlPictureProof.ResumeLayout(false);
            pnlPictureProof.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxPicture).EndInit();
            pnlSignatureProof.ResumeLayout(false);
            pnlSignatureProof.PerformLayout();
            pnlControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblLastName;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private Label lblFirstName;
        private TextBox txtBoxMiddleName;
        private Label lblMiddleName;
        private TextBox txtBoxSuffix;
        private Label lblSuffix;
        private Label lblSex;
        private ComboBox cmbBoxSex;
        private Label lblDateOfBirth;
        private Label lblAddress;
        private Label lblBloodType;
        private Label lblMaritalStatus;
        private ComboBox cmbBoxBloodType;
        private ComboBox cmbBoxMaritalStatus;
        private ComboBox cmbBoxProvince;
        private Label lblProvince;
        private ComboBox cmbBoxCity;
        private Label lblCity;
        private ComboBox cmbBoxBarangay;
        private Label lblBarangay;
        private Button btnSignature;
        public PictureBox picBoxSignature;
        private Button btnClearSign;
        private ComboBox cmbBoxDay;
        private ComboBox cmbBoxMonth;
        private TextBox textBoxYear;
        private Label lblDay;
        private Label lblMonth;
        private Label lblYear;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlInfoForm;
        private Panel pnlSeparator;
        private Label lblFormTitle;
        private ComboBox cmbBoxYears;
        private TableLayoutPanel tblPnlProof;
        private Panel pnlSignatureProof;
        private Panel pnlPictureProof;
        private Button btnCamera;
        public PictureBox picBoxPicture;
        private Button btnClear;
        public ComboBox cmbBoxCameraList;
        private Button btnBrowse;
        private Button btnCreateId;
        private Button btnClearForm;
        private Panel pnlControls;
        private Label lblPicture;
        private Label lblSignature;
    }
}
