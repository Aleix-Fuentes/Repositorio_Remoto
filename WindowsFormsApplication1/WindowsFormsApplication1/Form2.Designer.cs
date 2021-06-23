namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.EnviarMensaje = new System.Windows.Forms.Button();
            this.MensajeaEnviar = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CaraDado2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.CaraDado1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaraDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaraDado1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnviarMensaje
            // 
            this.EnviarMensaje.Location = new System.Drawing.Point(426, 286);
            this.EnviarMensaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnviarMensaje.Name = "EnviarMensaje";
            this.EnviarMensaje.Size = new System.Drawing.Size(123, 29);
            this.EnviarMensaje.TabIndex = 28;
            this.EnviarMensaje.Text = "Enviar";
            this.EnviarMensaje.UseVisualStyleBackColor = true;
            this.EnviarMensaje.Click += new System.EventHandler(this.EnviarMensaje_Click);
            // 
            // MensajeaEnviar
            // 
            this.MensajeaEnviar.Location = new System.Drawing.Point(57, 286);
            this.MensajeaEnviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MensajeaEnviar.Name = "MensajeaEnviar";
            this.MensajeaEnviar.Size = new System.Drawing.Size(361, 26);
            this.MensajeaEnviar.TabIndex = 27;
            this.MensajeaEnviar.TextChanged += new System.EventHandler(this.MensajeaEnviar_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(57, 69);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 206);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1366, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(360, 165);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 32;
            this.button1.Text = "Enviar jugada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CaraDado2
            // 
            this.CaraDado2.Location = new System.Drawing.Point(992, 69);
            this.CaraDado2.Name = "CaraDado2";
            this.CaraDado2.Size = new System.Drawing.Size(128, 119);
            this.CaraDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CaraDado2.TabIndex = 33;
            this.CaraDado2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1378, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Jugadores en partida";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(651, 349);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(664, 291);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1158, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 46);
            this.button2.TabIndex = 37;
            this.button2.Text = "Tirar dados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CaraDado1
            // 
            this.CaraDado1.Location = new System.Drawing.Point(819, 69);
            this.CaraDado1.Name = "CaraDado1";
            this.CaraDado1.Size = new System.Drawing.Size(128, 119);
            this.CaraDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CaraDado1.TabIndex = 38;
            this.CaraDado1.TabStop = false;
            this.CaraDado1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1330, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tu tirada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1466, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 46);
            this.button3.TabIndex = 41;
            this.button3.Text = "Jugadores en partida";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(213, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 49);
            this.label3.TabIndex = 49;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(118, 492);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 78);
            this.button4.TabIndex = 43;
            this.button4.Text = "Empezar partida";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Location = new System.Drawing.Point(324, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 46);
            this.button5.TabIndex = 44;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Location = new System.Drawing.Point(118, 442);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 46);
            this.button6.TabIndex = 45;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(123, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 42);
            this.label4.TabIndex = 50;
            this.label4.Text = "NÚMERO DE VIDAS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(680, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(582, 68);
            this.label5.TabIndex = 51;
            this.label5.Text = "TODAS LAS JUGADAS ORDENADAS DE MENOR VALOR A MAYOR ;)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1508, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 48);
            this.label6.TabIndex = 52;
            this.label6.Text = "JUGADA ANTERIOR";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(1540, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 48);
            this.label7.TabIndex = 53;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(1364, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 48);
            this.label8.TabIndex = 54;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(119, 701);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(280, 78);
            this.button7.TabIndex = 56;
            this.button7.Text = "Instrucciones";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(1330, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 48);
            this.label9.TabIndex = 57;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 749);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CaraDado1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaraDado2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EnviarMensaje);
            this.Controls.Add(this.MensajeaEnviar);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaraDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaraDado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnviarMensaje;
        private System.Windows.Forms.TextBox MensajeaEnviar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox CaraDado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox CaraDado1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
    }
}