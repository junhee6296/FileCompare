namespace FileCompare
{
    partial class Form1
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
            splitContainer1 = new SplitContainer();
            panelleftmiddle = new Panel();
            txtLeftDir = new TextBox();
            btnLeftDir = new Button();
            panelleftdown = new Panel();
            lvwLeftDir = new ListView();
            panelleftup = new Panel();
            panel2 = new Panel();
            lblAppName = new Label();
            btnCopyFromLeft = new Button();
            panelrightdown = new Panel();
            lvwRightDir = new ListView();
            panelrightmiddle = new Panel();
            txtRightDir = new TextBox();
            btnRightDir = new Button();
            panelrightup = new Panel();
            btnCopyFromRight = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelleftmiddle.SuspendLayout();
            panelleftdown.SuspendLayout();
            panelleftup.SuspendLayout();
            panelrightdown.SuspendLayout();
            panelrightmiddle.SuspendLayout();
            panelrightup.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ActiveCaptionText;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(128, 255, 255);
            splitContainer1.Panel1.Controls.Add(panelleftmiddle);
            splitContainer1.Panel1.Controls.Add(panelleftdown);
            splitContainer1.Panel1.Controls.Add(panelleftup);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(192, 255, 255);
            splitContainer1.Panel2.Controls.Add(panelrightdown);
            splitContainer1.Panel2.Controls.Add(panelrightmiddle);
            splitContainer1.Panel2.Controls.Add(panelrightup);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 398;
            splitContainer1.TabIndex = 0;
            // 
            // panelleftmiddle
            // 
            panelleftmiddle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelleftmiddle.BackColor = Color.FromArgb(255, 255, 192);
            panelleftmiddle.Controls.Add(txtLeftDir);
            panelleftmiddle.Controls.Add(btnLeftDir);
            panelleftmiddle.Location = new Point(0, 82);
            panelleftmiddle.Name = "panelleftmiddle";
            panelleftmiddle.Size = new Size(396, 37);
            panelleftmiddle.TabIndex = 7;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Font = new Font("서울남산체 L", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtLeftDir.Location = new Point(5, 6);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(303, 26);
            txtLeftDir.TabIndex = 4;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLeftDir.Font = new Font("서울남산체 L", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(312, 7);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(75, 23);
            btnLeftDir.TabIndex = 2;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // panelleftdown
            // 
            panelleftdown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelleftdown.BackColor = Color.FromArgb(255, 255, 192);
            panelleftdown.Controls.Add(lvwLeftDir);
            panelleftdown.Location = new Point(0, 125);
            panelleftdown.Name = "panelleftdown";
            panelleftdown.Size = new Size(399, 325);
            panelleftdown.TabIndex = 6;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwLeftDir.Location = new Point(4, 3);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(390, 301);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            // 
            // panelleftup
            // 
            panelleftup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelleftup.BackColor = Color.FromArgb(255, 255, 192);
            panelleftup.Controls.Add(panel2);
            panelleftup.Controls.Add(lblAppName);
            panelleftup.Controls.Add(btnCopyFromLeft);
            panelleftup.Location = new Point(0, 0);
            panelleftup.Name = "panelleftup";
            panelleftup.Size = new Size(396, 76);
            panelleftup.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 37);
            panel2.TabIndex = 6;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("서울남산체 M", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(12, 15);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(252, 44);
            lblAppName.TabIndex = 3;
            lblAppName.Text = "File Compare";
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromLeft.Font = new Font("서울남산체 L", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(302, 24);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(75, 35);
            btnCopyFromLeft.TabIndex = 1;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            // 
            // panelrightdown
            // 
            panelrightdown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelrightdown.BackColor = Color.FromArgb(192, 255, 192);
            panelrightdown.Controls.Add(lvwRightDir);
            panelrightdown.Location = new Point(3, 125);
            panelrightdown.Name = "panelrightdown";
            panelrightdown.Size = new Size(394, 325);
            panelrightdown.TabIndex = 8;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwRightDir.Location = new Point(3, 3);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(388, 302);
            lvwRightDir.TabIndex = 5;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            // 
            // panelrightmiddle
            // 
            panelrightmiddle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelrightmiddle.BackColor = Color.FromArgb(192, 255, 192);
            panelrightmiddle.Controls.Add(txtRightDir);
            panelrightmiddle.Controls.Add(btnRightDir);
            panelrightmiddle.Location = new Point(3, 82);
            panelrightmiddle.Name = "panelrightmiddle";
            panelrightmiddle.Size = new Size(394, 37);
            panelrightmiddle.TabIndex = 7;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Font = new Font("서울남산체 L", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtRightDir.Location = new Point(8, 6);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(298, 26);
            txtRightDir.TabIndex = 5;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRightDir.Font = new Font("서울남산체 L", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(312, 7);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(75, 23);
            btnRightDir.TabIndex = 1;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // panelrightup
            // 
            panelrightup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelrightup.BackColor = Color.FromArgb(192, 255, 192);
            panelrightup.Controls.Add(btnCopyFromRight);
            panelrightup.Location = new Point(3, 0);
            panelrightup.Name = "panelrightup";
            panelrightup.Size = new Size(394, 77);
            panelrightup.TabIndex = 6;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Font = new Font("서울남산체 L", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(17, 24);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(75, 35);
            btnCopyFromRight.TabIndex = 0;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelleftmiddle.ResumeLayout(false);
            panelleftmiddle.PerformLayout();
            panelleftdown.ResumeLayout(false);
            panelleftup.ResumeLayout(false);
            panelleftup.PerformLayout();
            panelrightdown.ResumeLayout(false);
            panelrightmiddle.ResumeLayout(false);
            panelrightmiddle.PerformLayout();
            panelrightup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView lvwLeftDir;
        private TextBox txtLeftDir;
        private Label lblAppName;
        private Button btnLeftDir;
        private Button btnCopyFromLeft;
        private ListView lvwRightDir;
        private TextBox txtRightDir;
        private Button btnRightDir;
        private Button btnCopyFromRight;
        private Panel panelleftdown;
        private Panel panelleftup;
        private Panel panel2;
        private Panel panelrightmiddle;
        private Panel panelrightup;
        private Panel panelrightdown;
        private Panel panelleftmiddle;
    }
}
