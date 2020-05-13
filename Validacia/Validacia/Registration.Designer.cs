namespace Validation
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.tbBirth = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBirth
            // 
            this.tbBirth.Location = new System.Drawing.Point(182, 29);
            this.tbBirth.Name = "tbBirth";
            this.tbBirth.Size = new System.Drawing.Size(42, 20);
            this.tbBirth.TabIndex = 10;
            this.tbBirth.Text = "0";
            this.tbBirth.Validating += new System.ComponentModel.CancelEventHandler(this.tbBirth_Validating);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRegister.Location = new System.Drawing.Point(21, 95);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(283, 32);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(179, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Age";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(21, 69);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(115, 20);
            this.tbSurname.TabIndex = 9;
            this.tbSurname.Validating += new System.ComponentModel.CancelEventHandler(this.tbSurname_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(182, 69);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(122, 20);
            this.tbNumber.TabIndex = 12;
            this.tbNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumber_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(179, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefon Number";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(21, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(115, 20);
            this.tbName.TabIndex = 7;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(321, 140);
            this.Controls.Add(this.tbBirth);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBirth;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

