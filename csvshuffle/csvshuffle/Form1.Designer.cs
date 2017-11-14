namespace csvshuffle
{
    partial class Form1
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
            this.lbInputFile = new System.Windows.Forms.Label();
            this.tbInputFile = new System.Windows.Forms.TextBox();
            this.tbOutputFile = new System.Windows.Forms.TextBox();
            this.lbOutputFile = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInputFile
            // 
            this.lbInputFile.AutoSize = true;
            this.lbInputFile.Location = new System.Drawing.Point(21, 31);
            this.lbInputFile.Name = "lbInputFile";
            this.lbInputFile.Size = new System.Drawing.Size(50, 13);
            this.lbInputFile.TabIndex = 0;
            this.lbInputFile.Text = "Input File";
            // 
            // tbInputFile
            // 
            this.tbInputFile.Location = new System.Drawing.Point(90, 28);
            this.tbInputFile.Name = "tbInputFile";
            this.tbInputFile.Size = new System.Drawing.Size(489, 20);
            this.tbInputFile.TabIndex = 1;
            this.tbInputFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbInputFile_MouseDoubleClick);
            // 
            // tbOutputFile
            // 
            this.tbOutputFile.Location = new System.Drawing.Point(90, 54);
            this.tbOutputFile.Name = "tbOutputFile";
            this.tbOutputFile.Size = new System.Drawing.Size(489, 20);
            this.tbOutputFile.TabIndex = 3;
            this.tbOutputFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbOutputFile_MouseDoubleClick);
            // 
            // lbOutputFile
            // 
            this.lbOutputFile.AutoSize = true;
            this.lbOutputFile.Location = new System.Drawing.Point(21, 57);
            this.lbOutputFile.Name = "lbOutputFile";
            this.lbOutputFile.Size = new System.Drawing.Size(58, 13);
            this.lbOutputFile.TabIndex = 2;
            this.lbOutputFile.Text = "Output File";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(599, 31);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(84, 39);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnProcess_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 98);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.tbOutputFile);
            this.Controls.Add(this.lbOutputFile);
            this.Controls.Add(this.tbInputFile);
            this.Controls.Add(this.lbInputFile);
            this.Name = "Form1";
            this.Text = "CSV Shuffle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInputFile;
        private System.Windows.Forms.TextBox tbInputFile;
        private System.Windows.Forms.TextBox tbOutputFile;
        private System.Windows.Forms.Label lbOutputFile;
        private System.Windows.Forms.Button btnProcess;
    }
}

