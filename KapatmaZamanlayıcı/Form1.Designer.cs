namespace KapatmaZamanlayıcı
{
    partial class KapatmaZamanlayiciForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KapatmaZamanlayiciForm));
            TopBarPanel = new Panel();
            ProgramIsimLabel = new Label();
            ProgramIcon = new PictureBox();
            MinimizePanel = new Panel();
            MinimizeLabel = new Label();
            ExitPanel = new Panel();
            ExitLabel = new Label();
            SaatTextBox = new TextBox();
            SaatLabel = new Label();
            DakikaLabel = new Label();
            DakikaTextBox = new TextBox();
            SaniyeLabel = new Label();
            SaniyeTextBox = new TextBox();
            KapatPanel = new Panel();
            KapatLabel = new Label();
            YenidenBaslatPanel = new Panel();
            YenidenBaslatLabel = new Label();
            AnaBildirimIcon = new NotifyIcon(components);
            UreticiLabel = new Label();
            ZamanlayaiciIptalPanel = new Panel();
            ZamanlayiciIptalLabel = new Label();
            AnaToolTip = new ToolTip(components);
            TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProgramIcon).BeginInit();
            MinimizePanel.SuspendLayout();
            ExitPanel.SuspendLayout();
            KapatPanel.SuspendLayout();
            YenidenBaslatPanel.SuspendLayout();
            ZamanlayaiciIptalPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopBarPanel
            // 
            TopBarPanel.BackColor = Color.AliceBlue;
            TopBarPanel.Controls.Add(ProgramIsimLabel);
            TopBarPanel.Controls.Add(ProgramIcon);
            TopBarPanel.Controls.Add(MinimizePanel);
            TopBarPanel.Controls.Add(ExitPanel);
            TopBarPanel.Dock = DockStyle.Top;
            TopBarPanel.Location = new Point(0, 0);
            TopBarPanel.Name = "TopBarPanel";
            TopBarPanel.Size = new Size(500, 35);
            TopBarPanel.TabIndex = 8;
            TopBarPanel.MouseDown += topBarPanel_MouseDown;
            TopBarPanel.MouseMove += topBarPanel_MouseMove;
            TopBarPanel.MouseUp += topBarPanel_MouseUp;
            // 
            // ProgramIsimLabel
            // 
            ProgramIsimLabel.Dock = DockStyle.Left;
            ProgramIsimLabel.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ProgramIsimLabel.Location = new Point(40, 0);
            ProgramIsimLabel.Name = "ProgramIsimLabel";
            ProgramIsimLabel.Size = new Size(158, 35);
            ProgramIsimLabel.TabIndex = 3;
            ProgramIsimLabel.Text = "Kapatma Zamanlayıcı";
            ProgramIsimLabel.TextAlign = ContentAlignment.MiddleCenter;
            ProgramIsimLabel.MouseDown += topBarPanel_MouseDown;
            ProgramIsimLabel.MouseMove += topBarPanel_MouseMove;
            ProgramIsimLabel.MouseUp += topBarPanel_MouseUp;
            // 
            // ProgramIcon
            // 
            ProgramIcon.Dock = DockStyle.Left;
            ProgramIcon.Image = Resource1.MainIconv2;
            ProgramIcon.Location = new Point(0, 0);
            ProgramIcon.Margin = new Padding(0);
            ProgramIcon.Name = "ProgramIcon";
            ProgramIcon.Size = new Size(40, 35);
            ProgramIcon.SizeMode = PictureBoxSizeMode.Zoom;
            ProgramIcon.TabIndex = 2;
            ProgramIcon.TabStop = false;
            ProgramIcon.MouseDown += topBarPanel_MouseDown;
            ProgramIcon.MouseMove += topBarPanel_MouseMove;
            ProgramIcon.MouseUp += topBarPanel_MouseUp;
            // 
            // MinimizePanel
            // 
            MinimizePanel.BackColor = Color.DarkGray;
            MinimizePanel.Controls.Add(MinimizeLabel);
            MinimizePanel.Dock = DockStyle.Right;
            MinimizePanel.Location = new Point(400, 0);
            MinimizePanel.Name = "MinimizePanel";
            MinimizePanel.Size = new Size(50, 35);
            MinimizePanel.TabIndex = 1;
            // 
            // MinimizeLabel
            // 
            MinimizeLabel.BackColor = Color.AliceBlue;
            MinimizeLabel.Dock = DockStyle.Fill;
            MinimizeLabel.Font = new Font("Calibri Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MinimizeLabel.Location = new Point(0, 0);
            MinimizeLabel.Name = "MinimizeLabel";
            MinimizeLabel.Size = new Size(50, 35);
            MinimizeLabel.TabIndex = 0;
            MinimizeLabel.Text = "-";
            MinimizeLabel.TextAlign = ContentAlignment.MiddleCenter;
            MinimizeLabel.Click += minimizeLabel_Click;
            MinimizeLabel.MouseLeave += minimizeLabel_MouseLeave;
            MinimizeLabel.MouseHover += minimizeLabel_MouseHover;
            // 
            // ExitPanel
            // 
            ExitPanel.BackColor = Color.Red;
            ExitPanel.Controls.Add(ExitLabel);
            ExitPanel.Dock = DockStyle.Right;
            ExitPanel.Location = new Point(450, 0);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Size = new Size(50, 35);
            ExitPanel.TabIndex = 0;
            // 
            // ExitLabel
            // 
            ExitLabel.BackColor = Color.AliceBlue;
            ExitLabel.Dock = DockStyle.Fill;
            ExitLabel.Font = new Font("Calibri Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ExitLabel.Location = new Point(0, 0);
            ExitLabel.Margin = new Padding(0);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(50, 35);
            ExitLabel.TabIndex = 1;
            ExitLabel.Text = "x";
            ExitLabel.TextAlign = ContentAlignment.TopCenter;
            ExitLabel.Click += exitLabel_Click;
            ExitLabel.MouseLeave += exitLabel_MouseLeave;
            ExitLabel.MouseHover += exitLabel_MouseHover;
            // 
            // SaatTextBox
            // 
            SaatTextBox.Location = new Point(26, 73);
            SaatTextBox.MaxLength = 2;
            SaatTextBox.Name = "SaatTextBox";
            SaatTextBox.PlaceholderText = "Max 24";
            SaatTextBox.Size = new Size(125, 27);
            SaatTextBox.TabIndex = 9;
            SaatTextBox.KeyPress += saatTextBox1_KeyPress;
            // 
            // SaatLabel
            // 
            SaatLabel.AutoSize = true;
            SaatLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaatLabel.Location = new Point(26, 47);
            SaatLabel.Name = "SaatLabel";
            SaatLabel.Size = new Size(43, 23);
            SaatLabel.TabIndex = 10;
            SaatLabel.Text = "Saat";
            // 
            // DakikaLabel
            // 
            DakikaLabel.AutoSize = true;
            DakikaLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DakikaLabel.Location = new Point(26, 103);
            DakikaLabel.Name = "DakikaLabel";
            DakikaLabel.Size = new Size(60, 23);
            DakikaLabel.TabIndex = 12;
            DakikaLabel.Text = "Dakika";
            // 
            // DakikaTextBox
            // 
            DakikaTextBox.Location = new Point(26, 129);
            DakikaTextBox.MaxLength = 2;
            DakikaTextBox.Name = "DakikaTextBox";
            DakikaTextBox.PlaceholderText = "Max 59";
            DakikaTextBox.Size = new Size(125, 27);
            DakikaTextBox.TabIndex = 11;
            DakikaTextBox.KeyPress += dakikaTextBox1_KeyPress;
            // 
            // SaniyeLabel
            // 
            SaniyeLabel.AutoSize = true;
            SaniyeLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaniyeLabel.Location = new Point(26, 159);
            SaniyeLabel.Name = "SaniyeLabel";
            SaniyeLabel.Size = new Size(59, 23);
            SaniyeLabel.TabIndex = 14;
            SaniyeLabel.Text = "Saniye";
            // 
            // SaniyeTextBox
            // 
            SaniyeTextBox.Location = new Point(26, 185);
            SaniyeTextBox.MaxLength = 2;
            SaniyeTextBox.Name = "SaniyeTextBox";
            SaniyeTextBox.PlaceholderText = "Max 59";
            SaniyeTextBox.Size = new Size(125, 27);
            SaniyeTextBox.TabIndex = 13;
            SaniyeTextBox.KeyPress += saniyeTextBox2_KeyPress;
            // 
            // KapatPanel
            // 
            KapatPanel.BackColor = SystemColors.MenuHighlight;
            KapatPanel.Controls.Add(KapatLabel);
            KapatPanel.Location = new Point(179, 78);
            KapatPanel.Name = "KapatPanel";
            KapatPanel.Size = new Size(297, 34);
            KapatPanel.TabIndex = 15;
            // 
            // KapatLabel
            // 
            KapatLabel.BackColor = SystemColors.MenuHighlight;
            KapatLabel.Dock = DockStyle.Fill;
            KapatLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            KapatLabel.ForeColor = SystemColors.ControlLightLight;
            KapatLabel.Location = new Point(0, 0);
            KapatLabel.Name = "KapatLabel";
            KapatLabel.Size = new Size(297, 34);
            KapatLabel.TabIndex = 0;
            KapatLabel.Text = "Kapat";
            KapatLabel.TextAlign = ContentAlignment.MiddleCenter;
            KapatLabel.Click += kapatLabel1_Click;
            KapatLabel.MouseDown += KapatLabel_MouseDown;
            KapatLabel.MouseLeave += kapatLabel1_MouseLeave;
            KapatLabel.MouseHover += kapatLabel1_MouseHover;
            // 
            // YenidenBaslatPanel
            // 
            YenidenBaslatPanel.BackColor = SystemColors.MenuHighlight;
            YenidenBaslatPanel.Controls.Add(YenidenBaslatLabel);
            YenidenBaslatPanel.Location = new Point(179, 128);
            YenidenBaslatPanel.Name = "YenidenBaslatPanel";
            YenidenBaslatPanel.Size = new Size(297, 34);
            YenidenBaslatPanel.TabIndex = 16;
            // 
            // YenidenBaslatLabel
            // 
            YenidenBaslatLabel.BackColor = SystemColors.MenuHighlight;
            YenidenBaslatLabel.Dock = DockStyle.Fill;
            YenidenBaslatLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            YenidenBaslatLabel.ForeColor = SystemColors.ControlLightLight;
            YenidenBaslatLabel.Location = new Point(0, 0);
            YenidenBaslatLabel.Name = "YenidenBaslatLabel";
            YenidenBaslatLabel.Size = new Size(297, 34);
            YenidenBaslatLabel.TabIndex = 0;
            YenidenBaslatLabel.Text = "Yeniden Başlat";
            YenidenBaslatLabel.TextAlign = ContentAlignment.MiddleCenter;
            YenidenBaslatLabel.Click += yenidenBaslatLabel1_Click;
            YenidenBaslatLabel.MouseDown += YenidenBaslatLabel_MouseDown;
            YenidenBaslatLabel.MouseLeave += yenidenBaslatLabel1_MouseLeave;
            YenidenBaslatLabel.MouseHover += yenidenBaslatLabel1_MouseHover;
            // 
            // AnaBildirimIcon
            // 
            AnaBildirimIcon.Icon = (Icon)resources.GetObject("AnaBildirimIcon.Icon");
            AnaBildirimIcon.Text = "Aktif Zamanlayıcı Yok!";
            AnaBildirimIcon.Visible = true;
            AnaBildirimIcon.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // UreticiLabel
            // 
            UreticiLabel.AutoSize = true;
            UreticiLabel.Location = new Point(230, 47);
            UreticiLabel.Name = "UreticiLabel";
            UreticiLabel.Size = new Size(195, 20);
            UreticiLabel.TabIndex = 17;
            UreticiLabel.Text = "Created by TheHypesTR '-..-'";
            UreticiLabel.MouseHover += label1_MouseHover;
            // 
            // ZamanlayaiciIptalPanel
            // 
            ZamanlayaiciIptalPanel.BackColor = SystemColors.MenuHighlight;
            ZamanlayaiciIptalPanel.Controls.Add(ZamanlayiciIptalLabel);
            ZamanlayaiciIptalPanel.Location = new Point(179, 178);
            ZamanlayaiciIptalPanel.Name = "ZamanlayaiciIptalPanel";
            ZamanlayaiciIptalPanel.Size = new Size(297, 34);
            ZamanlayaiciIptalPanel.TabIndex = 18;
            // 
            // ZamanlayiciIptalLabel
            // 
            ZamanlayiciIptalLabel.BackColor = SystemColors.MenuHighlight;
            ZamanlayiciIptalLabel.Dock = DockStyle.Fill;
            ZamanlayiciIptalLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ZamanlayiciIptalLabel.ForeColor = SystemColors.ControlLightLight;
            ZamanlayiciIptalLabel.Location = new Point(0, 0);
            ZamanlayiciIptalLabel.Name = "ZamanlayiciIptalLabel";
            ZamanlayiciIptalLabel.Size = new Size(297, 34);
            ZamanlayiciIptalLabel.TabIndex = 0;
            ZamanlayiciIptalLabel.Text = "Zamanlayıcıyı Durdur";
            ZamanlayiciIptalLabel.TextAlign = ContentAlignment.MiddleCenter;
            ZamanlayiciIptalLabel.Click += zamanlayiciIptalLabel2_Click;
            ZamanlayiciIptalLabel.MouseDown += ZamanlayiciIptalLabel_MouseDown;
            ZamanlayiciIptalLabel.MouseLeave += zamanlayiciIptalLabel2_MouseLeave;
            ZamanlayiciIptalLabel.MouseHover += zamanlayiciIptalLabel2_MouseHover;
            // 
            // AnaToolTip
            // 
            AnaToolTip.AutomaticDelay = 1000;
            AnaToolTip.AutoPopDelay = 9500;
            AnaToolTip.InitialDelay = 1000;
            AnaToolTip.ReshowDelay = 500;
            AnaToolTip.UseFading = false;
            // 
            // KapatmaZamanlayiciForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 237);
            Controls.Add(ZamanlayaiciIptalPanel);
            Controls.Add(UreticiLabel);
            Controls.Add(YenidenBaslatPanel);
            Controls.Add(KapatPanel);
            Controls.Add(SaniyeLabel);
            Controls.Add(SaniyeTextBox);
            Controls.Add(DakikaLabel);
            Controls.Add(DakikaTextBox);
            Controls.Add(SaatLabel);
            Controls.Add(SaatTextBox);
            Controls.Add(TopBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KapatmaZamanlayiciForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kapatma Zamanlayıcı";
            TopBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProgramIcon).EndInit();
            MinimizePanel.ResumeLayout(false);
            ExitPanel.ResumeLayout(false);
            KapatPanel.ResumeLayout(false);
            YenidenBaslatPanel.ResumeLayout(false);
            ZamanlayaiciIptalPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopBarPanel;
        private Label ProgramIsimLabel;
        private PictureBox ProgramIcon;
        private Panel MinimizePanel;
        private Label MinimizeLabel;
        private Panel ExitPanel;
        private Label ExitLabel;
        private TextBox SaatTextBox;
        private Label SaatLabel;
        private Label DakikaLabel;
        private TextBox DakikaTextBox;
        private Label SaniyeLabel;
        private TextBox SaniyeTextBox;
        private Panel KapatPanel;
        private Label KapatLabel;
        private Panel YenidenBaslatPanel;
        private Label YenidenBaslatLabel;
        private NotifyIcon AnaBildirimIcon;
        private Label UreticiLabel;
        private Panel ZamanlayaiciIptalPanel;
        private Label ZamanlayiciIptalLabel;
        private ToolTip AnaToolTip;
    }
}