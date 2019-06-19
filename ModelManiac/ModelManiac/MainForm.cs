using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelManiac
{
    public partial class MainForm : Form
    {
        public string fileName;

        public int ModelType = 0; //1 = vB, 0 = v5

        public int CurFrame = 0;
        public int CurVertex = 0;
        public int CurColour = 0;

        public RSDKv5.Model Modelv5 = new RSDKv5.Model();
        public RSDKvB.Model ModelvB = new RSDKvB.Model();

        public MainForm()
        {
            InitializeComponent();
        }

        public void New()
        {
            RSDKv5.Model Modelv5 = new RSDKv5.Model();
            RSDKvB.Model ModelvB = new RSDKvB.Model();
            RefreshFrameList();
            RefreshUI();
        }

        public void Open(string filepath)
        {
            fileName = filepath;
            switch (ModelType)
            {
                case 0:
                    Modelv5 = new RSDKv5.Model(filepath);
                    RefreshFrameList();
                    RefreshUI();
                    break;
                case 1:
                    ModelvB = new RSDKvB.Model(filepath);
                    RefreshFrameList();
                    RefreshUI();
                    break;
            }
        }

        public void Save(string filepath)
        {
            fileName = filepath;
            switch (ModelType)
            {
                case 0:
                    Modelv5.Write(new RSDKv5.Writer(filepath));
                    break;
                case 1:
                    ModelvB.Write(new RSDKvB.Writer(filepath));
                    break;
            }
        }

        public void RefreshUI()
        {
            //Draw Frame
        }

        public void RefreshFrameList()
        {
            FramesBox.Items.Clear();
            switch (ModelType)
            {
                case 0:
                    for (int i = 0; i < Modelv5.FramesCount; i++)
                    {
                        FramesBox.Items.Add("Frame " + (i + 1));
                    }
                    break;
                case 1:
                    FramesBox.Items.Add("Model Data");
                    break;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "RSDKv5 Models|*.bin|RSDKvB Models|*.bin";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                ModelType = (dlg.FilterIndex-1);
                Open(dlg.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                Save(fileName);
            }
            else
            {
                saveAsToolStripMenuItem_Click(this, e);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "RSDKv5 Models|*.bin|RSDKvB Models|*.bin";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                ModelType = dlg.FilterIndex-1;
                Save(dlg.FileName);
            }
        }

        private void FramesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FramesBox.SelectedIndex >= 0)
            {
                CurFrame = FramesBox.SelectedIndex;
                RefreshUI();
            }
        }

        private void importModelFromstlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = ".obj Models|*obj|STL Models|*.stl|Binary STL Models|*stl";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                string ext = System.IO.Path.GetFileName(dlg.FileName);
                switch (ModelType)
                {
                    case 0:
                        switch ((dlg.FilterIndex - 1))
                        {
                            case 0:
                                Modelv5.WriteAsOBJ(dlg.FileName + ".obj", System.IO.Path.GetFileNameWithoutExtension(dlg.FileName));
                                Modelv5.WriteMTL(new RSDKv5.Writer(dlg.FileName + ".mtl"));
                                break;
                            case 1:
                                Modelv5.WriteAsSTL(dlg.FileName + ".stl");
                                break;
                            case 2:
                                Modelv5.WriteAsSTLBinary(new RSDKv5.Writer(dlg.FileName + ".stl"));
                                break;
                        }
                        break;
                    case 1:
                        switch (dlg.FilterIndex - 1)
                        {
                            case 0:
                                ModelvB.WriteAsOBJ(dlg.FileName + ".obj", System.IO.Path.GetFileNameWithoutExtension(dlg.FileName));
                                ModelvB.WriteMTL(new RSDKvB.Writer(dlg.FileName + ".mtl"));
                                break;
                            case 1:
                                ModelvB.WriteAsSTL(dlg.FileName + ".stl");
                                break;
                            case 2:
                                ModelvB.WriteAsSTLBinary(new RSDKvB.Writer(dlg.FileName + ".stl"));
                                break;
                        }
                        break;
                }
            }
        }

        private void AddFrameButton_Click(object sender, EventArgs e)
        {
            switch (ModelType)
            {
                case 0:
                    Modelv5.AddFrame();                    
                    break;
            }
            RefreshFrameList();
            RefreshUI();
        }

        private void DeleteFrameButton_Click(object sender, EventArgs e)
        {
            switch (ModelType)
            {
                case 0:
                    Modelv5.DeleteFrame(CurFrame);
                    if (CurFrame > 0) CurFrame--;
                    break;
            }
            RefreshFrameList();
            RefreshUI();
        }

    }
}
