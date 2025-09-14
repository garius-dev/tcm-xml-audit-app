namespace XmlReader
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            btnSelectFolder = new Button();
            txtFolderPath = new TextBox();
            lblStatus = new Label();
            dgvResults = new DataGridView();
            panel1 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            btnSave = new Button();
            panel4 = new Panel();
            progressBar1 = new ProgressBar();
            pnlTopFrame = new Panel();
            lblFormTitle = new Label();
            pnlTopSideContainer = new Panel();
            btnConfig = new Button();
            picLogo = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            pnlTopFrame.SuspendLayout();
            pnlTopSideContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Cursor = Cursors.Hand;
            btnSelectFolder.Location = new Point(9, 5);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(140, 39);
            btnSelectFolder.TabIndex = 0;
            btnSelectFolder.Text = "Selecionar Pasta";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFolderPath.BackColor = Color.White;
            txtFolderPath.Font = new Font("Segoe UI", 14F);
            txtFolderPath.Location = new Point(6, 5);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.ReadOnly = true;
            txtFolderPath.Size = new Size(504, 39);
            txtFolderPath.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(6, 6);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(806, 57);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "--------";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.Location = new Point(6, 6);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(806, 298);
            dgvResults.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlTopFrame);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 525);
            panel1.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvResults);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 146);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(6);
            panel5.Size = new Size(818, 310);
            panel5.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(818, 82);
            panel2.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtFolderPath);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(6);
            panel7.Size = new Size(519, 54);
            panel7.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSave);
            panel6.Controls.Add(btnSelectFolder);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(519, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(6);
            panel6.Size = new Size(299, 54);
            panel6.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(155, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 39);
            btnSave.TabIndex = 1;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(progressBar1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 54);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(6);
            panel4.Size = new Size(818, 28);
            panel4.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(6, 6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(806, 16);
            progressBar1.TabIndex = 2;
            progressBar1.Visible = false;
            // 
            // pnlTopFrame
            // 
            pnlTopFrame.BackColor = Color.WhiteSmoke;
            pnlTopFrame.Controls.Add(lblFormTitle);
            pnlTopFrame.Controls.Add(pnlTopSideContainer);
            pnlTopFrame.Controls.Add(picLogo);
            pnlTopFrame.Dock = DockStyle.Top;
            pnlTopFrame.Location = new Point(0, 0);
            pnlTopFrame.Margin = new Padding(2);
            pnlTopFrame.Name = "pnlTopFrame";
            pnlTopFrame.Padding = new Padding(6);
            pnlTopFrame.Size = new Size(818, 64);
            pnlTopFrame.TabIndex = 8;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(46, 80, 159);
            lblFormTitle.Location = new Point(112, 6);
            lblFormTitle.Margin = new Padding(2, 0, 2, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Padding = new Padding(13, 0, 0, 0);
            lblFormTitle.Size = new Size(548, 52);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "XML Audit";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopSideContainer
            // 
            pnlTopSideContainer.Controls.Add(btnConfig);
            pnlTopSideContainer.Dock = DockStyle.Right;
            pnlTopSideContainer.Location = new Point(660, 6);
            pnlTopSideContainer.Margin = new Padding(0);
            pnlTopSideContainer.Name = "pnlTopSideContainer";
            pnlTopSideContainer.Padding = new Padding(6, 6, 5, 6);
            pnlTopSideContainer.Size = new Size(152, 52);
            pnlTopSideContainer.TabIndex = 2;
            pnlTopSideContainer.Visible = false;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(46, 80, 159);
            btnConfig.Cursor = Cursors.Hand;
            btnConfig.Dock = DockStyle.Right;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 98, 204);
            btnConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 105, 217);
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.ForeColor = Color.White;
            btnConfig.Location = new Point(109, 6);
            btnConfig.Margin = new Padding(2);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(38, 40);
            btnConfig.TabIndex = 10;
            btnConfig.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Left;
            picLogo.Image = Properties.Resources.logo_novo;
            picLogo.Location = new Point(6, 6);
            picLogo.Margin = new Padding(2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(106, 52);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(lblStatus);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 456);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(6);
            panel3.Size = new Size(818, 69);
            panel3.TabIndex = 5;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 80, 159);
            ClientSize = new Size(830, 537);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHome";
            Padding = new Padding(6);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XML Audit - Home";
            Load += frmHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pnlTopFrame.ResumeLayout(false);
            pnlTopSideContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectFolder;
        private TextBox txtFolderPath;
        private Label lblStatus;
        private DataGridView dgvResults;
        private Panel panel1;
        private Panel panel3;
        private ProgressBar progressBar1;
        private Panel pnlTopFrame;
        private Label lblFormTitle;
        private Panel pnlTopSideContainer;
        private Button btnConfig;
        private PictureBox picLogo;
        private Panel panel2;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel4;
        private Button btnSave;
    }
}
