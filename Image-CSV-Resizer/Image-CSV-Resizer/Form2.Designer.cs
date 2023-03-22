namespace Image_CSV_Resizer
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstPhotos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDestinyFolder = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lstFotosRedimensionadas = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione as fotos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Image_CSV_Resizer.Properties.Resources.Picture_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(209, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lstPhotos
            // 
            this.lstPhotos.FormattingEnabled = true;
            this.lstPhotos.ItemHeight = 15;
            this.lstPhotos.Location = new System.Drawing.Point(28, 207);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.Size = new System.Drawing.Size(446, 184);
            this.lstPhotos.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salvar em:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDestinyFolder
            // 
            this.txtDestinyFolder.Location = new System.Drawing.Point(28, 441);
            this.txtDestinyFolder.Name = "txtDestinyFolder";
            this.txtDestinyFolder.Size = new System.Drawing.Size(446, 23);
            this.txtDestinyFolder.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 74);
            this.button3.TabIndex = 7;
            this.button3.Text = "Redimensionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(327, 506);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "Limpar Campos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(151, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dimensões da foto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(83, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Largura";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(141, 124);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(72, 23);
            this.txtWidth.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(250, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Altura";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(298, 125);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(72, 23);
            this.txtHeight.TabIndex = 13;
            // 
            // lstFotosRedimensionadas
            // 
            this.lstFotosRedimensionadas.Location = new System.Drawing.Point(496, 53);
            this.lstFotosRedimensionadas.Name = "lstFotosRedimensionadas";
            this.lstFotosRedimensionadas.Size = new System.Drawing.Size(544, 497);
            this.lstFotosRedimensionadas.TabIndex = 14;
            this.lstFotosRedimensionadas.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(496, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fotos redimensionadas:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 54);
            this.button5.TabIndex = 16;
            this.button5.Text = "Carterinha";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(259, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 54);
            this.button6.TabIndex = 17;
            this.button6.Text = "Crachá";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Image_CSV_Resizer.Properties.Resources.Folder_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(132, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1063, 580);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstFotosRedimensionadas);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDestinyFolder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstPhotos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ListBox lstPhotos;
        private Button button1;
        private Label label2;
        private Button button2;
        private TextBox txtDestinyFolder;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label4;
        private TextBox txtWidth;
        private Label label5;
        private TextBox txtHeight;
        private ListView lstFotosRedimensionadas;
        private Label label6;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox2;
    }
}