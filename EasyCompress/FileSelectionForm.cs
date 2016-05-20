using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompressionLibrary;
using System.Text.RegularExpressions;

namespace EasyCompress
{
    public partial class FileSelectionForm : Form
    {
        public FileSelectionForm()
        {
            InitializeComponent();
        }

        //this initalises the filepath var with enough scope for both to access
        string filepath = "";

        private void BrowseButton_Click(object sender, EventArgs e)
        {


            //this opens a new file browser
            OpenFileDialog filebrowserDialog = new OpenFileDialog();
            //this checks to see if the user has clicked ok
            if (filebrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //get the filepath from the browserdialog
                filepath = filebrowserDialog.FileName;
                
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            //Regex to match the file extension
            Match match = Regex.Match(filepath, @"\.(.*)",
    RegexOptions.IgnoreCase);

            //initalise extension variable with enough scope
            string Extension = "";


            if (match.Success)
            {
                // Get the Group value
                Extension = match.Groups[1].Value;
            }
            else
            {
                ErrorLabel.Text = "Failed to parse extension";
            }

            Compression NewCompression = new Compression();
            Boolean Result = NewCompression.MainCompression(Extension, filepath);




            if (Result == true)
            {
                MessageBox.Show("Success!");
            }
            else if (Result == false)
            {
                ErrorLabel.Text = "File Type " + Extension + " Not Supported!";
            }
        }
    }
}
