using System;
using System.IO;

public class readFile
{
    public static void LeerArchivoPorLinea()
   {
        try
        {
            Console.Write("Ingresa el nombre del archivo a leer (con extensión): ");
            string nombreArchivo = Console.ReadLine();
            string rutaArchivo = Path.Combine(@"D:\Escritorio\Laboratorio Avengers\Inventos", nombreArchivo);

            if (File.Exists(rutaArchivo))
            {
                Console.WriteLine("Contenido del archivo:");
                foreach (string linea in File.ReadLines(rutaArchivo))
                {
                    Console.WriteLine(linea);
                    Console.WriteLine("Presione Enter para ver el siguiente invento...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer el archivo: {ex.Message}");
        }
    }

    public static void LeerArchivoCompleto()
    {
        try
        {
            Console.Write("Ingresa el nombre del archivo a leer (con extensión): ");
            string nombreArchivo = Console.ReadLine();
            string rutaArchivo = Path.Combine(@"D:\Escritorio\Laboratorio Avengers\Inventos", nombreArchivo);

            if (File.Exists(rutaArchivo))
            {
                Console.WriteLine("Contenido del archivo:");
                string contenido = File.ReadAllText(rutaArchivo);
                Console.WriteLine(contenido);
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer el archivo: {ex.Message}");
        }
    }

}