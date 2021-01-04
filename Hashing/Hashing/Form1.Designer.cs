namespace Hashing
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
            this.algorithmSelectionBox = new System.Windows.Forms.ComboBox();
            this.KeyASCIIButton = new System.Windows.Forms.TextBox();
            this.PlainTextASCIIButton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MACASCIIButton = new System.Windows.Forms.TextBox();
            this.MACHEXButton = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // algorithmSelectionBox
            // 
            this.algorithmSelectionBox.FormattingEnabled = true;
            this.algorithmSelectionBox.Location = new System.Drawing.Point(12, 12);
            this.algorithmSelectionBox.Name = "algorithmSelectionBox";
            this.algorithmSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.algorithmSelectionBox.TabIndex = 0;
            // 
            // KeyASCIIButton
            // 
            this.KeyASCIIButton.Location = new System.Drawing.Point(227, 28);
            this.KeyASCIIButton.Name = "KeyASCIIButton";
            this.KeyASCIIButton.Size = new System.Drawing.Size(321, 20);
            this.KeyASCIIButton.TabIndex = 1;
            // 
            // PlainTextASCIIButton
            // 
            this.PlainTextASCIIButton.Location = new System.Drawing.Point(227, 75);
            this.PlainTextASCIIButton.Name = "PlainTextASCIIButton";
            this.PlainTextASCIIButton.Size = new System.Drawing.Size(321, 20);
            this.PlainTextASCIIButton.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ASCII";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ASCII";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Plain Text";
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(12, 53);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(121, 23);
            this.ComputeButton.TabIndex = 7;
            this.ComputeButton.Text = "Compute MAC";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Verify MAC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.VerifyMacButtoon_Click);
            // 
            // MACASCIIButton
            // 
            this.MACASCIIButton.Location = new System.Drawing.Point(227, 177);
            this.MACASCIIButton.Name = "MACASCIIButton";
            this.MACASCIIButton.Size = new System.Drawing.Size(321, 20);
            this.MACASCIIButton.TabIndex = 9;
            // 
            // MACHEXButton
            // 
            this.MACHEXButton.Location = new System.Drawing.Point(227, 203);
            this.MACHEXButton.Name = "MACHEXButton";
            this.MACHEXButton.Size = new System.Drawing.Size(321, 20);
            this.MACHEXButton.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "MAC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ASCII";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "HEX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 248);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MACHEXButton);
            this.Controls.Add(this.MACASCIIButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainTextASCIIButton);
            this.Controls.Add(this.KeyASCIIButton);
            this.Controls.Add(this.algorithmSelectionBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox algorithmSelectionBox;
        private System.Windows.Forms.TextBox KeyASCIIButton;
        private System.Windows.Forms.TextBox PlainTextASCIIButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox MACASCIIButton;
        private System.Windows.Forms.TextBox MACHEXButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

