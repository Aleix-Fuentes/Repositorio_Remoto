using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApplication1
{
    
    public partial class Form2 : Form
    {
        int nForm;
        Socket server;
        string nombre;
        int numpartida;
        int n;
       
        int kiriki = 21; // definimos el valor de todas las jugadas del juego
        int ases = 20;
        int kungfu = 19;
        int Ks = 18;
        int Qs = 17;
        int Js = 16;
        int rojos = 15;
        int negros = 14;
        delegate void DelegadoParaEscribir(string mensaje); //delegados para evitar crossthreading
        delegate void DelegadoParaBotonTirar();
        int actualvida;
        int valorjugada;
        int resultado;
        string charjugada;
        string charresultado;
   
        public Form2(int nForm, Socket server, string nombre, int numpartida)
        {
            InitializeComponent();
            this.nForm = nForm;
            this.server = server;
            this.nombre = nombre;
            this.numpartida = numpartida;
            button2.Visible = false;

            //Rellenamos el datagridview con todas las posibles partidas
            dataGridView2.ColumnCount = 3;
            dataGridView2.Rows.Add("4 puntos", "5 puntos", "6 puntos");
            dataGridView2.Rows.Add("7 puntos", "8 puntos", "9 puntos");
            dataGridView2.Rows.Add("10 puntos", "Negros", "Rojos");
            dataGridView2.Rows.Add("Js", "Qs", "Ks");
            dataGridView2.Rows.Add("Kungfu" ,"Ases", "Kiriki");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; 
        }
        public void ActualizarJugadores(string mensaje) 
        {//Actualiza lista jugadores de una partida
            string[] sConectados = mensaje.Split(',');
            n = Convert.ToInt32(sConectados[0]);
            dataGridView1.RowCount = n;

            int j = 1;
            for (int i = 0; i < n; i++)
            {
                dataGridView1[0, i].Value = sConectados[j];
                j++;
            }
        }
        public void ListaJugadores (string mensaje)
        {//Delegado para actualizar jugadores
            DelegadoParaEscribir delegado5 = new DelegadoParaEscribir(ActualizarJugadores);
            dataGridView1.Invoke(delegado5, new object[] { mensaje });
        }
        private void EnviarMensaje_Click(object sender, EventArgs e) 
        {//envia mensaje por el chat
            string mensaje = "10/" + nForm + "/" + nombre + ": " + MensajeaEnviar.Text + "/";
            MensajeaEnviar.Clear();
            //Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg); 
        }
        public void PruebaVidas(string mensaje)
        {//Delegado para usar funcion recibirvidas
            DelegadoParaEscribir delegado5 = new DelegadoParaEscribir(RecibirVidas);
            this.Invoke(delegado5, new object[] { mensaje });
        }
        public void RecibirVidas(string mensaje) 
        {//definimos el numero de vidas con el que vamos a jugar
            //Escondo los botones relacionados con las vidas
            label4.Visible = false;
            label3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button4.Visible = false;

            string[] sVidas = mensaje.Split(',');
            int n = Convert.ToInt32(sVidas[0]);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = 2;
            int numvidas = Convert.ToInt32(sVidas[1]);
            for (int i = 0; i < n; i++)
            {
                dataGridView1[1, i].Value = numvidas;
            }
        }

        public void CerrarFormDel()
        {//Delegado para usar la función CerrarForm
            DelegadoParaBotonTirar delegado9 = new DelegadoParaBotonTirar(CerrarForm);
            dataGridView1.Invoke(delegado9, new object[] { });
        }
        public void CerrarForm()
        {
            this.Close();
        }

        private void MensajeaEnviar_TextChanged(object sender, EventArgs e)
        {

        }
        public void Escribir(string mensaje) 
        {//Escribimos en el chat de la partida
            richTextBox1.AppendText(mensaje + "\n");
        }
        public void EscribirEnChat(string mensaje)
        {//Delegado para usar funcion Escribir
            DelegadoParaEscribir delegado4 = new DelegadoParaEscribir(Escribir);
            richTextBox1.Invoke(delegado4, new object[] { mensaje });
        }
        public void DadosVisibles()
        {//Delegado para usar funcion BotonTirarDadosVisible
            DelegadoParaBotonTirar delegado5 = new DelegadoParaBotonTirar(BotonTirarDadosVisible);
            this.Invoke(delegado5, new object[] { });
        }
        public void BotonTirarDadosVisible()
        {//Ponemos el boton para tirar los dados visible
            button2.Visible = true;
        }
       
        public void ActualizarDataGrid(string mensaje)
        {//Fucnion para actualizar el datagrid cada vez que alguien pierde una vida
            string[] cositas = mensaje.Split(',');
            int numjug = Convert.ToInt32(cositas[0]);

            int j = 1;
            for (int i = 0; i < numjug; i++)
            {
                    dataGridView1[0, i].Value = cositas[j];
                    j++;
                    dataGridView1[1, i].Value = cositas[j];
                    j++;
            }
            label7.Text = "0";
            label8.Text = "";
            valorjugada = 0;
        }
        
        public void ActualizarVidas(string mensaje)
        {//Delegado para usar la funcion de ActualizarDataGrid
            DelegadoParaEscribir delegado6 = new DelegadoParaEscribir(ActualizarDataGrid);
            dataGridView1.Invoke(delegado6, new object[] { mensaje });
        }
        public void ParaPreguntarMentiras(string mensaje)
        {//Actualiza los labels donde esta la info de la jugada anterior
            string[] cositas = mensaje.Split(',');
            label8.Text =  cositas[1];
            label7.Text = cositas[0];
        }
        public void ValorTurnoAnterior(string mensaje)
        {//Delegado para usar la funcion de arriba
            DelegadoParaEscribir delegado7 = new DelegadoParaEscribir(ParaPreguntarMentiras);
            this.Invoke(delegado7, new object[] { mensaje });
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) 
        {//Cuando apreto el boton tirardados, se actualizan las fotos de los dados y calculamos el resultado
            int Dado1, Dado2;
            Random aleatorio = new Random();
            Dado1 = aleatorio.Next(1, 7);
            Dado2 = aleatorio.Next(1, 7);
            if (Dado1 == 1)
            {
                CaraDado1.Image = Image.FromFile("negros.JPG");
            }
            if (Dado1 == 2)
            {
                CaraDado1.Image = Image.FromFile("rojos.JPG");
            }
            if (Dado1 == 3)
            {
                CaraDado1.Image = Image.FromFile("J.JPG");
            }
            if (Dado1 == 4)
            {
                CaraDado1.Image = Image.FromFile("Q.JPG");
            }
            if (Dado1 == 5)
            {
                CaraDado1.Image = Image.FromFile("K.JPG");
            }
            if (Dado1 == 6)
            {
                CaraDado1.Image = Image.FromFile("as.JPG");
            }
            if (Dado2 == 1)
            {
                CaraDado2.Image = Image.FromFile("negros.JPG");
            }
            if (Dado2 == 2)
            {
                CaraDado2.Image = Image.FromFile("rojos.JPG");
            }
            if (Dado2 == 3)
            {
                CaraDado2.Image = Image.FromFile("J.JPG");
            }
            if (Dado2 == 4)
            {
                CaraDado2.Image = Image.FromFile("Q.JPG");
            }
            if (Dado2 == 5)
            {
                CaraDado2.Image = Image.FromFile("K.JPG");
            }
            if (Dado2 == 6)
            {
                CaraDado2.Image = Image.FromFile("as.JPG");
            }

            if (Dado1 != Dado2)
            {
                if (Dado1 == 1 && Dado2 == 2)
                {
                    resultado = kiriki;
                }
                else if (Dado1 == 2 && Dado2 == 1)
                {
                    resultado = kiriki;
                }
                else if (Dado1 == 6 && Dado2 == 5)
                {
                    resultado = kungfu;
                }
                else if (Dado1 == 5 && Dado2 == 6)
                {
                    resultado = kungfu;
                }
                else
                {
                    resultado = Dado1 + Dado2;
                }
            }
            if (Dado1 == Dado2)
            {
                if (Dado1 == 1)
                {
                    resultado = negros;
                }
                else if (Dado1 == 2)
                {
                    resultado = rojos;
                }
                else if (Dado1 == 3)
                {
                    resultado = Js;
                }
                else if (Dado1 == 4)
                {
                    resultado = Qs;
                }
                else if (Dado1 == 5)
                {
                    resultado = Ks;
                }
                else
                {
                    resultado = ases;
                }
             
                    
            }
            string mensaje = "18/" + nombre + "/";
            byte[] msg2 = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg2);
            //Enviamos al servidor un mensaje para asi poder indicar que se actualize el label9

            //hacemos invisible el boton pq solo queremos que tire una vez
            button2.Visible = false;
            button1.Visible = true;
        }
        public void ActualizarLblResult() 
        {//actualiza el label resultado
            charresultado = DevolverValorEnString(resultado);
            label9.Text = charresultado;         
        }
        public void ActualizarLblResultDel()
        {//Delegado para usar la función ActualizarLblResult
            DelegadoParaBotonTirar delegado8 = new DelegadoParaBotonTirar(ActualizarLblResult);
            dataGridView1.Invoke(delegado8, new object[] {});
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {//Enviamos la jugada con la que queremos mentir (o no) al próximo jugador
            string jugada;
            jugada = dataGridView2.CurrentCell.Value.ToString();
            valorjugada = 0;

            if( jugada == "3 puntos")
            {
                valorjugada = 3;
            }
            else if (jugada == "4 puntos")
            {
               valorjugada = 4;
            }
            else if (jugada == "5 puntos")
            {
                valorjugada = 5;
            }
            else if (jugada == "6 puntos")
            {
                valorjugada = 6;
            }
            else if (jugada == "7 puntos")
            {
                valorjugada = 7;
            }
            else if (jugada == "8 puntos")
            {
                valorjugada = 8;
            }
            else if (jugada == "9 puntos")
            {
                valorjugada = 9;
            }
            else if (jugada == "10 puntos")
            {
                valorjugada = 10;
            }
            else if (jugada == "Negros")
            {
                valorjugada = 14;
            }
            else if (jugada == "Rojos")
            {
                valorjugada = 15;
            }
            else if (jugada == "Js")
            {
                valorjugada = 16;
            }
            else if (jugada == "Qs")
            {
                valorjugada = 17;
            }
            else if (jugada == "Ks")
            {
                valorjugada = 18;
            }
            else if (jugada == "Ases")
            {
                valorjugada = 20;
            }
            else if (jugada == "Kiriki")
            {
                valorjugada = 21;
            }
            else if (jugada == "Kungfu")
            {
                valorjugada = 19;
            }
            int valoranterior = Convert.ToInt32(label7.Text);
            if (valoranterior < valorjugada)
            {   
                //valor jugada es lo que hemos enviado para mentir
                //resultado es el valor real de los dados
                string mensaje = "14/" + valorjugada + "/" + resultado + "/" + label7.Text + "/" + nombre + "/";
                // Enviamos al servidor el mensaje
                byte[] msg2 = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg2);
                button1.Visible = false; 
            }
              
            else
            {
                MessageBox.Show("Tienes que ser mayor que la jugada anterior! ;)");
            }
            
        }

        private void button3_Click(object sender, EventArgs e) 
        {//nos da la lista de conectados de esta partida, deberia ser automatico
            string mensaje = "13/" + nForm + "/" + numpartida + "/" + nombre + "/";
            // Enviamos al servidor el numero de form y el numero de partida con el nombre
            byte[] msg2 = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) 
        {//Sumamos vidas antes de empezar la partida
            actualvida = Convert.ToInt32(label3.Text);
            actualvida ++;
            label3.Text = Convert.ToString(actualvida); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) 
        {//Restamos vida antes de empezar la partida (decidimos cuantas queremos)

            actualvida = Convert.ToInt32(label3.Text);
            actualvida--;
            label3.Text = Convert.ToString(actualvida); 
        }

        private void button4_Click(object sender, EventArgs e) 
        {//Establecemos numero de vidas con el que empezamos
            actualvida = Convert.ToInt32(label3.Text);
            if (actualvida < 1 || actualvida > 10)
            {//Hay un rango de vidas para empezar
                MessageBox.Show("Tienes que jugar con un numero de vidas entre 1 y 10");
            }
            else
            {
                string mensaje = "15/" + actualvida + "/" + nForm + "/" + numpartida + "/";
                // Enviamos al servidor el numero de vidas que quiere empezar
                byte[] msg2 = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg2);  
            }           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) 
        {//Abrimos el form de instrucciones (form 3)

            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void ParaPreguntarMent(string mensaje) 
        {//Funcion donde se le enseña la jugada al jugador siguiente y el decide si se lo cree o no
   
            valorjugada = Convert.ToInt32(mensaje.Split(',')[0]);
            string jugador = Convert.ToString(mensaje.Split(',')[1]);
            resultado = Convert.ToInt32(mensaje.Split(',')[2]);
            string nommbre = mensaje.Split(',')[1];

            charjugada = DevolverValorEnString(valorjugada);
            //preguntamos si se cree la jugada

            var result = MessageBox.Show(jugador + " te envia " + charjugada + ", te lo crees??", " Mentirijillas ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Si se la cree seguimos el juego normal
                DelegadoParaBotonTirar delegado5 = new DelegadoParaBotonTirar(BotonTirarDadosVisible);
                this.Invoke(delegado5, new object[] { });
            }
            else if (result == DialogResult.No)
            {

                if (valorjugada == resultado)
                {//pierde la vida el que le ha dado que no 
                    string mensa = "16/" + nombre + "/" + numpartida + "/" + valorjugada + "/" + resultado + "/";
                    // Enviamos al servidor el valor de la jugada
                    byte[] msg2 = System.Text.Encoding.ASCII.GetBytes(mensa);
                    server.Send(msg2);
                }
                else if (valorjugada != resultado)
                {
                    //pierde la vida el que ha mentido 
                    string mensa = "17/" + jugador + "/" + numpartida + "/";
                    // Enviamos al servidor el valor de la jugada
                    byte[] msg2 = System.Text.Encoding.ASCII.GetBytes(mensa);
                    server.Send(msg2);
                }

                DelegadoParaBotonTirar delegado5 = new DelegadoParaBotonTirar(BotonTirarDadosVisible);
                this.Invoke(delegado5, new object[] { });
            }
        }

        public string DevolverValorEnString(int valorjugada)
        { //Convierte el valor de la jugada en string, ya que la gente no sabe que rojos equivale a 15 por ejemplo
            if (valorjugada == 3)
            {
                charjugada = "3 puntos";
            }
            else if (valorjugada == 4)
            {
                charjugada = "4 puntos";
            }
            else if (valorjugada == 5)
            {
                charjugada = "5 puntos";
            }
            else if (valorjugada == 6)
            {
                charjugada = "6 puntos";
            }
            else if (valorjugada == 7)
            {
                charjugada = "7 puntos";
            }
            else if (valorjugada == 8)
            {
                charjugada = "8 puntos";
            }
            else if (valorjugada == 9)
            {
                charjugada = "9 puntos";
            }
            else if (valorjugada == 10)
            {
                charjugada = "10 puntos";
            }
            else if (valorjugada == 14)
            {
                charjugada = "negros";
            }
            else if (valorjugada == 15)
            {
                charjugada = "rojos";
            }
            else if (valorjugada == 16)
            {
                charjugada = "Js";
            }
            else if (valorjugada == 17)
            {
                charjugada = "Qs";
            }
            else if (valorjugada == 18)
            {
                charjugada = "Ks";
            }
            else if (valorjugada == 20)
            {
                charjugada = "Ases";
            }
            else if (valorjugada == 21)
            {
                charjugada = "Kiriki";
            }
            else if (valorjugada == 19)
            {
                charjugada = "Kungfu";
            }

            return charjugada;
        }

        
       
    }
}
