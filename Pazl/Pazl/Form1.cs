using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pazl
{
    public partial class Pazl : Form
    {
        Image tempImage;
        PictureBox tempPicBox;
        public Pazl()
        {
            this.AllowDrop = true;
            InitializeComponent();

            pb1.AllowDrop = true;
            pb2.AllowDrop = true;
            pb3.AllowDrop = true;
            pb4.AllowDrop = true;
            pb5.AllowDrop = true;
            pb6.AllowDrop = true;
            pb7.AllowDrop = true;
            pb8.AllowDrop = true;
            pb9.AllowDrop = true;
            pb10.AllowDrop = true;
            pb11.AllowDrop = true;
            pb12.AllowDrop = true;
            pb13.AllowDrop = true;
            pb14.AllowDrop = true;
            pb15.AllowDrop = true;
            pb16.AllowDrop = true;
            pb17.AllowDrop = true;
            pb18.AllowDrop = true;
            pb19.AllowDrop = true;
            pb20.AllowDrop = true;
            pb21.AllowDrop = true;
            pb22.AllowDrop = true;
            pb23.AllowDrop = true;
            pb24.AllowDrop = true;
            pb25.AllowDrop = true;

            pbSklad.AllowDrop = true;
        }
        private void pictureBox1_DragEnter_1(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void pictureBox1_DragDrop_1(object sender, DragEventArgs e)
        {
            PictureBox picture = sender as PictureBox;

            if (picture.Name == pbSklad.Name && tempPicBox.Image != null)
            {
                imageList1.Images.Add(tempPicBox.Image);
                tempPicBox.Image = null;
                hScrollBar1.Maximum = hScrollBar1.Maximum + 1;
            }
            else if (tempPicBox.Name == pbSklad.Name && picture.Image != null)
            {              
                imageList1.Images.Add(picture.Image);
                hScrollBar1.Maximum = hScrollBar1.Maximum + 1;
                picture.Image = tempImage;
            }
            else if (picture != pbSklad)
            {
                tempPicBox.Image = picture.Image;
                picture.Image = tempImage;
            }
            hScrollBar1_Scroll(null, null);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox picture = sender as PictureBox;

            tempImage = picture.Image;
            tempPicBox = picture;

            if (picture.Name == pbSklad.Name)
            {
                imageList1.Images.RemoveAt(hScrollBar1.Value);
                hScrollBar1.Maximum = imageList1.Images.Count - 1;
            }
            if (imageList1.Images.Count == 0)
            {
                pbSklad.Visible = false;
                hScrollBar1.Visible = false;
            }
            picture.DoDragDrop(picture, DragDropEffects.Copy);
        }
        private void Pazl_Load(object sender, EventArgs e)
        {
            pbSklad.Image = imageList1.Images[0];
            hScrollBar1.Maximum = imageList1.Images.Count - 1;           
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pbSklad.Image = imageList1.Images[hScrollBar1.Value];
        }
    }
}
