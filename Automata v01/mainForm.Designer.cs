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
            this.MockDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MockDataButton
            // 
            this.MockDataButton.Location = new System.Drawing.Point(296, 434);
            this.MockDataButton.Name = "MockDataButton";
            this.MockDataButton.Size = new System.Drawing.Size(187, 51);
            this.MockDataButton.TabIndex = 0;
            this.MockDataButton.Text = "Sample data";
            this.MockDataButton.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 603);
            this.Controls.Add(this.MockDataButton);
            this.Name = "mainForm";
            this.Text = "Vizualizare automat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MockDataButton;
    }
}

