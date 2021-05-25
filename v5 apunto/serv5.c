#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <pthread.h>

int contador;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

int i;
int sockets[100];



typedef struct {
	char nombre [20];
	int socket;
} Conectado;
typedef struct {
	Conectado conectados [100];
	int num;
} ListaConectados;
typedef struct{
	int id;
	char jugadores[300];
	int numjugadores;
}Partida;

typedef struct{
	Partida partidas[100];
	int num;
}ListaPartidas;

ListaPartidas milistapart;

/*typedef struct {*/
/*	ListaConectados ListaJugadores;*/
/*	int ocupado;*/
/*	}Partida;*/

/*Partida TablaPartidas[100];*/

int PonSocket (ListaConectados *milista, int socket){
	if(milista->num<100){
		milista->conectados[milista->num].socket = socket;
		milista->num++;
		return 0;
	}
	else
	   return -1;
}

void PonNombre (ListaConectados *milista, char nombre[30], int socket)
	//agrega nombre a la lista de conectados
{
	
	strcpy (milista->conectados[milista->num].nombre, nombre);
	milista->conectados[milista->num].socket = socket;
	milista->num = milista->num + 1;
	
	
}

//me da la posicion que tengo en la lista
int DamePosicion(ListaConectados *milista, char nombre[30]){
	int encontrado = 0;
	for(int i =0; encontrado == 0 && i<100; i++){
		if(strcmp(milista->conectados[i].nombre, nombre) == 0){
			encontrado == 1;
			return i;
		}
		else
		   return-1;
	}
	
}

//elimina nombre de la lista de conectados
int Eliminar (ListaConectados *lista, char nombre[20])
{
	int pos = DamePosicion (lista, nombre);
	if (pos == -1)
		return -1;
	else{
		int i;
		for(i= pos; i< lista->num-1; i++){
			strcpy(lista->conectados[i].nombre, lista->conectados[i+1].nombre);
			lista->conectados[i].socket = lista->conectados[i+1].socket;
			/*lista->conectados[i] = lista->conectados[i+1];*/
		}
		
		for(i=0; i < lista->num; i++)
		{
			printf("esto es lo que queda %s\n",lista->conectados[i].nombre);
		}
		
	}
	
	lista->num--;
	return 0;
}



void DameConectados (ListaConectados *lista, char conectados [300]){
	//me da la los conectados en la lista
	
	sprintf (conectados,"");
	int i;
	
	/*printf("%d\n", lista->num);*/
	for (i=0; i< lista->num; i++){
		sprintf (conectados, "%s%s,", conectados, lista->conectados[i].nombre);
	}
	printf("esto es numero d conect: %d\n",lista->num);
	/*	sprintf(conectados, "%d/%s", lista->num, conectados);*/
	printf("esto es lista: %s\n", conectados);
	
}
int DameSocket(ListaConectados *milista, char nombre[30]){
	int encontrado = 0;
	int socket;
	for(int i =0; encontrado == 0 && i<100; i++){
		if(strcmp(milista->conectados[i].nombre, nombre) == 0){
			encontrado == 1;
			socket = milista->conectados[i].socket;
		}
	}
	return socket;
}
void DameNombre(ListaConectados *milista, int socket, char nombre[30]){
	int encontrado = 0;
	for(int i =0; encontrado == 0 && i<100; i++){
		if(milista->conectados[i].socket==socket){
			encontrado == 1;
			strcpy(nombre, milista->conectados[i].nombre);
		}
	}
}

