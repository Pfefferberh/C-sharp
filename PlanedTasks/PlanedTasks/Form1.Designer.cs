namespace PlanedTasks
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
            this.ivent = new System.Windows.Forms.TextBox();
            this.placeIvent = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.important = new System.Windows.Forms.TextBox();
            this.addIvent = new System.Windows.Forms.Button();
            this.clearItem = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ivent
            // 
            this.ivent.Location = new System.Drawing.Point(22, 12);
            this.ivent.Name = "ivent";
            this.ivent.Size = new System.Drawing.Size(100, 20);
            this.ivent.TabIndex = 0;
            this.ivent.Text = "Name ivent";
            // 
            // placeIvent
            // 
            this.placeIvent.Location = new System.Drawing.Point(22, 49);
            this.placeIvent.Name = "placeIvent";
            this.placeIvent.Size = new System.Drawing.Size(100, 20);
            this.placeIvent.TabIndex = 1;
            this.placeIvent.Text = "Place ivent";
            this.placeIvent.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 9, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // important
            // 
            this.important.AutoCompleteCustomSource.AddRange(new string[] {
            "little",
            "midle",
            "hight"});
            this.important.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.important.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.important.Location = new System.Drawing.Point(22, 87);
            this.important.Name = "important";
            this.important.Size = new System.Drawing.Size(100, 20);
            this.important.TabIndex = 3;
            this.important.Text = "midle";
            this.important.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // addIvent
            // 
            this.addIvent.Location = new System.Drawing.Point(22, 127);
            this.addIvent.Name = "addIvent";
            this.addIvent.Size = new System.Drawing.Size(100, 23);
            this.addIvent.TabIndex = 4;
            this.addIvent.Text = "add to ivents";
            this.addIvent.UseVisualStyleBackColor = true;
            this.addIvent.Click += new System.EventHandler(this.addIvent_Click);
            // 
            // clearItem
            // 
            this.clearItem.Location = new System.Drawing.Point(22, 167);
            this.clearItem.Name = "clearItem";
            this.clearItem.Size = new System.Drawing.Size(100, 23);
            this.clearItem.TabIndex = 5;
            this.clearItem.Text = "clear items";
            this.clearItem.UseVisualStyleBackColor = true;
            this.clearItem.Click += new System.EventHandler(this.clearItem_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(22, 206);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 23);
            this.save.TabIndex = 6;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.Location = new System.Drawing.Point(207, 55);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(200, 173);
            this.listBoxItem.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 323);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clearItem);
            this.Controls.Add(this.addIvent);
            this.Controls.Add(this.important);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.placeIvent);
            this.Controls.Add(this.ivent);
            this.Name = "Form1";
            this.Text = "Item planer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ivent;
        private System.Windows.Forms.TextBox placeIvent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox important;
        private System.Windows.Forms.Button addIvent;
        private System.Windows.Forms.Button clearItem;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ListBox listBoxItem;
    }
}

