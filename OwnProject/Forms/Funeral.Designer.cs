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
            this.labelTemetesModja = new System.Windows.Forms.Label();
            this.cbTemetesModja = new System.Windows.Forms.ComboBox();
            this.labelTemetesIdopont = new System.Windows.Forms.Label();
            this.labelTemetesTipusa = new System.Windows.Forms.Label();
            this.cbTemetesTipusa = new System.Windows.Forms.ComboBox();
            this.labelRavatalozo = new System.Windows.Forms.Label();
            this.cbRavatalozo = new System.Windows.Forms.ComboBox();
            this.labelKoporsoUrnaTipus = new System.Windows.Forms.Label();
            this.cbKoporsoTipus = new System.Windows.Forms.ComboBox();
            this.labelVakkriptaKeszon = new System.Windows.Forms.Label();
            this.cbVakkripta = new System.Windows.Forms.ComboBox();
            this.cbKeszon = new System.Windows.Forms.ComboBox();
            this.cbUrnaTipus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbELERHETOSEG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxA_E_SZ_I = new System.Windows.Forms.CheckBox();
            this.checkBoxA_E_L = new System.Windows.Forms.CheckBox();
            this.checkBoxA_E_H_B = new System.Windows.Forms.CheckBox();
            this.checkBoxA_E_SZ_A_K = new System.Windows.Forms.CheckBox();
            this.checkBoxA_H_A_K = new System.Windows.Forms.CheckBox();
            this.checkBoxA_H_H_A_K = new System.Windows.Forms.CheckBox();
            this.checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES = new System.Windows.Forms.CheckBox();
            this.cbSirasas = new System.Windows.Forms.ComboBox();
            this.labelSirasas = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelZene = new System.Windows.Forms.Label();
            this.tbZene = new System.Windows.Forms.TextBox();
            this.checkBoxUrnaterito = new System.Windows.Forms.CheckBox();
            this.labelUrnaterito = new System.Windows.Forms.Label();
            this.cbSirjelzo = new System.Windows.Forms.ComboBox();
            this.labelSirjelzo = new System.Windows.Forms.Label();
            this.tbT_I_E = new System.Windows.Forms.TextBox();
            this.cbT_I_N = new System.Windows.Forms.ComboBox();
            this.cbT_I_H = new System.Windows.Forms.ComboBox();
            this.labelSirhelyKolombariumSzam = new System.Windows.Forms.Label();
            this.tbSirhelyKolombariumSzam = new System.Windows.Forms.TextBox();
            this.cbTemetesHelye = new System.Windows.Forms.ComboBox();
            this.labelTemetesHelye = new System.Windows.Forms.Label();
            this.cbSirkoKripta = new System.Windows.Forms.ComboBox();
            this.labelSirkoKripta = new System.Windows.Forms.Label();
            this.cbT_I_ORA = new System.Windows.Forms.ComboBox();
            this.cbT_I_PERC = new System.Windows.Forms.ComboBox();
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
            this.btnVisszaBejelento.Click += new System.EventHandler(this.btnVisszaBejelento_Click);
            // 
            // btnBefejezesVisszaFomenu
            // 
            this.btnBefejezesVisszaFomenu.Location = new System.Drawing.Point(594, 461);
            this.btnBefejezesVisszaFomenu.Name = "btnBefejezesVisszaFomenu";
            this.btnBefejezesVisszaFomenu.Size = new System.Drawing.Size(109, 23);
            this.btnBefejezesVisszaFomenu.TabIndex = 42;
            this.btnBefejezesVisszaFomenu.Text = "Tovább: Nyomtatás";
            this.btnBefejezesVisszaFomenu.UseVisualStyleBackColor = true;
            this.btnBefejezesVisszaFomenu.Click += new System.EventHandler(this.btnBefejezesVisszaFomenu_Click);
            // 
            // labelTemetesModja
            // 
            this.labelTemetesModja.AutoSize = true;
            this.labelTemetesModja.Location = new System.Drawing.Point(23, 234);
            this.labelTemetesModja.Name = "labelTemetesModja";
            this.labelTemetesModja.Size = new System.Drawing.Size(79, 13);
            this.labelTemetesModja.TabIndex = 44;
            this.labelTemetesModja.Text = "Temetés módja";
            // 
            // cbTemetesModja
            // 
            this.cbTemetesModja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemetesModja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTemetesModja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTemetesModja.FormattingEnabled = true;
            this.cbTemetesModja.Items.AddRange(new object[] {
            "Urnaelvitel",
            "Koporsós",
            "Urnás"});
            this.cbTemetesModja.Location = new System.Drawing.Point(141, 226);
            this.cbTemetesModja.Name = "cbTemetesModja";
            this.cbTemetesModja.Size = new System.Drawing.Size(202, 28);
            this.cbTemetesModja.TabIndex = 43;
            this.cbTemetesModja.SelectedIndexChanged += new System.EventHandler(this.cbTemetesModja_SelectedIndexChanged);
            // 
            // labelTemetesIdopont
            // 
            this.labelTemetesIdopont.AutoSize = true;
            this.labelTemetesIdopont.Location = new System.Drawing.Point(22, 350);
            this.labelTemetesIdopont.Name = "labelTemetesIdopont";
            this.labelTemetesIdopont.Size = new System.Drawing.Size(94, 13);
            this.labelTemetesIdopont.TabIndex = 46;
            this.labelTemetesIdopont.Text = "Temetés időpontja";
            // 
            // labelTemetesTipusa
            // 
            this.labelTemetesTipusa.AutoSize = true;
            this.labelTemetesTipusa.Location = new System.Drawing.Point(23, 270);
            this.labelTemetesTipusa.Name = "labelTemetesTipusa";
            this.labelTemetesTipusa.Size = new System.Drawing.Size(79, 13);
            this.labelTemetesTipusa.TabIndex = 59;
            this.labelTemetesTipusa.Text = "Temetés tipusa";
            // 
            // cbTemetesTipusa
            // 
            this.cbTemetesTipusa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemetesTipusa.Enabled = false;
            this.cbTemetesTipusa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTemetesTipusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTemetesTipusa.FormattingEnabled = true;
            this.cbTemetesTipusa.Items.AddRange(new object[] {
            "-",
            "Polgári",
            "Katolikus",
            "Református",
            "Evangélikus",
            "Görög katolikus",
            "Baptista",
            "Jehova",
            "Szombatista"});
            this.cbTemetesTipusa.Location = new System.Drawing.Point(141, 262);
            this.cbTemetesTipusa.Name = "cbTemetesTipusa";
            this.cbTemetesTipusa.Size = new System.Drawing.Size(202, 28);
            this.cbTemetesTipusa.TabIndex = 58;
            // 
            // labelRavatalozo
            // 
            this.labelRavatalozo.AutoSize = true;
            this.labelRavatalozo.Location = new System.Drawing.Point(383, 120);
            this.labelRavatalozo.Name = "labelRavatalozo";
            this.labelRavatalozo.Size = new System.Drawing.Size(61, 13);
            this.labelRavatalozo.TabIndex = 61;
            this.labelRavatalozo.Text = "Ravatalozó";
            // 
            // cbRavatalozo
            // 
            this.cbRavatalozo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRavatalozo.Enabled = false;
            this.cbRavatalozo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRavatalozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRavatalozo.FormattingEnabled = true;
            this.cbRavatalozo.Location = new System.Drawing.Point(501, 112);
            this.cbRavatalozo.Name = "cbRavatalozo";
            this.cbRavatalozo.Size = new System.Drawing.Size(202, 28);
            this.cbRavatalozo.TabIndex = 60;
            // 
            // labelKoporsoUrnaTipus
            // 
            this.labelKoporsoUrnaTipus.AutoSize = true;
            this.labelKoporsoUrnaTipus.Location = new System.Drawing.Point(383, 191);
            this.labelKoporsoUrnaTipus.Name = "labelKoporsoUrnaTipus";
            this.labelKoporsoUrnaTipus.Size = new System.Drawing.Size(99, 13);
            this.labelKoporsoUrnaTipus.TabIndex = 63;
            this.labelKoporsoUrnaTipus.Text = "Koporsó/Urna tipus";
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
            // labelVakkriptaKeszon
            // 
            this.labelVakkriptaKeszon.AutoSize = true;
            this.labelVakkriptaKeszon.Location = new System.Drawing.Point(383, 273);
            this.labelVakkriptaKeszon.Name = "labelVakkriptaKeszon";
            this.labelVakkriptaKeszon.Size = new System.Drawing.Size(92, 13);
            this.labelVakkriptaKeszon.TabIndex = 65;
            this.labelVakkriptaKeszon.Text = "Vakkripta/Keszon";
            // 
            // cbVakkripta
            // 
            this.cbVakkripta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVakkripta.Enabled = false;
            this.cbVakkripta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbVakkripta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVakkripta.FormattingEnabled = true;
            this.cbVakkripta.Items.AddRange(new object[] {
            "-",
            "Vakkripta"});
            this.cbVakkripta.Location = new System.Drawing.Point(501, 265);
            this.cbVakkripta.Name = "cbVakkripta";
            this.cbVakkripta.Size = new System.Drawing.Size(202, 28);
            this.cbVakkripta.TabIndex = 64;
            this.cbVakkripta.SelectedIndexChanged += new System.EventHandler(this.cbVakkripta_SelectedIndexChanged);
            // 
            // cbKeszon
            // 
            this.cbKeszon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeszon.Enabled = false;
            this.cbKeszon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbKeszon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKeszon.FormattingEnabled = true;
            this.cbKeszon.Items.AddRange(new object[] {
            "-",
            "1 személyes",
            "2 személyes",
            "4 személyes"});
            this.cbKeszon.Location = new System.Drawing.Point(501, 265);
            this.cbKeszon.Name = "cbKeszon";
            this.cbKeszon.Size = new System.Drawing.Size(202, 28);
            this.cbKeszon.TabIndex = 66;
            // 
            // cbUrnaTipus
            // 
            this.cbUrnaTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrnaTipus.Enabled = false;
            this.cbUrnaTipus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbUrnaTipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbUrnaTipus.FormattingEnabled = true;
            this.cbUrnaTipus.Items.AddRange(new object[] {
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
            this.cbUrnaTipus.Location = new System.Drawing.Point(501, 184);
            this.cbUrnaTipus.Name = "cbUrnaTipus";
            this.cbUrnaTipus.Size = new System.Drawing.Size(202, 28);
            this.cbUrnaTipus.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Elérhetőség";
            // 
            // tbELERHETOSEG
            // 
            this.tbELERHETOSEG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbELERHETOSEG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbELERHETOSEG.Location = new System.Drawing.Point(501, 409);
            this.tbELERHETOSEG.Name = "tbELERHETOSEG";
            this.tbELERHETOSEG.Size = new System.Drawing.Size(202, 29);
            this.tbELERHETOSEG.TabIndex = 68;
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
            // checkBoxA_E_SZ_I
            // 
            this.checkBoxA_E_SZ_I.AutoSize = true;
            this.checkBoxA_E_SZ_I.Location = new System.Drawing.Point(59, 40);
            this.checkBoxA_E_SZ_I.Name = "checkBoxA_E_SZ_I";
            this.checkBoxA_E_SZ_I.Size = new System.Drawing.Size(162, 17);
            this.checkBoxA_E_SZ_I.TabIndex = 77;
            this.checkBoxA_E_SZ_I.Text = "Elhunyt személyi igazolványa";
            this.checkBoxA_E_SZ_I.UseVisualStyleBackColor = true;
            // 
            // checkBoxA_E_L
            // 
            this.checkBoxA_E_L.AutoSize = true;
            this.checkBoxA_E_L.Location = new System.Drawing.Point(59, 63);
            this.checkBoxA_E_L.Name = "checkBoxA_E_L";
            this.checkBoxA_E_L.Size = new System.Drawing.Size(131, 17);
            this.checkBoxA_E_L.TabIndex = 78;
            this.checkBoxA_E_L.Text = "Elhunyt lakcimkártyája";
            this.checkBoxA_E_L.UseVisualStyleBackColor = true;
            // 
            // checkBoxA_E_H_B
            // 
            this.checkBoxA_E_H_B.AutoSize = true;
            this.checkBoxA_E_H_B.Location = new System.Drawing.Point(59, 86);
            this.checkBoxA_E_H_B.Name = "checkBoxA_E_H_B";
            this.checkBoxA_E_H_B.Size = new System.Drawing.Size(200, 17);
            this.checkBoxA_E_H_B.TabIndex = 79;
            this.checkBoxA_E_H_B.Text = "Elhunyt halottvizsgálati bizonyitványa";
            this.checkBoxA_E_H_B.UseVisualStyleBackColor = true;
            // 
            // checkBoxA_E_SZ_A_K
            // 
            this.checkBoxA_E_SZ_A_K.AutoSize = true;
            this.checkBoxA_E_SZ_A_K.Location = new System.Drawing.Point(59, 109);
            this.checkBoxA_E_SZ_A_K.Name = "checkBoxA_E_SZ_A_K";
            this.checkBoxA_E_SZ_A_K.Size = new System.Drawing.Size(205, 17);
            this.checkBoxA_E_SZ_A_K.TabIndex = 81;
            this.checkBoxA_E_SZ_A_K.Text = "Elhunyt születési anyakönyvi kivonata";
            this.checkBoxA_E_SZ_A_K.UseVisualStyleBackColor = true;
            // 
            // checkBoxA_H_A_K
            // 
            this.checkBoxA_H_A_K.AutoSize = true;
            this.checkBoxA_H_A_K.Location = new System.Drawing.Point(59, 132);
            this.checkBoxA_H_A_K.Name = "checkBoxA_H_A_K";
            this.checkBoxA_H_A_K.Size = new System.Drawing.Size(170, 17);
            this.checkBoxA_H_A_K.TabIndex = 82;
            this.checkBoxA_H_A_K.Text = "Házassági anyakönyvi kivonat";
            this.checkBoxA_H_A_K.UseVisualStyleBackColor = true;
            // 
            // checkBoxA_H_H_A_K
            // 
            this.checkBoxA_H_H_A_K.AutoSize = true;
            this.checkBoxA_H_H_A_K.Location = new System.Drawing.Point(59, 155);
            this.checkBoxA_H_H_A_K.Name = "checkBoxA_H_H_A_K";
            this.checkBoxA_H_H_A_K.Size = new System.Drawing.Size(207, 17);
            this.checkBoxA_H_H_A_K.TabIndex = 83;
            this.checkBoxA_H_H_A_K.Text = "Házassági halotti anyakönyvi kivonata";
            this.checkBoxA_H_H_A_K.UseVisualStyleBackColor = true;
            // 
            // checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES
            // 
            this.checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES.AutoSize = true;
            this.checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES.Location = new System.Drawing.Point(19, 192);
            this.checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES.Name = "checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES";
            this.checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES.Size = new System.Drawing.Size(324, 17);
            this.checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES.TabIndex = 84;
            this.checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES.Text = "Elhunyt személyi igazolványát érvénytelenités után visszakérem";
            this.checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES.UseVisualStyleBackColor = true;
            // 
            // cbSirasas
            // 
            this.cbSirasas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSirasas.Enabled = false;
            this.cbSirasas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSirasas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSirasas.FormattingEnabled = true;
            this.cbSirasas.Location = new System.Drawing.Point(501, 301);
            this.cbSirasas.Name = "cbSirasas";
            this.cbSirasas.Size = new System.Drawing.Size(202, 28);
            this.cbSirasas.TabIndex = 87;
            // 
            // labelSirasas
            // 
            this.labelSirasas.AutoSize = true;
            this.labelSirasas.Location = new System.Drawing.Point(383, 309);
            this.labelSirasas.Name = "labelSirasas";
            this.labelSirasas.Size = new System.Drawing.Size(41, 13);
            this.labelSirasas.TabIndex = 86;
            this.labelSirasas.Text = "Sirásás";
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
            // labelZene
            // 
            this.labelZene.AutoSize = true;
            this.labelZene.Location = new System.Drawing.Point(383, 158);
            this.labelZene.Name = "labelZene";
            this.labelZene.Size = new System.Drawing.Size(32, 13);
            this.labelZene.TabIndex = 91;
            this.labelZene.Text = "Zene";
            // 
            // tbZene
            // 
            this.tbZene.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbZene.Enabled = false;
            this.tbZene.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbZene.Location = new System.Drawing.Point(501, 147);
            this.tbZene.Name = "tbZene";
            this.tbZene.Size = new System.Drawing.Size(202, 29);
            this.tbZene.TabIndex = 90;
            // 
            // checkBoxUrnaterito
            // 
            this.checkBoxUrnaterito.AutoSize = true;
            this.checkBoxUrnaterito.Enabled = false;
            this.checkBoxUrnaterito.Location = new System.Drawing.Point(501, 231);
            this.checkBoxUrnaterito.Name = "checkBoxUrnaterito";
            this.checkBoxUrnaterito.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUrnaterito.TabIndex = 92;
            this.checkBoxUrnaterito.UseVisualStyleBackColor = true;
            // 
            // labelUrnaterito
            // 
            this.labelUrnaterito.AutoSize = true;
            this.labelUrnaterito.Location = new System.Drawing.Point(382, 230);
            this.labelUrnaterito.Name = "labelUrnaterito";
            this.labelUrnaterito.Size = new System.Drawing.Size(53, 13);
            this.labelUrnaterito.TabIndex = 93;
            this.labelUrnaterito.Text = "Urnateritő";
            // 
            // cbSirjelzo
            // 
            this.cbSirjelzo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSirjelzo.Enabled = false;
            this.cbSirjelzo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSirjelzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSirjelzo.FormattingEnabled = true;
            this.cbSirjelzo.Items.AddRange(new object[] {
            "Kereszt",
            "Fejfa"});
            this.cbSirjelzo.Location = new System.Drawing.Point(501, 339);
            this.cbSirjelzo.Name = "cbSirjelzo";
            this.cbSirjelzo.Size = new System.Drawing.Size(202, 28);
            this.cbSirjelzo.TabIndex = 95;
            // 
            // labelSirjelzo
            // 
            this.labelSirjelzo.AutoSize = true;
            this.labelSirjelzo.Location = new System.Drawing.Point(383, 347);
            this.labelSirjelzo.Name = "labelSirjelzo";
            this.labelSirjelzo.Size = new System.Drawing.Size(40, 13);
            this.labelSirjelzo.TabIndex = 94;
            this.labelSirjelzo.Text = "Sirjelző";
            // 
            // tbT_I_E
            // 
            this.tbT_I_E.Enabled = false;
            this.tbT_I_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbT_I_E.Location = new System.Drawing.Point(140, 341);
            this.tbT_I_E.Name = "tbT_I_E";
            this.tbT_I_E.Size = new System.Drawing.Size(102, 29);
            this.tbT_I_E.TabIndex = 109;
            this.tbT_I_E.Text = "2020";
            // 
            // cbT_I_N
            // 
            this.cbT_I_N.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbT_I_N.Enabled = false;
            this.cbT_I_N.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbT_I_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbT_I_N.FormattingEnabled = true;
            this.cbT_I_N.Location = new System.Drawing.Point(298, 342);
            this.cbT_I_N.Name = "cbT_I_N";
            this.cbT_I_N.Size = new System.Drawing.Size(45, 28);
            this.cbT_I_N.TabIndex = 108;
            // 
            // cbT_I_H
            // 
            this.cbT_I_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbT_I_H.Enabled = false;
            this.cbT_I_H.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbT_I_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbT_I_H.FormattingEnabled = true;
            this.cbT_I_H.Location = new System.Drawing.Point(247, 342);
            this.cbT_I_H.Name = "cbT_I_H";
            this.cbT_I_H.Size = new System.Drawing.Size(45, 28);
            this.cbT_I_H.TabIndex = 107;
            // 
            // labelSirhelyKolombariumSzam
            // 
            this.labelSirhelyKolombariumSzam.AutoSize = true;
            this.labelSirhelyKolombariumSzam.Location = new System.Drawing.Point(383, 85);
            this.labelSirhelyKolombariumSzam.Name = "labelSirhelyKolombariumSzam";
            this.labelSirhelyKolombariumSzam.Size = new System.Drawing.Size(65, 13);
            this.labelSirhelyKolombariumSzam.TabIndex = 111;
            this.labelSirhelyKolombariumSzam.Text = "Sirhely szám";
            // 
            // tbSirhelyKolombariumSzam
            // 
            this.tbSirhelyKolombariumSzam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSirhelyKolombariumSzam.Enabled = false;
            this.tbSirhelyKolombariumSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSirhelyKolombariumSzam.Location = new System.Drawing.Point(501, 74);
            this.tbSirhelyKolombariumSzam.Name = "tbSirhelyKolombariumSzam";
            this.tbSirhelyKolombariumSzam.Size = new System.Drawing.Size(202, 29);
            this.tbSirhelyKolombariumSzam.TabIndex = 110;
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
            this.cbTemetesHelye.Location = new System.Drawing.Point(141, 301);
            this.cbTemetesHelye.Name = "cbTemetesHelye";
            this.cbTemetesHelye.Size = new System.Drawing.Size(202, 28);
            this.cbTemetesHelye.TabIndex = 120;
            // 
            // labelTemetesHelye
            // 
            this.labelTemetesHelye.AutoSize = true;
            this.labelTemetesHelye.Location = new System.Drawing.Point(23, 309);
            this.labelTemetesHelye.Name = "labelTemetesHelye";
            this.labelTemetesHelye.Size = new System.Drawing.Size(76, 13);
            this.labelTemetesHelye.TabIndex = 119;
            this.labelTemetesHelye.Text = "Temetés helye";
            // 
            // cbSirkoKripta
            // 
            this.cbSirkoKripta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSirkoKripta.Enabled = false;
            this.cbSirkoKripta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSirkoKripta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSirkoKripta.FormattingEnabled = true;
            this.cbSirkoKripta.Location = new System.Drawing.Point(501, 38);
            this.cbSirkoKripta.Name = "cbSirkoKripta";
            this.cbSirkoKripta.Size = new System.Drawing.Size(202, 28);
            this.cbSirkoKripta.TabIndex = 123;
            this.cbSirkoKripta.SelectedIndexChanged += new System.EventHandler(this.cbSirkoKripta_SelectedIndexChanged);
            // 
            // labelSirkoKripta
            // 
            this.labelSirkoKripta.AutoSize = true;
            this.labelSirkoKripta.Location = new System.Drawing.Point(383, 46);
            this.labelSirkoKripta.Name = "labelSirkoKripta";
            this.labelSirkoKripta.Size = new System.Drawing.Size(106, 13);
            this.labelSirkoKripta.TabIndex = 122;
            this.labelSirkoKripta.Text = "Sirkő/Kripta/Kolomb.";
            // 
            // cbT_I_ORA
            // 
            this.cbT_I_ORA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbT_I_ORA.Enabled = false;
            this.cbT_I_ORA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbT_I_ORA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbT_I_ORA.FormattingEnabled = true;
            this.cbT_I_ORA.Location = new System.Drawing.Point(149, 380);
            this.cbT_I_ORA.Name = "cbT_I_ORA";
            this.cbT_I_ORA.Size = new System.Drawing.Size(83, 28);
            this.cbT_I_ORA.TabIndex = 124;
            // 
            // cbT_I_PERC
            // 
            this.cbT_I_PERC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbT_I_PERC.Enabled = false;
            this.cbT_I_PERC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbT_I_PERC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbT_I_PERC.FormattingEnabled = true;
            this.cbT_I_PERC.Location = new System.Drawing.Point(255, 380);
            this.cbT_I_PERC.Name = "cbT_I_PERC";
            this.cbT_I_PERC.Size = new System.Drawing.Size(83, 28);
            this.cbT_I_PERC.TabIndex = 125;
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
            // KiegAdatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbT_I_PERC);
            this.Controls.Add(this.cbT_I_ORA);
            this.Controls.Add(this.cbSirkoKripta);
            this.Controls.Add(this.labelSirkoKripta);
            this.Controls.Add(this.cbTemetesHelye);
            this.Controls.Add(this.labelTemetesHelye);
            this.Controls.Add(this.labelSirhelyKolombariumSzam);
            this.Controls.Add(this.tbSirhelyKolombariumSzam);
            this.Controls.Add(this.tbT_I_E);
            this.Controls.Add(this.cbT_I_N);
            this.Controls.Add(this.cbT_I_H);
            this.Controls.Add(this.cbSirjelzo);
            this.Controls.Add(this.labelSirjelzo);
            this.Controls.Add(this.labelUrnaterito);
            this.Controls.Add(this.checkBoxUrnaterito);
            this.Controls.Add(this.labelZene);
            this.Controls.Add(this.tbZene);
            this.Controls.Add(this.cbSirasas);
            this.Controls.Add(this.labelSirasas);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES);
            this.Controls.Add(this.checkBoxA_H_H_A_K);
            this.Controls.Add(this.checkBoxA_H_A_K);
            this.Controls.Add(this.checkBoxA_E_SZ_A_K);
            this.Controls.Add(this.checkBoxA_E_H_B);
            this.Controls.Add(this.checkBoxA_E_L);
            this.Controls.Add(this.checkBoxA_E_SZ_I);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbELERHETOSEG);
            this.Controls.Add(this.cbUrnaTipus);
            this.Controls.Add(this.cbKeszon);
            this.Controls.Add(this.labelVakkriptaKeszon);
            this.Controls.Add(this.cbVakkripta);
            this.Controls.Add(this.labelKoporsoUrnaTipus);
            this.Controls.Add(this.cbKoporsoTipus);
            this.Controls.Add(this.labelRavatalozo);
            this.Controls.Add(this.cbRavatalozo);
            this.Controls.Add(this.labelTemetesTipusa);
            this.Controls.Add(this.cbTemetesTipusa);
            this.Controls.Add(this.labelTemetesIdopont);
            this.Controls.Add(this.labelTemetesModja);
            this.Controls.Add(this.cbTemetesModja);
            this.Controls.Add(this.btnBefejezesVisszaFomenu);
            this.Controls.Add(this.btnVisszaBejelento);
            this.Name = "KiegAdatok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiegészitő adatok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KiegAdatok_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVisszaBejelento;
        private System.Windows.Forms.Button btnBefejezesVisszaFomenu;
        private System.Windows.Forms.Label labelTemetesModja;
        private System.Windows.Forms.ComboBox cbTemetesModja;
        private System.Windows.Forms.Label labelTemetesIdopont;
        private System.Windows.Forms.Label labelTemetesTipusa;
        private System.Windows.Forms.ComboBox cbTemetesTipusa;
        private System.Windows.Forms.Label labelRavatalozo;
        private System.Windows.Forms.ComboBox cbRavatalozo;
        private System.Windows.Forms.Label labelKoporsoUrnaTipus;
        private System.Windows.Forms.ComboBox cbKoporsoTipus;
        private System.Windows.Forms.Label labelVakkriptaKeszon;
        private System.Windows.Forms.ComboBox cbVakkripta;
        private System.Windows.Forms.ComboBox cbKeszon;
        private System.Windows.Forms.ComboBox cbUrnaTipus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbELERHETOSEG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxA_E_SZ_I;
        private System.Windows.Forms.CheckBox checkBoxA_E_L;
        private System.Windows.Forms.CheckBox checkBoxA_E_H_B;
        private System.Windows.Forms.CheckBox checkBoxA_E_SZ_A_K;
        private System.Windows.Forms.CheckBox checkBoxA_H_A_K;
        private System.Windows.Forms.CheckBox checkBoxA_H_H_A_K;
        private System.Windows.Forms.CheckBox checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES;
        private System.Windows.Forms.ComboBox cbSirasas;
        private System.Windows.Forms.Label labelSirasas;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelZene;
        private System.Windows.Forms.TextBox tbZene;
        private System.Windows.Forms.CheckBox checkBoxUrnaterito;
        private System.Windows.Forms.Label labelUrnaterito;
        private System.Windows.Forms.ComboBox cbSirjelzo;
        private System.Windows.Forms.Label labelSirjelzo;
        private System.Windows.Forms.TextBox tbT_I_E;
        private System.Windows.Forms.ComboBox cbT_I_N;
        private System.Windows.Forms.ComboBox cbT_I_H;
        private System.Windows.Forms.Label labelSirhelyKolombariumSzam;
        private System.Windows.Forms.TextBox tbSirhelyKolombariumSzam;
        private System.Windows.Forms.ComboBox cbTemetesHelye;
        private System.Windows.Forms.Label labelTemetesHelye;
        private System.Windows.Forms.ComboBox cbSirkoKripta;
        private System.Windows.Forms.Label labelSirkoKripta;
        private System.Windows.Forms.ComboBox cbT_I_ORA;
        private System.Windows.Forms.ComboBox cbT_I_PERC;
        private System.Windows.Forms.Label label2;
    }
}