namespace EjemploControles
{

    public partial class Form1 : Form
    {
        string rutaImagen = "";
        List<Cursos> listaCursos = new List<Cursos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarControles()
        {
            cbFamilia.Items.Add("Inform�tica y Comunicaciones");
            cbFamilia.Items.Add("Administrativo");
            cbFamilia.Items.Add("Sanidad");
            cbFamilia.SelectedIndex = 0;

            lbxPoblacion.Items.Add("Avil�s");
            lbxPoblacion.Items.Add("Gij�n");
            lbxPoblacion.Items.Add("Oviedo");
            lbxPoblacion.SelectedIndex = 0;

            rbDesempleados.Checked = false;
        }
        private bool validarEntero(string dato)
        {
            if (int.TryParse(dato, out int valor))
            {
                return true;
            }
            return false;
        }

        private bool validarTexto(string dato)
        {
            if (string.IsNullOrEmpty(dato))
            {
                return false;
            }
            return true;
        }
        private void txCodigo_Leave(object sender, EventArgs e)
        {
            bool resultado = validarEntero(txCodigo.Text);
            if (!resultado)
            {
                aviso.Show("Tiene que ser un n�mero entero.", txCodigo, 0, txCodigo.Height + 5, 2000);
                txCodigo.Focus();
            }
        }

        private void txNombre_Leave(object sender, EventArgs e)
        {
            bool resultado = validarTexto(txNombre.Text);
            if (!resultado)
            {
                aviso.Show("El campo no puede estar vac�o.", txNombre, 0, txNombre.Height + 5, 2000);
                txNombre.Focus();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cargarControles();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ima�genes(*.jpg;*png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = ofd.FileName;
                pbFoto.Image = Image.FromFile(rutaImagen);
            }
        }

        private void btPrueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El c�digo del curso es {txCodigo.Text} y la familia profesional es {cbFamilia.Text}");
            MessageBox.Show($"La fecha es {dtInicio.Value.ToString()}");
            string mensaje = rbDesempleados.Checked ? rbDesempleados.Text : rbOcupados.Text;
            MessageBox.Show($"El colectivo es {mensaje}");
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseas agregar el registro", "Confirmaci�n", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Cursos c = new Cursos();
                c.Codigo = int.Parse(txCodigo.Text);
                c.Curso = txNombre.Text;
                c.Familia = cbFamilia.Text;
                c.Poblacion = lbxPoblacion.Text;
                c.Colectivo = rbDesempleados.Checked ? rbDesempleados.Text : rbOcupados.Text;
                c.Certificado = ckCertificados.Checked;
                c.Inicio = dtInicio.Value;
                c.Ruta = rutaImagen;
                listaCursos.Add(c);
                dgvCursos.DataSource = null;
                dgvCursos.DataSource = listaCursos;
            }
        }
    }
}