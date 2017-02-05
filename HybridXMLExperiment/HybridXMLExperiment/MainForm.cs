using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Generic;

using System.Linq;

namespace HybridXMLExperiment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Section for converting to compressed element tasks
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
            MessageBox.Show("Compressed Element Generated!");

        }

        //Section For Keyword Generation Tasks
        private void btnOpenFileKeywords_Click(object sender, EventArgs e)
        {
            OpenFileToGenerateKeywords.ShowDialog();
        }

        private void OpenFileToGenerateKeywords_FileOk(object sender, CancelEventArgs e)
        {
            txtOpenFileKeywords.Text = OpenFileToGenerateKeywords.FileName;            
            XmlDocument XDoc = new XmlDocument();
            XDoc.Load(OpenFileToGenerateKeywords.FileName);
            foreach (XmlNode thisNode in XDoc.DocumentElement.ChildNodes)
            {
                cmbBoxElementsKeywords.Items.Add(thisNode.Name);
            }

        }

        private void btnSaveFileKeywords_Click(object sender, EventArgs e)
        {
            SaveFileLocationKeywords.ShowDialog();
        }

        private void btnStartKeywordGeneration_Click(object sender, EventArgs e)
        {
            XmlDocument XDoc = new XmlDocument();
            KeywordGenerator KWG = new KeywordGenerator();
            List<KeywordGenerator.Counter> output = new List<KeywordGenerator.Counter>();

            KeywordGenerator.Counter CNT = new KeywordGenerator.Counter();
           
            XDoc.Load(txtOpenFileKeywords.Text);
            foreach (XmlNode thisNode in XDoc.DocumentElement.ChildNodes)
            {
                if (thisNode.Name == cmbBoxElementsKeywords.Text)
                {
                    string elementText = thisNode.InnerText;
                    //TODO Add logic to add new element and save new file
                    
                     output = KWG.KeywordGeneration(elementText, txtCommonWords.Text,5);
                    //CNT = List< KWG.KeywordGeneration(elementText, txtCommonWords.Text);




                    datagridKeywords.DataSource = output;// KWG.KeywordGeneration(elementText, txtCommonWords.Text);
                    datagridKeywords.Refresh();

                   


                }
            }

            XmlNode KWNode = XDoc.CreateElement("Keywords");
            
            
            foreach(KeywordGenerator.Counter kwc in output)
            {
                KWNode.InnerText += kwc.Word + " ";
            }            

            XDoc.DocumentElement.PrependChild(KWNode);     


            XDoc.Save(@txtSaveFileKeywords.Text);
            MessageBox.Show("Keyword Field Created!");

        }

        private void SaveFileLocationKeywords_FileOk(object sender, CancelEventArgs e)
        {
            txtSaveFileKeywords.Text = SaveFileLocationKeywords.FileName.ToString();
        }
    }
}
