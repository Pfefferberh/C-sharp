namespace AZS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbMC = new System.Windows.Forms.GroupBox();
            this.numericUpDownCola = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFriPotato = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGamb = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHotdog = new System.Windows.Forms.NumericUpDown();
            this.cbCola = new System.Windows.Forms.CheckBox();
            this.cbGamb = new System.Windows.Forms.CheckBox();
            this.cbFriPotato = new System.Windows.Forms.CheckBox();
            this.tbCoastCola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHotdog = new System.Windows.Forms.CheckBox();
            this.tbCoastPot = new System.Windows.Forms.TextBox();
            this.tbCoastGam = new System.Windows.Forms.TextBox();
            this.tbCoastHdog = new System.Windows.Forms.TextBox();
            this.gbPayMC = new System.Windows.Forms.GroupBox();
            this.lbSumaMC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAll = new System.Windows.Forms.GroupBox();
            this.lbSumaALL = new System.Windows.Forms.Label();
            this.forPayAll = new System.Windows.Forms.Button();
            this.lgrnAll = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gBPayGS = new System.Windows.Forms.GroupBox();
            this.lbSumaGS = new System.Windows.Forms.Label();
            this.cbGas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lgrn = new System.Windows.Forms.Label();
            this.tbCoastGas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLiters = new System.Windows.Forms.RadioButton();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.tbLiters = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.gBGS = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFriPotato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHotdog)).BeginInit();
            this.gbPayMC.SuspendLayout();
            this.gbAll.SuspendLayout();
            this.gBPayGS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBGS.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMC
            // 
            this.gbMC.BackColor = System.Drawing.Color.Transparent;
            this.gbMC.Controls.Add(this.numericUpDownCola);
            this.gbMC.Controls.Add(this.numericUpDownFriPotato);
            this.gbMC.Controls.Add(this.numericUpDownGamb);
            this.gbMC.Controls.Add(this.numericUpDownHotdog);
            this.gbMC.Controls.Add(this.cbCola);
            this.gbMC.Controls.Add(this.cbGamb);
            this.gbMC.Controls.Add(this.cbFriPotato);
            this.gbMC.Controls.Add(this.tbCoastCola);
            this.gbMC.Controls.Add(this.label5);
            this.gbMC.Controls.Add(this.label4);
            this.gbMC.Controls.Add(this.cbHotdog);
            this.gbMC.Controls.Add(this.tbCoastPot);
            this.gbMC.Controls.Add(this.tbCoastGam);
            this.gbMC.Controls.Add(this.tbCoastHdog);
            this.gbMC.Controls.Add(this.gbPayMC);
            this.gbMC.ForeColor = System.Drawing.Color.Lavender;
            this.gbMC.Location = new System.Drawing.Point(337, 12);
            this.gbMC.Name = "gbMC";
            this.gbMC.Size = new System.Drawing.Size(300, 251);
            this.gbMC.TabIndex = 1;
            this.gbMC.TabStop = false;
            this.gbMC.Text = "MIni-Cafe";
            // 
            // numericUpDownCola
            // 
            this.numericUpDownCola.Location = new System.Drawing.Point(248, 126);
            this.numericUpDownCola.Name = "numericUpDownCola";
            this.numericUpDownCola.ReadOnly = true;
            this.numericUpDownCola.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownCola.TabIndex = 3;
            this.numericUpDownCola.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownFriPotato
            // 
            this.numericUpDownFriPotato.Location = new System.Drawing.Point(248, 100);
            this.numericUpDownFriPotato.Name = "numericUpDownFriPotato";
            this.numericUpDownFriPotato.ReadOnly = true;
            this.numericUpDownFriPotato.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownFriPotato.TabIndex = 3;
            this.numericUpDownFriPotato.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownGamb
            // 
            this.numericUpDownGamb.Location = new System.Drawing.Point(248, 72);
            this.numericUpDownGamb.Name = "numericUpDownGamb";
            this.numericUpDownGamb.ReadOnly = true;
            this.numericUpDownGamb.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownGamb.TabIndex = 3;
            this.numericUpDownGamb.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownHotdog
            // 
            this.numericUpDownHotdog.Location = new System.Drawing.Point(248, 47);
            this.numericUpDownHotdog.Name = "numericUpDownHotdog";
            this.numericUpDownHotdog.ReadOnly = true;
            this.numericUpDownHotdog.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownHotdog.TabIndex = 3;
            this.numericUpDownHotdog.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // cbCola
            // 
            this.cbCola.AutoSize = true;
            this.cbCola.Location = new System.Drawing.Point(21, 125);
            this.cbCola.Name = "cbCola";
            this.cbCola.Size = new System.Drawing.Size(74, 17);
            this.cbCola.TabIndex = 2;
            this.cbCola.Text = "Coca-cola";
            this.cbCola.UseVisualStyleBackColor = true;
            this.cbCola.CheckedChanged += new System.EventHandler(this.cbCola_CheckedChanged);
            // 
            // cbGamb
            // 
            this.cbGamb.AutoSize = true;
            this.cbGamb.Location = new System.Drawing.Point(21, 76);
            this.cbGamb.Name = "cbGamb";
            this.cbGamb.Size = new System.Drawing.Size(69, 17);
            this.cbGamb.TabIndex = 2;
            this.cbGamb.Text = "Gamburg";
            this.cbGamb.UseVisualStyleBackColor = true;
            this.cbGamb.CheckedChanged += new System.EventHandler(this.cbGamb_CheckedChanged);
            // 
            // cbFriPotato
            // 
            this.cbFriPotato.AutoSize = true;
            this.cbFriPotato.Location = new System.Drawing.Point(21, 99);
            this.cbFriPotato.Name = "cbFriPotato";
            this.cbFriPotato.Size = new System.Drawing.Size(70, 17);
            this.cbFriPotato.TabIndex = 2;
            this.cbFriPotato.Text = "Fri potato";
            this.cbFriPotato.UseVisualStyleBackColor = true;
            this.cbFriPotato.CheckedChanged += new System.EventHandler(this.cbFriPotato_CheckedChanged);
            // 
            // tbCoastCola
            // 
            this.tbCoastCola.Location = new System.Drawing.Point(171, 125);
            this.tbCoastCola.Name = "tbCoastCola";
            this.tbCoastCola.ReadOnly = true;
            this.tbCoastCola.Size = new System.Drawing.Size(50, 20);
            this.tbCoastCola.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Coast";
            // 
            // cbHotdog
            // 
            this.cbHotdog.AutoSize = true;
            this.cbHotdog.Location = new System.Drawing.Point(21, 52);
            this.cbHotdog.Name = "cbHotdog";
            this.cbHotdog.Size = new System.Drawing.Size(61, 17);
            this.cbHotdog.TabIndex = 2;
            this.cbHotdog.Text = "Hotdog";
            this.cbHotdog.UseVisualStyleBackColor = true;
            this.cbHotdog.CheckedChanged += new System.EventHandler(this.cbHotdog_CheckedChanged);
            // 
            // tbCoastPot
            // 
            this.tbCoastPot.Location = new System.Drawing.Point(171, 99);
            this.tbCoastPot.Name = "tbCoastPot";
            this.tbCoastPot.ReadOnly = true;
            this.tbCoastPot.Size = new System.Drawing.Size(50, 20);
            this.tbCoastPot.TabIndex = 1;
            // 
            // tbCoastGam
            // 
            this.tbCoastGam.Location = new System.Drawing.Point(171, 73);
            this.tbCoastGam.Name = "tbCoastGam";
            this.tbCoastGam.ReadOnly = true;
            this.tbCoastGam.Size = new System.Drawing.Size(50, 20);
            this.tbCoastGam.TabIndex = 1;
            // 
            // tbCoastHdog
            // 
            this.tbCoastHdog.Location = new System.Drawing.Point(171, 46);
            this.tbCoastHdog.Name = "tbCoastHdog";
            this.tbCoastHdog.ReadOnly = true;
            this.tbCoastHdog.Size = new System.Drawing.Size(50, 20);
            this.tbCoastHdog.TabIndex = 1;
            // 
            // gbPayMC
            // 
            this.gbPayMC.Controls.Add(this.lbSumaMC);
            this.gbPayMC.Controls.Add(this.label3);
            this.gbPayMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPayMC.ForeColor = System.Drawing.Color.Aqua;
            this.gbPayMC.Location = new System.Drawing.Point(21, 162);
            this.gbPayMC.Name = "gbPayMC";
            this.gbPayMC.Size = new System.Drawing.Size(257, 72);
            this.gbPayMC.TabIndex = 0;
            this.gbPayMC.TabStop = false;
            this.gbPayMC.Text = "For to pay";
            // 
            // lbSumaMC
            // 
            this.lbSumaMC.AutoSize = true;
            this.lbSumaMC.Location = new System.Drawing.Point(187, 38);
            this.lbSumaMC.Name = "lbSumaMC";
            this.lbSumaMC.Size = new System.Drawing.Size(0, 13);
            this.lbSumaMC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "grn.";
            // 
            // gbAll
            // 
            this.gbAll.BackColor = System.Drawing.Color.Transparent;
            this.gbAll.Controls.Add(this.lbSumaALL);
            this.gbAll.Controls.Add(this.forPayAll);
            this.gbAll.Controls.Add(this.lgrnAll);
            this.gbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAll.ForeColor = System.Drawing.Color.GhostWhite;
            this.gbAll.Location = new System.Drawing.Point(20, 269);
            this.gbAll.Name = "gbAll";
            this.gbAll.Size = new System.Drawing.Size(617, 77);
            this.gbAll.TabIndex = 2;
            this.gbAll.TabStop = false;
            this.gbAll.Text = "For to pay all";
            // 
            // lbSumaALL
            // 
            this.lbSumaALL.AutoSize = true;
            this.lbSumaALL.ForeColor = System.Drawing.Color.Red;
            this.lbSumaALL.Location = new System.Drawing.Point(430, 33);
            this.lbSumaALL.Name = "lbSumaALL";
            this.lbSumaALL.Size = new System.Drawing.Size(39, 13);
            this.lbSumaALL.TabIndex = 2;
            this.lbSumaALL.Text = "Coast";
            // 
            // forPayAll
            // 
            this.forPayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forPayAll.ForeColor = System.Drawing.Color.Red;
            this.forPayAll.Location = new System.Drawing.Point(26, 19);
            this.forPayAll.Name = "forPayAll";
            this.forPayAll.Size = new System.Drawing.Size(148, 40);
            this.forPayAll.TabIndex = 0;
            this.forPayAll.Text = "All";
            this.forPayAll.UseVisualStyleBackColor = true;
            this.forPayAll.Click += new System.EventHandler(this.forPayAll_Click);
            // 
            // lgrnAll
            // 
            this.lgrnAll.AutoSize = true;
            this.lgrnAll.ForeColor = System.Drawing.Color.Red;
            this.lgrnAll.Location = new System.Drawing.Point(483, 33);
            this.lgrnAll.Name = "lgrnAll";
            this.lgrnAll.Size = new System.Drawing.Size(29, 13);
            this.lgrnAll.TabIndex = 2;
            this.lgrnAll.Text = "grn.";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(331, 346);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // gBPayGS
            // 
            this.gBPayGS.BackColor = System.Drawing.Color.Transparent;
            this.gBPayGS.Controls.Add(this.lbSumaGS);
            this.gBPayGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBPayGS.ForeColor = System.Drawing.Color.Cyan;
            this.gBPayGS.Location = new System.Drawing.Point(20, 162);
            this.gBPayGS.Name = "gBPayGS";
            this.gBPayGS.Size = new System.Drawing.Size(257, 72);
            this.gBPayGS.TabIndex = 0;
            this.gBPayGS.TabStop = false;
            this.gBPayGS.Text = "For to pay";
            // 
            // lbSumaGS
            // 
            this.lbSumaGS.AutoSize = true;
            this.lbSumaGS.Location = new System.Drawing.Point(153, 38);
            this.lbSumaGS.Name = "lbSumaGS";
            this.lbSumaGS.Size = new System.Drawing.Size(39, 13);
            this.lbSumaGS.TabIndex = 2;
            this.lbSumaGS.Text = "Coast";
            // 
            // cbGas
            // 
            this.cbGas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGas.FormattingEnabled = true;
            this.cbGas.Location = new System.Drawing.Point(86, 19);
            this.cbGas.Name = "cbGas";
            this.cbGas.Size = new System.Drawing.Size(121, 21);
            this.cbGas.TabIndex = 1;
            this.cbGas.SelectedIndexChanged += new System.EventHandler(this.cbGas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coast";
            // 
            // lgrn
            // 
            this.lgrn.AutoSize = true;
            this.lgrn.BackColor = System.Drawing.Color.Transparent;
            this.lgrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lgrn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lgrn.Location = new System.Drawing.Point(229, 66);
            this.lgrn.Name = "lgrn";
            this.lgrn.Size = new System.Drawing.Size(29, 13);
            this.lgrn.TabIndex = 2;
            this.lgrn.Text = "grn.";
            // 
            // tbCoastGas
            // 
            this.tbCoastGas.Location = new System.Drawing.Point(86, 66);
            this.tbCoastGas.Name = "tbCoastGas";
            this.tbCoastGas.ReadOnly = true;
            this.tbCoastGas.Size = new System.Drawing.Size(121, 20);
            this.tbCoastGas.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbSuma);
            this.groupBox1.Controls.Add(this.tbLiters);
            this.groupBox1.Controls.Add(this.rbSuma);
            this.groupBox1.Controls.Add(this.rbLiters);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(20, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbLiters
            // 
            this.rbLiters.AutoSize = true;
            this.rbLiters.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.rbLiters.Location = new System.Drawing.Point(6, 10);
            this.rbLiters.Name = "rbLiters";
            this.rbLiters.Size = new System.Drawing.Size(56, 17);
            this.rbLiters.TabIndex = 0;
            this.rbLiters.TabStop = true;
            this.rbLiters.Text = "Liters";
            this.rbLiters.UseVisualStyleBackColor = true;
            this.rbLiters.CheckedChanged += new System.EventHandler(this.rbLiters_CheckedChanged);
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.rbSuma.Location = new System.Drawing.Point(6, 34);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(56, 17);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            this.rbSuma.CheckedChanged += new System.EventHandler(this.rbSuma_CheckedChanged);
            // 
            // tbLiters
            // 
            this.tbLiters.Location = new System.Drawing.Point(138, 12);
            this.tbLiters.Name = "tbLiters";
            this.tbLiters.ReadOnly = true;
            this.tbLiters.Size = new System.Drawing.Size(100, 20);
            this.tbLiters.TabIndex = 1;
            this.tbLiters.TextChanged += new System.EventHandler(this.tbLiters_TextChanged);
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(138, 33);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.ReadOnly = true;
            this.tbSuma.Size = new System.Drawing.Size(100, 20);
            this.tbSuma.TabIndex = 1;
            this.tbSuma.TextChanged += new System.EventHandler(this.tbSuma_TextChanged);
            // 
            // gBGS
            // 
            this.gBGS.BackColor = System.Drawing.Color.Transparent;
            this.gBGS.Controls.Add(this.groupBox1);
            this.gBGS.Controls.Add(this.tbCoastGas);
            this.gBGS.Controls.Add(this.lgrn);
            this.gBGS.Controls.Add(this.label2);
            this.gBGS.Controls.Add(this.label1);
            this.gBGS.Controls.Add(this.cbGas);
            this.gBGS.Controls.Add(this.gBPayGS);
            this.gBGS.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.gBGS.Location = new System.Drawing.Point(0, 0);
            this.gBGS.Name = "gBGS";
            this.gBGS.Size = new System.Drawing.Size(331, 346);
            this.gBGS.TabIndex = 0;
            this.gBGS.TabStop = false;
            this.gBGS.Text = "Gas station";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(653, 346);
            this.Controls.Add(this.gbAll);
            this.Controls.Add(this.gbMC);
            this.Controls.Add(this.gBGS);
            this.Controls.Add(this.splitter1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "AZS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMC.ResumeLayout(false);
            this.gbMC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFriPotato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHotdog)).EndInit();
            this.gbPayMC.ResumeLayout(false);
            this.gbPayMC.PerformLayout();
            this.gbAll.ResumeLayout(false);
            this.gbAll.PerformLayout();
            this.gBPayGS.ResumeLayout(false);
            this.gBPayGS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBGS.ResumeLayout(false);
            this.gBGS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbMC;
        private System.Windows.Forms.GroupBox gbPayMC;
        private System.Windows.Forms.CheckBox cbCola;
        private System.Windows.Forms.CheckBox cbGamb;
        private System.Windows.Forms.CheckBox cbFriPotato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbHotdog;
        private System.Windows.Forms.TextBox tbCoastCola;
        private System.Windows.Forms.TextBox tbCoastPot;
        private System.Windows.Forms.TextBox tbCoastGam;
        private System.Windows.Forms.TextBox tbCoastHdog;
        private System.Windows.Forms.Label lbSumaMC;
        private System.Windows.Forms.GroupBox gbAll;
        private System.Windows.Forms.Label lbSumaALL;
        private System.Windows.Forms.Button forPayAll;
        private System.Windows.Forms.Label lgrnAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCola;
        private System.Windows.Forms.NumericUpDown numericUpDownFriPotato;
        private System.Windows.Forms.NumericUpDown numericUpDownGamb;
        private System.Windows.Forms.NumericUpDown numericUpDownHotdog;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox gBPayGS;
        private System.Windows.Forms.Label lbSumaGS;
        private System.Windows.Forms.ComboBox cbGas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lgrn;
        private System.Windows.Forms.TextBox tbCoastGas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.TextBox tbLiters;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbLiters;
        private System.Windows.Forms.GroupBox gBGS;
        private System.Windows.Forms.Timer timer1;
    }
}

