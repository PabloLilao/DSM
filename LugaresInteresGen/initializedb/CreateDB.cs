
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using LugaresInteresGenNHibernate.EN.LugaresInteres;
using LugaresInteresGenNHibernate.CEN.LugaresInteres;
using LugaresInteresGenNHibernate.CAD.LugaresInteres;
//using EjemploProyectoCP

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                /* PON A TRUE LAS PRUEBAS QUE QUIERAS VALIDAR
                 * SI VAS A CREAR NUEVAS PRUEBAS PONLAS COMO LAS DEMAS
                 */

                /* Nota mental: �Usuario no deberia tener un atributo que dijese si esta logueado o no?
                 */
                Boolean pruebasLogin = false;
                Boolean pruebasCambiarPassword = false;
                Boolean pruebasCrearComentario = false;
                Boolean pruebasReportar = false;
                Boolean pruebasCrearLugar = false;
                Boolean pruebasValidar = false;
                Boolean pruebasCrearActividad = true;
                System.Collections.Generic.IList<String> list_fotos = new System.Collections.Generic.List<String>();

                //HQL
                //Boolean pruebaBuscarNoValidados = false;

                //Usuario usado en pruebasLogin y pruebasCambiarPassword
                UsuarioCEN usucenutrio = new UsuarioCEN ();
                String oid;
                oid = usucenutrio.Registro ("pepe@peo.com", "pepe", "Serrano", "1234", "Montesinos", "fotochachi");
                if (oid != null) {
                        System.Console.WriteLine ("\n\n Se ha creado el usuario: pepe@peo.com");
                }



                /* PRUEBAS LOGIN */

                if (pruebasLogin) {
                        if (!usucenutrio.Login ("pepe@.com", "1234")) {
                                System.Console.WriteLine ("\n\n pepe NO se ha logueado porque ha introducido mal su email");
                        }
                        if (!usucenutrio.Login ("pepe@peo.com", "124")) {
                                System.Console.WriteLine ("\n\n pepe NO se ha logueado porque ha introducido mal su contrase�a");
                        }
                        if (usucenutrio.Login ("pepe@peo.com", "1234")) {
                                System.Console.WriteLine ("\n\n pepe S� se ha logueado");
                        }
                }
                /* PRUEBAS CAMBIAR PASSWORD */

                if (pruebasCambiarPassword) {
                        if (!usucenutrio.CambiarPassword ("pepe@peo.com", "124", "aleluya", "aleluya")) {
                                System.Console.WriteLine ("\n\n pepe NO ha cambiado su contrase�a porque ha introducido mal su contrase�a");
                        }
                        if (!usucenutrio.CambiarPassword ("pepe@peo.com", "1234", "aleluya", "aHleluya")) {
                                System.Console.WriteLine ("\n\n pepe NO ha cambiado su contrase�a porque ha escrito mal la nueva contrase�a");
                        }
                        if (!usucenutrio.CambiarPassword ("pepe@eo.com", "1234", "aleluya", "aleluya")) {
                                System.Console.WriteLine ("\n\n pepe NO ha cambiado su contrase�a porque ha escrito mal su email");
                        }
                        if (usucenutrio.CambiarPassword ("pepe@peo.com", "1234", "5678", "5678")) {
                                System.Console.WriteLine ("\n\n pepe ha cambiado su contrase�a");
                        }
                }
                /* PRUEBAS CREAR COMENTARIO */
                if (pruebasCrearComentario) {
                        ComentarioCEN coment1 = new ComentarioCEN ();
                        ComentarioEN nuevocomentario = null;
                        nuevocomentario = coment1.CrearComentario ("Comentario sin usuario", null);
                        if (nuevocomentario != null) {
                                Console.Write ("\n\n Se ha creado el comentario con usuario nulo  \n\n");
                        }
                        else{
                                Console.WriteLine ("\n\n NO se ha creado el comentario con usuario nulo  \n\n");
                        }
                        nuevocomentario = coment1.CrearComentario ("Comentario con usuario vacio", "");
                        if (nuevocomentario != null) {
                                Console.Write ("\n\n Se ha creado el comentario con usuario vacio \n\n");
                        }
                        else{
                                Console.WriteLine ("\n\n NO se ha creado el comentario con usuario vacio \n\n");
                        }
                        nuevocomentario = coment1.CrearComentario ("Comentario con usuario con espacio en blanco", " ");
                        if (nuevocomentario != null) {
                                Console.Write ("\n\n Se ha creado el comentario con usuario con espacio en blanco \n\n");
                        }
                        else{
                                Console.WriteLine ("\n\n NO se ha creado el comentario con usuario con espacio en blanco \n\n");
                        }
                        nuevocomentario = coment1.CrearComentario ("Comentario con usuario mal escrito", "pep@peo.com");
                        if (nuevocomentario != null) {
                                Console.Write ("\n\n Se ha creado el comentario con usuario mal escrito \n\n");
                        }
                        else{
                                Console.WriteLine ("\n\n NO se ha creado el comentario con usuario mal escrito \n\n");
                        }
                        nuevocomentario = coment1.CrearComentario (null, "pepe@peo.com");
                        if (nuevocomentario != null) {
                                Console.Write ("\n\n Se ha creado el comentario sin texto \n\n");
                        }
                        else{
                                Console.WriteLine ("\n\n NO se ha creado el comentario sin texto \n\n");
                        }
                        nuevocomentario = coment1.CrearComentario ("", "pepe@peo.com");
                        if (nuevocomentario != null) {
                                Console.Write ("\n\n Se ha creado el comentario con texto vacio \n\n");
                        }
                        else{
                                Console.WriteLine ("\n\n NO se ha creado el comentario con texto vacio \n\n");
                        }
                        nuevocomentario = coment1.CrearComentario (" ", "pepe@peo.com");
                        if (nuevocomentario != null) {
                                Console.Write ("\n\n Se ha creado el comentario con espacios en blanco \n\n");
                        }
                        else{
                                Console.WriteLine ("\n\n NO se ha creado el comentario con espacios en blanco \n\n");
                        }
                        nuevocomentario = coment1.CrearComentario ("���^'~~$�", "pepe@peo.com");
                        if (nuevocomentario != null) {
                                Console.Write ("\n\n Se ha creado el comentario con caracteres extra�os \n\n");
                        }
                        else{
                                Console.WriteLine ("\n\n NO se ha creado el comentario con caracteres extra�os \n\n");
                        }
                        nuevocomentario = coment1.CrearComentario ("Estoy haciendo mi primer comentario", "pepe@peo.com");
                        if (nuevocomentario != null) {
                                Console.Write ("\n\n Se ha creado el comentario normal \n\n");
                        }
                        else{
                                Console.WriteLine ("\n\n NO se ha creado el comentario normal \n\n");
                        }
                }

                /* PRUEBAS REPORTAR */
                if (pruebasReportar) {
                        ComentarioCEN coment1 = new ComentarioCEN ();
                        ComentarioEN nuevocomentario = null;
                        nuevocomentario = coment1.CrearComentario ("Comentario sin usuario", "pepe@peo.com");
                        if (nuevocomentario != null) {
                                Console.Write ("\n\n Se ha creado el comentario normal \n\n");
                                Console.Write (nuevocomentario.State);
                        }
                        else{
                                Console.WriteLine ("\n\n NO se ha creado el comentario normal \n\n");
                        }
                        if (coment1.Reportar (nuevocomentario.Id) == true) {
                                Console.Write ("\n\n Se ha reportado el comentario normal \n");
                                Console.Write ("Su nuevo estado es: ");
                                Console.Write (nuevocomentario.State);
                                Console.Write ("\\Deberia ser Reportado");
                        }
                        else{
                                Console.Write ("\n\n ERROR: No se ha podido reportar el comentario \n");
                        }
                        if (coment1.Reportar (nuevocomentario.Id) == true) {
                                Console.Write ("\n\n ERROR: Se ha reportado el comentario normal por segunda vez (ya esta reportado)  \n");
                                Console.Write ("Su nuevo estado es: ");
                                Console.Write (nuevocomentario.State);
                                Console.Write ("\\Deberia ser Reportado");
                        }
                        else{
                                Console.Write ("\n\n No se ha podido reportar el comentario porque ya esta reportado \n");
                        }
                }

                /* PRUEBAS CREAR LUGAR */
                if (pruebasCrearLugar) {
                        LugarCEN lugar1 = new LugarCEN ();
                        // System.Collections.Generic.IList<String> list_fotos = new System.Collections.Generic.List<String>();

                        lugar1.CrearLugar ("Granadella", "Parque natural", "Coordenadas", "Un lugar agradable para los domingueros", "Montepinos", list_fotos);
                        Console.Write ("\n\n Se ha creado lugar Granadella  \n\n");
                        LugarCEN lugar2 = new LugarCEN ();
                        lugar2.CrearLugar ("Lugar2", "Parque natural", "ubicacion", "Oleee domingueros", "Montepinos2", list_fotos);
                        Console.Write ("\n\n Se ha creado lugar Lugar2  \n\n");

                        //TODO COMENTARIO EN ESTAS PRUEBAS SE DEVERA AL CANSANCIO DE LOS COMPONENTES DEL GRUPO EN SU AFAN DE CREAR UNA BUENA PRACTICA, GRACIAS (^_^)
                        System.Collections.Generic.IList<LugarEN> list = null;
                        list = lugar1.BuscarLugarLocalidad ("Montepinos");
                        Console.WriteLine ("LISTA1");
                        Console.WriteLine (list [0]);
                        System.Collections.Generic.IList<LugarEN> list2 = null;
                        list2 = lugar2.BuscarLugarNombre ("Lugar2");
                        Console.WriteLine ("LISTA2");
                        Console.WriteLine (list2 [0]);
                        ActividadCEN acti1 = new ActividadCEN ();
                        LugarCEN lugar3 = new LugarCEN ();
                        System.Collections.Generic.IList<LugarEN> list4 = new System.Collections.Generic.List<LugarEN>();
                        lugar3.CrearLugar ("Pachi", "CAMPO", "UA", "TU SBES", "UA", list_fotos);
                        list4 = lugar3.BuscarLugarLocalidad ("UA");
                        Console.WriteLine ("SE HA CREADO, OSTIA!!!");
                        /* ACTIVIDADES COMO ENUMERATED
                         *  acti1.Nueva (LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ActivitiesEnum.Acampar, "ActividadPrueba", list4);
                         *  System.Collections.Generic.IList<ActividadEN> list3 = null;
                         *  list3 = acti1.BuscarActividad (LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ActivitiesEnum.Acampar);
                         *  Console.WriteLine ("LISTA3");
                         *  Console.WriteLine (list3 [0]);
                         *
                         *
                         */










                        /*
                         *
                         *  LugarCEN lugar3 = new LugarCEN ();
                         *  LugarEN ole = null;
                         *
                         *   ole = lugar3.CrearLugar("Lugar3", "parque", null, "Oleee domingueros", "Montepinos2", "Fotos2");
                         *
                         *    if (ole!= null)
                         *    {
                         *    Console.Write("\n\n Se ha creado el lugar sin ubicacion  \n\n");
                         *    }
                         *    else
                         *   {
                         *    Console.WriteLine("\n\n NO se ha creado el lugar sin ubicacion  \n\n");
                         *    }
                         *
                         *  ole = lugar3.CrearLugar ("Lugar3", "parque", "", "Oleee domingueros", "Montepinos2", "Fotos2");
                         *  if (ole != null) {
                         *          Console.Write ("\n\n Se ha creado el lugar con ubicacion vacia \n\n");
                         *  }
                         *  else{
                         *          Console.WriteLine ("\n\n NO se creado el lugar con ubicacion vacia \n\n");
                         *  }
                         *
                         *  ole = lugar3.CrearLugar ("Lugar4", "parque", " ", "Oleee domingueros", "Montepinos2", "Fotos2");
                         *  if (ole != null) {
                         *          Console.Write ("\n\n Se ha creado un lugar con ubicacion en blanco \n\n");
                         *  }
                         *  else{
                         *          Console.WriteLine ("\n\n NO se ha creado un lugar con ubicacion en blanco  \n\n");
                         *  }
                         *
                         */
                }

                //Pruebas buscarNoValidados
                /*
                 *
                 *         if (pruebaBuscarNoValidados)
                 *         {
                 *             System.Collections.Generic.IList<LugarEN> list = null;
                 *
                 *             list = lugar1.BuscarNoValidados();
                 *            Console.WriteLine(list[0].Nombre);
                 *             Console.WriteLine(list[1].Nombre);
                 *       }*/

                /////////////


                /* PRUEBAS VALIDAR */


                if (pruebasValidar) {
                        LugarCEN lugar1 = new LugarCEN ();
                        LugarEN oledos = new LugarEN ();

                        oledos = lugar1.CrearLugar ("Granadella", "Parque natural", "Coordenadas", "Un lugar agradable para los domingueros", "Montepinos", list_fotos);

                        if (!lugar1.Validar (null)) {
                                Console.WriteLine ("\n NO se ha podido validar el lugar con nombre nulo \n");
                        }
                        else {
                                Console.WriteLine ("\n Se ha podido validar el lugar a pesar de tener nombre nulo \n");
                        }

                        if (!lugar1.Validar ("")) {
                                Console.WriteLine ("\n NO se ha podido validar el lugar con nombre vacio \n");
                        }
                        else {
                                Console.WriteLine ("\n Se ha podido validar el lugar a pesar de tener nombre vacio \n");
                        } if (!lugar1.Validar (" ")) {
                                Console.WriteLine ("\n NO se ha podido validar el lugar con nombre con espacio en blanco \n");
                        }
                        else {
                                Console.WriteLine ("\n Se ha podido validar el lugar a pesar de tener nombre con espacio en blanco \n");
                        }
                        /* EXPLOTAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                         *
                         * if (!lugar1.Validar ("Granalla")) {
                         *          Console.WriteLine ("\n NO se ha podido validar el lugar porque tiene nombre incorrecto \n");
                         *  }
                         *  else {
                         *          Console.WriteLine ("\n Se ha podido validar el lugar a pesar de tener nombre incorrecto \n");
                         *  }
                         *
                         */
                        if (lugar1.Validar ("Granadella")) {
                                Console.WriteLine ("\n Se ha validado correctamente el lugar \n");
                        }
                        else {
                                Console.WriteLine ("\n No se ha podido validar el lugar \n");
                        }


                        LugarCEN lugar2 = new LugarCEN ();
                        lugar2.CrearLugar ("Lugar2", "Parque natural", "ubicacion", "Oleee domingueros", "Montepinos2", list_fotos);

                        System.Collections.Generic.IList<LugarEN> list = null;
                        Console.WriteLine (oledos.Validar);
                        list = lugar1.BuscarNoValidados ();
                        Console.WriteLine (list [0].Validar);

                        Console.WriteLine (list [0].Nombre);
                }

                if (pruebasCrearActividad) {
                        ActividadCEN act = new ActividadCEN ();
                         act.Nueva ("Acampar", "Acampemos por donde pille");
                         act.Nueva ("Senderismo", "Por cualquier lugar");
                }



                /*List<LugaresInteresGenNHibernate.EN.Mediaplayer.MusicTrackEN> musicTracks = new List<LugaresInteresGenNHibernate.EN.Mediaplayer.MusicTrackEN>();
                 * LugaresInteresGenNHibernate.EN.Mediaplayer.UserEN userEN = new LugaresInteresGenNHibernate.EN.Mediaplayer.UserEN();
                 * LugaresInteresGenNHibernate.EN.Mediaplayer.ArtistEN artistEN = new LugaresInteresGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * LugaresInteresGenNHibernate.EN.Mediaplayer.MusicTrackEN musicTrackEN = new LugaresInteresGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * LugaresInteresGenNHibernate.CEN.Mediaplayer.ArtistCEN artistCEN = new LugaresInteresGenNHibernate.CEN.Mediaplayer.ArtistCEN();
                 * LugaresInteresGenNHibernate.CEN.Mediaplayer.UserCEN userCEN = new LugaresInteresGenNHibernate.CEN.Mediaplayer.UserCEN();
                 * LugaresInteresGenNHibernate.CEN.Mediaplayer.MusicTrackCEN musicTrackCEN = new LugaresInteresGenNHibernate.CEN.Mediaplayer.MusicTrackCEN();
                 * LugaresInteresGenNHibernate.CEN.Mediaplayer.PlayListCEN playListCEN = new LugaresInteresGenNHibernate.CEN.Mediaplayer.PlayListCEN();
                 *
                 *              //Add Users
                 * userEN.Email = "user@user.com";
                 * userEN.Name = "user";
                 * userEN.Surname = "userSurname";
                 * userEN.Password = "user";
                 * userCEN.New_(userEN.Name, userEN.Surname, userEN.Email, userEN.Password);
                 *
                 * //Add Music Track1
                 * musicTrackEN.Id = "http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "Beer Beer Beer Beer Beer Beer ..";
                 * musicTrackEN.Name = "Beer Beer Beer";
                 * musicTrackEN.Company = "Company";
                 * musicTrackEN.Cover = "http://www.tomasabraham.com.ar/cajadig/2007/images/nro18-2/beer1.jpg";
                 * musicTrackEN.Price = 20;
                 * musicTrackEN.Rating = 5;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 200;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 * musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Define Album
                 * //LugaresInteresGenNHibernate.CEN.Mediaplayer.AlbumCEN albumCEN = new LugaresInteresGenNHibernate.CEN.Mediaplayer.AlbumCEN();
                 * //albumCEN.New_("Album 1", "This is a Album 1", artists, musicTracks);*/
                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
