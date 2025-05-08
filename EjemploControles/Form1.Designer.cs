namespace EjemploControles
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
            components = new System.ComponentModel.Container();
            lbNombre = new Label();
            txNombre = new TextBox();
            lbCodigo = new Label();
            lbFamilia = new Label();
            txCodigo = new TextBox();
            lbPoblacion = new Label();
            lbxPoblacion = new ListBox();
            rbDesempleados = new RadioButton();
            rbOcupados = new RadioButton();
            gbColectivo = new GroupBox();
            ckCertificados = new CheckBox();
            lbFecha = new Label();
            dtInicio = new DateTimePicker();
            pbFoto = new PictureBox();
            btCargar = new Button();
            btAgregar = new Button();
            cbFamilia = new ComboBox();
            aviso = new ToolTip(components);
            btPrueba = new Button();
            dgvCursos = new DataGridView();
            gbColectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AccessibleDescription = "Nombre";
            lbNombre.AccessibleName = "Nombre";
            lbNombre.AccessibleRole = AccessibleRole.Grip;
            lbNombre.AutoSize = true;
            lbNombre.BackColor = SystemColors.ButtonShadow;
            lbNombre.Location = new Point(252, 43);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(67, 20);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre:\r\n";
            // 
            // txNombre
            // 
            txNombre.Location = new Point(339, 43);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 4;
            txNombre.Leave += txNombre_Leave;
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.BackColor = SystemColors.ControlDark;
            lbCodigo.Location = new Point(14, 43);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(61, 20);
            lbCodigo.TabIndex = 1;
            lbCodigo.Text = "Código:";
            // 
            // lbFamilia
            // 
            lbFamilia.AutoSize = true;
            lbFamilia.BackColor = SystemColors.ControlDark;
            lbFamilia.Location = new Point(505, 43);
            lbFamilia.Name = "lbFamilia";
            lbFamilia.Size = new Size(137, 20);
            lbFamilia.TabIndex = 5;
            lbFamilia.Text = "Familia Profesional:";
            // 
            // txCodigo
            // 
            txCodigo.Location = new Point(97, 43);
            txCodigo.Name = "txCodigo";
            txCodigo.Size = new Size(125, 27);
            txCodigo.TabIndex = 2;
            txCodigo.Leave += txCodigo_Leave;
            // 
            // lbPoblacion
            // 
            lbPoblacion.AutoSize = true;
            lbPoblacion.BackColor = SystemColors.ControlDark;
            lbPoblacion.Location = new Point(14, 203);
            lbPoblacion.Name = "lbPoblacion";
            lbPoblacion.Size = new Size(77, 20);
            lbPoblacion.TabIndex = 9;
            lbPoblacion.Text = "Población:";
            // 
            // lbxPoblacion
            // 
            lbxPoblacion.FormattingEnabled = true;
            lbxPoblacion.Location = new Point(97, 203);
            lbxPoblacion.Name = "lbxPoblacion";
            lbxPoblacion.Size = new Size(150, 104);
            lbxPoblacion.TabIndex = 10;
            // 
            // rbDesempleados
            // 
            rbDesempleados.AutoSize = true;
            rbDesempleados.Location = new Point(4, 40);
            rbDesempleados.Name = "rbDesempleados";
            rbDesempleados.Size = new Size(123, 24);
            rbDesempleados.TabIndex = 0;
            rbDesempleados.Text = "Desempleado";
            rbDesempleados.UseVisualStyleBackColor = true;
            // 
            // rbOcupados
            // 
            rbOcupados.AutoSize = true;
            rbOcupados.Location = new Point(127, 40);
            rbOcupados.Name = "rbOcupados";
            rbOcupados.Size = new Size(91, 24);
            rbOcupados.TabIndex = 1;
            rbOcupados.TabStop = true;
            rbOcupados.Text = "Ocupado";
            rbOcupados.UseVisualStyleBackColor = true;
            // 
            // gbColectivo
            // 
            gbColectivo.Controls.Add(rbDesempleados);
            gbColectivo.Controls.Add(rbOcupados);
            gbColectivo.Location = new Point(281, 203);
            gbColectivo.Name = "gbColectivo";
            gbColectivo.Size = new Size(250, 104);
            gbColectivo.TabIndex = 11;
            gbColectivo.TabStop = false;
            gbColectivo.Text = "Colectivo:";
            // 
            // ckCertificados
            // 
            ckCertificados.AutoSize = true;
            ckCertificados.Location = new Point(577, 203);
            ckCertificados.Name = "ckCertificados";
            ckCertificados.Size = new Size(104, 24);
            ckCertificados.TabIndex = 12;
            ckCertificados.Text = "Certificado";
            ckCertificados.UseVisualStyleBackColor = true;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Location = new Point(577, 287);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(111, 20);
            lbFecha.TabIndex = 13;
            lbFecha.Text = "Fecha de inicio:";
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(765, 287);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(250, 27);
            dtInicio.TabIndex = 0;
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(900, 43);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(200, 224);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 14;
            pbFoto.TabStop = false;
            // 
            // btCargar
            // 
            btCargar.Location = new Point(1121, 48);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(138, 29);
            btCargar.TabIndex = 7;
            btCargar.Text = "Cargar imagen";
            btCargar.UseVisualStyleBackColor = true;
            btCargar.Click += btCargar_Click;
            // 
            // btAgregar
            // 
            btAgregar.Location = new Point(1121, 129);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(138, 29);
            btAgregar.TabIndex = 8;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // cbFamilia
            // 
            cbFamilia.FormattingEnabled = true;
            cbFamilia.Location = new Point(660, 43);
            cbFamilia.Name = "cbFamilia";
            cbFamilia.Size = new Size(201, 28);
            cbFamilia.TabIndex = 6;
            // 
            // btPrueba
            // 
            btPrueba.Location = new Point(14, 345);
            btPrueba.Name = "btPrueba";
            btPrueba.Size = new Size(94, 29);
            btPrueba.TabIndex = 15;
            btPrueba.Text = "Probar";
            btPrueba.UseVisualStyleBackColor = true;
            btPrueba.Click += btPrueba_Click;
            // 
            // dgvCursos
            // 
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(66, 401);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCursos.Size = new Size(1193, 188);
            dgvCursos.TabIndex = 16;
            dgvCursos.SelectionChanged += dgvCursos_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 664);
            Controls.Add(dgvCursos);
            Controls.Add(btPrueba);
            Controls.Add(cbFamilia);
            Controls.Add(btAgregar);
            Controls.Add(btCargar);
            Controls.Add(pbFoto);
            Controls.Add(dtInicio);
            Controls.Add(lbFecha);
            Controls.Add(ckCertificados);
            Controls.Add(gbColectivo);
            Controls.Add(lbxPoblacion);
            Controls.Add(lbPoblacion);
            Controls.Add(txCodigo);
            Controls.Add(lbFamilia);
            Controls.Add(lbCodigo);
            Controls.Add(txNombre);
            Controls.Add(lbNombre);
            Name = "Form1";
            Text = "Formulario";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            gbColectivo.ResumeLayout(false);
            gbColectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombre;
        private TextBox txNombre;
        private Label lbCodigo;
        private Label lbFamilia;
        private TextBox txCodigo;
        private Label lbPoblacion;
        private ListBox lbxPoblacion;
        private RadioButton rbDesempleados;
        private RadioButton rbOcupados;
        private GroupBox gbColectivo;
        private CheckBox ckCertificados;
        private Label lbFecha;
        private DateTimePicker dtInicio;
        private PictureBox pbFoto;
        private Button btCargar;
        private Button btAgregar;
        private ComboBox cbFamilia;
        private ToolTip aviso;
        private Button btPrueba;
        private DataGridView dgvCursos;
    }
}
