namespace GestionStock
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            dataGridView1 = new DataGridView();
            btnAdministrar = new Button();
            lblproductos = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(352, 150);
            dataGridView1.TabIndex = 0;
           
            // 
            // btnAdministrar
            // 
            btnAdministrar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdministrar.Location = new Point(135, 281);
            btnAdministrar.Name = "btnAdministrar";
            btnAdministrar.Size = new Size(152, 40);
            btnAdministrar.TabIndex = 1;
            btnAdministrar.Text = "ADMINISTRAR";
            btnAdministrar.UseVisualStyleBackColor = true;
            btnAdministrar.Click += btnAdministrar_Click;
            // 
            // lblproductos
            // 
            lblproductos.AutoSize = true;
            lblproductos.Font = new Font("Consolas", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblproductos.Location = new Point(161, 69);
            lblproductos.Name = "lblproductos";
            lblproductos.Size = new Size(142, 28);
            lblproductos.TabIndex = 2;
            lblproductos.Text = "CATEGORIAS";
           
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(306, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(129, 100);
            panel1.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(511, 380);
            Controls.Add(panel1);
            Controls.Add(lblproductos);
            Controls.Add(btnAdministrar);
            Controls.Add(dataGridView1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdministrar;
        private Label lblproductos;
        private Panel panel1;
    }
}