using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDatos;

namespace CapaDiseno
{
    public partial class frm_modificarPermisosAplicaciones : Form
    {
        sentencia sn = new sentencia();
        logica logic;

        public frm_modificarPermisosAplicaciones(string idUsuario)
        {
            InitializeComponent();
            logic = new logica(idUsuario);
            txt_ingresar.Visible = false;
            txt_consultar.Visible = false;
            txt_modificar.Visible = false;
            txt_eliminar.Visible = false;
            txt_imprimir.Visible = false;
            txt_usuario.Enabled = false;
            txt_aplicacion.Enabled = false;
            deshabilitarCheckBox();

        }

        void habilitarCheckBox()
        {
            cbx_ingresar.Enabled = true;
            cbx_consultar.Enabled = true;
            cbx_modificar.Enabled = true;
            cbx_eliminar.Enabled = true;
            cbx_imprimir.Enabled = true;
        }

        void deshabilitarCheckBox()
        {
            cbx_ingresar.Enabled = false;
            cbx_consultar.Enabled = false ;
            cbx_modificar.Enabled = false;
            cbx_eliminar.Enabled = false;
            cbx_imprimir.Enabled = false;
        }

        private void Frm_modificarPermisosAplicaciones_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtUsuario = logic.consultaLogicaUsuarios();

                foreach (DataRow row in dtUsuario.Rows)
                {
                    cbo_usuarios.Items.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                DataTable dtModulos = logic.consultaLogicaModulos();

                foreach (DataRow row in dtModulos.Rows)
                {
                    cbo_modulos.Items.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Cbo_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_aplicaciones.DataSource = null;
            cbo_aplicaciones.Items.Clear();
            cbo_aplicaciones.Text = " ";

            string sNombreModulo = cbo_modulos.SelectedItem.ToString();

            try
            {
                DataTable dtAplicaciones = logic.consultaLogicaAplicaciones(sNombreModulo);

                foreach (DataRow row in dtAplicaciones.Rows)
                {
                    cbo_aplicaciones.Items.Add(row[0].ToString());
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
        }

        void limpiarForm()
        {
            cbo_usuarios.Text = " ";
            cbo_modulos.Text = " ";
            cbo_aplicaciones.Text = " ";
        }

        void limpiarCambios()
        {
            txt_usuario.Text = "";
            txt_aplicacion.Text = "";
            cbx_ingresar.Checked = false;
            cbx_consultar.Checked = false;
            cbx_modificar.Checked = false;
            cbx_eliminar.Checked = false;
            cbx_imprimir.Checked = false;
            txt_ingresar.Text = "";
            txt_consultar.Text = "";
            txt_modificar.Text = "";
            txt_eliminar.Text = "";
            txt_imprimir.Text = "";
        }


        public static int iContadorFila = 0;

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (cbo_usuarios.SelectedItem == null || cbo_aplicaciones.SelectedItem == null)
            {
                MessageBox.Show("Faltan Datos Por Seleccionar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                habilitarCheckBox();
                string sUsuario = cbo_usuarios.SelectedItem.ToString();
                string sAplicacion = cbo_aplicaciones.SelectedItem.ToString();


                txt_usuario.Text = sUsuario;
                txt_aplicacion.Text = sAplicacion;

                try
                {
                    DataTable dtPermisos = logic.consultaLogicaPermisosAplicaciones(sUsuario, sAplicacion);

                    foreach (DataRow row in dtPermisos.Rows)
                    {
                        txt_ingresar.Text = row[0].ToString();
                        txt_consultar.Text = row[1].ToString();
                        txt_modificar.Text = row[2].ToString();
                        txt_eliminar.Text = row[3].ToString();
                        txt_imprimir.Text = row[4].ToString();
                    }

                    if (txt_ingresar.Text == "1")
                        cbx_ingresar.Checked = true;
                    else
                        cbx_ingresar.Checked = false;

                    if (txt_consultar.Text == "1")
                        cbx_consultar.Checked = true;
                    else
                        cbx_consultar.Checked = false;

                    if (txt_modificar.Text == "1")
                        cbx_modificar.Checked = true;
                    else
                        cbx_modificar.Checked = false;

                    if (txt_eliminar.Text == "1")
                        cbx_eliminar.Checked = true;
                    else
                        cbx_eliminar.Checked = false;

                    if (txt_imprimir.Text == "1")
                        cbx_imprimir.Checked = true;
                    else
                        cbx_imprimir.Checked = false;

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }


                limpiarForm();
            }
        }

        private void Btn_finalizar_Click(object sender, EventArgs e)
        {
            string sIngresar;
            string sConsulta;
            string sModificar;
            string sEliminar;
            string sImprimir;
            string sUsuario;
            string sAplicacion;

            sUsuario = txt_usuario.Text; 
            sAplicacion = txt_aplicacion.Text;

            if (txt_usuario.Text == "" || txt_aplicacion.Text== "")
            {
                MessageBox.Show("Faltan Campos Por Llenar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {


                    if (cbx_ingresar.Checked == true)
                        sIngresar = "1";
                    else
                        sIngresar = "0";

                    if (cbx_consultar.Checked == true)
                        sConsulta = "1";
                    else
                        sConsulta = "0";

                    if (cbx_modificar.Checked == true)
                        sModificar = "1";
                    else
                        sModificar = "0";

                    if (cbx_eliminar.Checked == true)
                        sEliminar = "1";
                    else
                        sEliminar = "0";

                    if (cbx_imprimir.Checked == true)
                        sImprimir = "1";
                    else
                        sImprimir = "0";

                    DataTable dtPermisos = logic.consultaLogicaModificarPermisosAplicaciones(sUsuario, sAplicacion, sIngresar, sConsulta, sModificar, sEliminar, sImprimir);


                    MessageBox.Show("Datos Actualizados Exitosamente");
                    limpiarCambios();
                    deshabilitarCheckBox();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
           

        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "modificaciones.chm", "Modificaciones.html");
        }
    }
}
