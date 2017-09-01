namespace IfStatements
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
            this.lblPunch = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPunch = new System.Windows.Forms.TextBox();
            this.btnEval = new System.Windows.Forms.Button();
            this.lblPowEval = new System.Windows.Forms.Label();
            this.lblBoxName = new System.Windows.Forms.Label();
            this.tbxPowEval = new System.Windows.Forms.TextBox();
            this.tbxBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblPunch
            // 
            this.lblPunch.AutoSize = true;
            this.lblPunch.Location = new System.Drawing.Point(10, 41);
            this.lblPunch.Name = "lblPunch";
            this.lblPunch.Size = new System.Drawing.Size(74, 13);
            this.lblPunch.TabIndex = 1;
            this.lblPunch.Text = "Punch Power:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(104, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 2;
            // 
            // tbxPunch
            // 
            this.tbxPunch.Location = new System.Drawing.Point(104, 38);
            this.tbxPunch.Name = "tbxPunch";
            this.tbxPunch.Size = new System.Drawing.Size(100, 20);
            this.tbxPunch.TabIndex = 3;
            // 
            // btnEval
            // 
            this.btnEval.Location = new System.Drawing.Point(115, 77);
            this.btnEval.Name = "btnEval";
            this.btnEval.Size = new System.Drawing.Size(75, 23);
            this.btnEval.TabIndex = 4;
            this.btnEval.Text = "Evaluate";
            this.btnEval.UseVisualStyleBackColor = true;
            this.btnEval.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPowEval
            // 
            this.lblPowEval.AutoSize = true;
            this.lblPowEval.Location = new System.Drawing.Point(10, 150);
            this.lblPowEval.Name = "lblPowEval";
            this.lblPowEval.Size = new System.Drawing.Size(93, 13);
            this.lblPowEval.TabIndex = 6;
            this.lblPowEval.Text = "Power Evaluation:";
            this.lblPowEval.Visible = false;
            // 
            // lblBoxName
            // 
            this.lblBoxName.AutoSize = true;
            this.lblBoxName.Location = new System.Drawing.Point(10, 124);
            this.lblBoxName.Name = "lblBoxName";
            this.lblBoxName.Size = new System.Drawing.Size(68, 13);
            this.lblBoxName.TabIndex = 5;
            this.lblBoxName.Text = "Boxer Name:";
            this.lblBoxName.Visible = false;
            // 
            // tbxPowEval
            // 
            this.tbxPowEval.Location = new System.Drawing.Point(104, 147);
            this.tbxPowEval.Name = "tbxPowEval";
            this.tbxPowEval.ReadOnly = true;
            this.tbxPowEval.Size = new System.Drawing.Size(100, 20);
            this.tbxPowEval.TabIndex = 8;
            this.tbxPowEval.Visible = false;
            // 
            // tbxBoxName
            // 
            this.tbxBoxName.Location = new System.Drawing.Point(104, 121);
            this.tbxBoxName.Name = "tbxBoxName";
            this.tbxBoxName.ReadOnly = true;
            this.tbxBoxName.Size = new System.Drawing.Size(100, 20);
            this.tbxBoxName.TabIndex = 7;
            this.tbxBoxName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 174);
            this.Controls.Add(this.tbxPowEval);
            this.Controls.Add(this.tbxBoxName);
            this.Controls.Add(this.lblPowEval);
            this.Controls.Add(this.lblBoxName);
            this.Controls.Add(this.btnEval);
            this.Controls.Add(this.tbxPunch);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblPunch);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPunch;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPunch;
        private System.Windows.Forms.Button btnEval;
        private System.Windows.Forms.Label lblPowEval;
        private System.Windows.Forms.Label lblBoxName;
        private System.Windows.Forms.TextBox tbxPowEval;
        private System.Windows.Forms.TextBox tbxBoxName;
    }
}

