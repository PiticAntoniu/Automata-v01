namespace Automata_v01
{
    partial class mainForm
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
            this.LoadAutomataButton = new System.Windows.Forms.Button();
            this.automataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadAutomataButton
            // 
            this.LoadAutomataButton.Location = new System.Drawing.Point(26, 519);
            this.LoadAutomataButton.Name = "LoadAutomataButton";
            this.LoadAutomataButton.Size = new System.Drawing.Size(260, 51);
            this.LoadAutomataButton.TabIndex = 1;
            this.LoadAutomataButton.Text = "Load Automata";
            this.LoadAutomataButton.UseVisualStyleBackColor = true;
            this.LoadAutomataButton.Click += new System.EventHandler(this.LoadAutomataButton_Click);
            // 
            // automataRichTextBox
            // 
            this.automataRichTextBox.Location = new System.Drawing.Point(26, 172);
            this.automataRichTextBox.Name = "automataRichTextBox";
            this.automataRichTextBox.Size = new System.Drawing.Size(649, 341);
            this.automataRichTextBox.TabIndex = 2;
            this.automataRichTextBox.Text = "";
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.Location = new System.Drawing.Point(26, 56);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(385, 44);
            this.wordTextBox.TabIndex = 3;
            this.wordTextBox.Text = "abcbc";
            this.wordTextBox.TextChanged += new System.EventHandler(this.wordTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.automataRichTextBox);
            this.Controls.Add(this.LoadAutomataButton);
            this.Name = "mainForm";
            this.Text = "Vizualizare automat";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadAutomataButton;
        private System.Windows.Forms.RichTextBox automataRichTextBox;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button button1;
    }
}

