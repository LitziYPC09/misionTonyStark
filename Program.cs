using System;
using System.IO;
using inventosTonyStark.clasesCRUD;
class program
{
    static void Main()
    {
        while (true)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();
            ProcesarOpcion(opcion);
        }
    }

    // Muestra el menú de opciones al usuario
    static void MostrarMenu()
    {
        Console.WriteLine("\n¿Qué acción deseas realizar?");
        Console.WriteLine("1. Crear archivo");
        Console.WriteLine("2. Agregar Invento");
        Console.WriteLine("3. Leer archivo (Linea por Linea)");
        Console.WriteLine("4. Leer archivo (Completo)");
        Console.WriteLine("5. Operaciones archivo");
        
        Console.WriteLine("6. Salir");
        Console.Write("Selecciona una opción: ");
    } 

    // Procesa la opción seleccionada por el usuario
    static void ProcesarOpcion(string opcion)
    {
        switch (opcion)
        {
            case "1":
                createFile.CrearArchivoConDirectorio();
                break;
            case "2":
                addInvet.AgregarInvento();
                break;
            case "3":
                readFile.LeerArchivoPorLinea();
                break;
            case "4":
                readFile.LeerArchivoCompleto();
                break;
            case "5":
                operationFiles.menuOperaciones();
                break;
            case "6":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}