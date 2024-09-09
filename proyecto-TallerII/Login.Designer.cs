namespace proyecto_TallerII
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.campodni = new System.Windows.Forms.Label();
            this.campocontraseña = new System.Windows.Forms.Label();
            this.botoningreso = new System.Windows.Forms.Button();
            this.botoncancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 293);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestion de ventas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 166;
            this.iconPictureBox1.Location = new System.Drawing.Point(33, 22);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(171, 166);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click_2);
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(298, 75);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(285, 26);
            this.txtdocumento.TabIndex = 3;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(298, 156);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(285, 26);
            this.txtclave.TabIndex = 4;
            // 
            // campodni
            // 
            this.campodni.AutoSize = true;
            this.campodni.Location = new System.Drawing.Point(298, 47);
            this.campodni.Name = "campodni";
            this.campodni.Size = new System.Drawing.Size(37, 20);
            this.campodni.TabIndex = 5;
            this.campodni.Text = "DNI";
            // 
            // campocontraseña
            // 
            this.campocontraseña.AutoSize = true;
            this.campocontraseña.Location = new System.Drawing.Point(294, 123);
            this.campocontraseña.Name = "campocontraseña";
            this.campocontraseña.Size = new System.Drawing.Size(92, 20);
            this.campocontraseña.TabIndex = 6;
            this.campocontraseña.Text = "Contraseña";
            // 
            // botoningreso
            // 
            this.botoningreso.BackColor = System.Drawing.Color.Green;
            this.botoningreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoningreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.botoningreso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botoningreso.Location = new System.Drawing.Point(298, 202);
            this.botoningreso.Margin = new System.Windows.Forms.Padding(0);
            this.botoningreso.Name = "botoningreso";
            this.botoningreso.Size = new System.Drawing.Size(124, 53);
            this.botoningreso.TabIndex = 7;
            this.botoningreso.Text = "Ingresar";
            this.botoningreso.UseVisualStyleBackColor = false;
            this.botoningreso.Click += new System.EventHandler(this.botoningreso_Click);
            // 
            // botoncancelar
            // 
            this.botoncancelar.BackColor = System.Drawing.Color.Brown;
            this.botoncancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botoncancelar.Location = new System.Drawing.Point(459, 206);
            this.botoncancelar.Name = "botoncancelar";
            this.botoncancelar.Size = new System.Drawing.Size(124, 49);
            this.botoncancelar.TabIndex = 8;
            this.botoncancelar.Text = "Cancelar";
            this.botoncancelar.UseVisualStyleBackColor = false;
            this.botoncancelar.Click += new System.EventHandler(this.botoncancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(43, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "MERCURIO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botoncancelar);
            this.Controls.Add(this.botoningreso);
            this.Controls.Add(this.campocontraseña);
            this.Controls.Add(this.campodni);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label campodni;
        private System.Windows.Forms.Label campocontraseña;
        private System.Windows.Forms.Button botoningreso;
        private System.Windows.Forms.Button botoncancelar;
        private System.Windows.Forms.Label label3;
    }
}