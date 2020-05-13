namespace TelefonBook
{
    partial class Child
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Child));
            this.pictureBoxLoadF = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNumb = new System.Windows.Forms.TextBox();
            this.buttonChoisFoto = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLoadF
            // 
            this.pictureBoxLoadF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLoadF.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadF.Image")));
            this.pictureBoxLoadF.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLoadF.Name = "pictureBoxLoadF";
            this.pictureBoxLoadF.Size = new System.Drawing.Size(128, 101);
            this.pictureBoxLoadF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoadF.TabIndex = 0;
            this.pictureBoxLoadF.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 120);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(127, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxNumb
            // 
            this.textBoxNumb.Location = new System.Drawing.Point(13, 146);
            this.textBoxNumb.Name = "textBoxNumb";
            this.textBoxNumb.Size = new System.Drawing.Size(127, 20);
            this.textBoxNumb.TabIndex = 1;
            // 
            // buttonChoisFoto
            // 
            this.buttonChoisFoto.Location = new System.Drawing.Point(13, 173);
            this.buttonChoisFoto.Name = "buttonChoisFoto";
            this.buttonChoisFoto.Size = new System.Drawing.Size(127, 23);
            this.buttonChoisFoto.TabIndex = 2;
            this.buttonChoisFoto.Text = "Load foto";
            this.buttonChoisFoto.UseVisualStyleBackColor = true;
            this.buttonChoisFoto.Click += new System.EventHandler(this.buttonChoisFoto_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 202);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 238);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonChoisFoto);
            this.Controls.Add(this.textBoxNumb);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBoxLoadF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Child";
            this.ShowIcon = false;
            this.Text = "Child";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Child_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChoisFoto;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.PictureBox pictureBoxLoadF;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxNumb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}