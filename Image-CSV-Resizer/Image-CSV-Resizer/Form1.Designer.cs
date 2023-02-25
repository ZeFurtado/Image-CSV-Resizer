namespace Image_CSV_Resizer
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
            this.btnResize = new System.Windows.Forms.Button();
            this.lstItemsCsv = new System.Windows.Forms.ListView();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstResizedPhotos = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.lstPhotos.Size = new System.Drawing.Size(551, 214);
            this.lstPhotos.TabIndex = 1;
            // 
            // btnPhotos
            // 
            this.btnPhotos.ForeColor = System.Drawing.Color.Black;
            this.btnPhotos.Location = new System.Drawing.Point(469, 28);
            this.btnPhotos.Name = "btnPhotos";
            this.btnPhotos.Size = new System.Drawing.Size(94, 23);
            this.btnPhotos.TabIndex = 2;
            this.btnPhotos.Text = "...";
            this.btnPhotos.UseVisualStyleBackColor = true;
            this.btnPhotos.Click += new System.EventHandler(this.btnPhotos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione a pasta destino";
            // 
            // txtDestinyFolder
            // 
            this.txtDestinyFolder.Location = new System.Drawing.Point(12, 323);
            this.txtDestinyFolder.Name = "txtDestinyFolder";
            this.txtDestinyFolder.Size = new System.Drawing.Size(551, 23);
            this.txtDestinyFolder.TabIndex = 4;
            // 
            // btnDestinyFolder
            // 
            this.btnDestinyFolder.ForeColor = System.Drawing.Color.Black;
            this.btnDestinyFolder.Location = new System.Drawing.Point(469, 298);
            this.btnDestinyFolder.Name = "btnDestinyFolder";
            this.btnDestinyFolder.Size = new System.Drawing.Size(94, 23);
            this.btnDestinyFolder.TabIndex = 5;
            this.btnDestinyFolder.Text = "...";
            this.btnDestinyFolder.UseVisualStyleBackColor = true;
            this.btnDestinyFolder.Click += new System.EventHandler(this.btnDestinyFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecione o arquivo CSV";
            // 
            // txtCsvFile
            // 
            this.txtCsvFile.Location = new System.Drawing.Point(12, 395);
            this.txtCsvFile.Name = "txtCsvFile";
            this.txtCsvFile.Size = new System.Drawing.Size(551, 23);
            this.txtCsvFile.TabIndex = 7;
            // 
            // btnCSVRead
            // 
            this.btnCSVRead.ForeColor = System.Drawing.Color.Black;
            this.btnCSVRead.Location = new System.Drawing.Point(469, 370);
            this.btnCSVRead.Name = "btnCSVRead";
            this.btnCSVRead.Size = new System.Drawing.Size(94, 23);
            this.btnCSVRead.TabIndex = 8;
            this.btnCSVRead.Text = "...";
            this.btnCSVRead.UseVisualStyleBackColor = true;
            this.btnCSVRead.Click += new System.EventHandler(this.btnCSVRead_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(755, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fotos Redimensionadas";
            // 
            // btnResize
            // 
            this.btnResize.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResize.ForeColor = System.Drawing.Color.Black;
            this.btnResize.Location = new System.Drawing.Point(602, 273);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(125, 70);
            this.btnResize.TabIndex = 12;
            this.btnResize.Text = "Redimensionar";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // lstItemsCsv
            // 
            this.lstItemsCsv.Location = new System.Drawing.Point(12, 424);
            this.lstItemsCsv.Name = "lstItemsCsv";
            this.lstItemsCsv.Size = new System.Drawing.Size(551, 228);
            this.lstItemsCsv.TabIndex = 13;
            this.lstItemsCsv.UseCompatibleStateImageBehavior = false;
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(569, 625);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 26);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstResizedPhotos
            // 
            this.lstResizedPhotos.Location = new System.Drawing.Point(755, 53);
            this.lstResizedPhotos.Name = "lstResizedPhotos";
            this.lstResizedPhotos.Size = new System.Drawing.Size(603, 598);
            this.lstResizedPhotos.TabIndex = 15;
            this.lstResizedPhotos.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Image_CSV_Resizer.Properties.Resources.Folder_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(255, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Image_CSV_Resizer.Properties.Resources.Picture_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(192, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Image_CSV_Resizer.Properties.Resources.CSV_icon;
            this.pictureBox3.Location = new System.Drawing.Point(246, 352);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1370, 663);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstResizedPhotos);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstItemsCsv);
            this.Controls.Add(this.btnResize);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private Button btnResize;
        private ListView lstItemsCsv;
        private Button btnClear;
        private ListView lstResizedPhotos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}