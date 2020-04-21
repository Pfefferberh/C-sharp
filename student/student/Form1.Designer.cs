namespace student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anketa));
            this.NameStud = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.hobby = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.Loads = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // NameStud
            // 
            this.NameStud.BackColor = System.Drawing.SystemColors.Window;
            this.NameStud.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NameStud.Location = new System.Drawing.Point(25, 54);
            this.NameStud.Name = "NameStud";
            this.NameStud.Size = new System.Drawing.Size(100, 20);
            this.NameStud.TabIndex = 0;
            this.NameStud.Text = "Name";
            this.NameStud.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameStud_MouseClick);
            this.NameStud.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NameStud_KeyUp);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(25, 81);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 20);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Surname";
            this.Surname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameStud_MouseClick);
            this.Surname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NameStud_KeyUp);
            // 
            // hobby
            // 
            this.hobby.Location = new System.Drawing.Point(131, 54);
            this.hobby.Name = "hobby";
            this.hobby.Size = new System.Drawing.Size(100, 20);
            this.hobby.TabIndex = 2;
            this.hobby.Text = "Hobby";
            this.hobby.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameStud_MouseClick);
            this.hobby.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NameStud_KeyUp);
            // 
            // Sex
            // 
            this.Sex.AutoCompleteCustomSource.AddRange(new string[] {
            "male",
            "female"});
            this.Sex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "male",
            "female"});
            this.Sex.Location = new System.Drawing.Point(131, 80);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(58, 21);
            this.Sex.TabIndex = 3;
            this.Sex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NameStud_KeyUp);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(25, 156);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(121, 28);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Save_KeyPress);
            this.Save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Save_MouseClick);
            // 
            // Loads
            // 
            this.Loads.Location = new System.Drawing.Point(185, 156);
            this.Loads.Name = "Loads";
            this.Loads.Size = new System.Drawing.Size(119, 28);
            this.Loads.TabIndex = 5;
            this.Loads.Text = "Load";
            this.Loads.UseVisualStyleBackColor = true;
            this.Loads.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Load_KeyPress);
            this.Loads.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Loads_MouseClick);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(249, 26);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(85, 75);
            this.Age.TabIndex = 6;
            this.Age.Text = "Age";
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(4, 26);
            this.Birthday.MaxDate = new System.DateTime(2020, 4, 19, 0, 0, 0, 0);
            this.Birthday.Name = "Birthday";
            this.Birthday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Birthday.Size = new System.Drawing.Size(227, 20);
            this.Birthday.TabIndex = 7;
            this.Birthday.Value = new System.DateTime(2020, 4, 19, 0, 0, 0, 0);
            this.Birthday.ValueChanged += new System.EventHandler(this.Birthday_ValueChanged);
            // 
            // Anketa
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 209);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Loads);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.hobby);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.NameStud);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(378, 248);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(378, 248);
            this.Name = "Anketa";
            this.ShowIcon = false;
            this.Text = "Anketa";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Anketa_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameStud;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox hobby;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Loads;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.DateTimePicker Birthday;
    }
}

