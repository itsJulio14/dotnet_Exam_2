using System.ComponentModel;

namespace Exam_2
{
    public partial class Form1 : Form
    {
        public BindingList<Taller> Talleres = new BindingList<Taller>();
        public BindingList<Reserva> Reservas = new BindingList<Reserva>();

        public Form1()
        {
            InitializeComponent();
            Datos();
        }

        public void Datos()
        {
            Talleres.Add(new Taller("Programación C#", 5));
            Talleres.Add(new Taller("Diseño Web", 4));
            Talleres.Add(new Taller("Reds Basicas", 6));

            cboTaller.DataSource = Talleres;
            dtagridDatos.DataSource = Reservas;

            actDisponibilidad();
        }

        public int lugarDisponible()
        {
            if (cboTaller.SelectedItem == null)
            {
                return 0;
            }

            Taller tallerSeleccionado = (Taller)cboTaller.SelectedItem;
            int cantidadReservada = 0;

            foreach (Reserva reserva in Reservas)
            {
                if (reserva.Taller == tallerSeleccionado)
                {
                    cantidadReservada += reserva.Cantidad;
                }
            }

            return tallerSeleccionado.CupoMaximo - cantidadReservada;

        }

        public void actDisponibilidad()
        {
            if (cboTaller.SelectedItem != null)
            {
                lblLugarDisp.Text = "Lugares disponibles: " + lugarDisponible();
            }
        }

        private void btnRegR_Click(object sender, EventArgs e)
        {
            string responsable = txtResp.Text.Trim();

            if (string.IsNullOrWhiteSpace(responsable))
            {
                MessageBox.Show("Ingrese el nombre del responsable.");
                return;
            }

            if (cboTaller.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un taller.");
                return;
            }

            if (!radbtnMat.Checked && !radbtnVesp.Checked)
            {
                MessageBox.Show("Seleccione un horario.");
                return;
            }

            Taller tallerSeleccionado = (Taller)cboTaller.SelectedItem;
            int cantSolicitada = (int)numCant.Value;


            int disponibles = lugarDisponible();

            if (cantSolicitada > disponibles)
            {
                MessageBox.Show("No hay lugares disponibles. Solo quedan " + disponibles + " lugares");
                return;
            }

            string turno;
            if (radbtnMat.Checked)
            {
                turno = "Matutino";
            }
            else
            {
                turno = "Vespertino";
            }
            bool reqMaterial = ckbReqMat.Checked;

            Reserva nuevaReserva = new Reserva(responsable, tallerSeleccionado, cantSolicitada, turno, reqMaterial);
            Reservas.Add(nuevaReserva);

            limpiarCampos();
            actDisponibilidad();
        }

        public void limpiarCampos()
        {
            txtResp.Clear();
            numCant.Value = 1;
            radbtnMat.Checked = false;
            radbtnVesp.Checked = false;
            ckbReqMat.Checked = false;
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnCancelarSele_Click(object sender, EventArgs e)
        {
            if (dtagridDatos.CurrentRow != null)
            {
                Reserva resevSele = (Reserva)dtagridDatos.CurrentRow.DataBoundItem;
                Reservas.Remove(resevSele);
                actDisponibilidad();
            }
            else
            {
                MessageBox.Show("Seleccione una reserva para cancelar.");
            }
        }
    }
}