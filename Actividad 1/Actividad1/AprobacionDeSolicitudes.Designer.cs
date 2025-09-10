namespace Actividad1
{
    partial class AprobacionDeSolicitudes
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
            labAprobacion = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            labComentario = new Label();
            textComentario = new TextBox();
            buttonAceptar = new Button();
            buttonRechazo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labAprobacion
            // 
            labAprobacion.AutoSize = true;
            labAprobacion.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labAprobacion.Location = new Point(12, 9);
            labAprobacion.Name = "labAprobacion";
            labAprobacion.Size = new Size(307, 31);
            labAprobacion.TabIndex = 2;
            labAprobacion.Text = "Aprobación de Solicitudes";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(603, 92);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.Frozen = true;
            Column1.HeaderText = "Empleado";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 106;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Materiales";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Cantidades";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Fecha";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // labComentario
            // 
            labComentario.AutoSize = true;
            labComentario.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labComentario.Location = new Point(12, 147);
            labComentario.Name = "labComentario";
            labComentario.Size = new Size(117, 25);
            labComentario.TabIndex = 6;
            labComentario.Text = "Comentarios:";
            // 
            // textComentario
            // 
            textComentario.Location = new Point(12, 175);
            textComentario.Name = "textComentario";
            textComentario.PlaceholderText = "Ingrese sus comentarios aquí...";
            textComentario.Size = new Size(307, 27);
            textComentario.TabIndex = 7;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(12, 233);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(152, 46);
            buttonAceptar.TabIndex = 19;
            buttonAceptar.Text = "Aprobar Solicitud";
            buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // buttonRechazo
            // 
            buttonRechazo.Location = new Point(192, 233);
            buttonRechazo.Name = "buttonRechazo";
            buttonRechazo.Size = new Size(152, 46);
            buttonRechazo.TabIndex = 20;
            buttonRechazo.Text = "Rechazar Solicitud";
            buttonRechazo.UseVisualStyleBackColor = true;
            buttonRechazo.UseWaitCursor = true;
            // 
            // AprobacionDeSolicitudes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 315);
            Controls.Add(buttonRechazo);
            Controls.Add(buttonAceptar);
            Controls.Add(textComentario);
            Controls.Add(labComentario);
            Controls.Add(dataGridView1);
            Controls.Add(labAprobacion);
            Name = "AprobacionDeSolicitudes";
            Text = "Aprobación de Solicitudes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labAprobacion;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label labComentario;
        private TextBox textComentario;
        private Button buttonAceptar;
        private Button buttonRechazo;
    }
}