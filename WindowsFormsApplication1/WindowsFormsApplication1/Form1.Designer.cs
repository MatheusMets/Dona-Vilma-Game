namespace TicTacToeGeneral
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
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnA1
            // 
            this.btnA1.Location = new System.Drawing.Point(95, 68);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(32, 23);
            this.btnA1.TabIndex = 0;
            this.btnA1.UseVisualStyleBackColor = true;
            // 
            // btnA2
            // 
            this.btnA2.Location = new System.Drawing.Point(170, 68);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(31, 23);
            this.btnA2.TabIndex = 1;
            this.btnA2.UseVisualStyleBackColor = true;
            // 
            // btnA3
            // 
            this.btnA3.Location = new System.Drawing.Point(247, 68);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(36, 23);
            this.btnA3.TabIndex = 2;
            this.btnA3.UseVisualStyleBackColor = true;
            // 
            // btnB3
            // 
            this.btnB3.Location = new System.Drawing.Point(247, 109);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(36, 23);
            this.btnB3.TabIndex = 5;
            this.btnB3.UseVisualStyleBackColor = true;
            // 
            // btnB2
            // 
            this.btnB2.Location = new System.Drawing.Point(170, 109);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(31, 23);
            this.btnB2.TabIndex = 4;
            this.btnB2.UseVisualStyleBackColor = true;
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(95, 109);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(32, 23);
            this.btnB1.TabIndex = 3;
            this.btnB1.UseVisualStyleBackColor = true;
            // 
            // btnC3
            // 
            this.btnC3.Location = new System.Drawing.Point(247, 158);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(36, 23);
            this.btnC3.TabIndex = 8;
            this.btnC3.UseVisualStyleBackColor = true;
            // 
            // btnC2
            // 
            this.btnC2.Location = new System.Drawing.Point(170, 158);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(31, 23);
            this.btnC2.TabIndex = 7;
            this.btnC2.UseVisualStyleBackColor = true;
            // 
            // btnC1
            // 
            this.btnC1.Location = new System.Drawing.Point(95, 158);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(32, 23);
            this.btnC1.TabIndex = 6;
            this.btnC1.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(170, 384);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "DONA VILMA GAME";
            // 
            // richLog
            // 
            this.richLog.Location = new System.Drawing.Point(13, 250);
            this.richLog.Name = "richLog";
            this.richLog.Size = new System.Drawing.Size(389, 120);
            this.richLog.TabIndex = 11;
            this.richLog.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "LOG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnA1);
            this.Name = "Form1";
            this.Text = "DONA VILMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richLog;
        private System.Windows.Forms.Label label2;
    }
}

