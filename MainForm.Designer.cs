namespace RedDownload
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProcess = new Label();
            btnDownload = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtUrl = new TextBox();
            lblURL = new Label();
            lblOutput = new Label();
            txtOutputPath = new TextBox();
            btnBrowse = new Button();
            lblStatus = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblProcess
            // 
            lblProcess.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblProcess, 4);
            lblProcess.Dock = DockStyle.Bottom;
            lblProcess.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProcess.Location = new Point(113, 264);
            lblProcess.Name = "lblProcess";
            lblProcess.Size = new Size(411, 29);
            lblProcess.TabIndex = 0;
            lblProcess.Text = "\r\n-";
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.Transparent;
            btnDownload.Dock = DockStyle.Fill;
            btnDownload.FlatStyle = FlatStyle.Popup;
            btnDownload.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDownload.ForeColor = Color.Black;
            btnDownload.Location = new Point(113, 238);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(74, 23);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Menu;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.940712F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.05929F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Controls.Add(lblProcess, 1, 5);
            tableLayoutPanel1.Controls.Add(btnDownload, 1, 4);
            tableLayoutPanel1.Controls.Add(txtUrl, 1, 1);
            tableLayoutPanel1.Controls.Add(lblURL, 0, 1);
            tableLayoutPanel1.Controls.Add(lblOutput, 0, 2);
            tableLayoutPanel1.Controls.Add(txtOutputPath, 1, 2);
            tableLayoutPanel1.Controls.Add(btnBrowse, 4, 2);
            tableLayoutPanel1.Controls.Add(lblStatus, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7814445F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.30942F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.965773F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.4446068F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.920422F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.57834F));
            tableLayoutPanel1.Size = new Size(527, 293);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // txtUrl
            // 
            txtUrl.BackColor = Color.DimGray;
            txtUrl.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(txtUrl, 3);
            txtUrl.Dock = DockStyle.Fill;
            txtUrl.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUrl.Location = new Point(113, 52);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(340, 27);
            txtUrl.TabIndex = 2;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Dock = DockStyle.Fill;
            lblURL.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblURL.Location = new Point(3, 49);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(104, 30);
            lblURL.TabIndex = 3;
            lblURL.Text = "Youtube Url";
            lblURL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Dock = DockStyle.Fill;
            lblOutput.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutput.Location = new Point(3, 79);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(104, 29);
            lblOutput.TabIndex = 4;
            lblOutput.Text = "Output Path";
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtOutputPath
            // 
            txtOutputPath.BackColor = Color.DimGray;
            txtOutputPath.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(txtOutputPath, 3);
            txtOutputPath.Dock = DockStyle.Fill;
            txtOutputPath.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOutputPath.Location = new Point(113, 82);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(340, 27);
            txtOutputPath.TabIndex = 5;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Transparent;
            btnBrowse.Dock = DockStyle.Fill;
            btnBrowse.FlatStyle = FlatStyle.Popup;
            btnBrowse.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.Black;
            btnBrowse.Location = new Point(459, 82);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(65, 23);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse\r\n";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(3, 274);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(104, 19);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(527, 293);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Reds Music Downloader";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblProcess;
        private Button btnDownload;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtUrl;
        private Label lblURL;
        private Label lblOutput;
        private TextBox txtOutputPath;
        private Button btnBrowse;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label lblStatus;
    }
}
