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
            this.ivent.Location = new System.Drawing.Point(22, 55);
            this.ivent.Name = "ivent";
            this.ivent.Size = new System.Drawing.Size(100, 20);
            this.ivent.TabIndex = 1;
            this.ivent.Text = "Name ivent";
            this.ivent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ivent_MouseDown);
            // 
            // placeIvent
            // 
            this.placeIvent.Location = new System.Drawing.Point(22, 110);
            this.placeIvent.Name = "placeIvent";
            this.placeIvent.Size = new System.Drawing.Size(100, 20);
            this.placeIvent.TabIndex = 2;
            this.placeIvent.Text = "Place ivent";
            this.placeIvent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ivent_MouseDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 12);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 4, 16, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 16, 0, 0, 0, 0);
            // 
            // important
            // 
            this.important.AutoCompleteCustomSource.AddRange(new string[] {
            "little",
            "midle",
            "hight"});
            this.important.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.important.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.important.Location = new System.Drawing.Point(22, 169);
            this.important.Name = "important";
            this.important.Size = new System.Drawing.Size(100, 20);
            this.important.TabIndex = 3;
            this.important.Text = "midlle";
            this.important.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ivent_MouseDown);
            // 
            // addIvent
            // 
            this.addIvent.Location = new System.Drawing.Point(21, 236);
            this.addIvent.Name = "addIvent";
            this.addIvent.Size = new System.Drawing.Size(100, 23);
            this.addIvent.TabIndex = 5;
            this.addIvent.Text = "add to ivents";
            this.addIvent.UseVisualStyleBackColor = true;
            this.addIvent.Click += new System.EventHandler(this.addIvent_Click);
            // 
            // clearItem
            // 
            this.clearItem.Location = new System.Drawing.Point(162, 236);
            this.clearItem.Name = "clearItem";
            this.clearItem.Size = new System.Drawing.Size(100, 23);
            this.clearItem.TabIndex = 6;
            this.clearItem.Text = "clear items";
            this.clearItem.UseVisualStyleBackColor = true;
            this.clearItem.Click += new System.EventHandler(this.clearItem_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(306, 236);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 23);
            this.save.TabIndex = 7;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.Location = new System.Drawing.Point(148, 55);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(259, 134);
            this.listBoxItem.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(422, 289);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clearItem);
            this.Controls.Add(this.addIvent);
            this.Controls.Add(this.important);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.placeIvent);
            this.Controls.Add(this.ivent);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Item planer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ivent_MouseClick);
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

