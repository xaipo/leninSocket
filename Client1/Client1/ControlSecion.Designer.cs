namespace Client1
{
    partial class ControlSecion
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
            this.components = new System.ComponentModel.Container();
            this.btn_cerrar_sec = new System.Windows.Forms.Button();
            this.panelcontrol = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.Label();
            this.txt_hora_ini = new System.Windows.Forms.Label();
            this.txttiempo1 = new System.Windows.Forms.Label();
            this.txttiempo = new System.Windows.Forms.Label();
            this.txthora_inicio = new System.Windows.Forms.Label();
            this.txtnombre_usu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tiempo_trans = new System.Windows.Forms.Timer(this.components);
            this.txttitulo = new System.Windows.Forms.Label();
            this.panelcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar_sec
            // 
            this.btn_cerrar_sec.Location = new System.Drawing.Point(36, 240);
            this.btn_cerrar_sec.Name = "btn_cerrar_sec";
            this.btn_cerrar_sec.Size = new System.Drawing.Size(143, 23);
            this.btn_cerrar_sec.TabIndex = 0;
            this.btn_cerrar_sec.Text = "Cerrar Secion";
            this.btn_cerrar_sec.UseVisualStyleBackColor = true;
            this.btn_cerrar_sec.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelcontrol
            // 
            this.panelcontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelcontrol.Controls.Add(this.txt_user);
            this.panelcontrol.Controls.Add(this.txt_hora_ini);
            this.panelcontrol.Controls.Add(this.txttiempo1);
            this.panelcontrol.Controls.Add(this.txttiempo);
            this.panelcontrol.Controls.Add(this.txthora_inicio);
            this.panelcontrol.Controls.Add(this.txtnombre_usu);
            this.panelcontrol.Controls.Add(this.label3);
            this.panelcontrol.Controls.Add(this.label2);
            this.panelcontrol.Controls.Add(this.label1);
            this.panelcontrol.Location = new System.Drawing.Point(12, 73);
            this.panelcontrol.Name = "panelcontrol";
            this.panelcontrol.Size = new System.Drawing.Size(184, 149);
            this.panelcontrol.TabIndex = 1;
            this.panelcontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_user
            // 
            this.txt_user.AutoSize = true;
            this.txt_user.Location = new System.Drawing.Point(81, 22);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(41, 13);
            this.txt_user.TabIndex = 8;
            this.txt_user.Text = "usuario";
            // 
            // txt_hora_ini
            // 
            this.txt_hora_ini.AutoSize = true;
            this.txt_hora_ini.Location = new System.Drawing.Point(81, 61);
            this.txt_hora_ini.Name = "txt_hora_ini";
            this.txt_hora_ini.Size = new System.Drawing.Size(49, 13);
            this.txt_hora_ini.TabIndex = 7;
            this.txt_hora_ini.Text = "00:00:00";
            // 
            // txttiempo1
            // 
            this.txttiempo1.AutoEllipsis = true;
            this.txttiempo1.AutoSize = true;
            this.txttiempo1.Location = new System.Drawing.Point(81, 95);
            this.txttiempo1.Name = "txttiempo1";
            this.txttiempo1.Size = new System.Drawing.Size(49, 13);
            this.txttiempo1.TabIndex = 6;
            this.txttiempo1.Text = "00:00:00";
            // 
            // txttiempo
            // 
            this.txttiempo.AutoSize = true;
            this.txttiempo.Location = new System.Drawing.Point(75, 95);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(0, 13);
            this.txttiempo.TabIndex = 5;
            // 
            // txthora_inicio
            // 
            this.txthora_inicio.AutoSize = true;
            this.txthora_inicio.Location = new System.Drawing.Point(75, 61);
            this.txthora_inicio.Name = "txthora_inicio";
            this.txthora_inicio.Size = new System.Drawing.Size(0, 13);
            this.txthora_inicio.TabIndex = 4;
            // 
            // txtnombre_usu
            // 
            this.txtnombre_usu.AutoSize = true;
            this.txtnombre_usu.Location = new System.Drawing.Point(75, 22);
            this.txtnombre_usu.Name = "txtnombre_usu";
            this.txtnombre_usu.Size = new System.Drawing.Size(0, 13);
            this.txtnombre_usu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tiempo_trans
            // 
            this.tiempo_trans.Interval = 1000;
            this.tiempo_trans.Tick += new System.EventHandler(this.tiempo_trans_Tick);
            // 
            // txttitulo
            // 
            this.txttitulo.AutoSize = true;
            this.txttitulo.Font = new System.Drawing.Font("Times New Roman", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(22, 18);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(166, 25);
            this.txttitulo.TabIndex = 2;
            this.txttitulo.Text = "Control de sesion";
            this.txttitulo.Click += new System.EventHandler(this.label4_Click);
            // 
            // ControlSecion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 273);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.panelcontrol);
            this.Controls.Add(this.btn_cerrar_sec);
            this.Name = "ControlSecion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ControlSecion";
            this.Load += new System.EventHandler(this.ControlSecion_Load);
            this.panelcontrol.ResumeLayout(false);
            this.panelcontrol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar_sec;
        private System.Windows.Forms.Panel panelcontrol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txttiempo;
        private System.Windows.Forms.Label txthora_inicio;
        private System.Windows.Forms.Label txtnombre_usu;
        private System.Windows.Forms.Timer tiempo_trans;
        private System.Windows.Forms.Label txttiempo1;
        private System.Windows.Forms.Label txt_hora_ini;
        private System.Windows.Forms.Label txt_user;
        private System.Windows.Forms.Label txttitulo;
    }
}