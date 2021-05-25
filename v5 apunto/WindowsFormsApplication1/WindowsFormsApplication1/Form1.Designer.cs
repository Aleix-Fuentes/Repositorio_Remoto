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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invitarbutton = new System.Windows.Forms.Button();
            this.InvitadoTB = new System.Windows.Forms.TextBox();
            this.Invitado = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MensajeaEnviar = new System.Windows.Forms.TextBox();
            this.EnviarMensaje = new System.Windows.Forms.Button();
            this.CrearPartida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Desconectarse_button
            // 
            this.Desconectarse_button.Location = new System.Drawing.Point(21, 122);
            this.Desconectarse_button.Name = "Desconectarse_button";
            this.Desconectarse_button.Size = new System.Drawing.Size(93, 23);
            this.Desconectarse_button.TabIndex = 0;
            this.Desconectarse_button.Text = "Desconectarse";
            this.Desconectarse_button.UseVisualStyleBackColor = true;
            this.Desconectarse_button.Click += new System.EventHandler(this.Desconectarse_button_Click);
            // 
            // Conectarse_button
            // 
            this.Conectarse_button.Location = new System.Drawing.Point(21, 93);
            this.Conectarse_button.Name = "Conectarse_button";
            this.Conectarse_button.Size = new System.Drawing.Size(93, 23);
            this.Conectarse_button.TabIndex = 1;
            this.Conectarse_button.Text = "Conectarse";
            this.Conectarse_button.UseVisualStyleBackColor = true;
            this.Conectarse_button.Click += new System.EventHandler(this.Conectarse_button_Click);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(21, 23);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(100, 20);
            this.Usuario.TabIndex = 2;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(21, 67);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(100, 20);
            this.Contraseña.TabIndex = 5;
            // 
            // ConsultaAleix_button
            // 
            this.ConsultaAleix_button.Location = new System.Drawing.Point(152, 20);
            this.ConsultaAleix_button.Name = "ConsultaAleix_button";
            this.ConsultaAleix_button.Size = new System.Drawing.Size(157, 23);
            this.ConsultaAleix_button.TabIndex = 6;
            this.ConsultaAleix_button.Text = "% de partidas ganadas";
            this.ConsultaAleix_button.UseVisualStyleBackColor = true;
            this.ConsultaAleix_button.Click += new System.EventHandler(this.ConsultaAleix_button_Click);
            // 
            // ConsultaDani_button
            // 
            this.ConsultaDani_button.Location = new System.Drawing.Point(152, 50);
            this.ConsultaDani_button.Name = "ConsultaDani_button";
            this.ConsultaDani_button.Size = new System.Drawing.Size(157, 23);
            this.ConsultaDani_button.TabIndex = 7;
            this.ConsultaDani_button.Text = "Maximas Partidas Ganadas";
            this.ConsultaDani_button.UseVisualStyleBackColor = true;
            this.ConsultaDani_button.Click += new System.EventHandler(this.ConsultaDani_button_Click);
            // 
            // ConsultaIngrid_button
            // 
            this.ConsultaIngrid_button.Location = new System.Drawing.Point(152, 108);
            this.ConsultaIngrid_button.Name = "ConsultaIngrid_button";
            this.ConsultaIngrid_button.Size = new System.Drawing.Size(182, 23);
            this.ConsultaIngrid_button.TabIndex = 8;
            this.ConsultaIngrid_button.Text = "Jugador ganador de esa partida";
            this.ConsultaIngrid_button.UseVisualStyleBackColor = true;
            this.ConsultaIngrid_button.Click += new System.EventHandler(this.ConsultaIngrid_button_Click);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(224, 176);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(100, 20);
            this.Fecha.TabIndex = 9;
            // 
            // Hora
            // 
            this.Hora.Location = new System.Drawing.Point(224, 203);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(100, 20);
            this.Hora.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hora";
            // 
            // CrearUsuario_button
            // 
            this.CrearUsuario_button.Location = new System.Drawing.Point(152, 79);
            this.CrearUsuario_button.Name = "CrearUsuario_button";
            this.CrearUsuario_button.Size = new System.Drawing.Size(157, 23);
            this.CrearUsuario_button.TabIndex = 14;
            this.CrearUsuario_button.Text = "Crear Usuario";
            this.CrearUsuario_button.UseVisualStyleBackColor = true;
            this.CrearUsuario_button.Click += new System.EventHandler(this.CrearUsuario_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 250);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(198, 80);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // invitarbutton
            // 
            this.invitarbutton.Location = new System.Drawing.Point(452, 216);
            this.invitarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.invitarbutton.Name = "invitarbutton";
            this.invitarbutton.Size = new System.Drawing.Size(75, 27);
            this.invitarbutton.TabIndex = 20;
            this.invitarbutton.Text = "Invitar";
            this.invitarbutton.UseVisualStyleBackColor = true;
            this.invitarbutton.Click += new System.EventHandler(this.invitarbutton_Click);
            // 
            // InvitadoTB
            // 
            this.InvitadoTB.Location = new System.Drawing.Point(453, 190);
            this.InvitadoTB.Name = "InvitadoTB";
            this.InvitadoTB.Size = new System.Drawing.Size(76, 20);
            this.InvitadoTB.TabIndex = 21;
            // 
            // Invitado
            // 
            this.Invitado.AutoSize = true;
            this.Invitado.Location = new System.Drawing.Point(469, 174);
            this.Invitado.Name = "Invitado";
            this.Invitado.Size = new System.Drawing.Size(45, 13);
            this.Invitado.TabIndex = 22;
            this.Invitado.Text = "Invitado";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 335);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 149);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // MensajeaEnviar
            // 
            this.MensajeaEnviar.Location = new System.Drawing.Point(12, 490);
            this.MensajeaEnviar.Name = "MensajeaEnviar";
            this.MensajeaEnviar.Size = new System.Drawing.Size(353, 20);
            this.MensajeaEnviar.TabIndex = 24;
            this.MensajeaEnviar.TextChanged += new System.EventHandler(this.MensajeaEnviar_TextChanged);
            // 
            // EnviarMensaje
            // 
            this.EnviarMensaje.Location = new System.Drawing.Point(394, 491);
            this.EnviarMensaje.Name = "EnviarMensaje";
            this.EnviarMensaje.Size = new System.Drawing.Size(82, 19);
            this.EnviarMensaje.TabIndex = 25;
            this.EnviarMensaje.Text = "Enviar";
            this.EnviarMensaje.UseVisualStyleBackColor = true;
            this.EnviarMensaje.Click += new System.EventHandler(this.EnviarMensaje_Click);
            // 
            // CrearPartida
            // 
            this.CrearPartida.Location = new System.Drawing.Point(368, 282);
            this.CrearPartida.Name = "CrearPartida";
            this.CrearPartida.Size = new System.Drawing.Size(108, 23);
            this.CrearPartida.TabIndex = 26;
            this.CrearPartida.Text = "Crear Partida";
            this.CrearPartida.UseVisualStyleBackColor = true;
            this.CrearPartida.Click += new System.EventHandler(this.CrearPartida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 589);
            this.Controls.Add(this.CrearPartida);
            this.Controls.Add(this.EnviarMensaje);
            this.Controls.Add(this.MensajeaEnviar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Invitado);
            this.Controls.Add(this.InvitadoTB);
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
        private System.Windows.Forms.TextBox InvitadoTB;
        private System.Windows.Forms.Label Invitado;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox MensajeaEnviar;
        private System.Windows.Forms.Button EnviarMensaje;
        private System.Windows.Forms.Button CrearPartida;
    }
}

