namespace GestionStock
{
    partial class agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregar));
            btnAgregar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            panel1 = new Panel();
            labelHabilitado = new Label();
            checbHabilitado = new CheckBox();
            labelCategoria = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnAgregar.Location = new Point(86, 249);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnSalir.Location = new Point(212, 249);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label1.Location = new Point(36, 61);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 2;
            label1.Text = "PRODUCTO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label2.Location = new Point(27, 114);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 3;
            label2.Text = "CATEGORIA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.Location = new Point(36, 159);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 4;
            label3.Text = "PRECIO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(212, 20);
            label4.Name = "label4";
            label4.Size = new Size(170, 22);
            label4.TabIndex = 5;
            label4.Text = "AGREGAR PRODUCTO";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(141, 57);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(121, 23);
            txtProducto.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(141, 159);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(86, 23);
            txtPrecio.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(284, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 100);
            panel1.TabIndex = 9;
            // 
            // labelHabilitado
            // 
            labelHabilitado.AutoSize = true;
            labelHabilitado.Font = new Font("Consolas", 12F, FontStyle.Bold);
            labelHabilitado.Location = new Point(36, 199);
            labelHabilitado.Name = "labelHabilitado";
            labelHabilitado.Size = new Size(108, 19);
            labelHabilitado.TabIndex = 10;
            labelHabilitado.Text = "HABILITADO:";
            // 
            // checbHabilitado
            // 
            checbHabilitado.AutoSize = true;
            checbHabilitado.Location = new Point(159, 204);
            checbHabilitado.Name = "checbHabilitado";
            checbHabilitado.Size = new Size(15, 14);
            checbHabilitado.TabIndex = 12;
            checbHabilitado.UseVisualStyleBackColor = true;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(144, 112);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(38, 15);
            labelCategoria.TabIndex = 13;
            labelCategoria.Text = "label5";
            // 
            // agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(553, 340);
            Controls.Add(labelCategoria);
            Controls.Add(checbHabilitado);
            Controls.Add(labelHabilitado);
            Controls.Add(panel1);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Name = "agregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProducto;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
        private Panel panel1;
        private Label labelHabilitado;
        private CheckBox checbHabilitado;
        private Label labelCategoria;
    }
}