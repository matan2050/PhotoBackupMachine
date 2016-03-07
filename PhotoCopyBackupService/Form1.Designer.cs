namespace PhotoCopyBackupService
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
            this.textboxSource = new System.Windows.Forms.TextBox();
            this.textboxTarget = new System.Windows.Forms.TextBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.btnTargetBrowse = new System.Windows.Forms.Button();
            this.BackupServiceBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textboxSource
            // 
            this.textboxSource.Location = new System.Drawing.Point(117, 21);
            this.textboxSource.Name = "textboxSource";
            this.textboxSource.Size = new System.Drawing.Size(399, 20);
            this.textboxSource.TabIndex = 0;
            // 
            // textboxTarget
            // 
            this.textboxTarget.Location = new System.Drawing.Point(117, 59);
            this.textboxTarget.Name = "textboxTarget";
            this.textboxTarget.Size = new System.Drawing.Size(399, 20);
            this.textboxTarget.TabIndex = 1;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(18, 24);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(76, 13);
            this.labelSource.TabIndex = 2;
            this.labelSource.Text = "Source Folder:";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(18, 62);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(95, 13);
            this.labelTarget.TabIndex = 3;
            this.labelTarget.Text = "Destination Folder:";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(214, 102);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(227, 23);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(536, 19);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSourceBrowse.TabIndex = 5;
            this.btnSourceBrowse.Text = "Browse";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // btnTargetBrowse
            // 
            this.btnTargetBrowse.Location = new System.Drawing.Point(536, 57);
            this.btnTargetBrowse.Name = "btnTargetBrowse";
            this.btnTargetBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnTargetBrowse.TabIndex = 6;
            this.btnTargetBrowse.Text = "Browse";
            this.btnTargetBrowse.UseVisualStyleBackColor = true;
            this.btnTargetBrowse.Click += new System.EventHandler(this.btnTargetBrowse_Click);
            // 
            // BackupServiceBackgroundWorker
            // 
            this.BackupServiceBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackupServiceBackgroundWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 150);
            this.Controls.Add(this.btnTargetBrowse);
            this.Controls.Add(this.btnSourceBrowse);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.textboxTarget);
            this.Controls.Add(this.textboxSource);
            this.Name = "Form1";
            this.Text = "PhotoCopy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxSource;
        private System.Windows.Forms.TextBox textboxTarget;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.Button btnTargetBrowse;
        private System.ComponentModel.BackgroundWorker BackupServiceBackgroundWorker;
    }
}

