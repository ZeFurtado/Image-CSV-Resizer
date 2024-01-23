namespace Image_CSV_Resizer
{
    partial class ExibeLogs
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Gainsboro;
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 639);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            StartPosition = FormStartPosition.CenterScreen;
            // 
            // ExibeLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 42);
            ClientSize = new Size(800, 663);
            Controls.Add(richTextBox1);
            Name = "ExibeLogs";
            Text = "ExibeLogs";
            ResumeLayout(false);
            
        }

        #endregion
        private RichTextBox richTextBox1;
    }
}