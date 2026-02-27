namespace Practica__4_add
{
    public partial class Form1 : Form
    {
        List<string> estudiantes = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string promedio = txtPromedio.Text;

            string estudiante = codigo + " - " + nombre + " - " + promedio;

            estudiantes.Add(estudiante);
            lstEstudiantes.Items.Add(estudiante);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtPromedio.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEstudiantes.SelectedItem != null)
            {
                estudiantes.Remove(lstEstudiantes.SelectedItem.ToString());
                lstEstudiantes.Items.Remove(lstEstudiantes.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un estudiante");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            estudiantes = estudiantes
            .OrderByDescending(x => double.Parse(x.Split('-')[2]))
            .ToList();

            lstEstudiantes.Items.Clear();

            foreach (var est in estudiantes)
            {
                lstEstudiantes.Items.Add(est);
            }
        }
    }
}
