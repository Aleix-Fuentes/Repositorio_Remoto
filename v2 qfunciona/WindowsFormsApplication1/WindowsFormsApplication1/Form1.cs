using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Conectarse_button_Click(object sender, EventArgs e)
        {
            
            if (Usuario.Text == "" || Contraseña.Text == "")
            {
                MessageBox.Show("Error al iniciar sesion, falta llenar los campos");
            }
            else
            {
                //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                //al que deseamos conectarnos
                IPAddress direc = IPAddress.Parse("192.168.56.102");
                IPEndPoint ipep = new IPEndPoint(direc, 9200);
                this.BackColor = Color.Red;


                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket
                    this.BackColor = Color.Green;
                    //MessageBox.Show("Conectado");

                }
                catch (SocketException ex)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }
                string mensaje = "5/" + Usuario.Text + "/" + Contraseña.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                if (mensaje == "NO")
                {
                    string mennsaje = "0/" + Usuario.Text;

                    byte[] msg3 = System.Text.Encoding.ASCII.GetBytes(mennsaje);
                    server.Send(msg3);

                    this.BackColor = Color.Red;

                    MessageBox.Show("No se ha iniciado sesion correctamente ");
                }
                else
                {
                    MessageBox.Show("Se ha podido iniciar sesion");
                }
            }
        }

        private void Desconectarse_button_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void ConsultaAleix_button_Click(object sender, EventArgs e)
        {
            string mensaje = "3/" + Usuario.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            if (mensaje == "NO")
            {
                MessageBox.Show("Usuario no encontrado");
            }
            else
            {                
                MessageBox.Show("El % de partidas ganadas es de: " + mensaje + "%");
            }
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaDani_button_Click(object sender, EventArgs e)
        {
            string mensaje = "2/" ;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show( mensaje);
        }

        private void ConsultaIngrid_button_Click(object sender, EventArgs e)
        {
            string mensaje = "4/" + Fecha.Text + "/" + Hora.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            if (mensaje == "NO")
            {
                MessageBox.Show("No hay partida a esa hora o fecha(Recuerda que la fecha se pone XX-XX-XXXX y la hora XX:XX)");
            }
            else
            {
                MessageBox.Show("El usuario que gano esa partida fue: " + mensaje);
            }

           
        }

        private void IniciarSesion_button_Click(object sender, EventArgs e)
        {
            //string mensaje = "5/" + Usuario.Text + "/" + Contraseña.Text;
            //// Enviamos al servidor el nombre tecleado
            //byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            //server.Send(msg);

            ////Recibimos la respuesta del servidor
            //byte[] msg2 = new byte[80];
            //server.Receive(msg2);
            //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            //if (mensaje == "SI")
            //{
            //    MessageBox.Show("Se ha iniciado sesion correctamente ");
            //}
            //else
            //{
            //    MessageBox.Show("No se ha podido iniciar sesion"); 
            //}

        }

        private void CrearUsuario_button_Click(object sender, EventArgs e)
        {

            if (Usuario.Text == "" || Contraseña.Text == "")
            {
                MessageBox.Show("Error al iniciar sesion, falta llenar los campos");
            }
            else
            {
                //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                //al que deseamos conectarnos
                IPAddress direc = IPAddress.Parse("192.168.56.102");
                IPEndPoint ipep = new IPEndPoint(direc, 9200);
                this.BackColor = Color.Red;


                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket
                    this.BackColor = Color.Green;
                    //MessageBox.Show("Conectado");

                }
                catch (SocketException ex)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }
                string mensaje = "1/" + Usuario.Text + "/" + Contraseña.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("Se ha creado usuario correctamente ");
                //if (mensaje == "SI")
                //{
                //    MessageBox.Show("Se ha creado usuario correctamente ");
                //}
                //else
                //{
                //    MessageBox.Show("No se ha creado usuario correctamente");
                //}

                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "6/";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            contl.Text = mensaje;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "7/";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            Conectados.Text = mensaje;
        }


    }
}
