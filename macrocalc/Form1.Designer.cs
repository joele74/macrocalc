namespace macrocalc
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
            this.uscita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.proteine = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fibre = new System.Windows.Forms.ComboBox();
            this.grassi = new System.Windows.Forms.ComboBox();
            this.carbo = new System.Windows.Forms.ComboBox();
            this.Colazione = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mfco = new System.Windows.Forms.Label();
            this.mgco = new System.Windows.Forms.Label();
            this.mcco = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ccolazione = new System.Windows.Forms.Label();
            this.mpco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pranzo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cpranzo = new System.Windows.Forms.Label();
            this.mfp = new System.Windows.Forms.Label();
            this.mpp = new System.Windows.Forms.Label();
            this.mgp = new System.Windows.Forms.Label();
            this.mcp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Spuntino = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.cspuntino = new System.Windows.Forms.Label();
            this.mfs = new System.Windows.Forms.Label();
            this.mps = new System.Windows.Forms.Label();
            this.mgs = new System.Windows.Forms.Label();
            this.mcs = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Cena = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.ccena = new System.Windows.Forms.Label();
            this.mfce = new System.Windows.Forms.Label();
            this.mpce = new System.Windows.Forms.Label();
            this.mgce = new System.Windows.Forms.Label();
            this.mcce = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.allc = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.ctot = new System.Windows.Forms.Label();
            this.ptot = new System.Windows.Forms.Label();
            this.ftot = new System.Windows.Forms.Label();
            this.gtot = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.Colazione.SuspendLayout();
            this.Pranzo.SuspendLayout();
            this.Spuntino.SuspendLayout();
            this.Cena.SuspendLayout();
            this.SuspendLayout();
            // 
            // uscita
            // 
            this.uscita.ForeColor = System.Drawing.SystemColors.Control;
            this.uscita.Location = new System.Drawing.Point(977, 12);
            this.uscita.Name = "uscita";
            this.uscita.Size = new System.Drawing.Size(25, 25);
            this.uscita.TabIndex = 0;
            this.uscita.Text = "X";
            this.uscita.UseVisualStyleBackColor = true;
            this.uscita.Click += new System.EventHandler(this.uscita_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(423, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCEGLI UN CIBO";
            // 
            // proteine
            // 
            this.proteine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.proteine.FormattingEnabled = true;
            this.proteine.Items.AddRange(new object[] {
            "Fesa di tacchino",
            "Tonno",
            "Bistecca di manzo",
            "Petto di pollo"});
            this.proteine.Location = new System.Drawing.Point(86, 125);
            this.proteine.Name = "proteine";
            this.proteine.Size = new System.Drawing.Size(121, 23);
            this.proteine.TabIndex = 2;
            this.proteine.SelectedIndexChanged += new System.EventHandler(this.proteine_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Colazione",
            "Pranzo",
            "Spuntino",
            "Cena"});
            this.comboBox2.Location = new System.Drawing.Point(851, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // fibre
            // 
            this.fibre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fibre.FormattingEnabled = true;
            this.fibre.Items.AddRange(new object[] {
            "Broccoli",
            "Insalata",
            "Patate",
            "Fagioli"});
            this.fibre.Location = new System.Drawing.Point(668, 125);
            this.fibre.Name = "fibre";
            this.fibre.Size = new System.Drawing.Size(121, 23);
            this.fibre.TabIndex = 4;
            // 
            // grassi
            // 
            this.grassi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grassi.FormattingEnabled = true;
            this.grassi.Items.AddRange(new object[] {
            "Olio",
            "Burro"});
            this.grassi.Location = new System.Drawing.Point(488, 125);
            this.grassi.Name = "grassi";
            this.grassi.Size = new System.Drawing.Size(121, 23);
            this.grassi.TabIndex = 5;
            // 
            // carbo
            // 
            this.carbo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.carbo.FormattingEnabled = true;
            this.carbo.Items.AddRange(new object[] {
            "Riso Basmati",
            "Pasta",
            "Pane",
            "Pizzoccheri"});
            this.carbo.Location = new System.Drawing.Point(285, 125);
            this.carbo.Name = "carbo";
            this.carbo.Size = new System.Drawing.Size(121, 23);
            this.carbo.TabIndex = 6;
            // 
            // Colazione
            // 
            this.Colazione.Controls.Add(this.label12);
            this.Colazione.Controls.Add(this.label9);
            this.Colazione.Controls.Add(this.label6);
            this.Colazione.Controls.Add(this.label3);
            this.Colazione.Controls.Add(this.mfco);
            this.Colazione.Controls.Add(this.mgco);
            this.Colazione.Controls.Add(this.mcco);
            this.Colazione.Controls.Add(this.label23);
            this.Colazione.Controls.Add(this.label19);
            this.Colazione.Controls.Add(this.ccolazione);
            this.Colazione.Controls.Add(this.mpco);
            this.Colazione.ForeColor = System.Drawing.SystemColors.Control;
            this.Colazione.Location = new System.Drawing.Point(7, 439);
            this.Colazione.Name = "Colazione";
            this.Colazione.Size = new System.Drawing.Size(251, 121);
            this.Colazione.TabIndex = 7;
            this.Colazione.TabStop = false;
            this.Colazione.Enter += new System.EventHandler(this.Colazione_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "fibre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "grassi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "carbo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "proteine";
            // 
            // mfco
            // 
            this.mfco.AutoSize = true;
            this.mfco.Location = new System.Drawing.Point(193, 85);
            this.mfco.Name = "mfco";
            this.mfco.Size = new System.Drawing.Size(13, 15);
            this.mfco.TabIndex = 18;
            this.mfco.Text = "0";
            // 
            // mgco
            // 
            this.mgco.AutoSize = true;
            this.mgco.Location = new System.Drawing.Point(193, 58);
            this.mgco.Name = "mgco";
            this.mgco.Size = new System.Drawing.Size(13, 15);
            this.mgco.TabIndex = 17;
            this.mgco.Text = "0";
            // 
            // mcco
            // 
            this.mcco.AutoSize = true;
            this.mcco.Location = new System.Drawing.Point(79, 85);
            this.mcco.Name = "mcco";
            this.mcco.Size = new System.Drawing.Size(13, 15);
            this.mcco.TabIndex = 16;
            this.mcco.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(59, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 15);
            this.label23.TabIndex = 15;
            this.label23.Text = "calorie";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(79, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 15);
            this.label19.TabIndex = 14;
            this.label19.Text = "macro";
            // 
            // ccolazione
            // 
            this.ccolazione.AutoSize = true;
            this.ccolazione.Location = new System.Drawing.Point(107, 19);
            this.ccolazione.Name = "ccolazione";
            this.ccolazione.Size = new System.Drawing.Size(13, 15);
            this.ccolazione.TabIndex = 3;
            this.ccolazione.Text = "0";
            // 
            // mpco
            // 
            this.mpco.AutoSize = true;
            this.mpco.Location = new System.Drawing.Point(79, 58);
            this.mpco.Name = "mpco";
            this.mpco.Size = new System.Drawing.Size(13, 15);
            this.mpco.TabIndex = 2;
            this.mpco.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(94, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "colazione";
            // 
            // Pranzo
            // 
            this.Pranzo.Controls.Add(this.label4);
            this.Pranzo.Controls.Add(this.label5);
            this.Pranzo.Controls.Add(this.label24);
            this.Pranzo.Controls.Add(this.label8);
            this.Pranzo.Controls.Add(this.label20);
            this.Pranzo.Controls.Add(this.label11);
            this.Pranzo.Controls.Add(this.cpranzo);
            this.Pranzo.Controls.Add(this.mfp);
            this.Pranzo.Controls.Add(this.mpp);
            this.Pranzo.Controls.Add(this.mgp);
            this.Pranzo.Controls.Add(this.mcp);
            this.Pranzo.ForeColor = System.Drawing.SystemColors.Control;
            this.Pranzo.Location = new System.Drawing.Point(264, 439);
            this.Pranzo.Name = "Pranzo";
            this.Pranzo.Size = new System.Drawing.Size(244, 121);
            this.Pranzo.TabIndex = 8;
            this.Pranzo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "fibre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "grassi";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(83, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 15);
            this.label24.TabIndex = 16;
            this.label24.Text = "calorie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "carbo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(103, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 15);
            this.label20.TabIndex = 15;
            this.label20.Text = "macro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "proteine";
            // 
            // cpranzo
            // 
            this.cpranzo.AutoSize = true;
            this.cpranzo.Location = new System.Drawing.Point(131, 19);
            this.cpranzo.Name = "cpranzo";
            this.cpranzo.Size = new System.Drawing.Size(13, 15);
            this.cpranzo.TabIndex = 6;
            this.cpranzo.Text = "0";
            // 
            // mfp
            // 
            this.mfp.AutoSize = true;
            this.mfp.Location = new System.Drawing.Point(208, 85);
            this.mfp.Name = "mfp";
            this.mfp.Size = new System.Drawing.Size(13, 15);
            this.mfp.TabIndex = 26;
            this.mfp.Text = "0";
            // 
            // mpp
            // 
            this.mpp.AutoSize = true;
            this.mpp.Location = new System.Drawing.Point(94, 58);
            this.mpp.Name = "mpp";
            this.mpp.Size = new System.Drawing.Size(13, 15);
            this.mpp.TabIndex = 23;
            this.mpp.Text = "0";
            // 
            // mgp
            // 
            this.mgp.AutoSize = true;
            this.mgp.Location = new System.Drawing.Point(208, 58);
            this.mgp.Name = "mgp";
            this.mgp.Size = new System.Drawing.Size(13, 15);
            this.mgp.TabIndex = 25;
            this.mgp.Text = "0";
            // 
            // mcp
            // 
            this.mcp.AutoSize = true;
            this.mcp.Location = new System.Drawing.Point(94, 85);
            this.mcp.Name = "mcp";
            this.mcp.Size = new System.Drawing.Size(13, 15);
            this.mcp.TabIndex = 24;
            this.mcp.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(355, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "pranzo";
            // 
            // Spuntino
            // 
            this.Spuntino.Controls.Add(this.label31);
            this.Spuntino.Controls.Add(this.label32);
            this.Spuntino.Controls.Add(this.label25);
            this.Spuntino.Controls.Add(this.label33);
            this.Spuntino.Controls.Add(this.label21);
            this.Spuntino.Controls.Add(this.label34);
            this.Spuntino.Controls.Add(this.cspuntino);
            this.Spuntino.Controls.Add(this.mfs);
            this.Spuntino.Controls.Add(this.mps);
            this.Spuntino.Controls.Add(this.mgs);
            this.Spuntino.Controls.Add(this.mcs);
            this.Spuntino.ForeColor = System.Drawing.SystemColors.Control;
            this.Spuntino.Location = new System.Drawing.Point(514, 439);
            this.Spuntino.Name = "Spuntino";
            this.Spuntino.Size = new System.Drawing.Size(245, 121);
            this.Spuntino.TabIndex = 8;
            this.Spuntino.TabStop = false;
            this.Spuntino.Enter += new System.EventHandler(this.Spuntino_Enter);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(147, 85);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 15);
            this.label31.TabIndex = 38;
            this.label31.Text = "fibre";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(147, 58);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 15);
            this.label32.TabIndex = 37;
            this.label32.Text = "grassi";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(59, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 15);
            this.label25.TabIndex = 17;
            this.label25.Text = "calorie";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 85);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 15);
            this.label33.TabIndex = 36;
            this.label33.Text = "carbo";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(86, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 15);
            this.label21.TabIndex = 16;
            this.label21.Text = "macro";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 58);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(51, 15);
            this.label34.TabIndex = 35;
            this.label34.Text = "proteine";
            // 
            // cspuntino
            // 
            this.cspuntino.AutoSize = true;
            this.cspuntino.Location = new System.Drawing.Point(114, 19);
            this.cspuntino.Name = "cspuntino";
            this.cspuntino.Size = new System.Drawing.Size(13, 15);
            this.cspuntino.TabIndex = 4;
            this.cspuntino.Text = "0";
            // 
            // mfs
            // 
            this.mfs.AutoSize = true;
            this.mfs.Location = new System.Drawing.Point(196, 85);
            this.mfs.Name = "mfs";
            this.mfs.Size = new System.Drawing.Size(13, 15);
            this.mfs.TabIndex = 34;
            this.mfs.Text = "0";
            // 
            // mps
            // 
            this.mps.AutoSize = true;
            this.mps.Location = new System.Drawing.Point(82, 58);
            this.mps.Name = "mps";
            this.mps.Size = new System.Drawing.Size(13, 15);
            this.mps.TabIndex = 31;
            this.mps.Text = "0";
            // 
            // mgs
            // 
            this.mgs.AutoSize = true;
            this.mgs.Location = new System.Drawing.Point(196, 58);
            this.mgs.Name = "mgs";
            this.mgs.Size = new System.Drawing.Size(13, 15);
            this.mgs.TabIndex = 33;
            this.mgs.Text = "0";
            // 
            // mcs
            // 
            this.mcs.AutoSize = true;
            this.mcs.Location = new System.Drawing.Point(82, 85);
            this.mcs.Name = "mcs";
            this.mcs.Size = new System.Drawing.Size(13, 15);
            this.mcs.TabIndex = 32;
            this.mcs.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(599, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "spuntino";
            // 
            // Cena
            // 
            this.Cena.Controls.Add(this.label39);
            this.Cena.Controls.Add(this.label26);
            this.Cena.Controls.Add(this.label40);
            this.Cena.Controls.Add(this.label22);
            this.Cena.Controls.Add(this.label41);
            this.Cena.Controls.Add(this.label42);
            this.Cena.Controls.Add(this.ccena);
            this.Cena.Controls.Add(this.mfce);
            this.Cena.Controls.Add(this.mpce);
            this.Cena.Controls.Add(this.mgce);
            this.Cena.Controls.Add(this.mcce);
            this.Cena.ForeColor = System.Drawing.SystemColors.Control;
            this.Cena.Location = new System.Drawing.Point(765, 439);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(244, 121);
            this.Cena.TabIndex = 8;
            this.Cena.TabStop = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(154, 85);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 15);
            this.label39.TabIndex = 46;
            this.label39.Text = "fibre";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(67, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 15);
            this.label26.TabIndex = 18;
            this.label26.Text = "calorie";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(154, 58);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(37, 15);
            this.label40.TabIndex = 45;
            this.label40.Text = "grassi";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(87, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 15);
            this.label22.TabIndex = 17;
            this.label22.Text = "macro";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(16, 85);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(37, 15);
            this.label41.TabIndex = 44;
            this.label41.Text = "carbo";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(16, 58);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(51, 15);
            this.label42.TabIndex = 43;
            this.label42.Text = "proteine";
            // 
            // ccena
            // 
            this.ccena.AutoSize = true;
            this.ccena.Location = new System.Drawing.Point(115, 19);
            this.ccena.Name = "ccena";
            this.ccena.Size = new System.Drawing.Size(13, 15);
            this.ccena.TabIndex = 8;
            this.ccena.Text = "0";
            // 
            // mfce
            // 
            this.mfce.AutoSize = true;
            this.mfce.Location = new System.Drawing.Point(203, 85);
            this.mfce.Name = "mfce";
            this.mfce.Size = new System.Drawing.Size(13, 15);
            this.mfce.TabIndex = 42;
            this.mfce.Text = "0";
            // 
            // mpce
            // 
            this.mpce.AutoSize = true;
            this.mpce.Location = new System.Drawing.Point(89, 58);
            this.mpce.Name = "mpce";
            this.mpce.Size = new System.Drawing.Size(13, 15);
            this.mpce.TabIndex = 39;
            this.mpce.Text = "0";
            // 
            // mgce
            // 
            this.mgce.AutoSize = true;
            this.mgce.Location = new System.Drawing.Point(203, 58);
            this.mgce.Name = "mgce";
            this.mgce.Size = new System.Drawing.Size(13, 15);
            this.mgce.TabIndex = 41;
            this.mgce.Text = "0";
            // 
            // mcce
            // 
            this.mcce.AutoSize = true;
            this.mcce.Location = new System.Drawing.Point(89, 85);
            this.mcce.Name = "mcce";
            this.mcce.Size = new System.Drawing.Size(13, 15);
            this.mcce.TabIndex = 40;
            this.mcce.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(838, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "cena";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(114, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "proteine";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(334, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "carbo";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(523, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "grassi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(710, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 15);
            this.label17.TabIndex = 12;
            this.label17.Text = "fibre";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(889, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 15);
            this.label18.TabIndex = 13;
            this.label18.Text = "pasto";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(456, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 64);
            this.button1.TabIndex = 14;
            this.button1.Text = "insersci cibo nel pasto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allc
            // 
            this.allc.AutoSize = true;
            this.allc.ForeColor = System.Drawing.SystemColors.Control;
            this.allc.Location = new System.Drawing.Point(945, 378);
            this.allc.Name = "allc";
            this.allc.Size = new System.Drawing.Size(13, 15);
            this.allc.TabIndex = 15;
            this.allc.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.SystemColors.Control;
            this.label28.Location = new System.Drawing.Point(867, 378);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 15);
            this.label28.TabIndex = 17;
            this.label28.Text = "calorie totali";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.Control;
            this.label29.Location = new System.Drawing.Point(28, 208);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 15);
            this.label29.TabIndex = 18;
            this.label29.Text = "macro totali";
            // 
            // ctot
            // 
            this.ctot.AutoSize = true;
            this.ctot.ForeColor = System.Drawing.SystemColors.Control;
            this.ctot.Location = new System.Drawing.Point(114, 262);
            this.ctot.Name = "ctot";
            this.ctot.Size = new System.Drawing.Size(13, 15);
            this.ctot.TabIndex = 24;
            this.ctot.Text = "0";
            // 
            // ptot
            // 
            this.ptot.AutoSize = true;
            this.ptot.ForeColor = System.Drawing.SystemColors.Control;
            this.ptot.Location = new System.Drawing.Point(114, 235);
            this.ptot.Name = "ptot";
            this.ptot.Size = new System.Drawing.Size(13, 15);
            this.ptot.TabIndex = 23;
            this.ptot.Text = "0";
            // 
            // ftot
            // 
            this.ftot.AutoSize = true;
            this.ftot.ForeColor = System.Drawing.SystemColors.Control;
            this.ftot.Location = new System.Drawing.Point(114, 318);
            this.ftot.Name = "ftot";
            this.ftot.Size = new System.Drawing.Size(13, 15);
            this.ftot.TabIndex = 24;
            this.ftot.Text = "0";
            // 
            // gtot
            // 
            this.gtot.AutoSize = true;
            this.gtot.ForeColor = System.Drawing.SystemColors.Control;
            this.gtot.Location = new System.Drawing.Point(114, 291);
            this.gtot.Name = "gtot";
            this.gtot.Size = new System.Drawing.Size(13, 15);
            this.gtot.TabIndex = 23;
            this.gtot.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.SystemColors.Control;
            this.label30.Location = new System.Drawing.Point(28, 318);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(31, 15);
            this.label30.TabIndex = 27;
            this.label30.Text = "fibre";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.SystemColors.Control;
            this.label35.Location = new System.Drawing.Point(28, 262);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(37, 15);
            this.label35.TabIndex = 28;
            this.label35.Text = "carbo";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.SystemColors.Control;
            this.label36.Location = new System.Drawing.Point(28, 291);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(37, 15);
            this.label36.TabIndex = 25;
            this.label36.Text = "grassi";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ForeColor = System.Drawing.SystemColors.Control;
            this.label37.Location = new System.Drawing.Point(28, 235);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(51, 15);
            this.label37.TabIndex = 26;
            this.label37.Text = "proteine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1014, 572);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.ftot);
            this.Controls.Add(this.ctot);
            this.Controls.Add(this.gtot);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.ptot);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.allc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Cena);
            this.Controls.Add(this.Spuntino);
            this.Controls.Add(this.Pranzo);
            this.Controls.Add(this.Colazione);
            this.Controls.Add(this.carbo);
            this.Controls.Add(this.grassi);
            this.Controls.Add(this.fibre);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.proteine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uscita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Colazione.ResumeLayout(false);
            this.Colazione.PerformLayout();
            this.Pranzo.ResumeLayout(false);
            this.Pranzo.PerformLayout();
            this.Spuntino.ResumeLayout(false);
            this.Spuntino.PerformLayout();
            this.Cena.ResumeLayout(false);
            this.Cena.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button uscita;
        private Label label1;
        private ComboBox proteine;
        private ComboBox comboBox2;
        private ComboBox fibre;
        private ComboBox grassi;
        private ComboBox carbo;
        private GroupBox Colazione;
        private Label label2;
        private Label mpco;
        private GroupBox Pranzo;
        private Label label7;
        private GroupBox Spuntino;
        private Label label10;
        private GroupBox Cena;
        private Label label13;
        private Label cpranzo;
        private Label cspuntino;
        private Label ccena;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label23;
        private Label label19;
        private Label ccolazione;
        private Label label24;
        private Label label20;
        private Label label25;
        private Label label21;
        private Label label26;
        private Label label22;
        private Button button1;
        private Label allc;
        private Label mfco;
        private Label mgco;
        private Label mcco;
        private Label label12;
        private Label label9;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label11;
        private Label mfp;
        private Label mpp;
        private Label mgp;
        private Label mcp;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label mfs;
        private Label mps;
        private Label mgs;
        private Label mcs;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label mfce;
        private Label mpce;
        private Label mgce;
        private Label mcce;
        private Label label28;
        private Label label29;
        private Label ctot;
        private Label ptot;
        private Label ftot;
        private Label gtot;
        private Label label30;
        private Label label35;
        private Label label36;
        private Label label37;
    }
}