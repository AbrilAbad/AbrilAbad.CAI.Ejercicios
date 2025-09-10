namespace Actividad1
{
    partial class EntregaDeMateriales
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
            labOrden = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            labDetalleOrden = new Label();
            listEntregas = new ListBox();
            labResponsable = new Label();
            textResponsable = new TextBox();
            labFechaDeEntrega = new Label();
            dateTimePicker1 = new DateTimePicker();
            buttonEntregar = new Button();
            buttonCencelarEntrega = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labOrden
            // 
            labOrden.AutoSize = true;
            labOrden.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labOrden.Location = new Point(12, 23);
            labOrden.Name = "labOrden";
            labOrden.Size = new Size(259, 31);
            labOrden.TabIndex = 9;
            labOrden.Text = "Entrega de Materiales";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(696, 74);
            dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.Frozen = true;
            Column1.HeaderText = "Número de Orden";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Proveedor";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Fecha de Emisión";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // labDetalleOrden
            // 
            labDetalleOrden.AutoSize = true;
            labDetalleOrden.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDetalleOrden.Location = new Point(12, 148);
            labDetalleOrden.Name = "labDetalleOrden";
            labDetalleOrden.Size = new Size(150, 25);
            labDetalleOrden.TabIndex = 11;
            labDetalleOrden.Text = "Detalle de Orden:";
            labDetalleOrden.Click += labNumOrden_Click;
            // 
            // listEntregas
            // 
            listEntregas.FormattingEnabled = true;
            listEntregas.Items.AddRange(new object[] { "Material: Tijera Cantidad: 2" });
            listEntregas.Location = new Point(12, 185);
            listEntregas.Name = "listEntregas";
            listEntregas.Size = new Size(320, 84);
            listEntregas.TabIndex = 14;
            // 
            // labResponsable
            // 
            labResponsable.AutoSize = true;
            labResponsable.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labResponsable.Location = new Point(12, 292);
            labResponsable.Name = "labResponsable";
            labResponsable.Size = new Size(220, 25);
            labResponsable.TabIndex = 15;
            labResponsable.Text = "Responsable de Depósito:";
            // 
            // textResponsable
            // 
            textResponsable.Location = new Point(12, 320);
            textResponsable.Name = "textResponsable";
            textResponsable.PlaceholderText = "Ingrese al responsable";
            textResponsable.Size = new Size(320, 27);
            textResponsable.TabIndex = 16;
            // 
            // labFechaDeEntrega
            // 
            labFechaDeEntrega.AutoSize = true;
            labFechaDeEntrega.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labFechaDeEntrega.Location = new Point(12, 369);
            labFechaDeEntrega.Name = "labFechaDeEntrega";
            labFechaDeEntrega.Size = new Size(151, 25);
            labFechaDeEntrega.TabIndex = 17;
            labFechaDeEntrega.Text = "Fecha de entrega:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 397);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // buttonEntregar
            // 
            buttonEntregar.Location = new Point(12, 446);
            buttonEntregar.Name = "buttonEntregar";
            buttonEntregar.Size = new Size(152, 46);
            buttonEntregar.TabIndex = 21;
            buttonEntregar.Text = "Confirmar Entrega";
            buttonEntregar.UseVisualStyleBackColor = true;
            // 
            // buttonCencelarEntrega
            // 
            buttonCencelarEntrega.Location = new Point(180, 446);
            buttonCencelarEntrega.Name = "buttonCencelarEntrega";
            buttonCencelarEntrega.Size = new Size(152, 46);
            buttonCencelarEntrega.TabIndex = 22;
            buttonCencelarEntrega.Text = "Cancelar";
            buttonCencelarEntrega.UseVisualStyleBackColor = true;
            // 
            // EntregaDeMateriales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(buttonCencelarEntrega);
            Controls.Add(buttonEntregar);
            Controls.Add(dateTimePicker1);
            Controls.Add(labFechaDeEntrega);
            Controls.Add(textResponsable);
            Controls.Add(labResponsable);
            Controls.Add(listEntregas);
            Controls.Add(labDetalleOrden);
            Controls.Add(dataGridView1);
            Controls.Add(labOrden);
            Name = "EntregaDeMateriales";
            Text = "Entrega de Materiales";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labOrden;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label labDetalleOrden;
        private ListBox listEntregas;
        private Label labResponsable;
        private TextBox textResponsable;
        private Label labFechaDeEntrega;
        private DateTimePicker dateTimePicker1;
        private Button buttonEntregar;
        private Button buttonCencelarEntrega;
    }
}