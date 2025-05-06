namespace EjemploControles
{
    public partial class Form1 : Form
    {
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarControles();
        }

        private void txNombre_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
