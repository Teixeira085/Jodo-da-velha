namespace Jodo_da_velha
{
    partial class Form1
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
            this.pibResetar = new System.Windows.Forms.PictureBox();
            this.pibFechar = new System.Windows.Forms.PictureBox();
            this.pibTicTac = new System.Windows.Forms.PictureBox();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pibJogo = new System.Windows.Forms.PictureBox();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibResetar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTicTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pibResetar
            // 
            this.pibResetar.Image = global::Jodo_da_velha.Properties.Resources._1564533_arrow_refrech_reload_update_icon;
            this.pibResetar.Location = new System.Drawing.Point(477, 315);
            this.pibResetar.Name = "pibResetar";
            this.pibResetar.Size = new System.Drawing.Size(100, 50);
            this.pibResetar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibResetar.TabIndex = 5;
            this.pibResetar.TabStop = false;
            this.pibResetar.Click += new System.EventHandler(this.pibResetar_Click);
            // 
            // pibFechar
            // 
            this.pibFechar.Image = global::Jodo_da_velha.Properties.Resources.multiply;
            this.pibFechar.Location = new System.Drawing.Point(477, 238);
            this.pibFechar.Name = "pibFechar";
            this.pibFechar.Size = new System.Drawing.Size(100, 50);
            this.pibFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibFechar.TabIndex = 4;
            this.pibFechar.TabStop = false;
            this.pibFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // pibTicTac
            // 
            this.pibTicTac.Image = global::Jodo_da_velha.Properties.Resources.tttmarqlrg;
            this.pibTicTac.Location = new System.Drawing.Point(3, 12);
            this.pibTicTac.Name = "pibTicTac";
            this.pibTicTac.Size = new System.Drawing.Size(574, 126);
            this.pibTicTac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTicTac.TabIndex = 3;
            this.pibTicTac.TabStop = false;
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.White;
            this.btn11.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(36, 193);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(113, 95);
            this.btn11.TabIndex = 6;
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.White;
            this.btn12.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(180, 193);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(113, 95);
            this.btn12.TabIndex = 7;
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.White;
            this.btn13.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Location = new System.Drawing.Point(325, 193);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(113, 95);
            this.btn13.TabIndex = 8;
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Red;
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(31, 618);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(132, 29);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "É a vez do X";
            // 
            // pibJogo
            // 
            this.pibJogo.Image = global::Jodo_da_velha.Properties.Resources._tictactoe__1_;
            this.pibJogo.Location = new System.Drawing.Point(3, 144);
            this.pibJogo.Name = "pibJogo";
            this.pibJogo.Size = new System.Drawing.Size(468, 468);
            this.pibJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pibJogo.TabIndex = 1;
            this.pibJogo.TabStop = false;
            // 
            // btn23
            // 
            this.btn23.BackColor = System.Drawing.Color.White;
            this.btn23.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn23.Location = new System.Drawing.Point(325, 327);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(113, 95);
            this.btn23.TabIndex = 15;
            this.btn23.UseVisualStyleBackColor = false;
            this.btn23.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.Color.White;
            this.btn22.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(180, 327);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(113, 95);
            this.btn22.TabIndex = 16;
            this.btn22.UseVisualStyleBackColor = false;
            this.btn22.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn31
            // 
            this.btn31.BackColor = System.Drawing.Color.White;
            this.btn31.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn31.Location = new System.Drawing.Point(36, 479);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(113, 95);
            this.btn31.TabIndex = 17;
            this.btn31.UseVisualStyleBackColor = false;
            this.btn31.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.Color.White;
            this.btn21.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(36, 327);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(113, 95);
            this.btn21.TabIndex = 18;
            this.btn21.UseVisualStyleBackColor = false;
            this.btn21.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn32
            // 
            this.btn32.BackColor = System.Drawing.Color.White;
            this.btn32.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn32.Location = new System.Drawing.Point(180, 479);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(113, 95);
            this.btn32.TabIndex = 19;
            this.btn32.UseVisualStyleBackColor = false;
            this.btn32.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn33
            // 
            this.btn33.BackColor = System.Drawing.Color.White;
            this.btn33.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn33.Location = new System.Drawing.Point(325, 479);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(113, 95);
            this.btn33.TabIndex = 20;
            this.btn33.UseVisualStyleBackColor = false;
            this.btn33.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 656);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.pibResetar);
            this.Controls.Add(this.pibFechar);
            this.Controls.Add(this.pibTicTac);
            this.Controls.Add(this.pibJogo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pibResetar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTicTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pibTicTac;
        private System.Windows.Forms.PictureBox pibFechar;
        private System.Windows.Forms.PictureBox pibResetar;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pibJogo;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
    }
}

