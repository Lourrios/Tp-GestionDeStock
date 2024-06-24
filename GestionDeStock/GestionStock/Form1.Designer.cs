namespace GestionStock
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
            txtusuario = new TextBox();
            txtContraseña = new TextBox();
            lblusuario = new Label();
            lblcontraseña = new Label();
            lblLogin = new Label();
            bntIngresar = new Button();
            panel1 = new Panel();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(253, 120);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(284, 23);
            txtusuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(253, 194);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(284, 23);
            txtContraseña.TabIndex = 1;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuario.Location = new Point(172, 125);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(72, 18);
            lblusuario.TabIndex = 2;
            lblusuario.Text = "USUARIO:";
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcontraseña.Location = new Point(135, 195);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(96, 18);
            lblcontraseña.TabIndex = 3;
            lblcontraseña.Text = "CONTRASEÑA:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(291, 44);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(89, 32);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "LOGIN";
            // 
            // bntIngresar
            // 
            bntIngresar.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntIngresar.Location = new Point(253, 239);
            bntIngresar.Name = "bntIngresar";
            bntIngresar.Size = new Size(89, 23);
            bntIngresar.TabIndex = 5;
            bntIngresar.Text = "INGRESAR";
            bntIngresar.UseVisualStyleBackColor = true;
            bntIngresar.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(57, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(109, 131);
            panel1.TabIndex = 6;
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(384, 239);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(89, 23);
            btnsalir.TabIndex = 7;
            btnsalir.Text = "SALIR";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(620, 294);
            Controls.Add(btnsalir);
            Controls.Add(panel1);
            Controls.Add(bntIngresar);
            Controls.Add(lblLogin);
            Controls.Add(lblcontraseña);
            Controls.Add(lblusuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtusuario);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusuario;
        private TextBox txtContraseña;
        private Label lblusuario;
        private Label lblcontraseña;
        private Label lblLogin;
        private Button bntIngresar;
        private Panel panel1;
        private Button btnsalir;
    }
}
