namespace RoundingProgram
{
    partial class frmRoundNumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIntro = new System.Windows.Forms.Label();
            this.nudDecimalsToKeep = new System.Windows.Forms.NumericUpDown();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblInputNumber = new System.Windows.Forms.Label();
            this.lblDecimalsToKeep = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRound = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalsToKeep)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(76, 42);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(119, 13);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Enter Number to Round";
            // 
            // nudDecimalsToKeep
            // 
            this.nudDecimalsToKeep.Location = new System.Drawing.Point(148, 100);
            this.nudDecimalsToKeep.Name = "nudDecimalsToKeep";
            this.nudDecimalsToKeep.Size = new System.Drawing.Size(108, 20);
            this.nudDecimalsToKeep.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtOutput.Location = new System.Drawing.Point(92, 140);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 3;
            // 
            // lblInputNumber
            // 
            this.lblInputNumber.AutoSize = true;
            this.lblInputNumber.Location = new System.Drawing.Point(29, 80);
            this.lblInputNumber.Name = "lblInputNumber";
            this.lblInputNumber.Size = new System.Drawing.Size(96, 13);
            this.lblInputNumber.TabIndex = 4;
            this.lblInputNumber.Text = "Decimal To Round";
            // 
            // lblDecimalsToKeep
            // 
            this.lblDecimalsToKeep.AutoSize = true;
            this.lblDecimalsToKeep.Location = new System.Drawing.Point(148, 79);
            this.lblDecimalsToKeep.Name = "lblDecimalsToKeep";
            this.lblDecimalsToKeep.Size = new System.Drawing.Size(121, 13);
            this.lblDecimalsToKeep.TabIndex = 5;
            this.lblDecimalsToKeep.Text = "Decimal Points To Keep";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(106, 166);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(75, 23);
            this.btnRound.TabIndex = 8;
            this.btnRound.Text = "button1";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(32, 99);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(100, 20);
            this.txtUserInput.TabIndex = 9;
            // 
            // frmRoundNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.lblDecimalsToKeep);
            this.Controls.Add(this.lblInputNumber);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.nudDecimalsToKeep);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmRoundNumber";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalsToKeep)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.NumericUpDown nudDecimalsToKeep;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblInputNumber;
        private System.Windows.Forms.Label lblDecimalsToKeep;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.TextBox txtUserInput;
    }
}

