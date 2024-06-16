1. Carpeta Scritps SQL -> Uso del SQL Server, contiene los scripts de la base de datos
  01CreateDataBase -> Script que crea la base de datos y genera la tabla llamada "DB_REGISTRO"
  02InsercionData -> Script que inserta datos en la tabla "DB_REGISTRO"
  03StoredProcedure -> Scritp que contiene Store Procedure para que lo podamos llamar desde nuestra WebAPI.

   Se debe ejecutar los scripts 01,02 y 03 en SQL Server, antes de ejecutar el proyecto de webApi.



3. Carpeta ProyectoWebApi -> Contiene nuestro proyecto de webAPI con .NET, abrirlo con Visual Studio. A continuacion se detalla las carpetas mas importantes del proyecto.

  Carpeta Model:
    Clase Cita -> Contiene los nombres de las columnas de la tabla "BD_REGISTRO"

  Carpeta Data:
    Clase Conexion -> Contiene la cadena de conexion con nuestra base de datos. Para obtener la cadena de conexion es en la opcion Herramientas/Conectar con la Base de Datos/Origen 
                      de Datos(Microsoft SQL Server)/Nombre del Servidor/ Nombre de la Base de Datos/Propiedades Avanzadas.
    Clase CitaData -> Esta clase va a llamar a cada uno de nuestros procedimientos almacenados creados de la BD. Contiene los metodos Registrar, Modificar, Listar, Obtener y Eliminar.
                      Usamos SQLConnection para hacer nuestra conexion a la BD, pasandole la cadena de conexion(rutaConexio)

  Carpeta Controllers: 
    Clase ValuesController -> Aqui estan los endpoint(GET, POST, PUT y DELETE).

  Carpeta AppStart:
    Clase WebApiConfig -> Habilita que nuestro servicio web pueda ser llamado desde cualquier lugar, usado por cualquier cliente.




3. Paquetes necesarios a instalar para que pueda funcionar nuestro proyecto.
   - System.Data.SqlClient
   - Microsoft.AspNet.WebApi.Cors
   Estos paquetes se instalan en el gestor de paquetes NuGet



4. Pruebas en Postman

   - Listar Citas (GET) -> https://localhost:{puerto}/api/cita
   - Obtener Cita (GET) -> https://localhost:{puerto}/api/cita/{id}
   - Registrar Cita (POST) -> https://localhost:{puerto}/api/cita
   - Modificar Cita (PUT) -> https://localhost:{puerto}/api/cita
   - Eliminar Cita (DELETE) -> https://localhost:{puerto}/api/cita
     
   
