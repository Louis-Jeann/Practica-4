namespace Practica__4_add
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPromedio = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            lstEstudiantes = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 22);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 22);
            label2.Name = "label2";
            label2.Size = new Size(102, 31);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(497, 22);
            label3.Name = "label3";
            label3.Size = new Size(119, 31);
            label3.TabIndex = 2;
            label3.Text = "Promedio";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 61);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(172, 27);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(241, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(478, 61);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(162, 27);
            txtPromedio.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 192, 192);
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(511, 132);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 54);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(511, 266);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 45);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.FromArgb(255, 192, 192);
            btnOrdenar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.Location = new Point(512, 406);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(128, 48);
            btnOrdenar.TabIndex = 8;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.Location = new Point(84, 175);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new Size(344, 204);
            lstEstudiantes.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(971, 713);
            Controls.Add(lstEstudiantes);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPromedio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Promedio de Estudiantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPromedio;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnOrdenar;
        private ListBox lstEstudiantes;
    }
}
