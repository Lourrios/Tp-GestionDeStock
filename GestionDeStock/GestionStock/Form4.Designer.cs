namespace GestionStock
{
    partial class Productos_por_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_por_Categoria));
            dataGridView1 = new DataGridView();
            btnSalir = new Button();
            bntAgregar = new Button();
            bntEditar = new Button();
            btnDesahibilar = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnAtras = new Button();
            btnSiguiente = new Button();
            labelPaginado = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(522, 272);
            dataGridView1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(588, 339);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 29);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // bntAgregar
            // 
            bntAgregar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            bntAgregar.Location = new Point(577, 189);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(109, 23);
            bntAgregar.TabIndex = 2;
            bntAgregar.Text = "AGREGAR";
            bntAgregar.UseVisualStyleBackColor = true;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // bntEditar
            // 
            bntEditar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            bntEditar.Location = new Point(577, 243);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(109, 23);
            bntEditar.TabIndex = 3;
            bntEditar.Text = "EDITAR";
            bntEditar.UseVisualStyleBackColor = true;
            bntEditar.Click += bntEditar_Click;
            // 
            // btnDesahibilar
            // 
            btnDesahibilar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnDesahibilar.Location = new Point(567, 294);
            btnDesahibilar.Name = "btnDesahibilar";
            btnDesahibilar.Size = new Size(130, 23);
            btnDesahibilar.TabIndex = 4;
            btnDesahibilar.Text = "DESHABILITAR";
            btnDesahibilar.UseVisualStyleBackColor = true;
            btnDesahibilar.Click += btnDesahibilar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(555, 149);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 5;
            label1.Text = "ADMINISTRAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 44);
            label2.Name = "label2";
            label2.Size = new Size(311, 28);
            label2.TabIndex = 6;
            label2.Text = "PRODUCTOS POR CATEGORIA";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(540, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 132);
            panel1.TabIndex = 7;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(12, 396);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 8;
            btnAtras.Text = "<Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(93, 397);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 9;
            btnSiguiente.Text = "Siguiente>";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // labelPaginado
            // 
            labelPaginado.AutoSize = true;
            labelPaginado.Location = new Point(433, 396);
            labelPaginado.Name = "labelPaginado";
            labelPaginado.Size = new Size(38, 15);
            labelPaginado.TabIndex = 10;
            labelPaginado.Text = "label3";
            // 
            // Productos_por_Categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(769, 447);
            Controls.Add(labelPaginado);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDesahibilar);
            Controls.Add(bntEditar);
            Controls.Add(bntAgregar);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Name = "Productos_por_Categoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSalir;
        private Button bntAgregar;
        private Button bntEditar;
        private Button btnDesahibilar;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnAtras;
        private Button btnSiguiente;
        private Label labelPaginado;
    }
}