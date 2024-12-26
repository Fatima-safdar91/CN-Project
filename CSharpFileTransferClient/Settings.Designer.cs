
namespace CSharpFileTransferClient {
    partial class Settings {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxSimDownload = new System.Windows.Forms.NumericUpDown();
            this.btnApplySettings = new System.Windows.Forms.Button();
            this.numMaxSizeAllowed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDownloadsDirectory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSimDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSizeAllowed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max simultaneous download:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max size allowed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Downloads folder:";
            // 
            // numMaxSimDownload
            // 
            this.numMaxSimDownload.Location = new System.Drawing.Point(356, 46);
            this.numMaxSimDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numMaxSimDownload.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaxSimDownload.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxSimDownload.Name = "numMaxSimDownload";
            this.numMaxSimDownload.Size = new System.Drawing.Size(116, 26);
            this.numMaxSimDownload.TabIndex = 6;
            this.numMaxSimDownload.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.Location = new System.Drawing.Point(356, 209);
            this.btnApplySettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(116, 35);
            this.btnApplySettings.TabIndex = 7;
            this.btnApplySettings.Text = "Apply";
            this.btnApplySettings.UseVisualStyleBackColor = true;
            this.btnApplySettings.Click += new System.EventHandler(this.btnApplySettings_Click);
            // 
            // numMaxSizeAllowed
            // 
            this.numMaxSizeAllowed.Location = new System.Drawing.Point(356, 98);
            this.numMaxSizeAllowed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numMaxSizeAllowed.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numMaxSizeAllowed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxSizeAllowed.Name = "numMaxSizeAllowed";
            this.numMaxSizeAllowed.Size = new System.Drawing.Size(72, 26);
            this.numMaxSizeAllowed.TabIndex = 8;
            this.numMaxSizeAllowed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "MB";
            // 
            // txtDownloadsDirectory
            // 
            this.txtDownloadsDirectory.Location = new System.Drawing.Point(208, 151);
            this.txtDownloadsDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDownloadsDirectory.Name = "txtDownloadsDirectory";
            this.txtDownloadsDirectory.Size = new System.Drawing.Size(260, 26);
            this.txtDownloadsDirectory.TabIndex = 10;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 269);
            this.Controls.Add(this.txtDownloadsDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numMaxSizeAllowed);
            this.Controls.Add(this.btnApplySettings);
            this.Controls.Add(this.numMaxSimDownload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSimDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSizeAllowed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMaxSimDownload;
        private System.Windows.Forms.Button btnApplySettings;
        private System.Windows.Forms.NumericUpDown numMaxSizeAllowed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDownloadsDirectory;
    }
}