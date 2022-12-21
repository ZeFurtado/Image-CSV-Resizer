namespace Image_CSV_Resizer
{
    partial class btnCSV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstPhotos = new System.Windows.Forms.ListBox();
            this.btnPhotos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDestinyFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione as Fotos";
            // 
            // lstPhotos
            // 
            this.lstPhotos.FormattingEnabled = true;
            this.lstPhotos.ItemHeight = 15;
            this.lstPhotos.Location = new System.Drawing.Point(12, 53);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.Size = new System.Drawing.Size(482, 199);
            this.lstPhotos.TabIndex = 1;
            // 
            // btnPhotos
            // 
            this.btnPhotos.ForeColor = System.Drawing.Color.Black;
            this.btnPhotos.Location = new System.Drawing.Point(500, 53);
            this.btnPhotos.Name = "btnPhotos";
            this.btnPhotos.Size = new System.Drawing.Size(69, 23);
            this.btnPhotos.TabIndex = 2;
            this.btnPhotos.Text = "...";
            this.btnPhotos.UseVisualStyleBackColor = true;
            this.btnPhotos.Click += new System.EventHandler(this.btnPhotos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione a pasta destino";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 23);
            this.textBox1.TabIndex = 4;
            // 
            // btnDestinyFolder
            // 
            this.btnDestinyFolder.ForeColor = System.Drawing.Color.Black;
            this.btnDestinyFolder.Location = new System.Drawing.Point(500, 298);
            this.btnDestinyFolder.Name = "btnDestinyFolder";
            this.btnDestinyFolder.Size = new System.Drawing.Size(69, 23);
            this.btnDestinyFolder.TabIndex = 5;
            this.btnDestinyFolder.Text = "...";
            this.btnDestinyFolder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecione o arquivo CSV";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 370);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(482, 23);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(500, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(12, 407);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(482, 229);
            this.listBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(591, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fotos Redimensionadas";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(591, 53);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(581, 574);
            this.listBox3.TabIndex = 11;
            // 
            // btnResize
            // 
            this.btnResize.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResize.ForeColor = System.Drawing.Color.Black;
            this.btnResize.Location = new System.Drawing.Point(325, 683);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(593, 98);
            this.btnResize.TabIndex = 12;
            this.btnResize.Text = "Redimensionar";
            this.btnResize.UseVisualStyleBackColor = true;
            // 
            // btnCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1184, 812);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDestinyFolder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPhotos);
            this.Controls.Add(this.lstPhotos);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "btnCSV";
            this.Text = "Image-CSV-Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstPhotos;
        private Button btnPhotos;
        private Label label2;
        private TextBox textBox1;
        private Button btnDestinyFolder;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private ListBox listBox2;
        private Label label4;
        private ListBox listBox3;
        private Button btnResize;
    }
}