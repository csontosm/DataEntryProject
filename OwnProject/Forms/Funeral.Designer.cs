namespace OwnProject
{
    partial class Funeral
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
            this.btnVisszaBejelento = new System.Windows.Forms.Button();
            this.btnBefejezesVisszaFomenu = new System.Windows.Forms.Button();
            this.lblFuneralMethod = new System.Windows.Forms.Label();
            this.cmbFuneralMethod = new System.Windows.Forms.ComboBox();
            this.lblFuneralDate = new System.Windows.Forms.Label();
            this.lblFuneralType = new System.Windows.Forms.Label();
            this.cmbFuneralType = new System.Windows.Forms.ComboBox();
            this.lblFuneralCatafalque = new System.Windows.Forms.Label();
            this.cmbFuneralCatafalque = new System.Windows.Forms.ComboBox();
            this.lblFuneralCoffinOrUrnType = new System.Windows.Forms.Label();
            this.cbKoporsoTipus = new System.Windows.Forms.ComboBox();
            this.lblFuneralCaissionType = new System.Windows.Forms.Label();
            this.cmbFuneralCrypt = new System.Windows.Forms.ComboBox();
            this.cmbFuneralCaissionType = new System.Windows.Forms.ComboBox();
            this.cmbFuneralCoffinOrUrnType = new System.Windows.Forms.ComboBox();
            this.lblClientReach = new System.Windows.Forms.Label();
            this.cmbClientReach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFuneralIsIDCardTaken = new System.Windows.Forms.CheckBox();
            this.cbFuneralIsAddressCardTaken = new System.Windows.Forms.CheckBox();
            this.cbFuneralIsDeathCertificateTaken = new System.Windows.Forms.CheckBox();
            this.cbFuneralIsBirthCertificateTaken = new System.Windows.Forms.CheckBox();
            this.cbFuneralIsMarriageCertificateTaken = new System.Windows.Forms.CheckBox();
            this.cbFuneralIsSpouseDeathCertificateTaken = new System.Windows.Forms.CheckBox();
            this.cbFuneralIsIDCardNeededByClient = new System.Windows.Forms.CheckBox();
            this.cmbFuneralGarveDigging = new System.Windows.Forms.ComboBox();
            this.lblFuneralGarveDigging = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblMusic = new System.Windows.Forms.Label();
            this.tbMusic = new System.Windows.Forms.TextBox();
            this.cbFuneralUrnCloth = new System.Windows.Forms.CheckBox();
            this.lblFuneralUrnCloth = new System.Windows.Forms.Label();
            this.cmbFuneralGraveMarker = new System.Windows.Forms.ComboBox();
            this.lblFuneralGraveMarker = new System.Windows.Forms.Label();
            this.tbFuneralDateYear = new System.Windows.Forms.TextBox();
            this.cmbFuneralDateDay = new System.Windows.Forms.ComboBox();
            this.cmbFuneralDateMonth = new System.Windows.Forms.ComboBox();
            this.lblFuneralGrave = new System.Windows.Forms.Label();
            this.tbFuneralGrave = new System.Windows.Forms.TextBox();
            this.cbTemetesHelye = new System.Windows.Forms.ComboBox();
            this.lblTemetesHelye = new System.Windows.Forms.Label();
            this.cmbGraveOrCrypt = new System.Windows.Forms.ComboBox();
            this.lblGraveOrCrypt = new System.Windows.Forms.Label();
            this.cmbFuneralDateHour = new System.Windows.Forms.ComboBox();
            this.cmbFuneralDateMinute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVisszaBejelento
            // 
            this.btnVisszaBejelento.Location = new System.Drawing.Point(19, 461);
            this.btnVisszaBejelento.Name = "btnVisszaBejelento";
            this.btnVisszaBejelento.Size = new System.Drawing.Size(75, 23);
            this.btnVisszaBejelento.TabIndex = 41;
            this.btnVisszaBejelento.Text = "Vissza";
            this.btnVisszaBejelento.UseVisualStyleBackColor = true;
            this.btnVisszaBejelento.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBefejezesVisszaFomenu
            // 
            this.btnBefejezesVisszaFomenu.Location = new System.Drawing.Point(594, 461);
            this.btnBefejezesVisszaFomenu.Name = "btnBefejezesVisszaFomenu";
            this.btnBefejezesVisszaFomenu.Size = new System.Drawing.Size(109, 23);
            this.btnBefejezesVisszaFomenu.TabIndex = 42;
            this.btnBefejezesVisszaFomenu.Text = "Tovább: Nyomtatás";
            this.btnBefejezesVisszaFomenu.UseVisualStyleBackColor = true;
            this.btnBefejezesVisszaFomenu.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblFuneralMethod
            // 
            this.lblFuneralMethod.AutoSize = true;
            this.lblFuneralMethod.Location = new System.Drawing.Point(23, 234);
            this.lblFuneralMethod.Name = "lblFuneralMethod";
            this.lblFuneralMethod.Size = new System.Drawing.Size(79, 13);
            this.lblFuneralMethod.TabIndex = 44;
            this.lblFuneralMethod.Text = "Temetés módja";
            // 
            // cmbFuneralMethod
            // 
            this.cmbFuneralMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralMethod.FormattingEnabled = true;
            this.cmbFuneralMethod.Items.AddRange(new object[] {
            "Urnaelvitel",
            "Koporsós",
            "Urnás"});
            this.cmbFuneralMethod.Location = new System.Drawing.Point(141, 226);
            this.cmbFuneralMethod.Name = "cmbFuneralMethod";
            this.cmbFuneralMethod.Size = new System.Drawing.Size(202, 28);
            this.cmbFuneralMethod.TabIndex = 43;
            this.cmbFuneralMethod.SelectedIndexChanged += new System.EventHandler(this.cmbFuneralMethod_SelectedIndexChanged);
            // 
            // lblFuneralDate
            // 
            this.lblFuneralDate.AutoSize = true;
            this.lblFuneralDate.Location = new System.Drawing.Point(22, 350);
            this.lblFuneralDate.Name = "lblFuneralDate";
            this.lblFuneralDate.Size = new System.Drawing.Size(94, 13);
            this.lblFuneralDate.TabIndex = 46;
            this.lblFuneralDate.Text = "Temetés időpontja";
            // 
            // lblFuneralType
            // 
            this.lblFuneralType.AutoSize = true;
            this.lblFuneralType.Location = new System.Drawing.Point(23, 270);
            this.lblFuneralType.Name = "lblFuneralType";
            this.lblFuneralType.Size = new System.Drawing.Size(79, 13);
            this.lblFuneralType.TabIndex = 59;
            this.lblFuneralType.Text = "Temetés tipusa";
            // 
            // cmbFuneralType
            // 
            this.cmbFuneralType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralType.Enabled = false;
            this.cmbFuneralType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralType.FormattingEnabled = true;
            this.cmbFuneralType.Items.AddRange(new object[] {
            "-",
            "Polgári",
            "Katolikus",
            "Református",
            "Evangélikus",
            "Görög katolikus",
            "Baptista",
            "Jehova",
            "Szombatista"});
            this.cmbFuneralType.Location = new System.Drawing.Point(141, 262);
            this.cmbFuneralType.Name = "cmbFuneralType";
            this.cmbFuneralType.Size = new System.Drawing.Size(202, 28);
            this.cmbFuneralType.TabIndex = 58;
            // 
            // lblFuneralCatafalque
            // 
            this.lblFuneralCatafalque.AutoSize = true;
            this.lblFuneralCatafalque.Location = new System.Drawing.Point(383, 120);
            this.lblFuneralCatafalque.Name = "lblFuneralCatafalque";
            this.lblFuneralCatafalque.Size = new System.Drawing.Size(61, 13);
            this.lblFuneralCatafalque.TabIndex = 61;
            this.lblFuneralCatafalque.Text = "Ravatalozó";
            // 
            // cmbFuneralCatafalque
            // 
            this.cmbFuneralCatafalque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralCatafalque.Enabled = false;
            this.cmbFuneralCatafalque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralCatafalque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralCatafalque.FormattingEnabled = true;
            this.cmbFuneralCatafalque.Location = new System.Drawing.Point(501, 112);
            this.cmbFuneralCatafalque.Name = "cmbFuneralCatafalque";
            this.cmbFuneralCatafalque.Size = new System.Drawing.Size(202, 28);
            this.cmbFuneralCatafalque.TabIndex = 60;
            // 
            // lblFuneralCoffinOrUrnType
            // 
            this.lblFuneralCoffinOrUrnType.AutoSize = true;
            this.lblFuneralCoffinOrUrnType.Location = new System.Drawing.Point(383, 191);
            this.lblFuneralCoffinOrUrnType.Name = "lblFuneralCoffinOrUrnType";
            this.lblFuneralCoffinOrUrnType.Size = new System.Drawing.Size(99, 13);
            this.lblFuneralCoffinOrUrnType.TabIndex = 63;
            this.lblFuneralCoffinOrUrnType.Text = "Koporsó/Urna tipus";
            // 
            // cbKoporsoTipus
            // 
            this.cbKoporsoTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKoporsoTipus.Enabled = false;
            this.cbKoporsoTipus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbKoporsoTipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKoporsoTipus.FormattingEnabled = true;
            this.cbKoporsoTipus.Items.AddRange(new object[] {
            "L6 Patina",
            "KTNy",
            "Fenyő hamu",
            "K-3",
            "K-4",
            "Torinó",
            "Mahagóni"});
            this.cbKoporsoTipus.Location = new System.Drawing.Point(501, 183);
            this.cbKoporsoTipus.Name = "cbKoporsoTipus";
            this.cbKoporsoTipus.Size = new System.Drawing.Size(202, 28);
            this.cbKoporsoTipus.TabIndex = 62;
            // 
            // lblFuneralCaissionType
            // 
            this.lblFuneralCaissionType.AutoSize = true;
            this.lblFuneralCaissionType.Location = new System.Drawing.Point(383, 273);
            this.lblFuneralCaissionType.Name = "lblFuneralCaissionType";
            this.lblFuneralCaissionType.Size = new System.Drawing.Size(92, 13);
            this.lblFuneralCaissionType.TabIndex = 65;
            this.lblFuneralCaissionType.Text = "Vakkripta/Keszon";
            // 
            // cmbFuneralCrypt
            // 
            this.cmbFuneralCrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralCrypt.Enabled = false;
            this.cmbFuneralCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralCrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralCrypt.FormattingEnabled = true;
            this.cmbFuneralCrypt.Items.AddRange(new object[] {
            "-",
            "Vakkripta"});
            this.cmbFuneralCrypt.Location = new System.Drawing.Point(501, 265);
            this.cmbFuneralCrypt.Name = "cmbFuneralCrypt";
            this.cmbFuneralCrypt.Size = new System.Drawing.Size(202, 28);
            this.cmbFuneralCrypt.TabIndex = 64;
            this.cmbFuneralCrypt.SelectedIndexChanged += new System.EventHandler(this.cmbFuneralCrypt_SelectedIndexChanged);
            // 
            // cmbFuneralCaissionType
            // 
            this.cmbFuneralCaissionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralCaissionType.Enabled = false;
            this.cmbFuneralCaissionType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralCaissionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralCaissionType.FormattingEnabled = true;
            this.cmbFuneralCaissionType.Items.AddRange(new object[] {
            "-",
            "1 személyes",
            "2 személyes",
            "4 személyes"});
            this.cmbFuneralCaissionType.Location = new System.Drawing.Point(501, 266);
            this.cmbFuneralCaissionType.Name = "cmbFuneralCaissionType";
            this.cmbFuneralCaissionType.Size = new System.Drawing.Size(202, 28);
            this.cmbFuneralCaissionType.TabIndex = 66;
            // 
            // cmbFuneralCoffinOrUrnType
            // 
            this.cmbFuneralCoffinOrUrnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralCoffinOrUrnType.Enabled = false;
            this.cmbFuneralCoffinOrUrnType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralCoffinOrUrnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralCoffinOrUrnType.FormattingEnabled = true;
            this.cmbFuneralCoffinOrUrnType.Items.AddRange(new object[] {
            "Matt keresztes",
            "Matt rózsa",
            "Matt kála",
            "Matt fiore",
            "Festett arany rózsás",
            "Festett arany keresztes",
            "Festett arany kálás",
            "Festett fiore galamb",
            "Festett liliom",
            "Antikolt fiore",
            "Antikolt kereszt",
            "Antikolt rózsa",
            "Antikolt kála",
            "Fa hatszög",
            "Fa iker kálás",
            "Kerámia iker",
            "Bordó fém",
            "Négyszög antikolt kála",
            "Ékszerdoboz",
            "Gránit kála",
            "Gránit rózsa",
            "Ónix téglalap",
            "Opál üveg fehér",
            "Opál üveg bordó",
            "Üveg amfóra"});
            this.cmbFuneralCoffinOrUrnType.Location = new System.Drawing.Point(501, 184);
            this.cmbFuneralCoffinOrUrnType.Name = "cmbFuneralCoffinOrUrnType";
            this.cmbFuneralCoffinOrUrnType.Size = new System.Drawing.Size(202, 28);
            this.cmbFuneralCoffinOrUrnType.TabIndex = 67;
            // 
            // lblClientReach
            // 
            this.lblClientReach.AutoSize = true;
            this.lblClientReach.Location = new System.Drawing.Point(383, 420);
            this.lblClientReach.Name = "lblClientReach";
            this.lblClientReach.Size = new System.Drawing.Size(63, 13);
            this.lblClientReach.TabIndex = 69;
            this.lblClientReach.Text = "Elérhetőség";
            // 
            // cmbClientReach
            // 
            this.cmbClientReach.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cmbClientReach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbClientReach.Location = new System.Drawing.Point(501, 409);
            this.cmbClientReach.Name = "cmbClientReach";
            this.cmbClientReach.Size = new System.Drawing.Size(202, 29);
            this.cmbClientReach.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Megrendelőtől átvett iratok:";
            // 
            // cbFuneralIsIDCardTaken
            // 
            this.cbFuneralIsIDCardTaken.AutoSize = true;
            this.cbFuneralIsIDCardTaken.Location = new System.Drawing.Point(59, 40);
            this.cbFuneralIsIDCardTaken.Name = "cbFuneralIsIDCardTaken";
            this.cbFuneralIsIDCardTaken.Size = new System.Drawing.Size(162, 17);
            this.cbFuneralIsIDCardTaken.TabIndex = 77;
            this.cbFuneralIsIDCardTaken.Text = "Elhunyt személyi igazolványa";
            this.cbFuneralIsIDCardTaken.UseVisualStyleBackColor = true;
            // 
            // cbFuneralIsAddressCardTaken
            // 
            this.cbFuneralIsAddressCardTaken.AutoSize = true;
            this.cbFuneralIsAddressCardTaken.Location = new System.Drawing.Point(59, 63);
            this.cbFuneralIsAddressCardTaken.Name = "cbFuneralIsAddressCardTaken";
            this.cbFuneralIsAddressCardTaken.Size = new System.Drawing.Size(131, 17);
            this.cbFuneralIsAddressCardTaken.TabIndex = 78;
            this.cbFuneralIsAddressCardTaken.Text = "Elhunyt lakcimkártyája";
            this.cbFuneralIsAddressCardTaken.UseVisualStyleBackColor = true;
            // 
            // cbFuneralIsDeathCertificateTaken
            // 
            this.cbFuneralIsDeathCertificateTaken.AutoSize = true;
            this.cbFuneralIsDeathCertificateTaken.Location = new System.Drawing.Point(59, 86);
            this.cbFuneralIsDeathCertificateTaken.Name = "cbFuneralIsDeathCertificateTaken";
            this.cbFuneralIsDeathCertificateTaken.Size = new System.Drawing.Size(200, 17);
            this.cbFuneralIsDeathCertificateTaken.TabIndex = 79;
            this.cbFuneralIsDeathCertificateTaken.Text = "Elhunyt halottvizsgálati bizonyitványa";
            this.cbFuneralIsDeathCertificateTaken.UseVisualStyleBackColor = true;
            // 
            // cbFuneralIsBirthCertificateTaken
            // 
            this.cbFuneralIsBirthCertificateTaken.AutoSize = true;
            this.cbFuneralIsBirthCertificateTaken.Location = new System.Drawing.Point(59, 109);
            this.cbFuneralIsBirthCertificateTaken.Name = "cbFuneralIsBirthCertificateTaken";
            this.cbFuneralIsBirthCertificateTaken.Size = new System.Drawing.Size(205, 17);
            this.cbFuneralIsBirthCertificateTaken.TabIndex = 81;
            this.cbFuneralIsBirthCertificateTaken.Text = "Elhunyt születési anyakönyvi kivonata";
            this.cbFuneralIsBirthCertificateTaken.UseVisualStyleBackColor = true;
            // 
            // cbFuneralIsMarriageCertificateTaken
            // 
            this.cbFuneralIsMarriageCertificateTaken.AutoSize = true;
            this.cbFuneralIsMarriageCertificateTaken.Location = new System.Drawing.Point(59, 132);
            this.cbFuneralIsMarriageCertificateTaken.Name = "cbFuneralIsMarriageCertificateTaken";
            this.cbFuneralIsMarriageCertificateTaken.Size = new System.Drawing.Size(170, 17);
            this.cbFuneralIsMarriageCertificateTaken.TabIndex = 82;
            this.cbFuneralIsMarriageCertificateTaken.Text = "Házassági anyakönyvi kivonat";
            this.cbFuneralIsMarriageCertificateTaken.UseVisualStyleBackColor = true;
            // 
            // cbFuneralIsSpouseDeathCertificateTaken
            // 
            this.cbFuneralIsSpouseDeathCertificateTaken.AutoSize = true;
            this.cbFuneralIsSpouseDeathCertificateTaken.Location = new System.Drawing.Point(59, 155);
            this.cbFuneralIsSpouseDeathCertificateTaken.Name = "cbFuneralIsSpouseDeathCertificateTaken";
            this.cbFuneralIsSpouseDeathCertificateTaken.Size = new System.Drawing.Size(205, 17);
            this.cbFuneralIsSpouseDeathCertificateTaken.TabIndex = 83;
            this.cbFuneralIsSpouseDeathCertificateTaken.Text = "Házastárs halotti anyakönyvi kivonata";
            this.cbFuneralIsSpouseDeathCertificateTaken.UseVisualStyleBackColor = true;
            // 
            // cbFuneralIsIDCardNeededByClient
            // 
            this.cbFuneralIsIDCardNeededByClient.AutoSize = true;
            this.cbFuneralIsIDCardNeededByClient.Location = new System.Drawing.Point(19, 192);
            this.cbFuneralIsIDCardNeededByClient.Name = "cbFuneralIsIDCardNeededByClient";
            this.cbFuneralIsIDCardNeededByClient.Size = new System.Drawing.Size(324, 17);
            this.cbFuneralIsIDCardNeededByClient.TabIndex = 84;
            this.cbFuneralIsIDCardNeededByClient.Text = "Elhunyt személyi igazolványát érvénytelenités után visszakérem";
            this.cbFuneralIsIDCardNeededByClient.UseVisualStyleBackColor = true;
            // 
            // cmbFuneralGarveDigging
            // 
            this.cmbFuneralGarveDigging.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralGarveDigging.Enabled = false;
            this.cmbFuneralGarveDigging.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralGarveDigging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralGarveDigging.FormattingEnabled = true;
            this.cmbFuneralGarveDigging.Location = new System.Drawing.Point(501, 301);
            this.cmbFuneralGarveDigging.Name = "cmbFuneralGarveDigging";
            this.cmbFuneralGarveDigging.Size = new System.Drawing.Size(202, 28);
            this.cmbFuneralGarveDigging.TabIndex = 87;
            // 
            // lblFuneralGarveDigging
            // 
            this.lblFuneralGarveDigging.AutoSize = true;
            this.lblFuneralGarveDigging.Location = new System.Drawing.Point(383, 309);
            this.lblFuneralGarveDigging.Name = "lblFuneralGarveDigging";
            this.lblFuneralGarveDigging.Size = new System.Drawing.Size(41, 13);
            this.lblFuneralGarveDigging.TabIndex = 86;
            this.lblFuneralGarveDigging.Text = "Sirásás";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "-",
            "Vakkripta"});
            this.comboBox2.Location = new System.Drawing.Point(501, 301);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 28);
            this.comboBox2.TabIndex = 85;
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Location = new System.Drawing.Point(383, 158);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(32, 13);
            this.lblMusic.TabIndex = 91;
            this.lblMusic.Text = "Zene";
            // 
            // tbMusic
            // 
            this.tbMusic.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMusic.Enabled = false;
            this.tbMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMusic.Location = new System.Drawing.Point(501, 147);
            this.tbMusic.Name = "tbMusic";
            this.tbMusic.Size = new System.Drawing.Size(202, 29);
            this.tbMusic.TabIndex = 90;
            // 
            // cbFuneralUrnCloth
            // 
            this.cbFuneralUrnCloth.AutoSize = true;
            this.cbFuneralUrnCloth.Enabled = false;
            this.cbFuneralUrnCloth.Location = new System.Drawing.Point(501, 231);
            this.cbFuneralUrnCloth.Name = "cbFuneralUrnCloth";
            this.cbFuneralUrnCloth.Size = new System.Drawing.Size(15, 14);
            this.cbFuneralUrnCloth.TabIndex = 92;
            this.cbFuneralUrnCloth.UseVisualStyleBackColor = true;
            // 
            // lblFuneralUrnCloth
            // 
            this.lblFuneralUrnCloth.AutoSize = true;
            this.lblFuneralUrnCloth.Location = new System.Drawing.Point(382, 230);
            this.lblFuneralUrnCloth.Name = "lblFuneralUrnCloth";
            this.lblFuneralUrnCloth.Size = new System.Drawing.Size(53, 13);
            this.lblFuneralUrnCloth.TabIndex = 93;
            this.lblFuneralUrnCloth.Text = "Urnateritő";
            // 
            // cmbFuneralGraveMarker
            // 
            this.cmbFuneralGraveMarker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralGraveMarker.Enabled = false;
            this.cmbFuneralGraveMarker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralGraveMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralGraveMarker.FormattingEnabled = true;
            this.cmbFuneralGraveMarker.Items.AddRange(new object[] {
            "Kereszt",
            "Fejfa"});
            this.cmbFuneralGraveMarker.Location = new System.Drawing.Point(501, 339);
            this.cmbFuneralGraveMarker.Name = "cmbFuneralGraveMarker";
            this.cmbFuneralGraveMarker.Size = new System.Drawing.Size(202, 28);
            this.cmbFuneralGraveMarker.TabIndex = 95;
            // 
            // lblFuneralGraveMarker
            // 
            this.lblFuneralGraveMarker.AutoSize = true;
            this.lblFuneralGraveMarker.Location = new System.Drawing.Point(383, 347);
            this.lblFuneralGraveMarker.Name = "lblFuneralGraveMarker";
            this.lblFuneralGraveMarker.Size = new System.Drawing.Size(40, 13);
            this.lblFuneralGraveMarker.TabIndex = 94;
            this.lblFuneralGraveMarker.Text = "Sirjelző";
            // 
            // tbFuneralDateYear
            // 
            this.tbFuneralDateYear.Enabled = false;
            this.tbFuneralDateYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFuneralDateYear.Location = new System.Drawing.Point(140, 341);
            this.tbFuneralDateYear.Name = "tbFuneralDateYear";
            this.tbFuneralDateYear.Size = new System.Drawing.Size(102, 29);
            this.tbFuneralDateYear.TabIndex = 109;
            this.tbFuneralDateYear.Text = "2020";
            // 
            // cmbFuneralDateDay
            // 
            this.cmbFuneralDateDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralDateDay.Enabled = false;
            this.cmbFuneralDateDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralDateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralDateDay.FormattingEnabled = true;
            this.cmbFuneralDateDay.Location = new System.Drawing.Point(298, 342);
            this.cmbFuneralDateDay.Name = "cmbFuneralDateDay";
            this.cmbFuneralDateDay.Size = new System.Drawing.Size(45, 28);
            this.cmbFuneralDateDay.TabIndex = 108;
            // 
            // cmbFuneralDateMonth
            // 
            this.cmbFuneralDateMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralDateMonth.Enabled = false;
            this.cmbFuneralDateMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralDateMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralDateMonth.FormattingEnabled = true;
            this.cmbFuneralDateMonth.Location = new System.Drawing.Point(247, 342);
            this.cmbFuneralDateMonth.Name = "cmbFuneralDateMonth";
            this.cmbFuneralDateMonth.Size = new System.Drawing.Size(45, 28);
            this.cmbFuneralDateMonth.TabIndex = 107;
            // 
            // lblFuneralGrave
            // 
            this.lblFuneralGrave.AutoSize = true;
            this.lblFuneralGrave.Location = new System.Drawing.Point(383, 85);
            this.lblFuneralGrave.Name = "lblFuneralGrave";
            this.lblFuneralGrave.Size = new System.Drawing.Size(65, 13);
            this.lblFuneralGrave.TabIndex = 111;
            this.lblFuneralGrave.Text = "Sirhely szám";
            // 
            // tbFuneralGrave
            // 
            this.tbFuneralGrave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFuneralGrave.Enabled = false;
            this.tbFuneralGrave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFuneralGrave.Location = new System.Drawing.Point(501, 74);
            this.tbFuneralGrave.Name = "tbFuneralGrave";
            this.tbFuneralGrave.Size = new System.Drawing.Size(202, 29);
            this.tbFuneralGrave.TabIndex = 110;
            // 
            // cbTemetesHelye
            // 
            this.cbTemetesHelye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemetesHelye.Enabled = false;
            this.cbTemetesHelye.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTemetesHelye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTemetesHelye.FormattingEnabled = true;
            this.cbTemetesHelye.Items.AddRange(new object[] {
            "Gödöllő (Dózsa György út 35)",
            "Máriabesnyő",
            "Egyéb"});
            this.cbTemetesHelye.Location = new System.Drawing.Point(142, 301);
            this.cbTemetesHelye.Name = "cbTemetesHelye";
            this.cbTemetesHelye.Size = new System.Drawing.Size(202, 28);
            this.cbTemetesHelye.TabIndex = 120;
            // 
            // lblTemetesHelye
            // 
            this.lblTemetesHelye.AutoSize = true;
            this.lblTemetesHelye.Location = new System.Drawing.Point(23, 309);
            this.lblTemetesHelye.Name = "lblTemetesHelye";
            this.lblTemetesHelye.Size = new System.Drawing.Size(76, 13);
            this.lblTemetesHelye.TabIndex = 119;
            this.lblTemetesHelye.Text = "Temetés helye";
            // 
            // cmbGraveOrCrypt
            // 
            this.cmbGraveOrCrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraveOrCrypt.Enabled = false;
            this.cmbGraveOrCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGraveOrCrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbGraveOrCrypt.FormattingEnabled = true;
            this.cmbGraveOrCrypt.Location = new System.Drawing.Point(501, 38);
            this.cmbGraveOrCrypt.Name = "cmbGraveOrCrypt";
            this.cmbGraveOrCrypt.Size = new System.Drawing.Size(202, 28);
            this.cmbGraveOrCrypt.TabIndex = 123;
            this.cmbGraveOrCrypt.SelectedIndexChanged += new System.EventHandler(this.cmbGraveOrCrypt_SelectedIndexChanged);
            // 
            // lblGraveOrCrypt
            // 
            this.lblGraveOrCrypt.AutoSize = true;
            this.lblGraveOrCrypt.Location = new System.Drawing.Point(383, 46);
            this.lblGraveOrCrypt.Name = "lblGraveOrCrypt";
            this.lblGraveOrCrypt.Size = new System.Drawing.Size(106, 13);
            this.lblGraveOrCrypt.TabIndex = 122;
            this.lblGraveOrCrypt.Text = "Sirkő/Kripta/Kolomb.";
            // 
            // cmbFuneralDateHour
            // 
            this.cmbFuneralDateHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralDateHour.Enabled = false;
            this.cmbFuneralDateHour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralDateHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralDateHour.FormattingEnabled = true;
            this.cmbFuneralDateHour.Location = new System.Drawing.Point(149, 380);
            this.cmbFuneralDateHour.Name = "cmbFuneralDateHour";
            this.cmbFuneralDateHour.Size = new System.Drawing.Size(83, 28);
            this.cmbFuneralDateHour.TabIndex = 124;
            // 
            // cmbFuneralDateMinute
            // 
            this.cmbFuneralDateMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuneralDateMinute.Enabled = false;
            this.cmbFuneralDateMinute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuneralDateMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuneralDateMinute.FormattingEnabled = true;
            this.cmbFuneralDateMinute.Location = new System.Drawing.Point(255, 380);
            this.cmbFuneralDateMinute.Name = "cmbFuneralDateMinute";
            this.cmbFuneralDateMinute.Size = new System.Drawing.Size(83, 28);
            this.cmbFuneralDateMinute.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(236, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = ":";
            // 
            // Funeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFuneralDateMinute);
            this.Controls.Add(this.cmbFuneralDateHour);
            this.Controls.Add(this.cmbGraveOrCrypt);
            this.Controls.Add(this.lblGraveOrCrypt);
            this.Controls.Add(this.cbTemetesHelye);
            this.Controls.Add(this.lblTemetesHelye);
            this.Controls.Add(this.lblFuneralGrave);
            this.Controls.Add(this.tbFuneralGrave);
            this.Controls.Add(this.tbFuneralDateYear);
            this.Controls.Add(this.cmbFuneralDateDay);
            this.Controls.Add(this.cmbFuneralDateMonth);
            this.Controls.Add(this.cmbFuneralGraveMarker);
            this.Controls.Add(this.lblFuneralGraveMarker);
            this.Controls.Add(this.lblFuneralUrnCloth);
            this.Controls.Add(this.cbFuneralUrnCloth);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.tbMusic);
            this.Controls.Add(this.cmbFuneralGarveDigging);
            this.Controls.Add(this.lblFuneralGarveDigging);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cbFuneralIsIDCardNeededByClient);
            this.Controls.Add(this.cbFuneralIsSpouseDeathCertificateTaken);
            this.Controls.Add(this.cbFuneralIsMarriageCertificateTaken);
            this.Controls.Add(this.cbFuneralIsBirthCertificateTaken);
            this.Controls.Add(this.cbFuneralIsDeathCertificateTaken);
            this.Controls.Add(this.cbFuneralIsAddressCardTaken);
            this.Controls.Add(this.cbFuneralIsIDCardTaken);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblClientReach);
            this.Controls.Add(this.cmbClientReach);
            this.Controls.Add(this.cmbFuneralCoffinOrUrnType);
            this.Controls.Add(this.cmbFuneralCaissionType);
            this.Controls.Add(this.lblFuneralCaissionType);
            this.Controls.Add(this.cmbFuneralCrypt);
            this.Controls.Add(this.lblFuneralCoffinOrUrnType);
            this.Controls.Add(this.cbKoporsoTipus);
            this.Controls.Add(this.lblFuneralCatafalque);
            this.Controls.Add(this.cmbFuneralCatafalque);
            this.Controls.Add(this.lblFuneralType);
            this.Controls.Add(this.cmbFuneralType);
            this.Controls.Add(this.lblFuneralDate);
            this.Controls.Add(this.lblFuneralMethod);
            this.Controls.Add(this.cmbFuneralMethod);
            this.Controls.Add(this.btnBefejezesVisszaFomenu);
            this.Controls.Add(this.btnVisszaBejelento);
            this.Name = "Funeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiegészitő adatok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Funeral_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVisszaBejelento;
        private System.Windows.Forms.Button btnBefejezesVisszaFomenu;
        private System.Windows.Forms.Label lblFuneralMethod;
        private System.Windows.Forms.ComboBox cmbFuneralMethod;
        private System.Windows.Forms.Label lblFuneralDate;
        private System.Windows.Forms.Label lblFuneralType;
        private System.Windows.Forms.ComboBox cmbFuneralType;
        private System.Windows.Forms.Label lblFuneralCatafalque;
        private System.Windows.Forms.ComboBox cmbFuneralCatafalque;
        private System.Windows.Forms.Label lblFuneralCoffinOrUrnType;
        private System.Windows.Forms.ComboBox cbKoporsoTipus;
        private System.Windows.Forms.Label lblFuneralCaissionType;
        private System.Windows.Forms.ComboBox cmbFuneralCrypt;
        private System.Windows.Forms.ComboBox cmbFuneralCaissionType;
        private System.Windows.Forms.ComboBox cmbFuneralCoffinOrUrnType;
        private System.Windows.Forms.Label lblClientReach;
        private System.Windows.Forms.TextBox cmbClientReach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbFuneralIsIDCardTaken;
        private System.Windows.Forms.CheckBox cbFuneralIsAddressCardTaken;
        private System.Windows.Forms.CheckBox cbFuneralIsDeathCertificateTaken;
        private System.Windows.Forms.CheckBox cbFuneralIsBirthCertificateTaken;
        private System.Windows.Forms.CheckBox cbFuneralIsMarriageCertificateTaken;
        private System.Windows.Forms.CheckBox cbFuneralIsSpouseDeathCertificateTaken;
        private System.Windows.Forms.CheckBox cbFuneralIsIDCardNeededByClient;
        private System.Windows.Forms.ComboBox cmbFuneralGarveDigging;
        private System.Windows.Forms.Label lblFuneralGarveDigging;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.TextBox tbMusic;
        private System.Windows.Forms.CheckBox cbFuneralUrnCloth;
        private System.Windows.Forms.Label lblFuneralUrnCloth;
        private System.Windows.Forms.ComboBox cmbFuneralGraveMarker;
        private System.Windows.Forms.Label lblFuneralGraveMarker;
        private System.Windows.Forms.TextBox tbFuneralDateYear;
        private System.Windows.Forms.ComboBox cmbFuneralDateDay;
        private System.Windows.Forms.ComboBox cmbFuneralDateMonth;
        private System.Windows.Forms.Label lblFuneralGrave;
        private System.Windows.Forms.TextBox tbFuneralGrave;
        private System.Windows.Forms.ComboBox cbTemetesHelye;
        private System.Windows.Forms.Label lblTemetesHelye;
        private System.Windows.Forms.ComboBox cmbGraveOrCrypt;
        private System.Windows.Forms.Label lblGraveOrCrypt;
        private System.Windows.Forms.ComboBox cmbFuneralDateHour;
        private System.Windows.Forms.ComboBox cmbFuneralDateMinute;
        private System.Windows.Forms.Label label2;
    }
}