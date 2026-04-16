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
            panelleft = new Panel();
            btnLeftDir = new Button();
            btnCopyFromLeft = new Button();
            lblAppName = new Label();
            txtLeftDir = new TextBox();
            lvwLeftDir = new ListView();
            panelright = new Panel();
            btnCopyFromRight = new Button();
            btnRightDir = new Button();
            txtRightDir = new TextBox();
            lvwRightDir = new ListView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelleft.SuspendLayout();
            panelright.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panelleft);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(192, 255, 255);
            splitContainer1.Panel2.Controls.Add(panelright);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 398;
            splitContainer1.TabIndex = 0;
            // 
            // panelleft
            // 
            panelleft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelleft.BackColor = Color.FromArgb(255, 255, 192);
            panelleft.Controls.Add(btnLeftDir);
            panelleft.Controls.Add(btnCopyFromLeft);
            panelleft.Controls.Add(lblAppName);
            panelleft.Controls.Add(txtLeftDir);
            panelleft.Controls.Add(lvwLeftDir);
            panelleft.Location = new Point(0, 3);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(399, 442);
            panelleft.TabIndex = 6;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLeftDir.Font = new Font("서울남산체 L", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(319, 82);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(75, 23);
            btnLeftDir.TabIndex = 2;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromLeft.Font = new Font("서울남산체 L", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(315, 13);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(75, 35);
            btnCopyFromLeft.TabIndex = 1;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("서울남산체 M", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(4, 6);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(252, 44);
            lblAppName.TabIndex = 3;
            lblAppName.Text = "File Compare";
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Font = new Font("서울남산체 L", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtLeftDir.Location = new Point(9, 81);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(303, 26);
            txtLeftDir.TabIndex = 4;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwLeftDir.Location = new Point(4, 125);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(390, 301);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            // 
            // panelright
            // 
            panelright.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelright.BackColor = Color.FromArgb(192, 255, 192);
            panelright.Controls.Add(btnCopyFromRight);
            panelright.Controls.Add(btnRightDir);
            panelright.Controls.Add(txtRightDir);
            panelright.Controls.Add(lvwRightDir);
            panelright.Location = new Point(3, 3);
            panelright.Name = "panelright";
            panelright.Size = new Size(394, 442);
            panelright.TabIndex = 8;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Font = new Font("서울남산체 L", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(9, 13);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(75, 35);
            btnCopyFromRight.TabIndex = 0;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRightDir.Font = new Font("서울남산체 L", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(311, 82);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(75, 23);
            btnRightDir.TabIndex = 1;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Font = new Font("서울남산체 L", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtRightDir.Location = new Point(7, 82);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(298, 26);
            txtRightDir.TabIndex = 5;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwRightDir.Location = new Point(3, 125);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(388, 302);
            lvwRightDir.TabIndex = 5;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
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
            panelleft.ResumeLayout(false);
            panelleft.PerformLayout();
            panelright.ResumeLayout(false);
            panelright.PerformLayout();
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
        private Panel panelleft;
        private Panel panelright;
    }
}
