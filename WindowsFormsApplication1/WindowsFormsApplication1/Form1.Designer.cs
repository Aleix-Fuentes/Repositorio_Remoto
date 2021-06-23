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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invitarbutton = new System.Windows.Forms.Button();
            this.CrearPartida = new System.Windows.Forms.Button();
            this.DarsedeBaja_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Desconectarse_button
            // 
            this.Desconectarse_button.Location = new System.Drawing.Point(592, 503);
            this.Desconectarse_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Desconectarse_button.Name = "Desconectarse_button";
            this.Desconectarse_button.Size = new System.Drawing.Size(219, 35);
            this.Desconectarse_button.TabIndex = 0;
            this.Desconectarse_button.Text = "Desconectarse";
            this.Desconectarse_button.UseVisualStyleBackColor = true;
            this.Desconectarse_button.Click += new System.EventHandler(this.Desconectarse_button_Click);
            // 
            // Conectarse_button
            // 
            this.Conectarse_button.Location = new System.Drawing.Point(592, 458);
            this.Conectarse_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Conectarse_button.Name = "Conectarse_button";
            this.Conectarse_button.Size = new System.Drawing.Size(219, 35);
            this.Conectarse_button.TabIndex = 1;
            this.Conectarse_button.Text = "Conectarse";
            this.Conectarse_button.UseVisualStyleBackColor = true;
            this.Conectarse_button.Click += new System.EventHandler(this.Conectarse_button_Click);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(592, 323);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(217, 26);
            this.Usuario.TabIndex = 2;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 294);
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
            this.label2.Location = new System.Drawing.Point(592, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(592, 391);
            this.Contraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(217, 26);
            this.Contraseña.TabIndex = 5;
            // 
            // ConsultaAleix_button
            // 
            this.ConsultaAleix_button.Location = new System.Drawing.Point(18, 320);
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
            this.ConsultaDani_button.Location = new System.Drawing.Point(18, 366);
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
            this.ConsultaIngrid_button.Location = new System.Drawing.Point(18, 411);
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
            this.Fecha.Location = new System.Drawing.Point(78, 465);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(148, 26);
            this.Fecha.TabIndex = 9;
            this.Fecha.TextChanged += new System.EventHandler(this.Fecha_TextChanged);
            // 
            // Hora
            // 
            this.Hora.Location = new System.Drawing.Point(78, 506);
            this.Hora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(148, 26);
            this.Hora.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 511);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hora";
            // 
            // CrearUsuario_button
            // 
            this.CrearUsuario_button.Location = new System.Drawing.Point(597, 578);
            this.CrearUsuario_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CrearUsuario_button.Name = "CrearUsuario_button";
            this.CrearUsuario_button.Size = new System.Drawing.Size(214, 35);
            this.CrearUsuario_button.TabIndex = 14;
            this.CrearUsuario_button.Text = "Crear Usuario";
            this.CrearUsuario_button.UseVisualStyleBackColor = true;
            this.CrearUsuario_button.Click += new System.EventHandler(this.CrearUsuario_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1120, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(297, 123);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // invitarbutton
            // 
            this.invitarbutton.Location = new System.Drawing.Point(1227, 497);
            this.invitarbutton.Name = "invitarbutton";
            this.invitarbutton.Size = new System.Drawing.Size(112, 42);
            this.invitarbutton.TabIndex = 20;
            this.invitarbutton.Text = "Invitar";
            this.invitarbutton.UseVisualStyleBackColor = true;
            this.invitarbutton.Click += new System.EventHandler(this.invitarbutton_Click);
            // 
            // CrearPartida
            // 
            this.CrearPartida.Location = new System.Drawing.Point(1200, 454);
            this.CrearPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CrearPartida.Name = "CrearPartida";
            this.CrearPartida.Size = new System.Drawing.Size(162, 35);
            this.CrearPartida.TabIndex = 26;
            this.CrearPartida.Text = "Crear Partida";
            this.CrearPartida.UseVisualStyleBackColor = true;
            this.CrearPartida.Click += new System.EventHandler(this.CrearPartida_Click);
            // 
            // DarsedeBaja_button
            // 
            this.DarsedeBaja_button.Location = new System.Drawing.Point(597, 623);
            this.DarsedeBaja_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DarsedeBaja_button.Name = "DarsedeBaja_button";
            this.DarsedeBaja_button.Size = new System.Drawing.Size(214, 35);
            this.DarsedeBaja_button.TabIndex = 27;
            this.DarsedeBaja_button.Text = "Darse de baja";
            this.DarsedeBaja_button.UseVisualStyleBackColor = true;
            this.DarsedeBaja_button.Click += new System.EventHandler(this.DarsedeBaja_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "CREDITOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1434, 906);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DarsedeBaja_button);
            this.Controls.Add(this.CrearPartida);
            this.Controls.Add(this.invitarbutton);
            this.Controls.Add(this.dataGridView1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button invitarbutton;
        private System.Windows.Forms.Button CrearPartida;
        private System.Windows.Forms.Button DarsedeBaja_button;
        private System.Windows.Forms.Button button1;
    }
}

