namespace ClienteChat
{
    partial class FormAdmin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.bttonpc1 = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelpcs = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEscuela = new System.Windows.Forms.Label();
            this.txtUsuarioID = new System.Windows.Forms.Label();
            this.txtUsuarioNom = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btntiempo = new System.Windows.Forms.Button();
            this.btnUsoLibre = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.btnreiniciar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPcdispo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelpcs.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelPcdispo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttonpc1
            // 
            this.bttonpc1.Image = ((System.Drawing.Image)(resources.GetObject("bttonpc1.Image")));
            this.bttonpc1.Location = new System.Drawing.Point(47, 27);
            this.bttonpc1.Name = "bttonpc1";
            this.bttonpc1.Size = new System.Drawing.Size(37, 41);
            this.bttonpc1.TabIndex = 2;
            this.bttonpc1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttonpc1.UseVisualStyleBackColor = true;
            this.bttonpc1.Click += new System.EventHandler(this.bttonpc_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnapagar.Image = ((System.Drawing.Image)(resources.GetObject("btnapagar.Image")));
            this.btnapagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnapagar.Location = new System.Drawing.Point(12, 374);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(69, 56);
            this.btnapagar.TabIndex = 10;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnapagar.UseVisualStyleBackColor = false;
            this.btnapagar.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "PC2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "PC3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panelpcs
            // 
            this.panelpcs.AutoSize = true;
            this.panelpcs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelpcs.BackgroundImage")));
            this.panelpcs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelpcs.Controls.Add(this.bttonpc1);
            this.panelpcs.Controls.Add(this.button3);
            this.panelpcs.Controls.Add(this.button4);
            this.panelpcs.Location = new System.Drawing.Point(87, 74);
            this.panelpcs.Name = "panelpcs";
            this.panelpcs.Size = new System.Drawing.Size(702, 402);
            this.panelpcs.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtEscuela);
            this.panel1.Controls.Add(this.txtUsuarioID);
            this.panel1.Controls.Add(this.txtUsuarioNom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picBoxUser);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(795, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 400);
            this.panel1.TabIndex = 8;
            // 
            // txtEscuela
            // 
            this.txtEscuela.AutoSize = true;
            this.txtEscuela.BackColor = System.Drawing.Color.Transparent;
            this.txtEscuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscuela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEscuela.Location = new System.Drawing.Point(33, 294);
            this.txtEscuela.Name = "txtEscuela";
            this.txtEscuela.Size = new System.Drawing.Size(164, 24);
            this.txtEscuela.TabIndex = 21;
            this.txtEscuela.Text = "Ing. en Sistemas";
            // 
            // txtUsuarioID
            // 
            this.txtUsuarioID.AutoSize = true;
            this.txtUsuarioID.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuarioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtUsuarioID.Location = new System.Drawing.Point(59, 152);
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.Size = new System.Drawing.Size(109, 24);
            this.txtUsuarioID.TabIndex = 20;
            this.txtUsuarioID.Text = "064262956";
            // 
            // txtUsuarioNom
            // 
            this.txtUsuarioNom.AutoSize = true;
            this.txtUsuarioNom.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuarioNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioNom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuarioNom.Location = new System.Drawing.Point(31, 222);
            this.txtUsuarioNom.Name = "txtUsuarioNom";
            this.txtUsuarioNom.Size = new System.Drawing.Size(166, 24);
            this.txtUsuarioNom.TabIndex = 19;
            this.txtUsuarioNom.Text = "Lenin Velastegui";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Escuela:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID Usuario:";
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUser.Image")));
            this.picBoxUser.Location = new System.Drawing.Point(81, 25);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(65, 67);
            this.picBoxUser.TabIndex = 15;
            this.picBoxUser.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(-1, 350);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(224, 43);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar Secion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btntiempo
            // 
            this.btntiempo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btntiempo.Image = ((System.Drawing.Image)(resources.GetObject("btntiempo.Image")));
            this.btntiempo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btntiempo.Location = new System.Drawing.Point(12, 126);
            this.btntiempo.Name = "btntiempo";
            this.btntiempo.Size = new System.Drawing.Size(69, 56);
            this.btntiempo.TabIndex = 10;
            this.btntiempo.Text = "Tiempo";
            this.btntiempo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntiempo.UseVisualStyleBackColor = false;
            this.btntiempo.Click += new System.EventHandler(this.btntiempo_Click);
            // 
            // btnUsoLibre
            // 
            this.btnUsoLibre.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUsoLibre.Image = ((System.Drawing.Image)(resources.GetObject("btnUsoLibre.Image")));
            this.btnUsoLibre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsoLibre.Location = new System.Drawing.Point(12, 188);
            this.btnUsoLibre.Name = "btnUsoLibre";
            this.btnUsoLibre.Size = new System.Drawing.Size(69, 56);
            this.btnUsoLibre.TabIndex = 10;
            this.btnUsoLibre.Text = "Uso Libre";
            this.btnUsoLibre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsoLibre.UseVisualStyleBackColor = false;
            this.btnUsoLibre.Click += new System.EventHandler(this.btnUsoLibre_Click);
            // 
            // btnreportes
            // 
            this.btnreportes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnreportes.Image = ((System.Drawing.Image)(resources.GetObject("btnreportes.Image")));
            this.btnreportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnreportes.Location = new System.Drawing.Point(12, 250);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(69, 56);
            this.btnreportes.TabIndex = 11;
            this.btnreportes.Text = "Reportes";
            this.btnreportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreportes.UseVisualStyleBackColor = false;
            this.btnreportes.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnreiniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnreiniciar.Image")));
            this.btnreiniciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnreiniciar.Location = new System.Drawing.Point(12, 312);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(69, 56);
            this.btnreiniciar.TabIndex = 12;
            this.btnreiniciar.Text = "Reiniciar";
            this.btnreiniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreiniciar.UseVisualStyleBackColor = false;
            this.btnreiniciar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 491);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 30);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(847, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora / fecha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(736, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuaro - Administrador";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(575, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado de conexcion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPcdispo
            // 
            this.panelPcdispo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPcdispo.BackgroundImage")));
            this.panelPcdispo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPcdispo.Controls.Add(this.label7);
            this.panelPcdispo.Location = new System.Drawing.Point(184, 38);
            this.panelPcdispo.Name = "panelPcdispo";
            this.panelPcdispo.Size = new System.Drawing.Size(575, 30);
            this.panelPcdispo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(529, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Disponibilidad de PCs";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1032, 521);
            this.Controls.Add(this.panelPcdispo);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnreiniciar);
            this.Controls.Add(this.btnreportes);
            this.Controls.Add(this.btnUsoLibre);
            this.Controls.Add(this.btntiempo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelpcs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelpcs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelPcdispo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttonpc1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Panel panelpcs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntiempo;
        private System.Windows.Forms.Button btnUsoLibre;
        private System.Windows.Forms.Button btnreportes;
        private System.Windows.Forms.Button btnreiniciar;
        private System.Windows.Forms.Label txtEscuela;
        private System.Windows.Forms.Label txtUsuarioID;
        private System.Windows.Forms.Label txtUsuarioNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPcdispo;
        private System.Windows.Forms.Label label7;
    }
}

