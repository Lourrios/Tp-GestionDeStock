namespace GestionStock
{
    partial class ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventas));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            panel1 = new Panel();
            labelPaginado = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 0;
            label1.Text = "VENTAS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(488, 200);
            dataGridView1.TabIndex = 1;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(43, 292);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "<Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(133, 292);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "Siguiente>";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(516, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 150);
            panel1.TabIndex = 4;
            // 
            // labelPaginado
            // 
            labelPaginado.AutoSize = true;
            labelPaginado.Location = new Point(414, 295);
            labelPaginado.Name = "labelPaginado";
            labelPaginado.Size = new Size(38, 15);
            labelPaginado.TabIndex = 5;
            labelPaginado.Text = "label2";
            // 
            // ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 408);
            Controls.Add(labelPaginado);
            Controls.Add(panel1);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Panel panel1;
        private Label labelPaginado;
    }
}