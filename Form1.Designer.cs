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
            panel3 = new Panel();
            lvwLeftDir = new ListView();
            txtLeftDir = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblAppName = new Label();
            btnCopyFromRight = new Button();
            btnLeftDir = new Button();
            lvwrightDir = new ListView();
            txtRightDir = new TextBox();
            btnRightDir = new Button();
            btnCopyFromLeft = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(txtLeftDir);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(btnLeftDir);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 399;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lvwLeftDir);
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 325);
            panel3.TabIndex = 6;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Location = new Point(0, 0);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(397, 325);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Font = new Font("서울남산체 L", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtLeftDir.Location = new Point(3, 88);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(309, 26);
            txtLeftDir.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblAppName);
            panel1.Controls.Add(btnCopyFromRight);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 76);
            panel1.TabIndex = 5;
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
            lblAppName.Location = new Point(3, 6);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(252, 44);
            lblAppName.TabIndex = 3;
            lblAppName.Text = "File Compare";
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Font = new Font("서울남산체 L", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(302, 24);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(75, 35);
            btnCopyFromRight.TabIndex = 1;
            btnCopyFromRight.Text = ">>>";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Font = new Font("서울남산체 L", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(318, 90);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(75, 23);
            btnLeftDir.TabIndex = 2;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            // 
            // lvwrightDir
            // 
            lvwrightDir.Location = new Point(-3, 0);
            lvwrightDir.Name = "lvwrightDir";
            lvwrightDir.Size = new Size(397, 325);
            lvwrightDir.TabIndex = 5;
            lvwrightDir.UseCompatibleStateImageBehavior = false;
            // 
            // txtRightDir
            // 
            txtRightDir.Font = new Font("서울남산체 L", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtRightDir.Location = new Point(8, 6);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(298, 26);
            txtRightDir.TabIndex = 5;
            // 
            // btnRightDir
            // 
            btnRightDir.Font = new Font("서울남산체 L", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(312, 7);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(75, 23);
            btnRightDir.TabIndex = 1;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Font = new Font("서울남산체 L", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(18, 24);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(75, 35);
            btnCopyFromLeft.TabIndex = 0;
            btnCopyFromLeft.Text = "<<<";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCopyFromLeft);
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(394, 77);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtRightDir);
            panel5.Controls.Add(btnRightDir);
            panel5.Location = new Point(3, 82);
            panel5.Name = "panel5";
            panel5.Size = new Size(394, 37);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Controls.Add(lvwrightDir);
            panel6.Location = new Point(3, 125);
            panel6.Name = "panel6";
            panel6.Size = new Size(394, 325);
            panel6.TabIndex = 8;
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
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView lvwLeftDir;
        private TextBox txtLeftDir;
        private Label lblAppName;
        private Button btnLeftDir;
        private Button btnCopyFromRight;
        private ListView lvwrightDir;
        private TextBox txtRightDir;
        private Button btnRightDir;
        private Button btnCopyFromLeft;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
    }
}
