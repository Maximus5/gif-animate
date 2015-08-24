using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gif.Components;

namespace GifAnimate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                listView1.Items.Add(file);
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem i in listView1.SelectedItems)
                    listView1.Items.Remove(i);
            }
        }

        bool ChooseFile()
        {
            saveFileDialog1.FileName = file1.Text;
            DialogResult lrc = saveFileDialog1.ShowDialog();
            if (lrc != DialogResult.OK)
                return false;
            file1.Text = saveFileDialog1.FileName;
            return (file1.Text != "");
        }

        private void fileBtn1_Click(object sender, EventArgs e)
        {
            ChooseFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count < 1)
            {
                MessageBox.Show("Drop source files first!", this.Text);
                return;
            }
            if ((file1.Text == "") && !ChooseFile())
            {
                return;
            }

            picture1.ImageLocation = "";

            Cursor.Current = Cursors.WaitCursor;

            String outputFilePath = file1.Text;
            AnimatedGifEncoder enc = new AnimatedGifEncoder();
            enc.Start(outputFilePath);
            enc.SetDelay((int)delay1.Value);
            //-1:no repeat,0:always repeat
            enc.SetRepeat(loop1.Checked ? 0 : -1);
            //for (int i = 0, count = imageFilePaths.Length; i < count; i++)
            foreach (ListViewItem i in listView1.Items)
            {
                enc.AddFrame(Image.FromFile(i.Text));
            }
            enc.Finish();

            picture1.ImageLocation = outputFilePath;

            Cursor.Current = Cursors.Default;
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picture1_Click(object sender, EventArgs e)
        {

        }
    }
}
