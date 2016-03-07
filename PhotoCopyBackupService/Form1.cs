using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoCopyBackupService
{
    public partial class Form1 : Form
    {
        string sourcePath;
        string targetPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSourceBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog getSourcePathFolderDialog = new FolderBrowserDialog();
            getSourcePathFolderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            getSourcePathFolderDialog.ShowNewFolderButton = true;

            if (getSourcePathFolderDialog.ShowDialog() == DialogResult.OK)
            {
                sourcePath = getSourcePathFolderDialog.SelectedPath;
                textboxSource.Text = sourcePath;
            }
        }

        private void btnTargetBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog getTargetPathFolderDialog = new FolderBrowserDialog();
            getTargetPathFolderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            getTargetPathFolderDialog.ShowNewFolderButton = true;

            if (getTargetPathFolderDialog.ShowDialog() == DialogResult.OK)
            {
                targetPath = getTargetPathFolderDialog.SelectedPath;
                textboxTarget.Text = targetPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (BackupServiceBackgroundWorker.IsBusy != true)
            {
                BackupServiceBackgroundWorker.RunWorkerAsync();
            }
        }

        private void BackupServiceBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ImagesFolder folder = new ImagesFolder(sourcePath);
            folder.FillImagesList();
            folder.CopyFolder(targetPath);
        }
    }
}
