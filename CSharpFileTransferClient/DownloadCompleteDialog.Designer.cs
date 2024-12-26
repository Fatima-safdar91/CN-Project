
namespace CSharpFileTransferClient {
    partial class DownloadCompleteDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOpenDownloads = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(107, 49);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(280, 25);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Download has been completed";
            // 
            // btnOpenDownloads
            // 
            this.btnOpenDownloads.Location = new System.Drawing.Point(63, 116);
            this.btnOpenDownloads.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenDownloads.Name = "btnOpenDownloads";
            this.btnOpenDownloads.Size = new System.Drawing.Size(171, 49);
            this.btnOpenDownloads.TabIndex = 1;
            this.btnOpenDownloads.Text = "Open Downloads";
            this.btnOpenDownloads.UseVisualStyleBackColor = true;
            this.btnOpenDownloads.Click += new System.EventHandler(this.btnOpenDownloads_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(259, 116);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DownloadCompleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 229);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenDownloads);
            this.Controls.Add(this.lblMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DownloadCompleteDialog";
            this.Text = "Download Complete";
            this.Load += new System.EventHandler(this.DownloadCompleteDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnOpenDownloads;
        private System.Windows.Forms.Button btnClose;
    }
}