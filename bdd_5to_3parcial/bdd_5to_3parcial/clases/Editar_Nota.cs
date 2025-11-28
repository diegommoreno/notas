using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdd_5to_3parcial.clases
{
    public partial class Editar_Nota : Form
    {
        private NotaFunciones repo;
        private Notas nota;

        public Editar_Nota(NotaFunciones r, Notas n)
        {
            InitializeComponent();
            repo = r;
            nota = n;

            txtTitulo.Text = n.Titulo;
            txtContenido.Text = n.Contenido;
            txtTags.Text = string.Join(",", n.Tags);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nota.Titulo = txtTitulo.Text;
            nota.Contenido = txtContenido.Text;
            nota.Tags = txtTags.Text;

            repo.ActualizarNota(nota);
            MessageBox.Show("Nota actualizada");
            this.Close();
        }
    }
}
