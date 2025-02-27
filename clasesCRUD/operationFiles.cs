using System;
using System.IO;

namespace inventosTonyStark.clasesCRUD
{
    public class operationFiles
    {
        public static void menuOperaciones()
        {
            while (true)
            
            {   //menu de opciones para operaciones con archivos
                Console.WriteLine("Operaciones con la clase File:");
                Console.WriteLine("1. Copiar un archivo");
                Console.WriteLine("2. Mover un archivo");
                Console.WriteLine("3. Crear una carpeta");
                Console.WriteLine("4. Verificar si existe un archivo");
                Console.WriteLine("5. Eliminar un archivo");
                Console.WriteLine("6. Listar archivos");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CopiarArchivo();
                        break;
                    case "2":
                        MoverArchivo();
                        break;
                    case "3":
                        CrearCarpeta();
                        break;
                    case "4":
                        VerificarArchivo();
                        break;
                    case "5":
                        EliminarArchivo();
                        break;
                    case "6":
                        ListarArchivos();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        public static void CopiarArchivo()
        {
            string rutaArchivo = @"D:\Escritorio\Laboratorio Avengers\Inventos\inventos.txt";
            string rutaBackup = @"D:\Escritorio\Laboratorio Avengers\Backup\inventos.txt";

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(rutaBackup));
                    File.Copy(rutaArchivo, rutaBackup, true);
                    Console.WriteLine("Archivo copiado con éxito.");
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al copiar el archivo: {ex.Message}");
            }
        }

        public static void MoverArchivo()
        {
            string rutaArchivo = @"D:\Escritorio\Laboratorio Avengers\Inventos\inventos.txt";
            string rutaDestino = @"D:\Escritorio\Laboratorio Avengers\ArchivosClasificados\inventos.txt";

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(rutaDestino));
                    File.Move(rutaArchivo, rutaDestino);
                    Console.WriteLine("Archivo movido con éxito.");
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mover el archivo: {ex.Message}");
            }
        }

        public static void CrearCarpeta()
        {
            string rutaCarpeta = @"D:\Escritorio\Laboratorio Avengers\ProyectosSecretos";

            try
            {
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                    Console.WriteLine("Carpeta creada con éxito.");
                }
                else
                {
                    Console.WriteLine("La carpeta ya existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la carpeta: {ex.Message}");
            }
        }

        public static void VerificarArchivo()
        {
            string rutaArchivo = @"D:\Escritorio\Laboratorio Avengers\Inventos\inventos.txt";

            if (File.Exists(rutaArchivo))
            {
                Console.WriteLine("El archivo existe.");
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
            }
        }

        public static void EliminarArchivo()
        {
            string rutaArchivo = @"D:\Escritorio\Laboratorio Avengers\Inventos\inventos.txt";
            string rutaBackup = @"D:\Escritorio\Laboratorio Avengers\Backup\inventos.txt";

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(rutaBackup));
                    File.Copy(rutaArchivo, rutaBackup, true);
                    File.Delete(rutaArchivo);
                    Console.WriteLine("Archivo eliminado con éxito después de hacer una copia de seguridad.");
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el archivo: {ex.Message}");
            }
        }

        public static void ListarArchivos()
        {
            string rutaCarpeta = @"D:\Escritorio\Laboratorio Avengers";

            try
            {
                if (Directory.Exists(rutaCarpeta))
                {
                    string[] archivos = Directory.GetFiles(rutaCarpeta);
                    Console.WriteLine("Archivos en la carpeta:");
                    foreach (string archivo in archivos)
                    {
                        Console.WriteLine(Path.GetFileName(archivo));
                    }
                }
                else
                {
                    Console.WriteLine("La carpeta no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar los archivos: {ex.Message}");
            }
        }
    }
}