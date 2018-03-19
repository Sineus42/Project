namespace Banka
{
    partial class Bank_Main
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Clients
            // 
            this.button1.Location = new System.Drawing.Point(58, 68);
            this.button1.Name = "Btn_Clients";
            this.button1.Size = new System.Drawing.Size(174, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_Clients);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Accounts";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Deposits";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(58, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 43);
            this.button4.TabIndex = 7;
            this.button4.Text = "Loans";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Bank_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.IsMdiContainer = true;
            this.Name = "Bank_Main";
            this.Text = "Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bank_Main_FormClosing);
            this.Load += new System.EventHandler(this.Bank_Main_Load);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}



