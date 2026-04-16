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
            lvwLeftDir = new ListView();
            btnCopyFromRight = new Button();
            btnCopyFromLeft = new Button();
            btnLeftDir = new Button();
            btnRightDir = new Button();
            lblAppName = new Label();
            txtLeftDir = new TextBox();
            txtRightDir = new TextBox();
            lvwrightDir = new ListView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(txtLeftDir);
            splitContainer1.Panel1.Controls.Add(lblAppName);
            splitContainer1.Panel1.Controls.Add(btnLeftDir);
            splitContainer1.Panel1.Controls.Add(btnCopyFromRight);
            splitContainer1.Panel1.Controls.Add(lvwLeftDir);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lvwrightDir);
            splitContainer1.Panel2.Controls.Add(txtRightDir);
            splitContainer1.Panel2.Controls.Add(btnRightDir);
            splitContainer1.Panel2.Controls.Add(btnCopyFromLeft);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 399;
            splitContainer1.TabIndex = 0;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Location = new Point(0, 125);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(396, 325);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Font = new Font("서울남산체 L", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(304, 12);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(75, 23);
            btnCopyFromRight.TabIndex = 1;
            btnCopyFromRight.Text = ">>>";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Font = new Font("서울남산체 L", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(21, 12);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(75, 23);
            btnCopyFromLeft.TabIndex = 0;
            btnCopyFromLeft.Text = "<<<";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Font = new Font("서울남산체 L", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(316, 71);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(75, 23);
            btnLeftDir.TabIndex = 2;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            // 
            // btnRightDir
            // 
            btnRightDir.Font = new Font("서울남산체 L", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(316, 73);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(75, 23);
            btnRightDir.TabIndex = 1;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("서울남산체 M", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(12, 12);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(252, 44);
            lblAppName.TabIndex = 3;
            lblAppName.Text = "File Compare";
            // 
            // txtLeftDir
            // 
            txtLeftDir.Font = new Font("서울남산체 L", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtLeftDir.Location = new Point(12, 71);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(298, 26);
            txtLeftDir.TabIndex = 4;
            // 
            // txtRightDir
            // 
            txtRightDir.Font = new Font("서울남산체 L", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtRightDir.Location = new Point(21, 71);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(289, 26);
            txtRightDir.TabIndex = 5;
            // 
            // lvwrightDir
            // 
            lvwrightDir.Location = new Point(3, 125);
            lvwrightDir.Name = "lvwrightDir";
            lvwrightDir.Size = new Size(394, 325);
            lvwrightDir.TabIndex = 5;
            lvwrightDir.UseCompatibleStateImageBehavior = false;
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
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
    }
}
