using System;
using System.IO;

namespace inventosTonyStark.clasesCRUD
{
    public class addInvet
    {
        public static void AgregarInvento()
        {
            Console.WriteLine("Ingrese el nombre del invento:");
            string nombre = Console.ReadLine();

            string rutaArchivo = @"D:\Escritorio\Laboratorio Avengers\Inventos\inventos.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    sw.WriteLine(nombre);
                }
                Console.WriteLine($"Invento agregado con éxito: {nombre}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el invento: {ex.Message}");
            }
        }
    }
}