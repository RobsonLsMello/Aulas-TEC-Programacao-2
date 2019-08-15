namespace TP02
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAceleracao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVelocidadeInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTempoDuracao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblVelocidadeFinal = new System.Windows.Forms.Label();
            this.lblTipoMovimento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlVelocidadeInicial = new System.Windows.Forms.Panel();
            this.pnlAceleracao = new System.Windows.Forms.Panel();
            this.pnlTempoDuracao = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbLimpar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlVelocidadeInicial.SuspendLayout();
            this.pnlAceleracao.SuspendLayout();
            this.pnlTempoDuracao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLimpar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pnlAceleracao);
            this.groupBox1.Controls.Add(this.pnlVelocidadeInicial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Corpo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "m/s²";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "m/s";
            // 
            // txtAceleracao
            // 
            this.txtAceleracao.Location = new System.Drawing.Point(4, 4);
            this.txtAceleracao.Name = "txtAceleracao";
            this.txtAceleracao.Size = new System.Drawing.Size(149, 20);
            this.txtAceleracao.TabIndex = 3;
            this.txtAceleracao.TextChanged += new System.EventHandler(this.txtAceleracao_TextChanged);
            this.txtAceleracao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAceleracao_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aceleração:";
            // 
            // txtVelocidadeInicial
            // 
            this.txtVelocidadeInicial.Location = new System.Drawing.Point(4, 4);
            this.txtVelocidadeInicial.Name = "txtVelocidadeInicial";
            this.txtVelocidadeInicial.Size = new System.Drawing.Size(149, 20);
            this.txtVelocidadeInicial.TabIndex = 1;
            this.txtVelocidadeInicial.TextChanged += new System.EventHandler(this.txtVelocidadeInicial_TextChanged);
            this.txtVelocidadeInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVelocidadeInicial_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velocidade Inicial:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pnlTempoDuracao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "s";
            // 
            // txtTempoDuracao
            // 
            this.txtTempoDuracao.Location = new System.Drawing.Point(4, 4);
            this.txtTempoDuracao.Name = "txtTempoDuracao";
            this.txtTempoDuracao.Size = new System.Drawing.Size(149, 20);
            this.txtTempoDuracao.TabIndex = 7;
            this.txtTempoDuracao.TextChanged += new System.EventHandler(this.txtTempoDuracao_TextChanged);
            this.txtTempoDuracao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempoDuracao_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tempo de Duração:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblVelocidadeFinal);
            this.groupBox3.Controls.Add(this.lblTipoMovimento);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(16, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados:";
            // 
            // lblVelocidadeFinal
            // 
            this.lblVelocidadeFinal.AutoSize = true;
            this.lblVelocidadeFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidadeFinal.Location = new System.Drawing.Point(132, 61);
            this.lblVelocidadeFinal.Name = "lblVelocidadeFinal";
            this.lblVelocidadeFinal.Size = new System.Drawing.Size(83, 13);
            this.lblVelocidadeFinal.TabIndex = 9;
            this.lblVelocidadeFinal.Text = "XXXX.XXXXX";
            // 
            // lblTipoMovimento
            // 
            this.lblTipoMovimento.AutoSize = true;
            this.lblTipoMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMovimento.Location = new System.Drawing.Point(132, 31);
            this.lblTipoMovimento.Name = "lblTipoMovimento";
            this.lblTipoMovimento.Size = new System.Drawing.Size(115, 13);
            this.lblTipoMovimento.TabIndex = 9;
            this.lblTipoMovimento.Text = "Tipo de Movimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Velocidade Final:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Movimento:";
            // 
            // pnlVelocidadeInicial
            // 
            this.pnlVelocidadeInicial.Controls.Add(this.txtVelocidadeInicial);
            this.pnlVelocidadeInicial.Location = new System.Drawing.Point(124, 19);
            this.pnlVelocidadeInicial.Name = "pnlVelocidadeInicial";
            this.pnlVelocidadeInicial.Size = new System.Drawing.Size(157, 28);
            this.pnlVelocidadeInicial.TabIndex = 6;
            // 
            // pnlAceleracao
            // 
            this.pnlAceleracao.Controls.Add(this.txtAceleracao);
            this.pnlAceleracao.Location = new System.Drawing.Point(124, 61);
            this.pnlAceleracao.Name = "pnlAceleracao";
            this.pnlAceleracao.Size = new System.Drawing.Size(157, 28);
            this.pnlAceleracao.TabIndex = 7;
            // 
            // pnlTempoDuracao
            // 
            this.pnlTempoDuracao.Controls.Add(this.txtTempoDuracao);
            this.pnlTempoDuracao.Location = new System.Drawing.Point(124, 19);
            this.pnlTempoDuracao.Name = "pnlTempoDuracao";
            this.pnlTempoDuracao.Size = new System.Drawing.Size(157, 28);
            this.pnlTempoDuracao.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(235)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(-3, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 143);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(11, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 161);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TP02.Properties.Resources.sonico;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pcbLimpar
            // 
            this.pcbLimpar.Image = global::TP02.Properties.Resources.levi;
            this.pcbLimpar.Location = new System.Drawing.Point(1, 4);
            this.pcbLimpar.Name = "pcbLimpar";
            this.pcbLimpar.Size = new System.Drawing.Size(129, 81);
            this.pcbLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLimpar.TabIndex = 1;
            this.pcbLimpar.TabStop = false;
            this.pcbLimpar.Click += new System.EventHandler(this.pcbLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::TP02.Properties.Resources.leave;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(7, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 89);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(58, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Limpar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(48, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Sair";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pcbLimpar);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(11, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 89);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(212)))), ((int)(((byte)(11)))));
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(339, -5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 338);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(30, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 118);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.btnSair);
            this.panel6.Location = new System.Drawing.Point(197, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(119, 111);
            this.panel6.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(212)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(688, 327);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinemática";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlVelocidadeInicial.ResumeLayout(false);
            this.pnlVelocidadeInicial.PerformLayout();
            this.pnlAceleracao.ResumeLayout(false);
            this.pnlAceleracao.PerformLayout();
            this.pnlTempoDuracao.ResumeLayout(false);
            this.pnlTempoDuracao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLimpar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAceleracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVelocidadeInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTempoDuracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblVelocidadeFinal;
        private System.Windows.Forms.Label lblTipoMovimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlAceleracao;
        private System.Windows.Forms.Panel pnlVelocidadeInicial;
        private System.Windows.Forms.Panel pnlTempoDuracao;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pcbLimpar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}

