namespace GifAnimate
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.fileBtn1 = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loop1 = new System.Windows.Forms.CheckBox();
            this.delay1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitAll1 = new System.Windows.Forms.SplitContainer();
            this.picture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitAll1)).BeginInit();
            this.splitAll1.Panel1.SuspendLayout();
            this.splitAll1.Panel2.SuspendLayout();
            this.splitAll1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.fileBtn1);
            this.splitContainer1.Panel2.Controls.Add(this.file1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.loop1);
            this.splitContainer1.Panel2.Controls.Add(this.delay1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2MinSize = 95;
            this.splitContainer1.Size = new System.Drawing.Size(288, 439);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 337);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create GIF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileBtn1
            // 
            this.fileBtn1.Location = new System.Drawing.Point(254, 35);
            this.fileBtn1.Name = "fileBtn1";
            this.fileBtn1.Size = new System.Drawing.Size(25, 20);
            this.fileBtn1.TabIndex = 5;
            this.fileBtn1.Text = "...";
            this.fileBtn1.UseVisualStyleBackColor = true;
            this.fileBtn1.Click += new System.EventHandler(this.fileBtn1_Click);
            // 
            // file1
            // 
            this.file1.Location = new System.Drawing.Point(70, 35);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(181, 20);
            this.file1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // loop1
            // 
            this.loop1.AutoSize = true;
            this.loop1.Checked = true;
            this.loop1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loop1.Location = new System.Drawing.Point(192, 8);
            this.loop1.Name = "loop1";
            this.loop1.Size = new System.Drawing.Size(50, 17);
            this.loop1.TabIndex = 2;
            this.loop1.Text = "Loop";
            this.loop1.UseVisualStyleBackColor = true;
            // 
            // delay1
            // 
            this.delay1.Location = new System.Drawing.Point(104, 7);
            this.delay1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.delay1.Name = "delay1";
            this.delay1.Size = new System.Drawing.Size(66, 20);
            this.delay1.TabIndex = 1;
            this.delay1.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frame delay (ms)";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "gif";
            this.saveFileDialog1.Filter = "GIF files|*.gif";
            this.saveFileDialog1.Title = "Save GIF file as...";
            // 
            // splitAll1
            // 
            this.splitAll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitAll1.Location = new System.Drawing.Point(5, 5);
            this.splitAll1.Margin = new System.Windows.Forms.Padding(0);
            this.splitAll1.Name = "splitAll1";
            // 
            // splitAll1.Panel1
            // 
            this.splitAll1.Panel1.Controls.Add(this.splitContainer1);
            this.splitAll1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            this.splitAll1.Panel1MinSize = 280;
            // 
            // splitAll1.Panel2
            // 
            this.splitAll1.Panel2.Controls.Add(this.picture1);
            this.splitAll1.Size = new System.Drawing.Size(849, 439);
            this.splitAll1.SplitterDistance = 288;
            this.splitAll1.SplitterWidth = 5;
            this.splitAll1.TabIndex = 1;
            // 
            // picture1
            // 
            this.picture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture1.Location = new System.Drawing.Point(0, 0);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(556, 439);
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 449);
            this.Controls.Add(this.splitAll1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Animated GIF creator (drag files into list)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delay1)).EndInit();
            this.splitAll1.Panel1.ResumeLayout(false);
            this.splitAll1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAll1)).EndInit();
            this.splitAll1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button fileBtn1;
        private System.Windows.Forms.TextBox file1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox loop1;
        private System.Windows.Forms.NumericUpDown delay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitAll1;
        private System.Windows.Forms.PictureBox picture1;
    }
}

