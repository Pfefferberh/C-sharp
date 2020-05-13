namespace TextEdit
{
    partial class TextEdits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEdits));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.TIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TIEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tSBold = new System.Windows.Forms.ToolStripButton();
            this.tSItalics = new System.Windows.Forms.ToolStripButton();
            this.tSUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSRight = new System.Windows.Forms.ToolStripButton();
            this.tSCenter = new System.Windows.Forms.ToolStripButton();
            this.tSLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSFontSize = new System.Windows.Forms.ToolStripButton();
            this.tSFontSizeUp = new System.Windows.Forms.ToolStripButton();
            this.tSFontSizeDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tSFontColor = new System.Windows.Forms.ToolStripButton();
            this.tSFontBackground = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tSListOffOn = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 52);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(776, 376);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.WordWrap = false;
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TIFile,
            this.TIEdit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // TIFile
            // 
            this.TIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TIFile.Name = "TIFile";
            this.TIFile.Size = new System.Drawing.Size(37, 20);
            this.TIFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save as..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // TIEdit
            // 
            this.TIEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.TIEdit.Name = "TIEdit";
            this.TIEdit.Size = new System.Drawing.Size(39, 20);
            this.TIEdit.Text = "Edit";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBold,
            this.tSItalics,
            this.tSUnderline,
            this.toolStripSeparator1,
            this.tSRight,
            this.tSCenter,
            this.tSLeft,
            this.toolStripSeparator2,
            this.tSFontSize,
            this.tSFontSizeUp,
            this.tSFontSizeDown,
            this.toolStripSeparator3,
            this.tSFontColor,
            this.tSFontBackground,
            this.toolStripSeparator4,
            this.tSListOffOn});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tSBold
            // 
            this.tSBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBold.Image = ((System.Drawing.Image)(resources.GetObject("tSBold.Image")));
            this.tSBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBold.Name = "tSBold";
            this.tSBold.Size = new System.Drawing.Size(23, 22);
            this.tSBold.Text = "toolStripButton1";
            this.tSBold.Click += new System.EventHandler(this.tSBold_Click);
            // 
            // tSItalics
            // 
            this.tSItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSItalics.Image = ((System.Drawing.Image)(resources.GetObject("tSItalics.Image")));
            this.tSItalics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSItalics.Name = "tSItalics";
            this.tSItalics.Size = new System.Drawing.Size(23, 22);
            this.tSItalics.Text = "toolStripButton2";
            this.tSItalics.Click += new System.EventHandler(this.tSItalics_Click);
            // 
            // tSUnderline
            // 
            this.tSUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tSUnderline.Image")));
            this.tSUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSUnderline.Name = "tSUnderline";
            this.tSUnderline.Size = new System.Drawing.Size(23, 22);
            this.tSUnderline.Text = "toolStripButton3";
            this.tSUnderline.Click += new System.EventHandler(this.tSUnderline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSRight
            // 
            this.tSRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSRight.Image = ((System.Drawing.Image)(resources.GetObject("tSRight.Image")));
            this.tSRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSRight.Name = "tSRight";
            this.tSRight.Size = new System.Drawing.Size(23, 22);
            this.tSRight.Text = "toolStripButton4";
            this.tSRight.Click += new System.EventHandler(this.tSRight_Click);
            // 
            // tSCenter
            // 
            this.tSCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSCenter.Image = ((System.Drawing.Image)(resources.GetObject("tSCenter.Image")));
            this.tSCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSCenter.Name = "tSCenter";
            this.tSCenter.Size = new System.Drawing.Size(23, 22);
            this.tSCenter.Text = "toolStripButton7";
            this.tSCenter.Click += new System.EventHandler(this.tSCenter_Click);
            // 
            // tSLeft
            // 
            this.tSLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSLeft.Image = ((System.Drawing.Image)(resources.GetObject("tSLeft.Image")));
            this.tSLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSLeft.Name = "tSLeft";
            this.tSLeft.Size = new System.Drawing.Size(23, 22);
            this.tSLeft.Text = "toolStripButton5";
            this.tSLeft.Click += new System.EventHandler(this.tSLeft_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tSFontSize
            // 
            this.tSFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSFontSize.Image = ((System.Drawing.Image)(resources.GetObject("tSFontSize.Image")));
            this.tSFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFontSize.Name = "tSFontSize";
            this.tSFontSize.Size = new System.Drawing.Size(23, 22);
            this.tSFontSize.Text = "toolStripButton1";
            this.tSFontSize.Click += new System.EventHandler(this.tSFontSize_Click);
            // 
            // tSFontSizeUp
            // 
            this.tSFontSizeUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSFontSizeUp.Image = ((System.Drawing.Image)(resources.GetObject("tSFontSizeUp.Image")));
            this.tSFontSizeUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFontSizeUp.Name = "tSFontSizeUp";
            this.tSFontSizeUp.Size = new System.Drawing.Size(23, 22);
            this.tSFontSizeUp.Text = "toolStripButton6";
            this.tSFontSizeUp.Click += new System.EventHandler(this.tSFontSizeUp_Click);
            // 
            // tSFontSizeDown
            // 
            this.tSFontSizeDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSFontSizeDown.Image = ((System.Drawing.Image)(resources.GetObject("tSFontSizeDown.Image")));
            this.tSFontSizeDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFontSizeDown.Name = "tSFontSizeDown";
            this.tSFontSizeDown.Size = new System.Drawing.Size(23, 22);
            this.tSFontSizeDown.Text = "toolStripButton8";
            this.tSFontSizeDown.Click += new System.EventHandler(this.tSFontSizeDown_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tSFontColor
            // 
            this.tSFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSFontColor.Image = ((System.Drawing.Image)(resources.GetObject("tSFontColor.Image")));
            this.tSFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFontColor.Name = "tSFontColor";
            this.tSFontColor.Size = new System.Drawing.Size(23, 22);
            this.tSFontColor.Text = "toolStripButton9";
            this.tSFontColor.Click += new System.EventHandler(this.tSFontColor_Click);
            // 
            // tSFontBackground
            // 
            this.tSFontBackground.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSFontBackground.Image = ((System.Drawing.Image)(resources.GetObject("tSFontBackground.Image")));
            this.tSFontBackground.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFontBackground.Name = "tSFontBackground";
            this.tSFontBackground.Size = new System.Drawing.Size(23, 22);
            this.tSFontBackground.Text = "toolStripButton10";
            this.tSFontBackground.Click += new System.EventHandler(this.tSFontBackground_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tSListOffOn
            // 
            this.tSListOffOn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSListOffOn.Image = ((System.Drawing.Image)(resources.GetObject("tSListOffOn.Image")));
            this.tSListOffOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSListOffOn.Name = "tSListOffOn";
            this.tSListOffOn.Size = new System.Drawing.Size(23, 22);
            this.tSListOffOn.Text = "toolStripButton11";
            this.tSListOffOn.Click += new System.EventHandler(this.tSListOffOn_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.cutToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.clearAllToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 92);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clearAllToolStripMenuItem.Text = "Clear all";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // TextEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TextEdit";
            this.Text = "TextEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TEdit_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem TIFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TIEdit;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tSBold;
        private System.Windows.Forms.ToolStripButton tSItalics;
        private System.Windows.Forms.ToolStripButton tSUnderline;
        private System.Windows.Forms.ToolStripButton tSRight;
        private System.Windows.Forms.ToolStripButton tSCenter;
        private System.Windows.Forms.ToolStripButton tSLeft;
        private System.Windows.Forms.ToolStripButton tSFontSizeUp;
        private System.Windows.Forms.ToolStripButton tSFontSizeDown;
        private System.Windows.Forms.ToolStripButton tSFontColor;
        private System.Windows.Forms.ToolStripButton tSFontBackground;
        private System.Windows.Forms.ToolStripButton tSListOffOn;
        private System.Windows.Forms.ToolStripButton tSFontSize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

