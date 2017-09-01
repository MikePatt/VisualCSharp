namespace BoxerChampion
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblWon = new System.Windows.Forms.Label();
            this.lblLost = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxWon = new System.Windows.Forms.TextBox();
            this.tbxLost = new System.Windows.Forms.TextBox();
            this.lblWinResult = new System.Windows.Forms.Label();
            this.lblEval = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Boxer Name:";
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Location = new System.Drawing.Point(7, 40);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(77, 13);
            this.lblWon.TabIndex = 1;
            this.lblWon.Text = "Matches Won:";
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Location = new System.Drawing.Point(7, 68);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(74, 13);
            this.lblLost.TabIndex = 2;
            this.lblLost.Text = "Matches Lost:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(90, 9);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 3;
            // 
            // tbxWon
            // 
            this.tbxWon.Location = new System.Drawing.Point(90, 37);
            this.tbxWon.Name = "tbxWon";
            this.tbxWon.Size = new System.Drawing.Size(100, 20);
            this.tbxWon.TabIndex = 4;
            // 
            // tbxLost
            // 
            this.tbxLost.Location = new System.Drawing.Point(90, 65);
            this.tbxLost.Name = "tbxLost";
            this.tbxLost.Size = new System.Drawing.Size(100, 20);
            this.tbxLost.TabIndex = 5;
            // 
            // lblWinResult
            // 
            this.lblWinResult.AutoSize = true;
            this.lblWinResult.Location = new System.Drawing.Point(75, 123);
            this.lblWinResult.Name = "lblWinResult";
            this.lblWinResult.Size = new System.Drawing.Size(0, 13);
            this.lblWinResult.TabIndex = 6;
            // 
            // lblEval
            // 
            this.lblEval.AutoSize = true;
            this.lblEval.Location = new System.Drawing.Point(75, 152);
            this.lblEval.Name = "lblEval";
            this.lblEval.Size = new System.Drawing.Size(0, 13);
            this.lblEval.TabIndex = 7;
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(103, 91);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(75, 23);
            this.btnResults.TabIndex = 8;
            this.btnResults.Text = "Results!";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 261);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.lblEval);
            this.Controls.Add(this.lblWinResult);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.lblWon);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxLost);
            this.Controls.Add(this.tbxWon);
            this.Controls.Add(this.tbxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxWon;
        private System.Windows.Forms.TextBox tbxLost;
        private System.Windows.Forms.Label lblWinResult;
        private System.Windows.Forms.Label lblEval;
        private System.Windows.Forms.Button btnResults;
    }
}

