﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using System.Data.Odbc;

namespace CapaDiseno
{
    public partial class frm_cambioclave : Form
    {
        logica logica1;

        string usuario;
        public frm_cambioclave(string idUsuario)
        {
            InitializeComponent();
            logica1 = new logica(idUsuario);
            usuario = idUsuario;
        }


        public frm_cambioclave()
        {
        }

        string buscar;

        private void Button1_Click(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_clave.Enabled = true;
            txt_nombres.Enabled = false;
            txt_apellidos.Enabled = false;
            btn_guardar.Enabled = true;

            buscar = txt_idbuscar.Text.Trim();

            try
            {
                DataTable dtusuario = logica1.buscar(buscar);

                if (dtusuario.ToString() == null)
                {
                    MessageBox.Show("No existe");

                }
                else
                {
                    foreach (DataRow dt in dtusuario.Rows)
                    {

                        txt_id.Text = (dt[0].ToString());
                        txt_nombres.Text = (dt[1].ToString());
                        txt_apellidos.Text = (dt[2].ToString());
                        txt_clave.Text = (dt[3].ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
        }

        string perfil;
        private void Frm_cambioclave_Load(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            txt_clave.Enabled = false;
            txt_nombres.Enabled = false;
            txt_apellidos.Enabled = false;
            btn_guardar.Enabled = false;

            

            try
            {
                DataTable dtusuario = logica1.updateclave(usuario);

                if (dtusuario.ToString() == null)
                {
                    MessageBox.Show("No existe");

                }
                else
                {
                   
                    foreach (DataRow dt in dtusuario.Rows)
                    {
                        
                        perfil = (dt[0].ToString());
                    }
                }

                if (perfil == "1")
                {
                    groupBox3.Visible = true;
                    groupBox2.Visible = true;
                    groupBox1.Visible = true;
                    btn_guardar.Visible = true;

                    groupBox4.Visible = false;
                    btn_guardar1.Visible = false;
                    btn_salir1.Visible = false;

                }
                else
                {
                    groupBox3.Visible = false;
                    groupBox2.Visible = false;
                    groupBox1.Visible = false;
                    btn_guardar.Visible = false;
                    btn_salir.Visible = false;

                    groupBox4.Visible = true;
                    btn_guardar1.Visible = true;
                    btn_salir1.Visible = true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }

        }

        void limpiar()
        {
            txt_apellidos.Text = "";
            txt_idbuscar.Text = "";
            txt_clave.Text = "";
            txt_nombres.Text = "";
            txt_id.Text = "";
            txt_clave.Text = "";
            txt_claves.Text = "";
            textBox1.Text = "";
        }


        public string id, nombre, apellido, clave;

        private void Txt_idbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        public string contra;
        private void Btn_guardar1_Click(object sender, EventArgs e)
        {
            contra = textBox1.Text;

            try
            {
                DataTable dtusuario = logica1.updatecliente(contra,usuario);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }
            limpiar();
        }

        private void Btn_salir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "CambioContraseña.chm", "cambio_contraseña.html");
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            id = txt_id.Text;
            nombre = txt_nombres.Text;
            apellido = txt_apellidos.Text;
            clave = txt_clave.Text;
           
            try
            {
                DataTable dtusuario = logica1.clave(id, nombre, apellido, clave);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return;
            }
            limpiar();
        }
    }
}
