namespace Actividad1
{
    partial class SolicitudDeMateriales
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
            buttonAñadir = new Button();
            labSolicitud = new Label();
            textNombre = new TextBox();
            comboMateriales = new ComboBox();
            labNombre = new Label();
            labArea = new Label();
            textArea = new TextBox();
            labMaterial = new Label();
            labCantidad = new Label();
            numericCantidad = new NumericUpDown();
            labMaterialesLista = new Label();
            listMateriales = new ListBox();
            buttonEliminar = new Button();
            labFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            buttonCancelar = new Button();
            buttonSolicitud = new Button();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            SuspendLayout();
            // 
            // buttonAñadir
            // 
            buttonAñadir.Location = new Point(10, 391);
            buttonAñadir.Name = "buttonAñadir";
            buttonAñadir.Size = new Size(148, 46);
            buttonAñadir.TabIndex = 0;
            buttonAñadir.Text = "Añadir a la lista";
            buttonAñadir.UseVisualStyleBackColor = true;
            // 
            // labSolicitud
            // 
            labSolicitud.AutoSize = true;
            labSolicitud.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labSolicitud.Location = new Point(12, 20);
            labSolicitud.Name = "labSolicitud";
            labSolicitud.Size = new Size(271, 31);
            labSolicitud.TabIndex = 1;
            labSolicitud.Text = "Solicitud de Materiales";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(12, 107);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Ingrese su nombre";
            textNombre.Size = new Size(241, 27);
            textNombre.TabIndex = 3;
            // 
            // comboMateriales
            // 
            comboMateriales.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMateriales.FormattingEnabled = true;
            comboMateriales.Items.AddRange(new object[] { "Seleccione un material ", "Tijeras ", "Lápices", "Cuadernos", "Biromes" });
            comboMateriales.Location = new Point(12, 261);
            comboMateriales.Name = "comboMateriales";
            comboMateriales.Size = new Size(241, 28);
            comboMateriales.TabIndex = 4;
            comboMateriales.Tag = "";
            // 
            // labNombre
            // 
            labNombre.AutoSize = true;
            labNombre.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labNombre.Location = new Point(12, 76);
            labNombre.Name = "labNombre";
            labNombre.Size = new Size(201, 25);
            labNombre.TabIndex = 5;
            labNombre.Text = "Nombre del empleado: ";
            // 
            // labArea
            // 
            labArea.AutoSize = true;
            labArea.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labArea.Location = new Point(12, 154);
            labArea.Name = "labArea";
            labArea.Size = new Size(57, 25);
            labArea.TabIndex = 6;
            labArea.Text = "Área: ";
            // 
            // textArea
            // 
            textArea.Location = new Point(12, 182);
            textArea.Name = "textArea";
            textArea.PlaceholderText = "Ingrese su área";
            textArea.Size = new Size(241, 27);
            textArea.TabIndex = 7;
            // 
            // labMaterial
            // 
            labMaterial.AutoSize = true;
            labMaterial.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labMaterial.Location = new Point(12, 233);
            labMaterial.Name = "labMaterial";
            labMaterial.Size = new Size(165, 25);
            labMaterial.TabIndex = 9;
            labMaterial.Text = "Material solicitado: ";
            // 
            // labCantidad
            // 
            labCantidad.AutoSize = true;
            labCantidad.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCantidad.Location = new Point(12, 314);
            labCantidad.Name = "labCantidad";
            labCantidad.Size = new Size(92, 25);
            labCantidad.TabIndex = 10;
            labCantidad.Text = "Cantidad: ";
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(12, 342);
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(241, 27);
            numericCantidad.TabIndex = 11;
            // 
            // labMaterialesLista
            // 
            labMaterialesLista.AutoSize = true;
            labMaterialesLista.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labMaterialesLista.Location = new Point(10, 479);
            labMaterialesLista.Name = "labMaterialesLista";
            labMaterialesLista.Size = new Size(232, 31);
            labMaterialesLista.TabIndex = 12;
            labMaterialesLista.Text = "Lista de Materiales ";
            // 
            // listMateriales
            // 
            listMateriales.FormattingEnabled = true;
            listMateriales.Items.AddRange(new object[] { "Material: Tijera Cantidad: 2" });
            listMateriales.Location = new Point(12, 525);
            listMateriales.Name = "listMateriales";
            listMateriales.Size = new Size(310, 104);
            listMateriales.TabIndex = 13;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(339, 583);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(152, 46);
            buttonEliminar.TabIndex = 14;
            buttonEliminar.Text = "Eliminar elemento";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // labFecha
            // 
            labFecha.AutoSize = true;
            labFecha.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labFecha.Location = new Point(10, 658);
            labFecha.Name = "labFecha";
            labFecha.Size = new Size(162, 25);
            labFecha.TabIndex = 15;
            labFecha.Text = "Fecha de solicitud: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(10, 686);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(10, 795);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(152, 46);
            buttonCancelar.TabIndex = 17;
            buttonCancelar.Text = "Cancelar Solicitud";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSolicitud
            // 
            buttonSolicitud.Location = new Point(12, 738);
            buttonSolicitud.Name = "buttonSolicitud";
            buttonSolicitud.Size = new Size(152, 46);
            buttonSolicitud.TabIndex = 18;
            buttonSolicitud.Text = "Enviar Solicitud";
            buttonSolicitud.UseVisualStyleBackColor = true;
            // 
            // SolicitudDeMateriales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 853);
            Controls.Add(buttonSolicitud);
            Controls.Add(buttonCancelar);
            Controls.Add(dateTimePicker1);
            Controls.Add(labFecha);
            Controls.Add(buttonEliminar);
            Controls.Add(listMateriales);
            Controls.Add(labMaterialesLista);
            Controls.Add(numericCantidad);
            Controls.Add(labCantidad);
            Controls.Add(labMaterial);
            Controls.Add(textArea);
            Controls.Add(labArea);
            Controls.Add(labNombre);
            Controls.Add(comboMateriales);
            Controls.Add(textNombre);
            Controls.Add(labSolicitud);
            Controls.Add(buttonAñadir);
            Name = "SolicitudDeMateriales";
            Text = "Solicitud de Materiales";
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAñadir;
        private Label labSolicitud;
        private TextBox textNombre;
        private ComboBox comboMateriales;
        private Label labNombre;
        private Label labArea;
        private TextBox textArea;
        private Label labMaterial;
        private Label labCantidad;
        private NumericUpDown numericCantidad;
        private Label labMaterialesLista;
        private ListBox listMateriales;
        private Button buttonEliminar;
        private Label labFecha;
        private DateTimePicker dateTimePicker1;
        private Button buttonCancelar;
        private Button buttonSolicitud;
    }
}
