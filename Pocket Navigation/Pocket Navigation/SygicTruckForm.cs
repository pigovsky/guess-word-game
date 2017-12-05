using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_Navigation
{
    public partial class SygicTruckForm : Form
    {
        // Create the file name string.
        string filename;
        // Create the webclient.
        WebClient client = new WebClient();
        public SygicTruckForm()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(36, 46, 59);
            bunifuProgressBar1.BackColor = Color.FromArgb(26, 32, 46);

        }

        private void SygicTruckForm_Load(object sender, EventArgs e)
        {

        }
        // Create the download void.
        private void DownloadFile(string url, string save)
        {
            // We need to add an using, so we can download another file after the first one completes. If we don't that it will not work.
            using (var client = new WebClient())
            {
                // Run code every time the download changes.
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Changed);
                // Run codes when file download has been completed.
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                // Start the download.
                client.DownloadFileAsync(new Uri(url), save);
            }
        }

        private void Changed(object sender, DownloadProgressChangedEventArgs e)
        {
            // Update the progress bar.
            bunifuProgressBar1.Value = e.ProgressPercentage;
            // Update status label.
            lblStatus.Text = "Status: downloading...";
            // Update progress label.
            lblProgress.Text = "Progress: downloaded " + (e.BytesReceived / 1024d / 1024d).ToString("0.00 MB") + " (" + e.BytesReceived + " bytes) of " + (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00 MB") + " (" + e.TotalBytesToReceive + " bytes) " + e.ProgressPercentage + "%";
            // Disable Download button.
            btnDownload.Enabled = false;
            // Enable Cancel button.
            btnCancel.Enabled = true;

        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // Run download canceled codes.
            if (e.Cancelled == true)
            {
                lblStatus.Text = "Status: download canceled.";
            }
            // Run download completed codes.
            else if (e.Cancelled == false)
            {
                lblStatus.Text = "Status: download completed!";
            }
            // Enable Download button.
            btnDownload.Enabled = true;
            // Disabled Cancel button.
            btnCancel.Enabled = false;
            // Reset the progress bar.
            bunifuProgressBar1.Value = 0;
        }
        private void Back_Program_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm f1 = new MainForm();
            f1.Show();
        }

        private void HideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Download_File_Click(object sender, EventArgs e)
        {
           
            string URL1 = "http://my-files.ru/Save/o48z3s/kodovaya tablica ASCII..png";
            string URL2 = "http://my-files.ru/Save/83pe2r/Actions-edit-clear-locationbar-rtl-icon.png";
            string URL3 = "http://my-files.ru/Save/llarqc/Black_Settings (1).png";
            string URL4 = "http://my-files.ru/Save/8tuhw2/igo-logo.png";
            string URL5 = "http://my-files.ru/Save/7gjrxk/krestik.png";
            string URL6 = "http://my-files.ru/Save/sfjvyr/sygic-truck-gps-navigation.png";
            string URL7 = "http://my-files.ru/Save/46mmf5/unnamed.png";
            string URL8 = "http://my-files.ru/Save/we9wrb/youtube (1).png";
            try
            {
                // Now we are going to create the function, that enter the file name automatically in the savefiledialog.
                Uri uri1 = new Uri(URL1);
                // Save the file name to the string.
                filename = Path.GetFileName(uri1.LocalPath);
                
            }
            catch
            {
                // Leave this blank, we don't need an exception message.
            }
            try
                {
               // FolderBrowserDialog choosecatalog = new FolderBrowserDialog();
                // Create a savefiledialog so the user can save the file.
                SaveFileDialog dialog = new SaveFileDialog();
                // Select the file type as all files.
                dialog.Filter = "All Files|*.*";
                    // Write the file name for the user.
                    dialog.FileName = filename;
                    // Open the dialog with dialogresult.
                    DialogResult result = dialog.ShowDialog();
                // Check if the user has clicked OK.

                if (result == DialogResult.OK)
                {
                    if(SygicTruckapkCheckbox1.Checked == true)
                    { 
                        // Start the download.
                        DownloadFile(URL1, dialog.FileName);
                    }
                  

                }

            }
            catch
                {
                    // Leave this blank, we don't need an exception message.
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Program_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string path = Application.StartupPath + @"";
        }
    }
}
