namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Desconectarse_button = new System.Windows.Forms.Button();
            this.Conectarse_button = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.ConsultaAleix_button = new System.Windows.Forms.Button();
            this.ConsultaDani_button = new System.Windows.Forms.Button();
            this.ConsultaIngrid_button = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.Hora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CrearUsuario_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invitarbutton = new System.Windows.Forms.Button();
            this.InvitadoTB = new System.Windows.Forms.TextBox();
            this.Invitado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Desconectarse_button
            // 
            this.Desconectarse_button.Location = new System.Drawing.Point(32, 305);
            this.Desconectarse_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Desconectarse_button.Name = "Desconectarse_button";
            this.Desconectarse_button.Size = new System.Drawing.Size(140, 35);
            this.Desconectarse_button.TabIndex = 0;
            this.Desconectarse_button.Text = "Desconectarse";
            this.Desconectarse_button.UseVisualStyleBackColor = true;
            this.Desconectarse_button.Click += new System.EventHandler(this.Desconectarse_button_Click);
            // 
            // Conectarse_button
            // 
            this.Conectarse_button.Location = new System.Drawing.Point(32, 260);
            this.Conectarse_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Conectarse_button.Name = "Conectarse_button";
            this.Conectarse_button.Size = new System.Drawing.Size(140, 35);
            this.Conectarse_button.TabIndex = 1;
            this.Conectarse_button.Text = "Conectarse";
            this.Conectarse_button.UseVisualStyleBackColor = true;
            this.Conectarse_button.Click += new System.EventHandler(this.Conectarse_button_Click);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(32, 35);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(148, 26);
            this.Usuario.TabIndex = 2;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(32, 103);
            this.Contraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(148, 26);
            this.Contraseña.TabIndex = 5;
            // 
            // ConsultaAleix_button
            // 
            this.ConsultaAleix_button.Location = new System.Drawing.Point(274, 29);
            this.ConsultaAleix_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConsultaAleix_button.Name = "ConsultaAleix_button";
            this.ConsultaAleix_button.Size = new System.Drawing.Size(236, 35);
            this.ConsultaAleix_button.TabIndex = 6;
            this.ConsultaAleix_button.Text = "% de partidas ganadas";
            this.ConsultaAleix_button.UseVisualStyleBackColor = true;
            this.ConsultaAleix_button.Click += new System.EventHandler(this.ConsultaAleix_button_Click);
            // 
            // ConsultaDani_button
            // 
            this.ConsultaDani_button.Location = new System.Drawing.Point(274, 77);
            this.ConsultaDani_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConsultaDani_button.Name = "ConsultaDani_button";
            this.ConsultaDani_button.Size = new System.Drawing.Size(236, 35);
            this.ConsultaDani_button.TabIndex = 7;
            this.ConsultaDani_button.Text = "Maximas Partidas Ganadas";
            this.ConsultaDani_button.UseVisualStyleBackColor = true;
            this.ConsultaDani_button.Click += new System.EventHandler(this.ConsultaDani_button_Click);
            // 
            // ConsultaIngrid_button
            // 
            this.ConsultaIngrid_button.Location = new System.Drawing.Point(274, 226);
            this.ConsultaIngrid_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConsultaIngrid_button.Name = "ConsultaIngrid_button";
            this.ConsultaIngrid_button.Size = new System.Drawing.Size(273, 35);
            this.ConsultaIngrid_button.TabIndex = 8;
            this.ConsultaIngrid_button.Text = "Jugador ganador de esa partida";
            this.ConsultaIngrid_button.UseVisualStyleBackColor = true;
            this.ConsultaIngrid_button.Click += new System.EventHandler(this.ConsultaIngrid_button_Click);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(336, 271);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(148, 26);
            this.Fecha.TabIndex = 9;
            // 
            // Hora
            // 
            this.Hora.Location = new System.Drawing.Point(336, 312);
            this.Hora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(148, 26);
            this.Hora.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hora";
            // 
            // CrearUsuario_button
            // 
            this.CrearUsuario_button.Location = new System.Drawing.Point(274, 122);
            this.CrearUsuario_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CrearUsuario_button.Name = "CrearUsuario_button";
            this.CrearUsuario_button.Size = new System.Drawing.Size(236, 35);
            this.CrearUsuario_button.TabIndex = 14;
            this.CrearUsuario_button.Text = "Crear Usuario";
            this.CrearUsuario_button.UseVisualStyleBackColor = true;
            this.CrearUsuario_button.Click += new System.EventHandler(this.CrearUsuario_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 108);
            this.button1.TabIndex = 15;
            this.button1.Text = "Numero de servicios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contl
            // 
            this.contl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contl.Location = new System.Drawing.Point(646, 146);
            this.contl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contl.Name = "contl";
            this.contl.Size = new System.Drawing.Size(176, 86);
            this.contl.TabIndex = 16;
            this.contl.Click += new System.EventHandler(this.contl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(297, 123);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // invitarbutton
            // 
            this.invitarbutton.Location = new System.Drawing.Point(678, 332);
            this.invitarbutton.Name = "invitarbutton";
            this.invitarbutton.Size = new System.Drawing.Size(113, 41);
            this.invitarbutton.TabIndex = 20;
            this.invitarbutton.Text = "Invitar";
            this.invitarbutton.UseVisualStyleBackColor = true;
            this.invitarbutton.Click += new System.EventHandler(this.invitarbutton_Click);
            // 
            // InvitadoTB
            // 
            this.InvitadoTB.Location = new System.Drawing.Point(679, 292);
            this.InvitadoTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InvitadoTB.Name = "InvitadoTB";
            this.InvitadoTB.Size = new System.Drawing.Size(112, 26);
            this.InvitadoTB.TabIndex = 21;
            // 
            // Invitado
            // 
            this.Invitado.AutoSize = true;
            this.Invitado.Location = new System.Drawing.Point(704, 267);
            this.Invitado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Invitado.Name = "Invitado";
            this.Invitado.Size = new System.Drawing.Size(65, 20);
            this.Invitado.TabIndex = 22;
            this.Invitado.Text = "Invitado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 758);
            this.Controls.Add(this.Invitado);
            this.Controls.Add(this.InvitadoTB);
            this.Controls.Add(this.invitarbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.contl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CrearUsuario_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.ConsultaIngrid_button);
            this.Controls.Add(this.ConsultaDani_button);
            this.Controls.Add(this.ConsultaAleix_button);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Conectarse_button);
            this.Controls.Add(this.Desconectarse_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Desconectarse_button;
        private System.Windows.Forms.Button Conectarse_button;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Button ConsultaAleix_button;
        private System.Windows.Forms.Button ConsultaDani_button;
        private System.Windows.Forms.Button ConsultaIngrid_button;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.TextBox Hora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CrearUsuario_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label contl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button invitarbutton;
        private System.Windows.Forms.TextBox InvitadoTB;
        private System.Windows.Forms.Label Invitado;
    }
}

