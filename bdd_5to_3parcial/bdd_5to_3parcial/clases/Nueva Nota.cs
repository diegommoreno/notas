using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bdd_5to_3parcial.clases;

namespace bdd_5to_3parcial.clases
{
    public partial class Nueva_Nota : Form
    {
        private NotaFunciones repo;

        public Nueva_Nota(NotaFunciones r)
        {
            InitializeComponent();
            repo = r;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nota = new Notas()
            {
                Titulo = txtTitulo.Text,
                Contenido = txtContenido.Text,
                Tags = txtTags.Text
            };
                
            repo.CrearNota(nota);
            MessageBox.Show("Nota creada");
            this.Close();
        }
    }
}

