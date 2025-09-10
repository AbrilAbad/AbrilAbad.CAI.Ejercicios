namespace Actividad1
{
    partial class RecepcionDeMateriales
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
            labRecepcion = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            buttonRecepcion = new Button();
            labComentario = new Label();
            textComentario = new TextBox();
            buttonError = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(12, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(696, 74);
            dataGridView1.TabIndex = 11;
            // 
            // labRecepcion
            // 
            labRecepcion.AutoSize = true;
            labRecepcion.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labRecepcion.Location = new Point(12, 9);
            labRecepcion.Name = "labRecepcion";
            labRecepcion.Size = new Size(288, 31);
            labRecepcion.TabIndex = 12;
            labRecepcion.Text = "Recepción de Materiales";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.Frozen = true;
            Column1.HeaderText = "Materiales";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Cantidades";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Fecha de Recepción";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // buttonRecepcion
            // 
            buttonRecepcion.Location = new Point(12, 231);
            buttonRecepcion.Name = "buttonRecepcion";
            buttonRecepcion.Size = new Size(176, 57);
            buttonRecepcion.TabIndex = 22;
            buttonRecepcion.Text = "Confirmar Recepción";
            buttonRecepcion.UseVisualStyleBackColor = true;
            // 
            // labComentario
            // 
            labComentario.AutoSize = true;
            labComentario.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labComentario.Location = new Point(12, 141);
            labComentario.Name = "labComentario";
            labComentario.Size = new Size(117, 25);
            labComentario.TabIndex = 23;
            labComentario.Text = "Comentarios:";
            // 
            // textComentario
            // 
            textComentario.Location = new Point(12, 169);
            textComentario.Name = "textComentario";
            textComentario.PlaceholderText = "Ingrese sus comentarios aquí...";
            textComentario.Size = new Size(307, 27);
            textComentario.TabIndex = 24;
            // 
            // buttonError
            // 
            buttonError.Location = new Point(209, 231);
            buttonError.Name = "buttonError";
            buttonError.Size = new Size(176, 57);
            buttonError.TabIndex = 25;
            buttonError.Text = "Reportar Faltante/Error";
            buttonError.UseVisualStyleBackColor = true;
            // 
            // RecepcionDeMateriales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 330);
            Controls.Add(buttonError);
            Controls.Add(textComentario);
            Controls.Add(labComentario);
            Controls.Add(buttonRecepcion);
            Controls.Add(labRecepcion);
            Controls.Add(dataGridView1);
            Name = "RecepcionDeMateriales";
            Text = "Recepción de Materiales";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label labRecepcion;
        private Button buttonRecepcion;
        private Label labComentario;
        private TextBox textComentario;
        private Button buttonError;
    }
}