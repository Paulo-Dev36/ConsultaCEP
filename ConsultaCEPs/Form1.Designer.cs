
namespace ConsultaCEPs
{
    partial class consultaInitial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.textRua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.horas = new System.Windows.Forms.Label();
            this.maskedCep = new System.Windows.Forms.MaskedTextBox();
            this.autor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cep
            // 
            this.cep.AutoSize = true;
            this.cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cep.Location = new System.Drawing.Point(53, 46);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(59, 25);
            this.cep.TabIndex = 0;
            this.cep.Text = "CEP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultado:";
            // 
            // textEstado
            // 
            this.textEstado.BackColor = System.Drawing.Color.Silver;
            this.textEstado.Location = new System.Drawing.Point(53, 203);
            this.textEstado.Name = "textEstado";
            this.textEstado.ReadOnly = true;
            this.textEstado.Size = new System.Drawing.Size(382, 22);
            this.textEstado.TabIndex = 3;
            this.textEstado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textCidade
            // 
            this.textCidade.BackColor = System.Drawing.Color.Silver;
            this.textCidade.Location = new System.Drawing.Point(53, 269);
            this.textCidade.Name = "textCidade";
            this.textCidade.ReadOnly = true;
            this.textCidade.Size = new System.Drawing.Size(382, 22);
            this.textCidade.TabIndex = 4;
            // 
            // textBairro
            // 
            this.textBairro.BackColor = System.Drawing.Color.Silver;
            this.textBairro.Location = new System.Drawing.Point(53, 336);
            this.textBairro.Name = "textBairro";
            this.textBairro.ReadOnly = true;
            this.textBairro.Size = new System.Drawing.Size(382, 22);
            this.textBairro.TabIndex = 5;
            // 
            // textRua
            // 
            this.textRua.BackColor = System.Drawing.Color.Silver;
            this.textRua.Location = new System.Drawing.Point(53, 402);
            this.textRua.Name = "textRua";
            this.textRua.ReadOnly = true;
            this.textRua.Size = new System.Drawing.Size(382, 22);
            this.textRua.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rua:";
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bntSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntSair.Location = new System.Drawing.Point(329, 449);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(106, 34);
            this.bntSair.TabIndex = 11;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Location = new System.Drawing.Point(208, 449);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 34);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(243, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // horas
            // 
            this.horas.AutoSize = true;
            this.horas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horas.Location = new System.Drawing.Point(5, 501);
            this.horas.Margin = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(64, 17);
            this.horas.TabIndex = 14;
            this.horas.Text = "19:59:50";
            // 
            // maskedCep
            // 
            this.maskedCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskedCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedCep.Location = new System.Drawing.Point(53, 69);
            this.maskedCep.Mask = "00000-000";
            this.maskedCep.Name = "maskedCep";
            this.maskedCep.Size = new System.Drawing.Size(184, 24);
            this.maskedCep.TabIndex = 1;
            // 
            // autor
            // 
            this.autor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.autor.AutoSize = true;
            this.autor.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.autor.Location = new System.Drawing.Point(326, 501);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(165, 17);
            this.autor.TabIndex = 16;
            this.autor.Text = "Paulo Vinícius Rodrigues";
            this.autor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // consultaInitial
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(497, 523);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.maskedCep);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textRua);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cep);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "consultaInitial";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.TextBox textRua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label horas;
        private System.Windows.Forms.MaskedTextBox maskedCep;
        private System.Windows.Forms.Label autor;
    }
}

