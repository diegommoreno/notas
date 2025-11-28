using bdd_5to_3parcial.clases;
using System.Web;

namespace bdd_5to_3parcial
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }
        NotaFunciones repo = new NotaFunciones();

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarNotas();
        }

        void CargarNotas()
        {
            dgvNotas.DataSource = repo.ObtenerNotas();
            if (dgvNotas.Columns["id"] != null)
            {
                dgvNotas.Columns["id"].Visible = false;
            }
            dgvNotas.Columns["Titulo"].HeaderText = "Título";
            dgvNotas.Columns["Contenido"].HeaderText = "Texto";
            dgvNotas.Columns["Tags"].HeaderText = "Etiquetas";
            dgvNotas.Columns["FechaCreacion"].HeaderText = "Fecha";


        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Nueva_Nota f = new(repo);
            f.ShowDialog();
            CargarNotas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvNotas.SelectedRows.Count == null)
            {
                MessageBox.Show("No hay notas para actualizar");
            }
            if (dgvNotas.SelectedRows.Count == 0) return;

            var nota = dgvNotas.SelectedRows[0].DataBoundItem as Notas;
            Editar_Nota f = new(repo, nota);
            f.ShowDialog();
            CargarNotas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvNotas.SelectedRows.Count == 0) return;
            var nota = dgvNotas.SelectedRows[0].DataBoundItem as Notas;
            repo.EliminarNota(nota.Id);
            CargarNotas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var filtro = txtBuscar.Text.ToLower();
            var lista = repo.ObtenerNotas();

            var resultado = lista.Where(n =>
                n.Titulo.ToLower().Contains(filtro) ||
                n.Tags.ToLower().Contains(filtro)
            ).ToList();

            dgvNotas.DataSource = resultado;
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

