﻿namespace Image_CSV_Resizer
{
    partial class Form1
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
            this.txtDestinyFolder = new System.Windows.Forms.TextBox();
            this.btnDestinyFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCsvFile = new System.Windows.Forms.TextBox();
            this.btnCSVRead = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.lstItemsCsv = new System.Windows.Forms.ListView();
            this.btnClear = new System.Windows.Forms.Button();
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
            this.lstPhotos.Size = new System.Drawing.Size(512, 199);
            this.lstPhotos.TabIndex = 1;
            // 
            // btnPhotos
            // 
            this.btnPhotos.ForeColor = System.Drawing.Color.Black;
            this.btnPhotos.Location = new System.Drawing.Point(530, 53);
            this.btnPhotos.Name = "btnPhotos";
            this.btnPhotos.Size = new System.Drawing.Size(55, 23);
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
            // txtDestinyFolder
            // 
            this.txtDestinyFolder.Location = new System.Drawing.Point(12, 298);
            this.txtDestinyFolder.Name = "txtDestinyFolder";
            this.txtDestinyFolder.Size = new System.Drawing.Size(512, 23);
            this.txtDestinyFolder.TabIndex = 4;
            // 
            // btnDestinyFolder
            // 
            this.btnDestinyFolder.ForeColor = System.Drawing.Color.Black;
            this.btnDestinyFolder.Location = new System.Drawing.Point(530, 298);
            this.btnDestinyFolder.Name = "btnDestinyFolder";
            this.btnDestinyFolder.Size = new System.Drawing.Size(55, 23);
            this.btnDestinyFolder.TabIndex = 5;
            this.btnDestinyFolder.Text = "...";
            this.btnDestinyFolder.UseVisualStyleBackColor = true;
            this.btnDestinyFolder.Click += new System.EventHandler(this.btnDestinyFolder_Click);
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
            // txtCsvFile
            // 
            this.txtCsvFile.Location = new System.Drawing.Point(12, 370);
            this.txtCsvFile.Name = "txtCsvFile";
            this.txtCsvFile.Size = new System.Drawing.Size(512, 23);
            this.txtCsvFile.TabIndex = 7;
            // 
            // btnCSVRead
            // 
            this.btnCSVRead.ForeColor = System.Drawing.Color.Black;
            this.btnCSVRead.Location = new System.Drawing.Point(530, 370);
            this.btnCSVRead.Name = "btnCSVRead";
            this.btnCSVRead.Size = new System.Drawing.Size(55, 23);
            this.btnCSVRead.TabIndex = 8;
            this.btnCSVRead.Text = "...";
            this.btnCSVRead.UseVisualStyleBackColor = true;
            this.btnCSVRead.Click += new System.EventHandler(this.btnCSVRead_Click);
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
            this.btnResize.Location = new System.Drawing.Point(308, 642);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(593, 98);
            this.btnResize.TabIndex = 12;
            this.btnResize.Text = "Redimensionar";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // lstItemsCsv
            // 
            this.lstItemsCsv.Location = new System.Drawing.Point(12, 399);
            this.lstItemsCsv.Name = "lstItemsCsv";
            this.lstItemsCsv.Size = new System.Drawing.Size(512, 228);
            this.lstItemsCsv.TabIndex = 13;
            this.lstItemsCsv.UseCompatibleStateImageBehavior = false;
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(923, 655);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 66);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstItemsCsv);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCSVRead);
            this.Controls.Add(this.txtCsvFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDestinyFolder);
            this.Controls.Add(this.txtDestinyFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPhotos);
            this.Controls.Add(this.lstPhotos);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Image-CSV-Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstPhotos;
        private Button btnPhotos;
        private Label label2;
        private TextBox txtDestinyFolder;
        private Button btnDestinyFolder;
        private Label label3;
        private TextBox txtCsvFile;
        private Button btnCSVRead;
        private Label label4;
        private ListBox listBox3;
        private Button btnResize;
        private ListView lstItemsCsv;
        private Button btnClear;
    }
}