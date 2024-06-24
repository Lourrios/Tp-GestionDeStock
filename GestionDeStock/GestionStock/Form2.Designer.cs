namespace GestionStock
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            bntproductos = new Button();
            bntVentas = new Button();
            btncompras = new Button();
            btnsalir = new Button();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // bntproductos
            // 
            bntproductos.BackColor = SystemColors.ButtonHighlight;
            bntproductos.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic);
            bntproductos.Location = new Point(153, 90);
            bntproductos.Name = "bntproductos";
            bntproductos.Size = new Size(185, 42);
            bntproductos.TabIndex = 0;
            bntproductos.Text = "PRODUCTOS";
            bntproductos.UseVisualStyleBackColor = false;
            bntproductos.Click += bntproductos_Click;
            // 
            // bntVentas
            // 
            bntVentas.BackColor = SystemColors.ButtonHighlight;
            bntVentas.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic);
            bntVentas.Location = new Point(153, 153);
            bntVentas.Name = "bntVentas";
            bntVentas.Size = new Size(185, 37);
            bntVentas.TabIndex = 1;
            bntVentas.Text = "VENTAS";
            bntVentas.UseVisualStyleBackColor = false;
            bntVentas.Click += bntVentas_Click;
            // 
            // btncompras
            // 
            btncompras.BackColor = SystemColors.ButtonHighlight;
            btncompras.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic);
            btncompras.Location = new Point(153, 223);
            btncompras.Name = "btncompras";
            btncompras.Size = new Size(185, 38);
            btncompras.TabIndex = 2;
            btncompras.Text = "COMPRAS";
            btncompras.UseVisualStyleBackColor = false;
            btncompras.Click += btncompras_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = SystemColors.ButtonHighlight;
            btnsalir.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(217, 296);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(88, 34);
            btnsalir.TabIndex = 3;
            btnsalir.Text = "Log out";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Consolas", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 19);
            label1.Name = "label1";
            label1.Size = new Size(239, 34);
            label1.TabIndex = 4;
            label1.Text = "ADMINISTRACION";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(426, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 199);
            panel1.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(670, 368);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnsalir);
            Controls.Add(btncompras);
            Controls.Add(bntVentas);
            Controls.Add(bntproductos);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntproductos;
        private Button bntVentas;
        private Button btncompras;
        private Button btnsalir;
        private Label label1;
        private Panel panel1;
    }
}