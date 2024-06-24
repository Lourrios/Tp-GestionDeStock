namespace GestionStock
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            label1 = new Label();
            btnEditar = new Button();
            label2 = new Label();
            label3 = new Label();
            checkBoxHabilitado = new CheckBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            txtProducto = new TextBox();
            btnSalir = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 31);
            label1.Name = "label1";
            label1.Size = new Size(160, 22);
            label1.TabIndex = 0;
            label1.Text = "EDITAR PRODUCTO";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(74, 270);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            label2.Location = new Point(37, 91);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 2;
            label2.Text = "PRODUCTO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            label3.Location = new Point(37, 211);
            label3.Name = "label3";
            label3.Size = new Size(96, 18);
            label3.TabIndex = 3;
            label3.Text = "HABILITADO:";
            // 
            // checkBoxHabilitado
            // 
            checkBoxHabilitado.AutoSize = true;
            checkBoxHabilitado.Location = new Point(144, 215);
            checkBoxHabilitado.Name = "checkBoxHabilitado";
            checkBoxHabilitado.Size = new Size(15, 14);
            checkBoxHabilitado.TabIndex = 4;
            checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            label4.Location = new Point(37, 156);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 5;
            label4.Text = "PRECIO:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(144, 151);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 6;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(144, 91);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(215, 270);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(284, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 147);
            panel1.TabIndex = 9;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(498, 397);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(txtProducto);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(checkBoxHabilitado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Name = "Editar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEditar;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxHabilitado;
        private Label label4;
        private TextBox txtPrecio;
        private TextBox txtProducto;
        private Button btnSalir;
        private Panel panel1;
    }
}