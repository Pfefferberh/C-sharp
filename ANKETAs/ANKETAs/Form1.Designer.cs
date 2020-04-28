namespace ANKETAs
{
    partial class Anketa
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
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.DomainUpDownHobby = new System.Windows.Forms.DomainUpDown();
            this.TextBoxHobby = new System.Windows.Forms.TextBox();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.DateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelLang = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(178, 199);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(99, 23);
            this.ButtonLoad.TabIndex = 28;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(178, 160);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(99, 23);
            this.ButtonSave.TabIndex = 12;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(177, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 121);
            this.PictureBox1.TabIndex = 27;
            this.PictureBox1.TabStop = false;
            // 
            // DomainUpDownHobby
            // 
            this.DomainUpDownHobby.Items.Add("Sport");
            this.DomainUpDownHobby.Items.Add("Music");
            this.DomainUpDownHobby.Items.Add("Art");
            this.DomainUpDownHobby.Items.Add("else");
            this.DomainUpDownHobby.Location = new System.Drawing.Point(12, 202);
            this.DomainUpDownHobby.Name = "DomainUpDownHobby";
            this.DomainUpDownHobby.ReadOnly = true;
            this.DomainUpDownHobby.Size = new System.Drawing.Size(131, 20);
            this.DomainUpDownHobby.TabIndex = 26;
            this.DomainUpDownHobby.Text = "Sport";
            this.DomainUpDownHobby.SelectedItemChanged += new System.EventHandler(this.DomainUpDownHobby_SelectedItemChanged);
            // 
            // TextBoxHobby
            // 
            this.TextBoxHobby.Location = new System.Drawing.Point(12, 228);
            this.TextBoxHobby.Name = "TextBoxHobby";
            this.TextBoxHobby.Size = new System.Drawing.Size(131, 20);
            this.TextBoxHobby.TabIndex = 25;
            this.TextBoxHobby.Text = "Enter your hobby";
            this.TextBoxHobby.Visible = false;
            // 
            // CheckBox5
            // 
            this.CheckBox5.AutoSize = true;
            this.CheckBox5.Location = new System.Drawing.Point(128, 180);
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.Size = new System.Drawing.Size(15, 14);
            this.CheckBox5.TabIndex = 24;
            this.CheckBox5.ThreeState = true;
            this.CheckBox5.UseVisualStyleBackColor = true;
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new System.Drawing.Point(84, 160);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(49, 17);
            this.CheckBox4.TabIndex = 23;
            this.CheckBox4.Text = "Java";
            this.CheckBox4.UseVisualStyleBackColor = true;
            this.CheckBox4.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(84, 136);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(59, 17);
            this.CheckBox3.TabIndex = 20;
            this.CheckBox3.Text = "Python";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(12, 160);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(40, 17);
            this.CheckBox2.TabIndex = 22;
            this.CheckBox2.Text = "C#";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(12, 136);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(45, 17);
            this.CheckBox1.TabIndex = 21;
            this.CheckBox1.Text = "C++";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // DateTimePickerBirth
            // 
            this.DateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerBirth.Location = new System.Drawing.Point(12, 91);
            this.DateTimePickerBirth.MaxDate = new System.DateTime(2020, 4, 28, 0, 0, 0, 0);
            this.DateTimePickerBirth.Name = "DateTimePickerBirth";
            this.DateTimePickerBirth.Size = new System.Drawing.Size(131, 20);
            this.DateTimePickerBirth.TabIndex = 19;
            this.DateTimePickerBirth.Value = new System.DateTime(2020, 4, 28, 0, 0, 0, 0);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Location = new System.Drawing.Point(9, 180);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(113, 19);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Do you now English?";
            // 
            // LabelLang
            // 
            this.LabelLang.BackColor = System.Drawing.SystemColors.Control;
            this.LabelLang.Location = new System.Drawing.Point(9, 114);
            this.LabelLang.Name = "LabelLang";
            this.LabelLang.Size = new System.Drawing.Size(113, 19);
            this.LabelLang.TabIndex = 17;
            this.LabelLang.Text = "Program language";
            // 
            // LabelAge
            // 
            this.LabelAge.BackColor = System.Drawing.SystemColors.Control;
            this.LabelAge.Location = new System.Drawing.Point(9, 69);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(134, 19);
            this.LabelAge.TabIndex = 16;
            this.LabelAge.Text = "Choise your birthday";
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Location = new System.Drawing.Point(84, 38);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.RadioButtonFemale.TabIndex = 14;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            this.RadioButtonFemale.CheckedChanged += new System.EventHandler(this.RadioButtonFemale_CheckedChanged);
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Location = new System.Drawing.Point(12, 38);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.RadioButtonMale.TabIndex = 15;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            this.RadioButtonMale.CheckedChanged += new System.EventHandler(this.RadioButtonMale_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(130, 20);
            this.textBoxName.TabIndex = 29;
            this.textBoxName.Text = "Name";
            this.textBoxName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseClick);
            // 
            // Anketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 252);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.DomainUpDownHobby);
            this.Controls.Add(this.TextBoxHobby);
            this.Controls.Add(this.CheckBox5);
            this.Controls.Add(this.CheckBox4);
            this.Controls.Add(this.CheckBox3);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.DateTimePickerBirth);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabelLang);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.RadioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 291);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 291);
            this.Name = "Anketa";
            this.ShowIcon = false;
            this.Text = "Anketa";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonLoad;
        internal System.Windows.Forms.Button ButtonSave;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.DomainUpDown DomainUpDownHobby;
        internal System.Windows.Forms.TextBox TextBoxHobby;
        internal System.Windows.Forms.CheckBox CheckBox5;
        internal System.Windows.Forms.CheckBox CheckBox4;
        internal System.Windows.Forms.CheckBox CheckBox3;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.DateTimePicker DateTimePickerBirth;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabelLang;
        internal System.Windows.Forms.Label LabelAge;
        internal System.Windows.Forms.RadioButton RadioButtonFemale;
        internal System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

