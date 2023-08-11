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
            label1 = new Label();
            lstPhotos = new ListBox();
            btnPhotos = new Button();
            label2 = new Label();
            txtDestinyFolder = new TextBox();
            btnDestinyFolder = new Button();
            label3 = new Label();
            txtCsvFile = new TextBox();
            btnCSVRead = new Button();
            label4 = new Label();
            btnResize = new Button();
            lstItemsCsv = new ListView();
            btnClear = new Button();
            lstResizedPhotos = new ListView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 0;
            label1.Text = "Selecione as Fotos";
            // 
            // lstPhotos
            // 
            lstPhotos.FormattingEnabled = true;
            lstPhotos.ItemHeight = 15;
            lstPhotos.Location = new Point(12, 53);
            lstPhotos.Name = "lstPhotos";
            lstPhotos.Size = new Size(551, 214);
            lstPhotos.TabIndex = 1;
            // 
            // btnPhotos
            // 
            btnPhotos.ForeColor = Color.Black;
            btnPhotos.Location = new Point(469, 28);
            btnPhotos.Name = "btnPhotos";
            btnPhotos.Size = new Size(94, 23);
            btnPhotos.TabIndex = 2;
            btnPhotos.Text = "...";
            btnPhotos.UseVisualStyleBackColor = true;
            btnPhotos.Click += btnPhotos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 290);
            label2.Name = "label2";
            label2.Size = new Size(248, 30);
            label2.TabIndex = 3;
            label2.Text = "Selecione a pasta destino";
            // 
            // txtDestinyFolder
            // 
            txtDestinyFolder.Location = new Point(12, 323);
            txtDestinyFolder.Name = "txtDestinyFolder";
            txtDestinyFolder.Size = new Size(551, 23);
            txtDestinyFolder.TabIndex = 4;
            // 
            // btnDestinyFolder
            // 
            btnDestinyFolder.ForeColor = Color.Black;
            btnDestinyFolder.Location = new Point(469, 298);
            btnDestinyFolder.Name = "btnDestinyFolder";
            btnDestinyFolder.Size = new Size(94, 23);
            btnDestinyFolder.TabIndex = 5;
            btnDestinyFolder.Text = "...";
            btnDestinyFolder.UseVisualStyleBackColor = true;
            btnDestinyFolder.Click += btnDestinyFolder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 362);
            label3.Name = "label3";
            label3.Size = new Size(237, 30);
            label3.TabIndex = 6;
            label3.Text = "Selecione o arquivo CSV";
            // 
            // txtCsvFile
            // 
            txtCsvFile.Location = new Point(12, 395);
            txtCsvFile.Name = "txtCsvFile";
            txtCsvFile.Size = new Size(551, 23);
            txtCsvFile.TabIndex = 7;
            // 
            // btnCSVRead
            // 
            btnCSVRead.ForeColor = Color.Black;
            btnCSVRead.Location = new Point(469, 370);
            btnCSVRead.Name = "btnCSVRead";
            btnCSVRead.Size = new Size(94, 23);
            btnCSVRead.TabIndex = 8;
            btnCSVRead.Text = "...";
            btnCSVRead.UseVisualStyleBackColor = true;
            btnCSVRead.Click += btnCSVRead_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(755, 21);
            label4.Name = "label4";
            label4.Size = new Size(231, 30);
            label4.TabIndex = 10;
            label4.Text = "Fotos Redimensionadas";
            // 
            // btnResize
            // 
            btnResize.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResize.ForeColor = Color.Black;
            btnResize.Location = new Point(596, 261);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(130, 70);
            btnResize.TabIndex = 12;
            btnResize.Text = "Redimensionar";
            btnResize.UseVisualStyleBackColor = true;
            btnResize.Click += btnResize_Click;
            // 
            // lstItemsCsv
            // 
            lstItemsCsv.Location = new Point(12, 424);
            lstItemsCsv.Name = "lstItemsCsv";
            lstItemsCsv.Size = new Size(551, 228);
            lstItemsCsv.TabIndex = 13;
            lstItemsCsv.UseCompatibleStateImageBehavior = false;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(569, 349);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 26);
            btnClear.TabIndex = 14;
            btnClear.Text = "Limpar Campos";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lstResizedPhotos
            // 
            lstResizedPhotos.Location = new Point(755, 53);
            lstResizedPhotos.Name = "lstResizedPhotos";
            lstResizedPhotos.Size = new Size(603, 598);
            lstResizedPhotos.TabIndex = 15;
            lstResizedPhotos.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Folder_Icon;
            pictureBox1.Location = new Point(284, 292);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture_Icon;
            pictureBox2.Location = new Point(212, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CSV_icon;
            pictureBox3.Location = new Point(284, 350);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1370, 663);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lstResizedPhotos);
            Controls.Add(btnClear);
            Controls.Add(lstItemsCsv);
            Controls.Add(btnResize);
            Controls.Add(label4);
            Controls.Add(btnCSVRead);
            Controls.Add(txtCsvFile);
            Controls.Add(label3);
            Controls.Add(btnDestinyFolder);
            Controls.Add(txtDestinyFolder);
            Controls.Add(label2);
            Controls.Add(btnPhotos);
            Controls.Add(lstPhotos);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Image-CSV-Resizer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
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