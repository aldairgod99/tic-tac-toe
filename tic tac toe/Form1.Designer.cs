namespace tic_tac_toe
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
            a1 = new Button();
            a2 = new Button();
            a3 = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            c3 = new Button();
            c2 = new Button();
            c1 = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            btnlimpiar = new Button();
            label4 = new Label();
            groupBox3 = new GroupBox();
            lbluserrojo = new Label();
            btnreiniciar = new Button();
            groupBox2 = new GroupBox();
            txtuserazul = new TextBox();
            lbluserazul = new Label();
            pictureBox1 = new PictureBox();
            btniniciar = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // a1
            // 
            a1.Location = new Point(-1, 0);
            a1.Name = "a1";
            a1.Size = new Size(90, 90);
            a1.TabIndex = 0;
            a1.UseVisualStyleBackColor = true;
            a1.Click += a1_Click;
            // 
            // a2
            // 
            a2.Location = new Point(95, 0);
            a2.Name = "a2";
            a2.Size = new Size(90, 90);
            a2.TabIndex = 1;
            a2.UseVisualStyleBackColor = true;
            a2.Click += a2_Click;
            // 
            // a3
            // 
            a3.Location = new Point(192, 0);
            a3.Name = "a3";
            a3.Size = new Size(90, 90);
            a3.TabIndex = 2;
            a3.UseVisualStyleBackColor = true;
            a3.Click += a3_Click;
            // 
            // b3
            // 
            b3.Location = new Point(192, 96);
            b3.Name = "b3";
            b3.Size = new Size(90, 90);
            b3.TabIndex = 5;
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b2
            // 
            b2.Location = new Point(95, 96);
            b2.Name = "b2";
            b2.Size = new Size(90, 90);
            b2.TabIndex = 4;
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b1
            // 
            b1.Location = new Point(-1, 96);
            b1.Name = "b1";
            b1.Size = new Size(90, 90);
            b1.TabIndex = 3;
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // c3
            // 
            c3.Location = new Point(192, 192);
            c3.Name = "c3";
            c3.Size = new Size(90, 90);
            c3.TabIndex = 8;
            c3.UseVisualStyleBackColor = true;
            c3.Click += c3_Click;
            // 
            // c2
            // 
            c2.Location = new Point(95, 192);
            c2.Name = "c2";
            c2.Size = new Size(90, 90);
            c2.TabIndex = 7;
            c2.UseVisualStyleBackColor = true;
            c2.Click += c2_Click;
            // 
            // c1
            // 
            c1.Location = new Point(-1, 192);
            c1.Name = "c1";
            c1.Size = new Size(90, 90);
            c1.TabIndex = 6;
            c1.UseVisualStyleBackColor = true;
            c1.Click += c1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(a3);
            panel1.Controls.Add(c3);
            panel1.Controls.Add(a1);
            panel1.Controls.Add(c2);
            panel1.Controls.Add(a2);
            panel1.Controls.Add(c1);
            panel1.Controls.Add(b1);
            panel1.Controls.Add(b3);
            panel1.Controls.Add(b2);
            panel1.Location = new Point(267, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 282);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(btnlimpiar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(btnreiniciar);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btniniciar);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(790, 350);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introduzca El Nombre De Los Jugadores";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(568, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(295, 239);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(155, 35);
            btnlimpiar.TabIndex = 8;
            btnlimpiar.Text = "LIMPIAR";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Visible = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 84);
            label4.Name = "label4";
            label4.Size = new Size(36, 25);
            label4.TabIndex = 4;
            label4.Text = "VS";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbluserrojo);
            groupBox3.Location = new Point(533, 136);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 200);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // lbluserrojo
            // 
            lbluserrojo.AutoSize = true;
            lbluserrojo.Location = new Point(75, 84);
            lbluserrojo.Name = "lbluserrojo";
            lbluserrojo.Size = new Size(50, 25);
            lbluserrojo.TabIndex = 3;
            lbluserrojo.Text = "CPU";
            lbluserrojo.Click += lbluserrojo_Click;
            // 
            // btnreiniciar
            // 
            btnreiniciar.Location = new Point(295, 198);
            btnreiniciar.Name = "btnreiniciar";
            btnreiniciar.Size = new Size(155, 35);
            btnreiniciar.TabIndex = 9;
            btnreiniciar.Text = "REINICIAR";
            btnreiniciar.UseVisualStyleBackColor = true;
            btnreiniciar.Visible = false;
            btnreiniciar.Click += btnreiniciar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtuserazul);
            groupBox2.Controls.Add(lbluserazul);
            groupBox2.Location = new Point(32, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 200);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // txtuserazul
            // 
            txtuserazul.Location = new Point(56, 135);
            txtuserazul.Name = "txtuserazul";
            txtuserazul.Size = new Size(100, 33);
            txtuserazul.TabIndex = 2;
            // 
            // lbluserazul
            // 
            lbluserazul.AutoSize = true;
            lbluserazul.Location = new Point(70, 84);
            lbluserazul.Name = "lbluserazul";
            lbluserazul.Size = new Size(86, 25);
            lbluserazul.TabIndex = 2;
            lbluserazul.Text = "Jugador";
            lbluserazul.Click += lbluserazul_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btniniciar
            // 
            btniniciar.Location = new Point(295, 157);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(155, 35);
            btniniciar.TabIndex = 7;
            btniniciar.Text = "INICIAR";
            btniniciar.UseVisualStyleBackColor = true;
            btniniciar.Click += btniniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(555, 56);
            label1.Name = "label1";
            label1.Size = new Size(0, 65);
            label1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 696);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button a1;
        private Button a2;
        private Button a3;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button c3;
        private Button c2;
        private Button c1;
        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtuserazul;
        private Button btniniciar;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label4;
        private Label lbluserrojo;
        private Label lbluserazul;
        private Button btnreiniciar;
        private Button btnlimpiar;
    }
}