int CrearPartida(ListaPartidas *milistapart, char nombre[20], int numjugadores){
	
	if(milistapart->num >> 99){
		printf("La lista de partidas esta llena\n");
		return -1;
	}
	else{
		strcpy (milistapart->partidas[milistapart->num].jugadores, nombre);
		milistapart->partidas[milistapart->num].id = milistapart->num;
		milistapart->partidas[milistapart->num].numjugadores = numjugadores;
		milistapart->num= milistapart->num + 1;
		return milistapart->partidas[milistapart->num].id;
	}
}
/*int AnadirPartida(LConectados *ListaConectados, int sock_conn, int socketInvitado[100],int NumInvitados)*/
/*{*/
/*	int i = 0;*/
/*	int encontrado = 0;*/
/*	while(i<100 && encontrado==0)*/
/*	{*/
/*		if (TablaPartidas[i].ocupado == 0)*/
/*		{*/
/*			TablaPartidas[i].ocupado = 1;*/
/*TablaPartidas[i].turno = 0;*/
/*			encontrado = 1;*/
/*		}*/
/*		else*/
/*			i++;*/
/*	}*/
/*	if (encontrado == 1)*/
/*	{*/
/*		int j = 0;*/
/*		int enc = 0;*/
/*		while (j < ListaConectados->num && enc ==0)*/
/*		{*/
/*			if (ListaConectados->Conectados[j].socket == sock_conn)*/
/*			{*/
/*				TablaPartidas[i].ListaJugadores.Conectados[0] =  ListaConectados->Conectados[j];*/
/*				printf("sock_conn: %d\n", sock_conn);*/
/*				TablaPartidas[i].ListaJugadores.num ++;*/
/*				enc = 1;*/
/*			}*/
/*			else*/
/*			{*/
/*				j++;*/
/*			}*/
/*		}*/
/*		for (j = 0; j < NumInvitados ; j++)*/
/*		{*/
/*			int n = 0;*/
/*			int enc = 0;*/
/*			while (n < ListaConectados->num && enc ==0)*/
/*			{*/
/*				if (ListaConectados->Conectados[n].socket == socketinvitado[j])*/
/*				{*/
/*					TablaPartidas[i].ListaJugadores.Conectados[TablaPartidas[i].ListaJugadores.num] =  ListaConectados->Conectados[n];*/
/*					TablaPartidas[i].ListaJugadores.num ++;*/
/*					enc = 1;*/
/*				}*/
/*				else*/
/*				{*/
/*					n++;*/
/*				}*/
/*			}*/
/*		}*/


/*		return i;*/
/*	}*/
/*	else*/
/*		return -1;*/
/*}*/


