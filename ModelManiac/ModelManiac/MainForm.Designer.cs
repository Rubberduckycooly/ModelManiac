namespace ModelManiac
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wireFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importModelFromstlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FramesBox = new System.Windows.Forms.ListBox();
            this.FramePreviewBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RotationYBar = new System.Windows.Forms.TrackBar();
            this.RotationZBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScaleXNUD = new System.Windows.Forms.NumericUpDown();
            this.ScaleYNUD = new System.Windows.Forms.NumericUpDown();
            this.ModelPreviewBox = new ImageBox.ImageBox();
            this.RotationXBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.ScaleZNUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.FramePreviewBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationYBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationZBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleXNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleYNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationXBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleZNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wireFrameToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // wireFrameToolStripMenuItem
            // 
            this.wireFrameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.wireFrameToolStripMenuItem.CheckOnClick = true;
            this.wireFrameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wireFrameToolStripMenuItem.Name = "wireFrameToolStripMenuItem";
            this.wireFrameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.wireFrameToolStripMenuItem.Text = "WireFrame";
            this.wireFrameToolStripMenuItem.Click += new System.EventHandler(this.WireFrameToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importModelFromstlToolStripMenuItem,
            this.exportToToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // importModelFromstlToolStripMenuItem
            // 
            this.importModelFromstlToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.importModelFromstlToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.importModelFromstlToolStripMenuItem.Name = "importModelFromstlToolStripMenuItem";
            this.importModelFromstlToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.importModelFromstlToolStripMenuItem.Text = "Import Model";
            this.importModelFromstlToolStripMenuItem.Click += new System.EventHandler(this.importModelFromstlToolStripMenuItem_Click);
            // 
            // exportToToolStripMenuItem
            // 
            this.exportToToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.exportToToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exportToToolStripMenuItem.Name = "exportToToolStripMenuItem";
            this.exportToToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.exportToToolStripMenuItem.Text = "Export Model";
            this.exportToToolStripMenuItem.Click += new System.EventHandler(this.exportToToolStripMenuItem_Click);
            // 
            // FramesBox
            // 
            this.FramesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.FramesBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FramesBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FramesBox.FormattingEnabled = true;
            this.FramesBox.ItemHeight = 16;
            this.FramesBox.Location = new System.Drawing.Point(0, 28);
            this.FramesBox.Name = "FramesBox";
            this.FramesBox.Size = new System.Drawing.Size(159, 562);
            this.FramesBox.TabIndex = 13;
            this.FramesBox.SelectedIndexChanged += new System.EventHandler(this.FramesBox_SelectedIndexChanged);
            // 
            // FramePreviewBox
            // 
            this.FramePreviewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.FramePreviewBox.Controls.Add(this.ScaleZNUD);
            this.FramePreviewBox.Controls.Add(this.label6);
            this.FramePreviewBox.Controls.Add(this.RotationXBar);
            this.FramePreviewBox.Controls.Add(this.label5);
            this.FramePreviewBox.Controls.Add(this.ScaleYNUD);
            this.FramePreviewBox.Controls.Add(this.ScaleXNUD);
            this.FramePreviewBox.Controls.Add(this.label4);
            this.FramePreviewBox.Controls.Add(this.label3);
            this.FramePreviewBox.Controls.Add(this.RotationZBar);
            this.FramePreviewBox.Controls.Add(this.label2);
            this.FramePreviewBox.Controls.Add(this.RotationYBar);
            this.FramePreviewBox.Controls.Add(this.label1);
            this.FramePreviewBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FramePreviewBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FramePreviewBox.Location = new System.Drawing.Point(159, 356);
            this.FramePreviewBox.Name = "FramePreviewBox";
            this.FramePreviewBox.Size = new System.Drawing.Size(782, 234);
            this.FramePreviewBox.TabIndex = 14;
            this.FramePreviewBox.TabStop = false;
            this.FramePreviewBox.Text = "Frame Preview Options";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox1.Controls.Add(this.ModelPreviewBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(159, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 328);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame Preview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rotation Y:";
            // 
            // RotationYBar
            // 
            this.RotationYBar.LargeChange = 10;
            this.RotationYBar.Location = new System.Drawing.Point(87, 97);
            this.RotationYBar.Maximum = 255;
            this.RotationYBar.Name = "RotationYBar";
            this.RotationYBar.Size = new System.Drawing.Size(342, 56);
            this.RotationYBar.TabIndex = 1;
            this.RotationYBar.Scroll += new System.EventHandler(this.RotationYBar_Scroll);
            // 
            // RotationZBar
            // 
            this.RotationZBar.LargeChange = 10;
            this.RotationZBar.Location = new System.Drawing.Point(87, 159);
            this.RotationZBar.Maximum = 255;
            this.RotationZBar.Name = "RotationZBar";
            this.RotationZBar.Size = new System.Drawing.Size(342, 56);
            this.RotationZBar.TabIndex = 3;
            this.RotationZBar.Scroll += new System.EventHandler(this.RotationZBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rotation Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scale X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Scale Y:";
            // 
            // ScaleXNUD
            // 
            this.ScaleXNUD.Location = new System.Drawing.Point(519, 20);
            this.ScaleXNUD.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ScaleXNUD.Name = "ScaleXNUD";
            this.ScaleXNUD.Size = new System.Drawing.Size(62, 22);
            this.ScaleXNUD.TabIndex = 6;
            this.ScaleXNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScaleXNUD.ValueChanged += new System.EventHandler(this.ScaleXNUD_ValueChanged);
            // 
            // ScaleYNUD
            // 
            this.ScaleYNUD.Location = new System.Drawing.Point(519, 48);
            this.ScaleYNUD.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ScaleYNUD.Name = "ScaleYNUD";
            this.ScaleYNUD.Size = new System.Drawing.Size(62, 22);
            this.ScaleYNUD.TabIndex = 7;
            this.ScaleYNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScaleYNUD.ValueChanged += new System.EventHandler(this.ScaleYNUD_ValueChanged);
            // 
            // ModelPreviewBox
            // 
            this.ModelPreviewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ModelPreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelPreviewBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ModelPreviewBox.GridColorAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ModelPreviewBox.Location = new System.Drawing.Point(3, 18);
            this.ModelPreviewBox.Name = "ModelPreviewBox";
            this.ModelPreviewBox.Size = new System.Drawing.Size(776, 307);
            this.ModelPreviewBox.TabIndex = 1;
            // 
            // RotationXBar
            // 
            this.RotationXBar.LargeChange = 10;
            this.RotationXBar.Location = new System.Drawing.Point(87, 35);
            this.RotationXBar.Maximum = 255;
            this.RotationXBar.Name = "RotationXBar";
            this.RotationXBar.Size = new System.Drawing.Size(342, 56);
            this.RotationXBar.TabIndex = 9;
            this.RotationXBar.Value = 115;
            this.RotationXBar.Scroll += new System.EventHandler(this.RotationXBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rotation X:";
            // 
            // ScaleZNUD
            // 
            this.ScaleZNUD.Location = new System.Drawing.Point(519, 76);
            this.ScaleZNUD.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ScaleZNUD.Name = "ScaleZNUD";
            this.ScaleZNUD.Size = new System.Drawing.Size(62, 22);
            this.ScaleZNUD.TabIndex = 11;
            this.ScaleZNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScaleZNUD.ValueChanged += new System.EventHandler(this.ScaleZNUD_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Scale Z:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(941, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FramePreviewBox);
            this.Controls.Add(this.FramesBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ModelManiac";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FramePreviewBox.ResumeLayout(false);
            this.FramePreviewBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RotationYBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationZBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleXNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleYNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationXBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleZNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importModelFromstlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToToolStripMenuItem;
        private System.Windows.Forms.ListBox FramesBox;
        private System.Windows.Forms.GroupBox FramePreviewBox;
        private System.Windows.Forms.ToolStripMenuItem wireFrameToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ScaleYNUD;
        private System.Windows.Forms.NumericUpDown ScaleXNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar RotationZBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar RotationYBar;
        private System.Windows.Forms.Label label1;
        private ImageBox.ImageBox ModelPreviewBox;
        private System.Windows.Forms.NumericUpDown ScaleZNUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar RotationXBar;
        private System.Windows.Forms.Label label5;
    }
}

