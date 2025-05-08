using System.Drawing.Drawing2D;

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
            cbFamilia.Items.Add("Informática y Comunicaciones");
            cbFamilia.Items.Add("Administrativo");
            cbFamilia.Items.Add("Sanidad");
            cbFamilia.SelectedIndex = 0;

            lbxPoblacion.Items.Add("Avilés");
            lbxPoblacion.Items.Add("Gijón");
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
                aviso.Show("Tiene que ser un número entero.", txCodigo, 0, txCodigo.Height + 5, 2000);
                txCodigo.Focus();
            }
        }

        private void txNombre_Leave(object sender, EventArgs e)
        {
            bool resultado = validarTexto(txNombre.Text);
            if (!resultado)
            {
                aviso.Show("El campo no puede estar vacío.", txNombre, 0, txNombre.Height + 5, 2000);
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
            ofd.Filter = "Imaágenes(*.jpg;*png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = ofd.FileName;
                pbFoto.Image = Image.FromFile(rutaImagen);
            }
        }

        private void btPrueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El código del curso es {txCodigo.Text} y la familia profesional es {cbFamilia.Text}");
            MessageBox.Show($"La fecha es {dtInicio.Value.ToString()}");
            string mensaje = rbDesempleados.Checked ? rbDesempleados.Text : rbOcupados.Text;
            MessageBox.Show($"El colectivo es {mensaje}");
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseas agregar el registro", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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

        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCursos.CurrentRow?.DataBoundItem is Cursos c)
            //Si la fila seleccionada no es nula, y además está enlazada con un registro que es Cursos, crea un objeto de la clase cursos llamado c.
            {
                txCodigo.Text = c.Codigo.ToString();
                txNombre.Text = c.Curso.ToString();
                cbFamilia.SelectedItem = c.Familia.ToString();
                lbxPoblacion.SelectedItem = c.Poblacion.ToString();
                if (c.Colectivo == "desempleados")
                {
                    rbDesempleados.Checked = true;
                }
                else
                {
                    rbOcupados.Checked = true;
                }
                ckCertificados.Checked = c.Certificado;
                dtInicio.Value = c.Inicio;
                if (string.IsNullOrEmpty(c.Ruta))
                {
                    pbFoto.Image = null;
                }
                else
                {
                    pbFoto.Image = Image.FromFile(c.Ruta);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("cursos.txt");
            foreach (Cursos c in listaCursos)
            {
                string linea = string.Join("|",
                    c.Codigo,
                    c.Curso,
                    c.Familia,
                    c.Poblacion,
                    c.Certificado,
                    c.Colectivo,
                    c.Inicio.ToString("yyyy-MM-dd"),
                    c.Ruta);
                sw.WriteLine(linea);
            }
            sw.Close();
        }
        private void cargarRegistros()
        {
            listaCursos = new List<Cursos>();
            if (File.Exists("cursos.text"))
            {
                string[] lineas = File.ReadAllLines("cursos.txt");
                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split('|');
                    if (partes.Length == 8)
                    {
                        Cursos c = new Cursos();
                        c.Codigo = int.Parse(partes[0]);
                        c.Curso = partes[1];
                        c.Familia = partes[2];
                        c.Poblacion = partes[3];
                        c.Certificado = bool.Parse(partes[4]);
                        c.Colectivo = partes[5];
                        c.Inicio = DateTime.Parse(partes[6]);
                        c.Ruta = partes[7];
                        listaCursos.Add(c);
                    }
                }

            }
            dgvCursos.DataSource = null;
            dgvCursos.DataSource = listaCursos;
        }
        
    }
}