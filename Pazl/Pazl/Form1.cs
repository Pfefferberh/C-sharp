using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
           
            if (picture != pbSklad)
            tempPicBox.Image = picture.Image;
                picture.Image = tempImage;
            hScrollBar1_Scroll(null,null);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            tempImage = picture.Image;
            tempPicBox = picture;
            if (picture == pbSklad)
                imageList1.Images.RemoveAt(hScrollBar1.Value);
            picture.DoDragDrop(picture.Image, DragDropEffects.Copy);
        }
        private void Pazl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < imageList1.Images.Count; i++)
                pbSklad.Image = imageList1.Images[i];
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Maximum = imageList1.Images.Count-1;
            Text = imageList1.Images.Count.ToString();
            pbSklad.Image = imageList1.Images[hScrollBar1.Value];
        }
    }
}
