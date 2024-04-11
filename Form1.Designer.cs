namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtBilet = new TextBox();
            label4 = new Label();
            txtKola = new TextBox();
            label3 = new Label();
            txtSu = new TextBox();
            label2 = new Label();
            txtMisir = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblBilet = new Label();
            lblKola = new Label();
            lblSu = new Label();
            lblMisir = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label20 = new Label();
            lblOdenecek = new Label();
            groupBox3 = new GroupBox();
            lblKasa = new Label();
            label15 = new Label();
            button1 = new Button();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(txtBilet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtKola);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMisir);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(49, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 286);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktar";
            // 
            // txtBilet
            // 
            txtBilet.BackColor = Color.LightCyan;
            txtBilet.Location = new Point(80, 150);
            txtBilet.Name = "txtBilet";
            txtBilet.Size = new Size(115, 32);
            txtBilet.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 150);
            label4.Name = "label4";
            label4.Size = new Size(51, 24);
            label4.TabIndex = 6;
            label4.Text = "Bilet:";
            // 
            // txtKola
            // 
            txtKola.BackColor = Color.LightCyan;
            txtKola.Location = new Point(80, 108);
            txtKola.Name = "txtKola";
            txtKola.Size = new Size(115, 32);
            txtKola.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 108);
            label3.Name = "label3";
            label3.Size = new Size(52, 24);
            label3.TabIndex = 4;
            label3.Text = "Kola:";
            // 
            // txtSu
            // 
            txtSu.BackColor = Color.LightCyan;
            txtSu.Location = new Point(80, 70);
            txtSu.Name = "txtSu";
            txtSu.Size = new Size(115, 32);
            txtSu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 70);
            label2.Name = "label2";
            label2.Size = new Size(36, 24);
            label2.TabIndex = 2;
            label2.Text = "Su:";
            // 
            // txtMisir
            // 
            txtMisir.BackColor = Color.LightCyan;
            txtMisir.Location = new Point(80, 34);
            txtMisir.Name = "txtMisir";
            txtMisir.Size = new Size(115, 32);
            txtMisir.TabIndex = 1;
            txtMisir.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 34);
            label1.Name = "label1";
            label1.Size = new Size(54, 24);
            label1.TabIndex = 0;
            label1.Text = "Mısır:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PowderBlue;
            groupBox2.Controls.Add(lblBilet);
            groupBox2.Controls.Add(lblKola);
            groupBox2.Controls.Add(lblSu);
            groupBox2.Controls.Add(lblMisir);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(331, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(167, 286);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fiyatlar";
            // 
            // lblBilet
            // 
            lblBilet.AutoSize = true;
            lblBilet.Location = new Point(82, 147);
            lblBilet.Name = "lblBilet";
            lblBilet.Size = new Size(59, 24);
            lblBilet.TabIndex = 10;
            lblBilet.Text = "100TL";
            lblBilet.Click += label12_Click;
            // 
            // lblKola
            // 
            lblKola.AutoSize = true;
            lblKola.Location = new Point(88, 105);
            lblKola.Name = "lblKola";
            lblKola.Size = new Size(50, 24);
            lblKola.TabIndex = 9;
            lblKola.Text = "20TL";
            // 
            // lblSu
            // 
            lblSu.AutoSize = true;
            lblSu.Location = new Point(91, 67);
            lblSu.Name = "lblSu";
            lblSu.Size = new Size(40, 24);
            lblSu.TabIndex = 8;
            lblSu.Text = "5TL";
            // 
            // lblMisir
            // 
            lblMisir.AutoSize = true;
            lblMisir.Location = new Point(86, 34);
            lblMisir.Name = "lblMisir";
            lblMisir.Size = new Size(51, 24);
            lblMisir.TabIndex = 7;
            lblMisir.Text = "50TL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 150);
            label5.Name = "label5";
            label5.Size = new Size(51, 24);
            label5.TabIndex = 6;
            label5.Text = "Bilet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 108);
            label6.Name = "label6";
            label6.Size = new Size(52, 24);
            label6.TabIndex = 4;
            label6.Text = "Kola:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 70);
            label7.Name = "label7";
            label7.Size = new Size(36, 24);
            label7.TabIndex = 2;
            label7.Text = "Su:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 34);
            label8.Name = "label8";
            label8.Size = new Size(54, 24);
            label8.TabIndex = 0;
            label8.Text = "Mısır:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(24, 28);
            label20.Name = "label20";
            label20.Size = new Size(144, 24);
            label20.TabIndex = 0;
            label20.Text = "Ödenecek tutar:";
            // 
            // lblOdenecek
            // 
            lblOdenecek.AutoSize = true;
            lblOdenecek.Location = new Point(164, 28);
            lblOdenecek.Name = "lblOdenecek";
            lblOdenecek.Size = new Size(41, 24);
            lblOdenecek.TabIndex = 7;
            lblOdenecek.Text = "0TL";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.PaleTurquoise;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(lblKasa);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(lblOdenecek);
            groupBox3.Controls.Add(label20);
            groupBox3.Location = new Point(528, 114);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(229, 200);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // lblKasa
            // 
            lblKasa.AutoSize = true;
            lblKasa.Location = new Point(127, 150);
            lblKasa.Name = "lblKasa";
            lblKasa.Size = new Size(41, 24);
            lblKasa.TabIndex = 10;
            lblKasa.Text = "0TL";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(66, 150);
            label15.Name = "label15";
            label15.Size = new Size(55, 24);
            label15.TabIndex = 9;
            label15.Text = "Kasa:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.Location = new Point(62, 55);
            button1.Name = "button1";
            button1.Size = new Size(106, 44);
            button1.TabIndex = 8;
            button1.Text = "hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(142, 25);
            label13.Name = "label13";
            label13.Size = new Size(373, 33);
            label13.TabIndex = 11;
            label13.Text = "Sinema/Büfe Satış Paneli";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(521, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.Location = new Point(62, 103);
            button2.Name = "button2";
            button2.Size = new Size(106, 44);
            button2.TabIndex = 11;
            button2.Text = "temizle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(805, 403);
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMisir;
        private Label label1;
        private TextBox txtBilet;
        private Label label4;
        private TextBox txtKola;
        private Label label3;
        private TextBox txtSu;
        private Label label2;
        private GroupBox groupBox2;
        private Label lblBilet;
        private Label lblKola;
        private Label lblSu;
        private Label lblMisir;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label20;
        private Label lblOdenecek;
        private GroupBox groupBox3;
        private Button button1;
        private Label label13;
        private PictureBox pictureBox1;
        private Label lblKasa;
        private Label label15;
        private Button button2;
    }
}
