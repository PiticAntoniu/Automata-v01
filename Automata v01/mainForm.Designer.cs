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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.LoadAutomataButton = new System.Windows.Forms.Button();
            this.automataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StepByStepRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadAutomataButton
            // 
            this.LoadAutomataButton.Location = new System.Drawing.Point(26, 106);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // StepByStepRichTextBox
            // 
            this.StepByStepRichTextBox.Location = new System.Drawing.Point(26, 548);
            this.StepByStepRichTextBox.Name = "StepByStepRichTextBox";
            this.StepByStepRichTextBox.Size = new System.Drawing.Size(649, 528);
            this.StepByStepRichTextBox.TabIndex = 7;
            this.StepByStepRichTextBox.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 1110);
            this.Controls.Add(this.StepByStepRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.automataRichTextBox);
            this.Controls.Add(this.LoadAutomataButton);
            this.Name = "mainForm";
            this.Text = "Vizualizare automat";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadAutomataButton;
        private System.Windows.Forms.RichTextBox automataRichTextBox;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox StepByStepRichTextBox;
    }
}

