namespace GestionStock
{
    partial class Form4
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            bntAgregar = new Button();
            bntEditar = new Button();
            btnDesahibilar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(522, 334);
            dataGridView1.TabIndex = 0;
           
            // 
            // button1
            // 
            button1.Location = new Point(604, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // bntAgregar
            // 
            bntAgregar.Location = new Point(604, 86);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(133, 23);
            bntAgregar.TabIndex = 2;
            bntAgregar.Text = "AGREGAR";
            bntAgregar.UseVisualStyleBackColor = true;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // bntEditar
            // 
            bntEditar.Location = new Point(604, 143);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(133, 23);
            bntEditar.TabIndex = 3;
            bntEditar.Text = "EDITAR";
            bntEditar.UseVisualStyleBackColor = true;
            // 
            // btnDesahibilar
            // 
            btnDesahibilar.Location = new Point(604, 210);
            btnDesahibilar.Name = "btnDesahibilar";
            btnDesahibilar.Size = new Size(125, 23);
            btnDesahibilar.TabIndex = 4;
            btnDesahibilar.Text = "DESHABILITAR";
            btnDesahibilar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(521, 45);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 5;
            label1.Text = "ADMINISTRAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 19);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 6;
            label2.Text = "PRODUCTOS POR CATEGORIA";
            
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(769, 447);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDesahibilar);
            Controls.Add(bntEditar);
            Controls.Add(bntAgregar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button bntAgregar;
        private Button bntEditar;
        private Button btnDesahibilar;
        private Label label1;
        private Label label2;
    }
}