#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>




int main(int argc, char *argv[])
{
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexi￯﾿ﾯ￯ﾾ﾿￯ﾾﾳn: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexin
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "juego" ,0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9200);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i;
	// Bucle infinito
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
		
		int terminar =0;
		// Entramos en un bucle para atender todas las peticiones de este cliente
		//hasta que se desconecte
		while (terminar ==0)
		{
			// Ahora recibimos la petici?n
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			
			// Tenemos que a?adirle la marca de fin de string 
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';
			
			
			printf ("Peticion: %s\n",peticion);
			
			// vamos a ver que quieren
			char *p = strtok( peticion, "/");
			int codigo =  atoi (p);
			// Ya tenemos el c?digo de la petici?n
			/*char usuario[60];*/
			
/*						if (codigo !=0)*/
/*						{*/
/*							p = strtok( NULL, "/");*/
			
/*							strcpy (usuario, p);*/
			// Ya tenemos el nombre
/*							printf ("Codigo: %d, Usuario: %s\n", codigo, usuario);*/
/*						}*/
			
			if (codigo ==0) //petici?n de desconexi?n
				terminar=1;
			else if (codigo ==1) //usuario contrase￯﾿ﾱa
			{
/*				char user[20];*/
/*				char password[20];*/
/*				char consulta[80];*/
/*				for (i=0; i<100; i++) {*/
/*					if (codigo !=0)*/
/*					{*/
/*						p = strtok( NULL, "/");*/
					
/*						strcpy (user, p);*/
/*						p = strtok( NULL, "/");*/
/*						strcpy (password, p);				*/
/*						printf ("Codigo: %d, Usuario: %s, Contrase￱a: %s\n", codigo, user, password);*/
/*					}*/
					
/*					if (err!=2) */
/*					{*/
/*						printf ("Error al introducir los datos \n");*/
/*						exit (1);*/
/*					}*/
					// Ahora construimos el string con el comando SQL
					// para insertar la persona en la base. Ese string es:
					// INSERT INTO personas VALUES ('dni', 'nombre', edad); 
/*					strcpy (consulta, "INSERT INTO JUGADOR VALUES (");*/
					//strcat (consulta, "4");
/*				    strcat (consulta,"6,'");*/
/*					strcat (consulta, user);*/
/*					strcat (consulta,"','");*/
/*					strcat (consulta, password);*/
/*					strcat (consulta,"',0,0);");*/
					//strcat (consulta, "0");
					//strcat (consulta, ",0);");
					
						
					
/*					printf("consulta = %s\n", consulta);*/
					// Ahora ya podemos realizar la insercion 
/*					err = mysql_query(conn, consulta);*/
/*					if (err!=0) {*/
/*						printf ("Error al introducir datos la base %u %s\n", */
/*								mysql_errno(conn), mysql_error(conn));*/
/*						exit (1);*/
/*					}*/
/*				}*/
				
				
				char user[20];
				char password[20];
				char consulta[80];
				if (codigo !=0)
				{
					p = strtok( NULL, "/");
					
					strcpy (user, p);
					p = strtok( NULL, "/");
					strcpy (password, p);
					// Ya tenemos el nombre
					
					printf ("Codigo: %d, Usuario: %s, Contrase￱a: %s\n", codigo, user, password);
				}
				 //construimos la consulta SQL
				
				strcpy (consulta,"INSERT INTO JUGADOR VALUES("); 
				strcat (consulta, "9");
				strcat (consulta,",'");
				strcat (consulta, user);
				strcat (consulta,"','");
				strcat (consulta, password);
				strcat (consulta,"',");
				strcat (consulta, "0");
				strcat (consulta,",");
				strcat (consulta, "0);");
				//strcat (consulta,"','-/-/-');");
				 //hacemos la consulta 
				err=mysql_query (conn, consulta);
				if (err!=0) 
				{
					printf ("Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				resultado = mysql_store_result (conn); 
				row = mysql_fetch_row (resultado);
				if (row == NULL)
				{
					printf ("No se han obtenido datos en la consulta\n");
					sprintf(respuesta,"%s,");
				}
				else 
					sprintf(respuesta,"%s",row[0]);
/*				err = mysql_query (conn, consulta); */
/*				if (err!=0) */
/*				{*/
/*					printf ("Error al consultar datos de la base %u %s\n",*/
/*							mysql_errno(conn), mysql_error(conn));*/
/*					exit (1);*/
/*				}*/
				
			}
			else if (codigo ==2)
			{
				char consulta[80];
				sprintf (consulta,"SELECT JUGADOR.USUARIO FROM JUGADOR WHERE JUGADOR.PARTIDASGANADAS = (SELECT MAX(JUGADOR.PARTIDASGANADAS) FROM JUGADOR)");
				//sprintf (consulta,"SELECT JUGADOR.USUARIO FROM JUGADOR WHERE JUGADOR.PARTIDASGANADAS > 14");
				err=mysql_query (conn, consulta);
				if (err!=0) 
				{
					printf ("Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				resultado = mysql_store_result (conn); 
				row = mysql_fetch_row (resultado);
				if (row == NULL)
				{
					printf ("No se han obtenido datos en la consulta\n");
					sprintf(respuesta,"%s,");
				}
				else 
					sprintf(respuesta,"%s",row[0]);
			}
			else if (codigo ==3)
			{				
				//nos da el % de partidas ganadas
				char usuario[60];
				if (codigo !=0)
				{
					p = strtok( NULL, "/");
					
					strcpy (usuario, p);
					// Ya tenemos el nombre
					printf ("Codigo: %d, Usuario: %s\n", codigo, usuario);
				}
				char consulta [80];
				sprintf (consulta,"SELECT (100 * JUGADOR.PARTIDASGANADAS DIV JUGADOR.PARTIDASJUGADAS) FROM JUGADOR WHERE JUGADOR.USUARIO = '%s'", usuario);
				//sprintf (respuesta, "%s",consulta);
				err=mysql_query (conn, consulta);
				if (err!=0) 
				{
					printf ("Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
					
					
				
				}
				resultado = mysql_store_result (conn); 
				row = mysql_fetch_row (resultado);
				if (row == NULL)
				{
					printf ("No se han obtenido datos en la consulta\n");
					sprintf(respuesta,"NO");
				}
				else 
					sprintf(respuesta,"%s",row[0]);
			}	
				
			else if (codigo ==4)
					// Usuario ganador de una partida concreta
			{
				char fecha[20];
				char hora[20];
				if (codigo !=0)
				{
					p = strtok( NULL, "/");
					
					strcpy (fecha, p);
					p = strtok( NULL, "/");
					strcpy (hora, p);
					// Ya tenemos el nombre
					
					printf ("Codigo: %d, Fecha: %s, Hora: %s\n", codigo, fecha, hora);
				}
		
/*					char fecha[20];*/
					// Pregunto la fecha de la partida
/*					printf ("Dame una fecha separada por /\n"); */
/*					scanf ("%s", fecha);*/
/*					char hora[20];*/
					// Pregunto la hora de la partida
/*					printf ("Dame una hora separada por :\n"); */
/*					scanf ("%s", hora);*/
					//nos da el usuario que gano esa partida
					char consulta [80];
					sprintf (consulta,"SELECT JUGADOR.USUARIO FROM (JUGADOR,PARTIDAS)  WHERE PARTIDAS.FECHA = '%s' AND PARTIDAS.HORA = '%s' AND ID_G = JUGADOR.ID", fecha, hora);
					err=mysql_query (conn, consulta);
					if (err!=0) 
					{
						printf ("Error al consultar datos de la base %u %s\n",
								mysql_errno(conn), mysql_error(conn));
						exit (1);
						
						
						
					}
					resultado = mysql_store_result (conn); 
					row = mysql_fetch_row (resultado);
					if (row == NULL)
					{
						printf ("No se han obtenido datos en la consulta\n");
						sprintf(respuesta,"NO");
					}
					else 
						sprintf(respuesta,"%s",row[0]);
/*					err=mysql_query (conn, consulta);*/
/*					if (err!=0) */
/*					{*/
/*						printf ("Error al consultar datos de la base %u %s\n",*/
/*								mysql_errno(conn), mysql_error(conn));*/
/*						exit (1);*/
/*						resultado = mysql_store_result (conn); */
/*						row = mysql_fetch_row (resultado);*/
/*						if (row == NULL)*/
/*						{*/
/*							printf ("No se han obtenido datos en la consulta\n");*/
/*							sprintf(respuesta,"%s,");*/
/*						}*/
/*						else */
/*							sprintf(respuesta,"%s,",row[0]);*/
/*					}*/
			}
			else if (codigo==5) //Loguearse		2/Nombre/Contraseￃﾱa
			{
				char usuarios[60];
				char contrasena [60];
				p = strtok(NULL, "/");
				strcpy(usuarios,p);
				
				p = strtok(NULL,"/");
				strcpy(contrasena,p);
				char consulta[500];
				
				sprintf (consulta,"SELECT JUGADOR.USUARIO FROM JUGADOR WHERE JUGADOR.USUARIO = '%s' AND  JUGADOR.CONTRASE￑A = '%s';", usuarios, contrasena);
				
				
				err=mysql_query(conn, consulta);
				resultado = mysql_store_result(conn);
				row = mysql_fetch_row(resultado);
				
				if(row==NULL)
				{
					sprintf(respuesta, "NO");
				}
				else{
					sprintf(respuesta, "SI");
					printf("%s conectado.", usuarios);
				}
			}

				
				if (codigo !=0)
				{
					
					printf ("Respuesta: %s\n", respuesta);
					// Enviamos respuesta
					write (sock_conn,respuesta, strlen(respuesta));
				}
				
				// Se acabo el servicio para este cliente
				//close(sock_conn); 
			}
		}
	}
	