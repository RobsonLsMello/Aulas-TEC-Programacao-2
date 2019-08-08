namespace TP01
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtR3 = new System.Windows.Forms.TextBox();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblR3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.ForeColor = System.Drawing.Color.Transparent;
            this.btnConverter.Image = ((System.Drawing.Image)(resources.GetObject("btnConverter.Image")));
            this.btnConverter.Location = new System.Drawing.Point(244, 26);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(53, 59);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(51, 38);
            this.txtR1.MaxLength = 10;
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(165, 20);
            this.txtR1.TabIndex = 1;
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(51, 88);
            this.txtR2.MaxLength = 10;
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(165, 20);
            this.txtR2.TabIndex = 2;
            // 
            // txtR3
            // 
            this.txtR3.Location = new System.Drawing.Point(51, 137);
            this.txtR3.MaxLength = 10;
            this.txtR3.Name = "txtR3";
            this.txtR3.Size = new System.Drawing.Size(165, 20);
            this.txtR3.TabIndex = 3;
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.Location = new System.Drawing.Point(48, 22);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(21, 13);
            this.lblR1.TabIndex = 5;
            this.lblR1.Text = "R1";
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Location = new System.Drawing.Point(48, 72);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(21, 13);
            this.lblR2.TabIndex = 6;
            this.lblR2.Text = "R2";
            // 
            // lblR3
            // 
            this.lblR3.AutoSize = true;
            this.lblR3.Location = new System.Drawing.Point(48, 121);
            this.lblR3.Name = "lblR3";
            this.lblR3.Size = new System.Drawing.Size(21, 13);
            this.lblR3.TabIndex = 7;
            this.lblR3.Text = "R3";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(146, 26);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 59);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(45, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 22);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Convertor Triângulo > Estrela";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPrincipal.Controls.Add(this.groupBox1);
            this.pnlPrincipal.Location = new System.Drawing.Point(-8, 160);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(351, 221);
            this.pnlPrincipal.TabIndex = 10;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.Location = new System.Drawing.Point(49, 26);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(53, 59);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.Location = new System.Drawing.Point(54, 36);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(222, 98);
            this.pbxLogo.TabIndex = 11;
            this.pbxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnConverter);
            this.panel1.Location = new System.Drawing.Point(-8, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 113);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblR3);
            this.groupBox1.Controls.Add(this.lblR2);
            this.groupBox1.Controls.Add(this.lblR1);
            this.groupBox1.Controls.Add(this.txtR3);
            this.groupBox1.Controls.Add(this.txtR2);
            this.groupBox1.Controls.Add(this.txtR1);
            this.groupBox1.Location = new System.Drawing.Point(29, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 172);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resistências:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ω";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ω";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ω";
            // 
            // TmrUpdate
            // 
            this.TmrUpdate.Enabled = true;
            this.TmrUpdate.Interval = 500;
            this.TmrUpdate.Tick += new System.EventHandler(this.TmrUpdate_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(334, 486);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.pnlPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertor";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.TextBox txtR3;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblR3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TmrUpdate;

    }
}

