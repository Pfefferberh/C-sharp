namespace GameCommand
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
            this.lbcommand1 = new System.Windows.Forms.ListBox();
            this.lbAll = new System.Windows.Forms.ListBox();
            this.lbcommand2 = new System.Windows.Forms.ListBox();
            this.btnTo1 = new System.Windows.Forms.Button();
            this.btnTo2 = new System.Windows.Forms.Button();
            this.btnSaveT1 = new System.Windows.Forms.Button();
            this.btnSaveT2 = new System.Windows.Forms.Button();
            this.domainUpDownShow = new System.Windows.Forms.DomainUpDown();
            this.lbShowCommand = new System.Windows.Forms.ListBox();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFrom1 = new System.Windows.Forms.Button();
            this.btnFrom2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcommand1
            // 
            this.lbcommand1.FormattingEnabled = true;
            this.lbcommand1.Location = new System.Drawing.Point(12, 12);
            this.lbcommand1.Name = "lbcommand1";
            this.lbcommand1.Size = new System.Drawing.Size(151, 147);
            this.lbcommand1.TabIndex = 0;
            // 
            // lbAll
            // 
            this.lbAll.FormattingEnabled = true;
            this.lbAll.Location = new System.Drawing.Point(231, 12);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(151, 147);
            this.lbAll.TabIndex = 0;
            // 
            // lbcommand2
            // 
            this.lbcommand2.FormattingEnabled = true;
            this.lbcommand2.Location = new System.Drawing.Point(450, 12);
            this.lbcommand2.Name = "lbcommand2";
            this.lbcommand2.Size = new System.Drawing.Size(151, 147);
            this.lbcommand2.TabIndex = 0;
            // 
            // btnTo1
            // 
            this.btnTo1.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTo1.Location = new System.Drawing.Point(169, 46);
            this.btnTo1.Name = "btnTo1";
            this.btnTo1.Size = new System.Drawing.Size(56, 53);
            this.btnTo1.TabIndex = 1;
            this.btnTo1.Text = "<<";
            this.btnTo1.UseVisualStyleBackColor = false;
            this.btnTo1.Click += new System.EventHandler(this.btnTo1_Click);
            // 
            // btnTo2
            // 
            this.btnTo2.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTo2.Location = new System.Drawing.Point(388, 46);
            this.btnTo2.Name = "btnTo2";
            this.btnTo2.Size = new System.Drawing.Size(56, 53);
            this.btnTo2.TabIndex = 1;
            this.btnTo2.Text = ">>";
            this.btnTo2.UseVisualStyleBackColor = false;
            this.btnTo2.Click += new System.EventHandler(this.btnTo2_Click);
            // 
            // btnSaveT1
            // 
            this.btnSaveT1.Location = new System.Drawing.Point(25, 194);
            this.btnSaveT1.Name = "btnSaveT1";
            this.btnSaveT1.Size = new System.Drawing.Size(120, 23);
            this.btnSaveT1.TabIndex = 2;
            this.btnSaveT1.Text = "Save Team 1";
            this.btnSaveT1.UseVisualStyleBackColor = true;
            this.btnSaveT1.Click += new System.EventHandler(this.btnSaveT1_Click);
            // 
            // btnSaveT2
            // 
            this.btnSaveT2.Location = new System.Drawing.Point(466, 194);
            this.btnSaveT2.Name = "btnSaveT2";
            this.btnSaveT2.Size = new System.Drawing.Size(120, 23);
            this.btnSaveT2.TabIndex = 2;
            this.btnSaveT2.Text = "Save Team 2";
            this.btnSaveT2.UseVisualStyleBackColor = true;
            this.btnSaveT2.Click += new System.EventHandler(this.btnSaveT2_Click);
            // 
            // domainUpDownShow
            // 
            this.domainUpDownShow.Location = new System.Drawing.Point(262, 272);
            this.domainUpDownShow.Name = "domainUpDownShow";
            this.domainUpDownShow.ReadOnly = true;
            this.domainUpDownShow.Size = new System.Drawing.Size(120, 20);
            this.domainUpDownShow.TabIndex = 4;
            this.domainUpDownShow.Text = "Team 1";
            this.domainUpDownShow.SelectedItemChanged += new System.EventHandler(this.domainUpDownShow_SelectedItemChanged);
            // 
            // lbShowCommand
            // 
            this.lbShowCommand.FormattingEnabled = true;
            this.lbShowCommand.Location = new System.Drawing.Point(12, 247);
            this.lbShowCommand.Name = "lbShowCommand";
            this.lbShowCommand.Size = new System.Drawing.Size(222, 95);
            this.lbShowCommand.TabIndex = 0;
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Location = new System.Drawing.Point(262, 455);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(191, 20);
            this.domainUpDown3.TabIndex = 4;
            this.domainUpDown3.Text = "domainUpDown1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count peoples in teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choise team for show";
            // 
            // btnFrom1
            // 
            this.btnFrom1.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFrom1.Location = new System.Drawing.Point(169, 106);
            this.btnFrom1.Name = "btnFrom1";
            this.btnFrom1.Size = new System.Drawing.Size(56, 53);
            this.btnFrom1.TabIndex = 1;
            this.btnFrom1.Text = ">>";
            this.btnFrom1.UseVisualStyleBackColor = false;
            this.btnFrom1.Click += new System.EventHandler(this.btnFrom1_Click);
            // 
            // btnFrom2
            // 
            this.btnFrom2.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFrom2.Location = new System.Drawing.Point(388, 105);
            this.btnFrom2.Name = "btnFrom2";
            this.btnFrom2.Size = new System.Drawing.Size(56, 53);
            this.btnFrom2.TabIndex = 1;
            this.btnFrom2.Text = "<<";
            this.btnFrom2.UseVisualStyleBackColor = false;
            this.btnFrom2.Click += new System.EventHandler(this.btnFrom2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(262, 197);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(615, 359);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainUpDown3);
            this.Controls.Add(this.domainUpDownShow);
            this.Controls.Add(this.btnSaveT2);
            this.Controls.Add(this.btnSaveT1);
            this.Controls.Add(this.btnFrom2);
            this.Controls.Add(this.btnTo2);
            this.Controls.Add(this.btnFrom1);
            this.Controls.Add(this.btnTo1);
            this.Controls.Add(this.lbcommand2);
            this.Controls.Add(this.lbShowCommand);
            this.Controls.Add(this.lbAll);
            this.Controls.Add(this.lbcommand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbcommand1;
        private System.Windows.Forms.ListBox lbAll;
        private System.Windows.Forms.ListBox lbcommand2;
        private System.Windows.Forms.Button btnTo1;
        private System.Windows.Forms.Button btnTo2;
        private System.Windows.Forms.Button btnSaveT1;
        private System.Windows.Forms.Button btnSaveT2;
        private System.Windows.Forms.DomainUpDown domainUpDownShow;
        private System.Windows.Forms.ListBox lbShowCommand;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFrom1;
        private System.Windows.Forms.Button btnFrom2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

