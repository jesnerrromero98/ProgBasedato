using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacionExpediente;
using CapaPresentacionMedico;
using CapaPresentacionConsulta;
using CapaPresentacionReceta;
using capapresentacionWF;
using CapaPresentacionEspecialidad;

namespace capapresentacionWF
{
    public partial class registroMDI : Form
    {

        public registroMDI()
        {
            InitializeComponent();
        }



        private void ExpedienteMenu_Click(object sender, EventArgs e)
        {
            var formulario = new fExpediente();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void MedicoMenu_Click(object sender, EventArgs e)
        {
            var formulario = new fMedico();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void ConsultaMenu_Click(object sender, EventArgs e)
        {
            var formulario = new fConsulta();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void EspecialidadMenu_Click(object sender, EventArgs e)
        {
            var formulario = new fEspecialidad();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void RecetaMenu_Click(object sender, EventArgs e)
        {
            var formulario = new fReceta();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void CitaMenu_Click(object sender, EventArgs e)
        {
            var formulario = new Form1();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void registroMDI_Load(object sender, EventArgs e)
        {
            this.Text = $"{this.Text} - {config.UsuarioActual.LoginName}";
            permisos();
        }

        private void permisos()
        {
            switch (config.UsuarioActual.LoginName)
            {
                case "admin":
                    MedicoMenu.Visible = false;
                    ConsultaMenu.Visible = false;
                    RecetaMenu.Visible = false;
                    break;
                case "doctor":
                    ExpedienteMenu.Visible = false;
                    EspecialidadMenu.Visible = false;
                    CitaMenu.Visible = false;
                    break;
            }
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
