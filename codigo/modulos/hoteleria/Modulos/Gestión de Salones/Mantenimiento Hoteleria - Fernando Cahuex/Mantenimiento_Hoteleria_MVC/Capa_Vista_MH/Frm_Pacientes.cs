using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Navegador;
using Capa_Vista_Navegador;

namespace Capa_Vista_MH
{
    public partial class Frm_Pacientes : Form
    {
        public Frm_Pacientes()
        {
            InitializeComponent();
            //parametros para navegador
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_Paciente"
            };

            string[] columnas = {
                        "tbl_paciente",
                        "pk_idPaciente",
                        "nombrePaciente",
                        "apellidoPaciente",
                        "fechaNacimientoPaciente",
                        "sexoPaciente",
                        "direccionPaciente",
                        "telefonoPaciente",
                        "estadoPaciente"

                    };

            string[] sEtiquetas = {
                        "Código Paciente",
                        "Nombre de Paciente",
                        "Apellido de Paciente",
                        "Fecha Nacimiento",
                        "Sexo",
                        "Direccion",
                        "Telefono",
                        "Estado"
                    };


            int id_aplicacion = 3407;
            int id_Modulo = 8;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }

    }
}
