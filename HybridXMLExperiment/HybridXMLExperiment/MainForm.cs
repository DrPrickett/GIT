using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace HybridXMLExperiment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void OpenFileToConvert_FileOk(object sender, CancelEventArgs e)
        {
            txtOpenFile.Text = OpenFileToConvert.FileName;
            XmlDocument XDoc = new XmlDocument();
            XDoc.Load(OpenFileToConvert.FileName);
            foreach (XmlNode thisNode in XDoc.DocumentElement.ChildNodes)
            {
                cmbBoxElements.Items.Add(thisNode.Name);
            }
            
        }

        private void SaveFileLocation_FileOk(object sender, CancelEventArgs e)
        {
            txtSaveFile.Text = SaveFileLocation.FileName;
        }

       
        private void btnOpenFileToConvert_Click(object sender, EventArgs e)
        {
            OpenFileToConvert.ShowDialog();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileLocation.ShowDialog();
        }
        private void btnStartConversion_Click(object sender, EventArgs e)
        {
            Compression COMP = new Compression();
            XmlDocument XDoc = new XmlDocument();
            XDoc.Load(@txtOpenFile.Text);
            foreach(XmlNode thisNode in XDoc.DocumentElement.ChildNodes)
            {
                if(thisNode.Name == cmbBoxElements.Text)
                {
                    string original = thisNode.InnerText;
                    thisNode.InnerText = COMP.CompressString(original);
                }
            }

            XDoc.Save(@txtSaveFile.Text);
            


        }
    }
}
