namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pila = new Pila();
            var cola = new Cola();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Usar Pila");
                Console.WriteLine("2. Usar Cola");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    EjecutarEstructura("PILA", pila.Agregar, pila.Eliminar, pila.Imprimir);
                }
                else if (opcion == "2")
                {
                    EjecutarEstructura("COLA", cola.Agregar, cola.Eliminar, cola.Imprimir);
                }
                else if (opcion == "0")
                {
                    Console.WriteLine("Saliendo del programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Presiona Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }// Método genérico que recibe funciones específicas para pila o cola
        static void EjecutarEstructura(string nombre, Action<string> agregar, Action eliminar, Func<string> imprimir)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== {nombre} ===");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Ver elementos");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el dato: ");
                        string dato = Console.ReadLine();
                        agregar(dato);
                        Console.WriteLine("Elemento agregado.");
                        break;
                    case "2":
                        try
                        {
                            eliminar();
                            Console.WriteLine("Elemento eliminado.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("ERROR: " + ex.Message);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Elementos actuales:");
                        Console.WriteLine(imprimir());
                        break;
                    case "0":
                        return; // Volver al menú principal
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}
