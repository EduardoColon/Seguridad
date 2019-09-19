namespace CapaDiseno
{
    partial class frm_modificarPermisosAplicaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.cbo_modulos = new System.Windows.Forms.ComboBox();
            this.lbl_modulo = new System.Windows.Forms.Label();
            this.cbo_usuarios = new System.Windows.Forms.ComboBox();
            this.cbo_aplicaciones = new System.Windows.Forms.ComboBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_aplicacion = new System.Windows.Forms.TextBox();
            this.txt_ingresar = new System.Windows.Forms.TextBox();
            this.txt_consultar = new System.Windows.Forms.TextBox();
            this.txt_modificar = new System.Windows.Forms.TextBox();
            this.txt_eliminar = new System.Windows.Forms.TextBox();
            this.txt_imprimir = new System.Windows.Forms.TextBox();
            this.cbx_ingresar = new System.Windows.Forms.CheckBox();
            this.cbx_consultar = new System.Windows.Forms.CheckBox();
            this.cbx_modificar = new System.Windows.Forms.CheckBox();
            this.cbx_eliminar = new System.Windows.Forms.CheckBox();
            this.cbx_imprimir = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.Gpb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.cbo_modulos);
            this.Gpb_datos.Controls.Add(this.lbl_modulo);
            this.Gpb_datos.Controls.Add(this.cbo_usuarios);
            this.Gpb_datos.Controls.Add(this.cbo_aplicaciones);
            this.Gpb_datos.Controls.Add(this.btn_consultar);
            this.Gpb_datos.Controls.Add(this.label1);
            this.Gpb_datos.Controls.Add(this.label2);
            this.Gpb_datos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(14, 54);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(5);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(5);
            this.Gpb_datos.Size = new System.Drawing.Size(782, 114);
            this.Gpb_datos.TabIndex = 13;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // cbo_modulos
            // 
            this.cbo_modulos.FormattingEnabled = true;
            this.cbo_modulos.Location = new System.Drawing.Point(259, 52);
            this.cbo_modulos.Margin = new System.Windows.Forms.Padding(5);
            this.cbo_modulos.Name = "cbo_modulos";
            this.cbo_modulos.Size = new System.Drawing.Size(182, 25);
            this.cbo_modulos.TabIndex = 12;
            this.cbo_modulos.SelectedIndexChanged += new System.EventHandler(this.Cbo_modulos_SelectedIndexChanged);
            // 
            // lbl_modulo
            // 
            this.lbl_modulo.AutoSize = true;
            this.lbl_modulo.Location = new System.Drawing.Point(323, 29);
            this.lbl_modulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_modulo.Name = "lbl_modulo";
            this.lbl_modulo.Size = new System.Drawing.Size(62, 17);
            this.lbl_modulo.TabIndex = 11;
            this.lbl_modulo.Text = "Modulos";
            // 
            // cbo_usuarios
            // 
            this.cbo_usuarios.FormattingEnabled = true;
            this.cbo_usuarios.Location = new System.Drawing.Point(47, 53);
            this.cbo_usuarios.Margin = new System.Windows.Forms.Padding(5);
            this.cbo_usuarios.Name = "cbo_usuarios";
            this.cbo_usuarios.Size = new System.Drawing.Size(182, 25);
            this.cbo_usuarios.TabIndex = 0;
            // 
            // cbo_aplicaciones
            // 
            this.cbo_aplicaciones.FormattingEnabled = true;
            this.cbo_aplicaciones.Location = new System.Drawing.Point(465, 53);
            this.cbo_aplicaciones.Margin = new System.Windows.Forms.Padding(5);
            this.cbo_aplicaciones.Name = "cbo_aplicaciones";
            this.cbo_aplicaciones.Size = new System.Drawing.Size(182, 25);
            this.cbo_aplicaciones.TabIndex = 1;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(680, 46);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(88, 34);
            this.btn_consultar.TabIndex = 10;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aplicaciones";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(629, 380);
            this.btn_finalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(153, 30);
            this.btn_finalizar.TabIndex = 16;
            this.btn_finalizar.Text = "Guardar Cambios";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.Btn_finalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "MODIFICACION DE PERMISOS DE APLICACIONES";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(240, 206);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(159, 23);
            this.txt_usuario.TabIndex = 18;
            // 
            // txt_aplicacion
            // 
            this.txt_aplicacion.Location = new System.Drawing.Point(240, 247);
            this.txt_aplicacion.Name = "txt_aplicacion";
            this.txt_aplicacion.Size = new System.Drawing.Size(159, 23);
            this.txt_aplicacion.TabIndex = 19;
            // 
            // txt_ingresar
            // 
            this.txt_ingresar.Location = new System.Drawing.Point(432, 204);
            this.txt_ingresar.Name = "txt_ingresar";
            this.txt_ingresar.Size = new System.Drawing.Size(24, 23);
            this.txt_ingresar.TabIndex = 20;
            // 
            // txt_consultar
            // 
            this.txt_consultar.Location = new System.Drawing.Point(432, 247);
            this.txt_consultar.Name = "txt_consultar";
            this.txt_consultar.Size = new System.Drawing.Size(24, 23);
            this.txt_consultar.TabIndex = 21;
            // 
            // txt_modificar
            // 
            this.txt_modificar.Location = new System.Drawing.Point(432, 289);
            this.txt_modificar.Name = "txt_modificar";
            this.txt_modificar.Size = new System.Drawing.Size(24, 23);
            this.txt_modificar.TabIndex = 22;
            // 
            // txt_eliminar
            // 
            this.txt_eliminar.Location = new System.Drawing.Point(432, 336);
            this.txt_eliminar.Name = "txt_eliminar";
            this.txt_eliminar.Size = new System.Drawing.Size(24, 23);
            this.txt_eliminar.TabIndex = 23;
            // 
            // txt_imprimir
            // 
            this.txt_imprimir.Location = new System.Drawing.Point(432, 380);
            this.txt_imprimir.Name = "txt_imprimir";
            this.txt_imprimir.Size = new System.Drawing.Size(24, 23);
            this.txt_imprimir.TabIndex = 24;
            // 
            // cbx_ingresar
            // 
            this.cbx_ingresar.AutoSize = true;
            this.cbx_ingresar.Location = new System.Drawing.Point(474, 206);
            this.cbx_ingresar.Name = "cbx_ingresar";
            this.cbx_ingresar.Size = new System.Drawing.Size(77, 21);
            this.cbx_ingresar.TabIndex = 25;
            this.cbx_ingresar.Text = "Ingresar";
            this.cbx_ingresar.UseVisualStyleBackColor = true;
            // 
            // cbx_consultar
            // 
            this.cbx_consultar.AutoSize = true;
            this.cbx_consultar.Location = new System.Drawing.Point(474, 249);
            this.cbx_consultar.Name = "cbx_consultar";
            this.cbx_consultar.Size = new System.Drawing.Size(89, 21);
            this.cbx_consultar.TabIndex = 26;
            this.cbx_consultar.Text = "Consultar";
            this.cbx_consultar.UseVisualStyleBackColor = true;
            // 
            // cbx_modificar
            // 
            this.cbx_modificar.AutoSize = true;
            this.cbx_modificar.Location = new System.Drawing.Point(474, 291);
            this.cbx_modificar.Name = "cbx_modificar";
            this.cbx_modificar.Size = new System.Drawing.Size(87, 21);
            this.cbx_modificar.TabIndex = 27;
            this.cbx_modificar.Text = "Modificar";
            this.cbx_modificar.UseVisualStyleBackColor = true;
            // 
            // cbx_eliminar
            // 
            this.cbx_eliminar.AutoSize = true;
            this.cbx_eliminar.Location = new System.Drawing.Point(474, 338);
            this.cbx_eliminar.Name = "cbx_eliminar";
            this.cbx_eliminar.Size = new System.Drawing.Size(77, 21);
            this.cbx_eliminar.TabIndex = 28;
            this.cbx_eliminar.Text = "Eliminar";
            this.cbx_eliminar.UseVisualStyleBackColor = true;
            // 
            // cbx_imprimir
            // 
            this.cbx_imprimir.AutoSize = true;
            this.cbx_imprimir.Location = new System.Drawing.Point(474, 382);
            this.cbx_imprimir.Name = "cbx_imprimir";
            this.cbx_imprimir.Size = new System.Drawing.Size(79, 21);
            this.cbx_imprimir.TabIndex = 29;
            this.cbx_imprimir.Text = "Imprimir";
            this.cbx_imprimir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Aplicacion";
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Image = global::CapaDiseno.Properties.Resources.icons8_ayuda_30;
            this.btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ayuda.Location = new System.Drawing.Point(710, 9);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(86, 36);
            this.btn_ayuda.TabIndex = 253;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_modificarPermisosAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 514);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_imprimir);
            this.Controls.Add(this.cbx_eliminar);
            this.Controls.Add(this.cbx_modificar);
            this.Controls.Add(this.cbx_consultar);
            this.Controls.Add(this.cbx_ingresar);
            this.Controls.Add(this.txt_imprimir);
            this.Controls.Add(this.txt_eliminar);
            this.Controls.Add(this.txt_modificar);
            this.Controls.Add(this.txt_consultar);
            this.Controls.Add(this.txt_ingresar);
            this.Controls.Add(this.txt_aplicacion);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.Gpb_datos);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_modificarPermisosAplicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Permisos de Aplicaciones";
            this.Load += new System.EventHandler(this.Frm_modificarPermisosAplicaciones_Load);
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_datos;
        public System.Windows.Forms.ComboBox cbo_modulos;
        private System.Windows.Forms.Label lbl_modulo;
        public System.Windows.Forms.ComboBox cbo_usuarios;
        private System.Windows.Forms.ComboBox cbo_aplicaciones;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_aplicacion;
        private System.Windows.Forms.TextBox txt_ingresar;
        private System.Windows.Forms.TextBox txt_consultar;
        private System.Windows.Forms.TextBox txt_modificar;
        private System.Windows.Forms.TextBox txt_eliminar;
        private System.Windows.Forms.TextBox txt_imprimir;
        private System.Windows.Forms.CheckBox cbx_ingresar;
        private System.Windows.Forms.CheckBox cbx_consultar;
        private System.Windows.Forms.CheckBox cbx_modificar;
        private System.Windows.Forms.CheckBox cbx_eliminar;
        private System.Windows.Forms.CheckBox cbx_imprimir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ayuda;
    }
}