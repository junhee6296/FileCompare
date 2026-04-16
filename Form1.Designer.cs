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
            panel1 = new Panel();
            txtLeftDir = new TextBox();
            btnLeftDir = new Button();
            pannelleftdown = new Panel();
            lvwLeftDir = new ListView();
            pannelleftup = new Panel();
            panel2 = new Panel();
            lblAppName = new Label();
            btnCopyFromRight = new Button();
            pannelrightdown = new Panel();
            lvwRightDir = new ListView();
            panelrightmiddle = new Panel();
            txtRightDir = new TextBox();
            btnRightDir = new Button();
            pannelrightup = new Panel();
            btnCopyFromLeft = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            pannelleftdown.SuspendLayout();
            pannelleftup.SuspendLayout();
            pannelrightdown.SuspendLayout();
            panelrightmiddle.SuspendLayout();
            pannelrightup.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(pannelleftdown);
            splitContainer1.Panel1.Controls.Add(pannelleftup);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(192, 255, 255);
            splitContainer1.Panel2.Controls.Add(pannelrightdown);
            splitContainer1.Panel2.Controls.Add(panelrightmiddle);
            splitContainer1.Panel2.Controls.Add(pannelrightup);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 398;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(txtLeftDir);
            panel1.Controls.Add(btnLeftDir);
            panel1.Location = new Point(0, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 37);
            panel1.TabIndex = 7;
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
            // pannelleftdown
            // 
            pannelleftdown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pannelleftdown.BackColor = Color.FromArgb(255, 255, 192);
            pannelleftdown.Controls.Add(lvwLeftDir);
            pannelleftdown.Location = new Point(0, 125);
            pannelleftdown.Name = "pannelleftdown";
            pannelleftdown.Size = new Size(399, 325);
            pannelleftdown.TabIndex = 6;
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
            // pannelleftup
            // 
            pannelleftup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pannelleftup.BackColor = Color.FromArgb(255, 255, 192);
            pannelleftup.Controls.Add(panel2);
            pannelleftup.Controls.Add(lblAppName);
            pannelleftup.Controls.Add(btnCopyFromRight);
            pannelleftup.Location = new Point(0, 0);
            pannelleftup.Name = "pannelleftup";
            pannelleftup.Size = new Size(396, 76);
            pannelleftup.TabIndex = 5;
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
            // btnCopyFromRight
            // 
            btnCopyFromRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromRight.Font = new Font("서울남산체 L", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(302, 24);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(75, 35);
            btnCopyFromRight.TabIndex = 1;
            btnCopyFromRight.Text = ">>>";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            // 
            // pannelrightdown
            // 
            pannelrightdown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pannelrightdown.BackColor = Color.FromArgb(192, 255, 192);
            pannelrightdown.Controls.Add(lvwRightDir);
            pannelrightdown.Location = new Point(3, 125);
            pannelrightdown.Name = "pannelrightdown";
            pannelrightdown.Size = new Size(394, 325);
            pannelrightdown.TabIndex = 8;
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
            // pannelrightup
            // 
            pannelrightup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pannelrightup.BackColor = Color.FromArgb(192, 255, 192);
            pannelrightup.Controls.Add(btnCopyFromLeft);
            pannelrightup.Location = new Point(3, 0);
            pannelrightup.Name = "pannelrightup";
            pannelrightup.Size = new Size(394, 77);
            pannelrightup.TabIndex = 6;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Font = new Font("서울남산체 L", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(17, 24);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(75, 35);
            btnCopyFromLeft.TabIndex = 0;
            btnCopyFromLeft.Text = "<<<";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pannelleftdown.ResumeLayout(false);
            pannelleftup.ResumeLayout(false);
            pannelleftup.PerformLayout();
            pannelrightdown.ResumeLayout(false);
            panelrightmiddle.ResumeLayout(false);
            panelrightmiddle.PerformLayout();
            pannelrightup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView lvwLeftDir;
        private TextBox txtLeftDir;
        private Label lblAppName;
        private Button btnLeftDir;
        private Button btnCopyFromRight;
        private ListView lvwRightDir;
        private TextBox txtRightDir;
        private Button btnRightDir;
        private Button btnCopyFromLeft;
        private Panel pannelleftdown;
        private Panel pannelleftup;
        private Panel panel2;
        private Panel panelrightmiddle;
        private Panel pannelrightup;
        private Panel pannelrightdown;
        private Panel panel1;
    }
}
