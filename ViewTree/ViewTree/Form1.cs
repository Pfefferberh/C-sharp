﻿using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ViewTree
{
    public partial class PROVODNIIIIK : Form
    {
        public PROVODNIIIIK()
        {
            InitializeComponent();
            listView1.SmallImageList = imageListSmall; 
            listView1.LargeImageList = imageListBig;
            listView1.Columns.Add("Name",100);
            listView1.Columns.Add("Size",100);
            listView1.Columns.Add("Creation",100);
            listView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                FillDriveNodes();
        }
        private void FillDriveNodes()
        {
            try
            {
                TreeNode RootNode = new TreeNode { Text = folderBrowserDialog1.SelectedPath };
                FillTreeNode(RootNode, RootNode.Text);
                treeView1.Nodes.Add(RootNode);
            }
            catch (Exception ex) { }
        }
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }
        }
        void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
        // событие перед выделением узла
        void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void FillListView(string[] files, int i)
        {
            foreach (string file in files)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                lvi.ImageIndex = i;
                listView1.Items.Add(lvi);
            }
        }
        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            Refffffreeeshhh(treeView1.SelectedNode.FullPath);
            path = treeView1.SelectedNode.FullPath;
        }
        string path; 
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {      
            if ( string.IsNullOrEmpty(Path.GetExtension(path + "\\" + listView1.SelectedItems[0].Text)))
            {
                path += "\\" + listView1.SelectedItems[0].Text;
                Text = Path.GetExtension(path);
            Refffffreeeshhh(path);
            }
        }
        private void Refffffreeeshhh(string path)
        {
            listView1.Items.Clear();
            string[] folder = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            FillListView(folder, 1);
            FillListView(files, 0);
        }
        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }
        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }
        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
        private void detaliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfo = directoryInfo.GetFiles("*.*");
            DirectoryInfo[] info = directoryInfo.GetDirectories();

            foreach (var tem in fileInfo)
            {
                ListViewItem list = new ListViewItem();
                list.ImageIndex = 0;
                list.Text = tem.FullName.Remove(0, tem.FullName.LastIndexOf('\\') + 1);
                list.SubItems.Add(tem.Length.ToString()+" b");
                list.SubItems.Add(tem.CreationTime.ToString());
                listView1.Items.Add(list);
            }
            foreach (var tem in info)
            {
                ListViewItem list = new ListViewItem();
                list.ImageIndex = 1;
                list.Text = tem.FullName.Remove(0, tem.FullName.LastIndexOf('\\') + 1);
                list.SubItems.Add( " ");
                list.SubItems.Add(tem.CreationTime.ToString());
                listView1.Items.Add(list);
            }
        }
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List; 
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Path.GetExtension(path + "\\" + listView1.SelectedItems[0].Text)))
                Directory.Delete(path + "\\" + listView1.SelectedItems[0].Text);
            else 
                File.Delete(path + "\\" + listView1.SelectedItems[0].Text);
                listView1.SelectedItems[0].Remove();
        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path = path.Substring(0, path.LastIndexOf('\\'));
            Refffffreeeshhh(path);
        }
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteToolStripMenuItem_Click(null, null);
            if (e.KeyCode == Keys.Back)
                backToolStripMenuItem_Click(null, null);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text="Name: "+ listView1.SelectedItems[0].Text;
            toolStripStatusLabel2.Text = "Created: " + File.GetCreationTimeUtc(path+"\\" + listView1.SelectedItems[0].Text); 
        }
    }
}