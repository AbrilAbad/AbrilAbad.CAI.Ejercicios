namespace Actividad1
{
    partial class GeneracionDeOrden
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
            labComentario = new Label();
            labOrden = new Label();
            dataGridView1 = new DataGridView();
            labNumOrden = new Label();
            textNumOrden = new TextBox();
            labProveedor = new Label();
            textProveedor = new TextBox();
            labFechaDeOrden = new Label();
            dateTimePicker1 = new DateTimePicker();
            buttonOrden = new Button();
            buttonCancelarOrden = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labComentario
            // 
            labComentario.AutoSize = true;
            labComentario.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labComentario.Location = new Point(12, 53);
            labComentario.Name = "labComentario";
            labComentario.Size = new Size(194, 25);
            labComentario.TabIndex = 7;
            labComentario.Text = "Solicitudes Aprobadas:";
            // 
            // labOrden
            // 
            labOrden.AutoSize = true;
            labOrden.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labOrden.Location = new Point(12, 9);
            labOrden.Name = "labOrden";
            labOrden.Size = new Size(251, 31);
            labOrden.TabIndex = 8;
            labOrden.Text = "Generación de Orden";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 92);
            dataGridView1.TabIndex = 9;
            // 
            // labNumOrden
            // 
            labNumOrden.AutoSize = true;
            labNumOrden.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labNumOrden.Location = new Point(12, 176);
            labNumOrden.Name = "labNumOrden";
            labNumOrden.Size = new Size(161, 25);
            labNumOrden.TabIndex = 10;
            labNumOrden.Text = "Número de Orden:";
            // 
            // textNumOrden
            // 
            textNumOrden.Location = new Point(12, 204);
            textNumOrden.Name = "textNumOrden";
            textNumOrden.PlaceholderText = "Ingrese número de orden";
            textNumOrden.Size = new Size(307, 27);
            textNumOrden.TabIndex = 11;
            // 
            // labProveedor
            // 
            labProveedor.AutoSize = true;
            labProveedor.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labProveedor.Location = new Point(12, 254);
            labProveedor.Name = "labProveedor";
            labProveedor.Size = new Size(98, 25);
            labProveedor.TabIndex = 12;
            labProveedor.Text = "Proveedor:";
            // 
            // textProveedor
            // 
            textProveedor.Location = new Point(12, 282);
            textProveedor.Name = "textProveedor";
            textProveedor.PlaceholderText = "Ingrese proveedor";
            textProveedor.Size = new Size(307, 27);
            textProveedor.TabIndex = 13;
            // 
            // labFechaDeOrden
            // 
            labFechaDeOrden.AutoSize = true;
            labFechaDeOrden.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labFechaDeOrden.Location = new Point(12, 332);
            labFechaDeOrden.Name = "labFechaDeOrden";
            labFechaDeOrden.Size = new Size(153, 25);
            labFechaDeOrden.TabIndex = 14;
            labFechaDeOrden.Text = "Fecha de emisión:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 360);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(307, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // buttonOrden
            // 
            buttonOrden.Location = new Point(12, 413);
            buttonOrden.Name = "buttonOrden";
            buttonOrden.Size = new Size(152, 46);
            buttonOrden.TabIndex = 20;
            buttonOrden.Text = "Generar Orden";
            buttonOrden.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarOrden
            // 
            buttonCancelarOrden.Location = new Point(188, 413);
            buttonCancelarOrden.Name = "buttonCancelarOrden";
            buttonCancelarOrden.Size = new Size(152, 46);
            buttonCancelarOrden.TabIndex = 21;
            buttonCancelarOrden.Text = "Cancelar";
            buttonCancelarOrden.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.Frozen = true;
            Column1.HeaderText = "Empleado";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Materiales";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Cantidades";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Fecha";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // GeneracionDeOrden
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(buttonCancelarOrden);
            Controls.Add(buttonOrden);
            Controls.Add(dateTimePicker1);
            Controls.Add(labFechaDeOrden);
            Controls.Add(textProveedor);
            Controls.Add(labProveedor);
            Controls.Add(textNumOrden);
            Controls.Add(labNumOrden);
            Controls.Add(dataGridView1);
            Controls.Add(labOrden);
            Controls.Add(labComentario);
            Name = "GeneracionDeOrden";
            Text = "Generación de Orden";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labComentario;
        private Label labOrden;
        private DataGridView dataGridView1;
        private Label labNumOrden;
        private TextBox textNumOrden;
        private Label labProveedor;
        private TextBox textProveedor;
        private Label labFechaDeOrden;
        private DateTimePicker dateTimePicker1;
        private Button buttonOrden;
        private Button buttonCancelarOrden;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}