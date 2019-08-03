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
    public partial class NavitelForm : Form
    {
        // Create the file name string.
        string filename;
        // Create the webclient.
        WebClient client = new WebClient();
        public NavitelForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(36, 46, 59);
            this.bunifuProgressBar1.BackColor = Color.FromArgb(26, 32, 46);
        }

        private void Back_Program_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm f1 = new MainForm();
            f1.Show();
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
        private void Exit_Program_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NavitelForm_Load(object sender, EventArgs e)
        {

        }

        private void SygicTruckapkCheckbox3_OnChange(object sender, EventArgs e)
        {

        }

        private void BaseMapCheckbox8_OnChange(object sender, EventArgs e)
        {

        }

        private void UkraineCheckbox4_OnChange(object sender, EventArgs e)
        {

        }

        private void TruckEuropeCheckbox5_OnChange(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox6_OnChange(object sender, EventArgs e)
        {

        }

        private void SpeedcamCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void VoicesCheckbox7_OnChange(object sender, EventArgs e)
        {

        }

        private void InstructionsCheckbox9_OnChange(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string URL = "http://my-files.ru/Save/o48z3s/kodovaya tablica ASCII..png";
                           
            try
            {
                // Now we are going to create the function, that enter the file name automatically in the savefiledialog.
                Uri uri = new Uri(URL);
                // Save the file name to the string.
                filename = Path.GetFileName(uri.LocalPath);
            }
            catch
            {
                // Leave this blank, we don't need an exception message.
            }
            try
            {
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
                    // Start the download.
                    DownloadFile(URL, dialog.FileName);
                }
            }
            catch
            {
                // Leave this blank, we don't need an exception message.
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }
    }
}
