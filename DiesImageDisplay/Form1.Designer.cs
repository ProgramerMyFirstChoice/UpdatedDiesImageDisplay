namespace DiesImageDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureDice = new System.Windows.Forms.PictureBox();
            this.btnDisplayDice = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDiceValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Value of Dice";
            // 
            // pictureDice
            // 
            this.pictureDice.Location = new System.Drawing.Point(230, 24);
            this.pictureDice.Name = "pictureDice";
            this.pictureDice.Size = new System.Drawing.Size(120, 104);
            this.pictureDice.TabIndex = 1;
            this.pictureDice.TabStop = false;
            // 
            // btnDisplayDice
            // 
            this.btnDisplayDice.Location = new System.Drawing.Point(47, 162);
            this.btnDisplayDice.Name = "btnDisplayDice";
            this.btnDisplayDice.Size = new System.Drawing.Size(103, 32);
            this.btnDisplayDice.TabIndex = 2;
            this.btnDisplayDice.Text = "Display Dice";
            this.btnDisplayDice.UseVisualStyleBackColor = true;
            this.btnDisplayDice.Click += new System.EventHandler(this.btnDisplayDice_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(244, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDiceValue
            // 
            this.txtDiceValue.Location = new System.Drawing.Point(12, 58);
            this.txtDiceValue.Name = "txtDiceValue";
            this.txtDiceValue.Size = new System.Drawing.Size(164, 20);
            this.txtDiceValue.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 243);
            this.Controls.Add(this.txtDiceValue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayDice);
            this.Controls.Add(this.pictureDice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dice Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureDice;
        private System.Windows.Forms.Button btnDisplayDice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDiceValue;
    }
}

