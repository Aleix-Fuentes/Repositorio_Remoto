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
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;

        delegate void DelegadoParaEscribir(string mensaje);
        delegate void DelegadoParaVaciar();
        List<Form2> formularios = new List<Form2>();
        int numpartida;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 1;
            invitarbutton.Visible = false;
        }
        public void EscribirenChat(string mensaje)
        { 
        }
        public void Vaciar()
        {
            Usuario.Text = "";
            Contraseña.Text = "";
            byte[] msg4 = System.Text.Encoding.ASCII.GetBytes("0/");
            server.Send(msg4);

            // Nos desconectamos
            atender.Abort();
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }
        public void ActualizarListaConectados(string mensaje) 
        { //actualiza la lista de conectados
            string[] sConectados = mensaje.Split(',');
            int n = Convert.ToInt32(sConectados[0]);
            dataGridView1.RowCount = n;
            int j = 1;
            for (int i = 0; i < n; i++)
            {
                dataGridView1[0, i].Value = sConectados[j];
                j++;
            }
        }
        private void AtenderServidor ()
        {
            while (true)
            { 
                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string[] trozos = Encoding.ASCII.GetString(msg2).Split('/');
                string cod = trozos[0];
                int codigo = Convert.ToInt32(cod);
                string mensaje;
                switch (codigo) 
                {
                    case 0: //desconexión
                        mensaje = trozos[1].Split('\0')[0];
                        MessageBox.Show(mensaje);
                        break;

                    case 1://se crea usuario
                        mensaje = trozos[1].Split('\0')[0];       
                        MessageBox.Show("Se ha creado usuario:" + mensaje + "correctamente ");
                        break;

                    case 2://consulta que nos da el nombre del jugador con mas partidas ganadas
                        mensaje = trozos[1].Split('\0')[0]; 
                        MessageBox.Show(mensaje);
                        break;

                    case 3: //enseña al cliente el resultado de la consulta de % de partidas ganadas
                        mensaje = trozos[1].Split('\0')[0]; 
                        if (mensaje == "NO")
                        {
                            MessageBox.Show("Usuario no encontrado");
                        }
                        else if(mensaje == "(null)")
                        {
                            MessageBox.Show("Este usuario no ha ganado ninguna partida todavia");
                        }
                        else
                        {
                            MessageBox.Show("El % de partidas ganadas es de: " + mensaje + "%");
                        }
                        break;

                    case 4: //resultado consulta ganador cierta partida concreta
                        mensaje = trozos[1].Split('\0')[0]; 
                        if (mensaje == "NO")
                        {
                            MessageBox.Show("No hay partida a esa hora o fecha(Recuerda que la fecha se pone XX-XX-XXXX y la hora XX:XX)");
                        }
                        else
                        {
                            MessageBox.Show("El usuario que gano esa partida fue: " + mensaje);
                        }
                        break;

                    case 5: //inicio de sesion
                        mensaje = trozos[1].Split('\0')[0]; 
                        if (mensaje == "NO")
                        {
                            string mennsaje = "0/" + Usuario.Text;
                            byte[] msg3 = System.Text.Encoding.ASCII.GetBytes(mennsaje);
                            server.Send(msg3);

                            MessageBox.Show("No se ha iniciado sesion correctamente ");
                        }
                        else
                        {
                            MessageBox.Show("Se ha podido iniciar sesion");
                        }
                        break;
                    
                    case 7://delegado para actualizar lista de conectados
                        mensaje = trozos[1].Split('\0')[0]; 
                        DelegadoParaEscribir delegado = new DelegadoParaEscribir(ActualizarListaConectados);
                        dataGridView1.Invoke(delegado, new object[] { mensaje });
                        break;

                    case 8:
                    //Pregunta si acepta o no la invitacion
                            mensaje = trozos[1].Split('\0')[0]; 
                            string[] invit = mensaje.Split(',');
                            int n = Convert.ToInt32(invit[1]);
                            var result = MessageBox.Show(invit[0] + " te ha invitado, aceptas?"," Nueva invitacion ",MessageBoxButtons.YesNo);
                         
                            if (result == DialogResult.Yes)
                            {
                                //Envio la respuesta al servidor informando que si ha aceptado
                                string respuesta = "9/SI/" + Usuario.Text + "/" + invit[0] + "/" + n  ;
                                byte[] msg = System.Text.Encoding.ASCII.GetBytes(respuesta);
                                server.Send(msg);
                                //Abro un formulario nuevo
                            }
                            else
                            {
                                //Envio la respusta al servidor informando que ha rechazado la invitacion
                                string respuesta = "9/NO/" + Usuario.Text + "/" + invit[0] + "/" + n;
                                byte[] msg = System.Text.Encoding.ASCII.GetBytes(respuesta);
                                server.Send(msg);
                            }
                        break;

                    case 9: //resultado invitacion
                        mensaje = trozos[1].Split('\0')[0]; 
                        break;

                    case 10: // funcion delegada para escribir en el chat
                         mensaje = trozos[1].Split('/')[0]; 
                         int nform = Convert.ToInt32(trozos[2]);
                         formularios[nform].EscribirEnChat(mensaje);
                         break;

                    case 11: //funcion para eliminar usuario de la base de datos y desconectarlo
                        mensaje = trozos[1].Split('\0')[0]; 
                        MessageBox.Show("Se ha eliminado el usuario: " + mensaje + " correctamente");
                        DelegadoParaVaciar delegado3 = new DelegadoParaVaciar(Vaciar);
                        break;

                    case 12://Para actualizar los jugadores
                         int numform = Convert.ToInt32(trozos[1]);
                         mensaje = trozos[2].Split('/')[0];
                         formularios[numform].ListaJugadores(mensaje);
                        break;

                    case 13: //Recojo variable numpartida
                        numpartida = Convert.ToInt32(trozos[1]);
                        break;
                        
                    case 14://Para abrir form2
                        mensaje = trozos[1].Split('\0')[0];
                        if (mensaje == "SI")
                        {//Abro los formularios 
                            ThreadStart ts = delegate { PonerEnMarchaFormulario(); };
                            Thread T = new Thread(ts);
                            T.Start();
                        }
                        break;

                    case 15: // establecemos limite de vidas
                         numform = Convert.ToInt32(trozos[1]);
                         mensaje = trozos[2].Split('/')[0];
                         formularios[numform].PruebaVidas(mensaje);
                         break;

                    case 16: // hacemos visibles los dados cuando al cliente le toque tirar
                        numform = Convert.ToInt32(trozos[1].Split('\0')[0]);
                        formularios[numform].DadosVisibles();
                        break;

                    case 17://recibe la jugada del jugador anterior y pregunta al usuario si se lo cree o no
                        numform = Convert.ToInt32(trozos[1]);
                        mensaje = trozos[2].Split('/')[0];
                        formularios[numform].ParaPreguntarMent(mensaje);
                        break;

                    case 18://guarda valor de la jugada que le han enviado en el turno anterior
                        numform = Convert.ToInt32(trozos[1]);
                        mensaje = trozos[2].Split('\0')[0];
                        formularios[numform].ValorTurnoAnterior(mensaje);
                        break;

                    case 19: // actualiza las vidas de los jugadores de la lista de jugadores de cierta partida.
                        numform = Convert.ToInt32(trozos[1]);
                        mensaje = trozos[2].Split('\0')[0];
                        formularios[numform].ActualizarVidas(mensaje);


                         //string menssaje = "19/" + numform;
                         //// Enviamos al servidor el nombre tecleado
                         //byte[] msg6 = System.Text.Encoding.ASCII.GetBytes(mensaje);
                         //server.Send(msg6);

                        break;

                    case 20:
                        numform = Convert.ToInt32(trozos[1]);
                        formularios[numform].ActualizarLblResultDel();
                        break;

                    case 21:
                        numform = Convert.ToInt32(trozos[1]);
                        formularios[numform].CerrarFormDel();
                        break;

                }
            }
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
                //IPAddress direc = IPAddress.Parse("192.168.56.102");
                IPAddress direc = IPAddress.Parse("147.83.117.22");
                IPEndPoint ipep = new IPEndPoint(direc, 50084);
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
                string mensaje = "5/" +  Usuario.Text + "/" + Contraseña.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //pongo en marcha el thread que atenderá los mensajes del servidor
                ThreadStart ts = delegate { AtenderServidor(); };
                atender = new Thread(ts);
                atender.Start();
            }
        }
        private void Desconectarse_button_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            atender.Abort();
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void ConsultaAleix_button_Click(object sender, EventArgs e) //botón de consulta 1
        {
            string mensaje = "3/" + Usuario.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaDani_button_Click(object sender, EventArgs e) //botón de consulta 2
        {
            string mensaje = "2/" ;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg); 
        }

        private void ConsultaIngrid_button_Click(object sender, EventArgs e) //botón de consulta 3
        {
            if (Fecha.Text == "" || Hora.Text == "")
            {
                MessageBox.Show("Falta rellenar el campo de hora o de fecha");
            }
            else 
            {
            string mensaje = "4/" + Fecha.Text + "/" + Hora.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            }
        }

        private void IniciarSesion_button_Click(object sender, EventArgs e)
        { 

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
                //IPAddress direc = IPAddress.Parse("192.168.56.102");
                IPAddress direc = IPAddress.Parse("147.83.117.22");
                IPEndPoint ipep = new IPEndPoint(direc, 50084);
                this.BackColor = Color.Red;

                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket
                    this.BackColor = Color.Green;
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
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Conectados_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void contl_Click(object sender, EventArgs e)
        {

        }

        private void invitarbutton_Click(object sender, EventArgs e) 
        {//invita a los usuarios en los cuales clicas en el datagrid de la lista de conectados
            string invitados = null;
            int i = 0;
            bool invito = false;
            int numinvitados = dataGridView1.SelectedCells.Count;
            while (i < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[i].Cells[0].Selected)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value == null)
                    {
                        MessageBox.Show("No has seleccionado a ningun jugador");
                        invito = false;
                        break;
                    }
                    else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == Usuario.Text)
                    {
                        MessageBox.Show("Te estas invitando a ti mismo");
                        invito = false;
                        break;
                    }
                    else
                    {
                        invitados = invitados + ",";
                        invitados = invitados + dataGridView1.Rows[i].Cells[0].Value.ToString();
                        i = i + 1;
                        invito = true;
                    }
                }
                else
                {
                    i = i + 1;
                }

            }

            if (invito == true)
            {
                string mensaje = "8/" + Usuario.Text + "," + Convert.ToString(numinvitados) + invitados;
                // Enviamos al servidor el nombre introducido
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        private void CrearPartida_Click(object sender, EventArgs e) //crea partida y nos permite invitar a jugadores
        {
            string mensaje;
            mensaje = " ";
            mensaje = "12/" + Usuario.Text + "/";
            // Enviamos al servidor el nombre introducido
            byte[] msg2 = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg2);
            invitarbutton.Visible = true;
        }
        private void PonerEnMarchaFormulario() 
        {//inicializamos el form 2
            int cont = formularios.Count;
            Form2 f = new Form2(cont,server,Usuario.Text,numpartida);
            formularios.Add(f);
            f.ShowDialog();
        }

        private void DarsedeBaja_button_Click(object sender, EventArgs e) 
        {//nos damos de baja de la base de datos y cerramos cliente
                string User = Usuario.Text;
                string mensaje = "11/" + User + "/" + Contraseña.Text;
                // Enviamos al servidor el nombre introducido
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
                atender.Abort();
                this.BackColor = Color.Gray;
                server.Shutdown(SocketShutdown.Both);
                server.Close(); 
            }

        private void Fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrimos el form de instrucciones (form 3)

            Form4 f = new Form4();
            f.ShowDialog();
        }
    }     
}