/*int EncontrarSocket(char nombre[20],ListaConectados *lista)*/
/*{*/
/*	int encontrado=0;*/
/*	int i=0;*/
/*	while((i<(lista->num))&&(encontrado == 0))*/
/*	{*/
/*		if((strcmp(lista->conectados[i].nombre,nombre)==0))*/
/*			encontrado=1;*/
/*		else */
/*			i=i+1;*/
/*	}*/
/*	if(encontrado)*/
/*	{*/
/*		return lista->conectados[i].socket;*/
/*	}*/
/*	else*/
/*	   return -1;*/
/*}*/
ListaConectados miLista;
void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	conn = mysql_init(NULL);
	//error al conectar
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	/*conn = mysql_real_connect (conn, "shiva2.upc.es","root", "mysql", "T5_juego" ,0, NULL, 0);*/
		conn = mysql_real_connect (conn, "localhost","root", "mysql", "T5_juego" ,0, NULL, 0);
	//error al iniciar
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	char peticion[512];
	char respuesta[512];
	int ret;
	int terminar =0;
	while (terminar ==0)
	{
		
		
		// Ahora recibimos la petici?n
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que anadirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		/*peticion[ret]='\0';*/
		
		
		printf ("Peticion: %s\n",peticion);
		
		char *p = strtok( peticion, "/");
		
		int codigo =  atoi (p);
		if (codigo ==0)
		{//peticion de desconexion
			
			char usuario[30];			
			p = strtok(NULL,"/"); 
			strcpy(usuario, p);
			
			/*	Eliminamos el usuario de la lista de conectados.*/
			
			pthread_mutex_lock(&mutex);
			int r = Eliminar(&miLista, usuario);
			
			
			pthread_mutex_unlock(&mutex);
			sprintf(respuesta, "0/");
			if (r ==0)
				printf("Eliminado\n");
			else
				printf("No eliminado\n");
			terminar=1;
			
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
			
		}
		else if (codigo == 6)
			sprintf (respuesta, "%d", contador);
		else if (codigo ==1) //consulta para crear nuevo usuario
		{		
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
				
				printf ("Codigo: %d, Usuario: %s, Contrasena: %s\n", codigo, user, password);
			}
			//construimos la consulta SQL
			
			strcpy (consulta,"INSERT INTO JUGADOR VALUES("); 
			//strcat (consulta, "4");
			strcat (consulta,"'");
			strcat (consulta, user);
			strcat (consulta,"','");
			strcat (consulta, password);
			strcat (consulta,"',");
			strcat (consulta, "0");
			strcat (consulta,",");
			strcat (consulta, "0);");
			
			//hacemos la consulta 
			err=mysql_query (conn, consulta);
			if (err!=0) 
			{
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			
			resultado = mysql_store_result (conn);
			/*printf ("HOLA\n");*/
			/*sprintf(respuesta,"SI");*/
			pthread_mutex_lock(&mutex);
			PonNombre(&miLista, user, sock_conn);
			sprintf(respuesta, "1/%s", user);
			pthread_mutex_unlock(&mutex);
			
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
			
		}
		else if (codigo ==2)//consulta que nos da el nombre del jugador con mas partidas ganadas
		{
			char consulta[80];
			sprintf (consulta,"SELECT JUGADOR.USUARIO FROM JUGADOR WHERE JUGADOR.PARTIDASGANADAS = (SELECT MAX(JUGADOR.PARTIDASGANADAS) FROM JUGADOR)");
			
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
				sprintf(respuesta,"2/%s,");
			}
			else 
				sprintf(respuesta,"2/%s",row[0]);
			
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
		}
		else if (codigo ==3)//consulta que nos da el % de partidas ganadas
		{				
			
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
				sprintf(respuesta,"3/NO");
			}
			else 
				sprintf(respuesta,"3/%s",row[0]);
			
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
		}	
		
		else if (codigo ==4)//consulta que nos da el usuario ganador de una partida concreta
			
		{
			char fecha[20];
			char hora[20];
			if (codigo !=0)
			{
				p = strtok( NULL, "/");
				
				strcpy (fecha, p);//fecha
				p = strtok( NULL, "/");
				strcpy (hora, p);//hora
				
				
				printf ("Codigo: %d, Fecha: %s, Hora: %s\n", codigo, fecha, hora);
			}
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
				sprintf(respuesta,"4/NO");
			}
			else 
				sprintf(respuesta,"4/%s",row[0]);
			
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
			
		}
		else if (codigo==5) //Consulta para loguearse
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
			if (err!=0) {
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			
			resultado = mysql_store_result(conn);
			printf("%s\n", resultado);
			row = mysql_fetch_row(resultado);
			
			if(row==NULL)
			{
				sprintf(respuesta, "5/NO");
				
				
			}
			else{
				/*sprintf(respuesta, "5/SI");*/
				printf("%s conectado.", usuarios);
				// agregar nombre a la lista de conectados
				pthread_mutex_lock(&mutex);
				PonNombre(&miLista, usuarios, sock_conn);
				pthread_mutex_unlock(&mutex);
				sprintf(respuesta, "5/%s", usuarios);
				
				
			}
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
		}
		else if (codigo==8){
			char jugador[20];
			char invitador[20];
			p = strtok(NULL,",");
			strcpy(invitador, p);
			p = strtok(NULL,",");
			int numjugadores= atoi(p);
			printf("Numero jugadores: %d\n", numjugadores);
			int part = CrearPartida(&milistapart, invitador, numjugadores); 
			printf("%d\n", part);
			if (part== -1){
				printf("La lista esta llena\n");
			}
			else{
				int i=0;
				while(i<numjugadores){
					p = strtok(NULL,",");
					strcpy(jugador, p);
					printf("Jugador: %s\n", jugador);
					pthread_mutex_lock(&mutex);
					int socketjugador = DameSocket(&miLista, jugador);
					pthread_mutex_unlock(&mutex);
					printf("Socket: %d\n", socketjugador);
					if (socketjugador != 0){
						sprintf(respuesta, "8/%s,%d", invitador, part);
						printf("Invitacion: %s\n", respuesta);
						write(socketjugador,respuesta,strlen(respuesta));
					}
					i++;
				}
			}
		}
		/*			printf("entro en el codigo8\n");*/
		/*			char invitador[30];*/
		/*			char invitado[30];*/
		/*			char mensaje[100];*/
		/*			printf("antes del strtok\n");*/
		/*			p = strtok(NULL, ",");*/
		/*			strcpy(invitador, p);*/
		/*			printf("el invitador es:%s\n", invitador);*/
		/*			p = strtok(NULL, ",");*/
		/*			strcpy(invitado, p);*/
		/*			printf("antesdeencontrarsocket\n");*/
		/*			pthread_mutex_lock(&mutex);*/
		/*			int socketinvitado = DameSocket(&miLista, invitado);*/
		/*			pthread_mutex_unlock(&mutex);*/
		/*			printf("%d\n",socketinvitado);*/
		/*			if(socketinvitado == -1)*/
		/*				sprintf(mensaje, "8/error");*/
		
		/*			sprintf(mensaje, "8/%s", invitador);*/
		
		/*			printf(mensaje);*/
		/*			write(socketinvitado, mensaje, strlen(mensaje));*/
		
		else if (codigo==9){
			char mensaje[30];
			char respuesta[20];
			char invitador[30];
			char invitado[30];
			p = strtok(NULL, "/");
			strcpy(respuesta, p);
			p = strtok(NULL, "/");
			strcpy(invitado, p);
			p = strtok(NULL, "/");
			strcpy(invitador, p);
			p = strtok(NULL,"/");
			int partida= atoi(p);			
			pthread_mutex_lock(&mutex);
			int socketinvitador = DameSocket(&miLista, invitador);
			pthread_mutex_unlock(&mutex);
			printf("%s\n",respuesta);
			if (strcmp(respuesta, "SI")== 0)
			{
				sprintf(mensaje, "9/%s ha aceptado tu invitacion",invitado);
			}
			else
			{
				sprintf(mensaje, "9/%s ha rechazado tu invitacion",invitado);
			}	
			
			write(socketinvitador,mensaje,strlen(mensaje));
		}
		else if (codigo==10) {
			char chat[400];
			char mensaje[500];
			
			p = strtok(NULL, "/");
			strcpy(chat,p);
			sprintf(mensaje, "10/%s",chat);
			int j;
			for (j=0; j< i; j++)
				write (sockets[j],mensaje, strlen(mensaje));
			
		}
		
		
		
		
		/*		if (*//*(codigo !=0) &&*//* (codigo !=4)||(codigo !=8)||(codigo !=9) )*///envia la respuesta
		/*		{*/
		
		/*			printf ("Respuesta: %s\n", respuesta);*/
		// Enviamos respuesta
		/*			write (sock_conn,respuesta, strlen(respuesta));*/
		/*		}*/
		if ((codigo == 1)||(codigo == 2)||(codigo == 3)||(codigo == 4)||(codigo == 5) ||(codigo == 10))
		{
			pthread_mutex_lock (&mutex);//no interrumpas ahora
			contador = contador+1;
			pthread_mutex_unlock (&mutex);// ya puedes interrumpir
			char conectados[300];
			DameConectados(&miLista, conectados);
			/*sprintf(respuesta,"7/%s",conectados);*/
			
			
			// notificar a todos los clientes conectados
			char notificacion[200];
			sprintf (notificacion, "7/%d,%s",miLista.num, conectados);
			printf("esto es notificacion: %s\n", notificacion);
			int j;
			printf("%d\n", i);
			for (j=0; j< i; j++)
				write (sockets[j],notificacion, strlen(notificacion));
			//Devolvemos nombres de conectados  
			
		}
		/*		if (codigo == 10){*/
		
		/*			char notificacion[200];*/
		/*			sprintf (notificacion, "10/%s",conectados);*/
		/*			int j;*/
		/*			for (j=0; j< i; j++)*/
		/*				write (sockets[j],notificacion, strlen(notificacion));*/
		
		
		
	}
}


int main(int argc, char *argv[])
{
	int err;
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
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
	serv_adr.sin_port = htons(50083);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	contador = 0;
	/*	int i;*/
	/*	int sockets[100];*/
	pthread_t thread[100];
	i=0;
	// Bucle infinito
	for (;;)
	{
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		sockets[i] =sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		
		// Crear thead y decirle lo que tiene que hacer
		
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);
		i=i+1;
		
	}
}