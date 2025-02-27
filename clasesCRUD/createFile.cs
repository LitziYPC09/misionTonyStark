using System;
using System.IO;

public class createFile
{
    public static void CrearArchivoConDirectorio()
    {
        try
        {
            Console.Write("Ingresa el nombre del archivo a crear (con extensión): ");
            string nombreArchivo = Console.ReadLine();
            string rutaArchivo = Path.Combine(@"D:\Escritorio\Laboratorio Avengers\Inventos", nombreArchivo);
            string directorio = Path.GetDirectoryName(rutaArchivo);

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
                Console.WriteLine("Archivo creado exitosamente.");
            }
            else
            {
                Console.WriteLine("El archivo ya existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear el archivo: {ex.Message}");
        }
    }
}