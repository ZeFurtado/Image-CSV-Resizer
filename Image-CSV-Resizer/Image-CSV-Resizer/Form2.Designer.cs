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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lstPhotos = new ListBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            txtDestinyFolder = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtWidth = new TextBox();
            label5 = new Label();
            txtHeight = new TextBox();
            label6 = new Label();
            button5 = new Button();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            lstFotosRedimensionadas = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 174);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 0;
            label1.Text = "Selecione as fotos:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Picture_Icon;
            pictureBox1.Location = new Point(209, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lstPhotos
            // 
            lstPhotos.FormattingEnabled = true;
            lstPhotos.ItemHeight = 15;
            lstPhotos.Location = new Point(28, 207);
            lstPhotos.Name = "lstPhotos";
            lstPhotos.Size = new Size(446, 184);
            lstPhotos.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(396, 178);
            button1.Name = "button1";
            button1.Size = new Size(78, 23);
            button1.TabIndex = 3;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 408);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 4;
            label2.Text = "Salvar em:";
            // 
            // button2
            // 
            button2.Location = new Point(396, 412);
            button2.Name = "button2";
            button2.Size = new Size(78, 23);
            button2.TabIndex = 5;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtDestinyFolder
            // 
            txtDestinyFolder.Location = new Point(28, 441);
            txtDestinyFolder.Name = "txtDestinyFolder";
            txtDestinyFolder.Size = new Size(446, 23);
            txtDestinyFolder.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Location = new Point(132, 486);
            button3.Name = "button3";
            button3.Size = new Size(189, 82);
            button3.TabIndex = 7;
            button3.Text = "Redimensionar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(327, 506);
            button4.Name = "button4";
            button4.Size = new Size(75, 48);
            button4.TabIndex = 8;
            button4.Text = "Limpar Campos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(161, 82);
            label3.Name = "label3";
            label3.Size = new Size(188, 30);
            label3.TabIndex = 9;
            label3.Text = "Dimensões da foto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(83, 125);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 10;
            label4.Text = "Largura";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(141, 124);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(72, 23);
            txtWidth.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(250, 126);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 12;
            label5.Text = "Altura";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(298, 125);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(72, 23);
            txtHeight.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(496, 20);
            label6.Name = "label6";
            label6.Size = new Size(231, 30);
            label6.TabIndex = 15;
            label6.Text = "Fotos redimensionadas:";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Location = new Point(83, 28);
            button5.Name = "button5";
            button5.Size = new Size(134, 51);
            button5.TabIndex = 16;
            button5.Text = "Carterinha";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(276, 28);
            button6.Name = "button6";
            button6.Size = new Size(144, 51);
            button6.TabIndex = 17;
            button6.Text = "Crachá";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Folder_Icon;
            pictureBox2.Location = new Point(132, 411);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // lstFotosRedimensionadas
            // 
            lstFotosRedimensionadas.Location = new Point(496, 55);
            lstFotosRedimensionadas.Name = "lstFotosRedimensionadas";
            lstFotosRedimensionadas.Size = new Size(544, 495);
            lstFotosRedimensionadas.TabIndex = 14;
            lstFotosRedimensionadas.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1063, 580);
            Controls.Add(pictureBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(lstFotosRedimensionadas);
            Controls.Add(txtHeight);
            Controls.Add(label5);
            Controls.Add(txtWidth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txtDestinyFolder);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(lstPhotos);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label6;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox2;
        private ListView lstFotosRedimensionadas;
    }
}