namespace Tablet
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1Help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1Help
            // 
            this.label1Help.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1Help.ForeColor = System.Drawing.Color.LightCoral;
            this.label1Help.Location = new System.Drawing.Point(257, 18);
            this.label1Help.Name = "label1Help";
            this.label1Help.Size = new System.Drawing.Size(455, 140);
            this.label1Help.TabIndex = 0;
            this.label1Help.Text = "Often asked questions";
            this.label1Help.Click += new System.EventHandler(this.label1Help_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1Help);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1Help;
    }
}