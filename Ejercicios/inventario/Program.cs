using System;

namespace inventario
{
    class Program
    {   
        static string[,] productos = new string[5,3]
        {
            {"001","Iphone X",       "0"},
            {"002","Laptop Dell",    "5"},
            {"003","Monitor Samsung","2"},
            {"004","Mouse",          "100"},
            {"005","Headset",        "25"},
           
        };

        static void listarProductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de productos");
            Console.WriteLine("*********************");
            Console.WriteLine("Codigo , Descripcion , y Existencia");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i , 0] + " | " + productos[i , 1] + " | " + productos[i , 2]); 
            }
        }

        static void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
        for (int i = 0; i < 5; i++)
        {
            if (productos[i , 0] == codigo) {
                if (tipoMovimiento == "+") {
                    productos[i , 2] = (Int32.Parse(productos[i , 2]) + cantidad).ToString();
                } else {
                    productos[i , 2] = (Int32.Parse(productos[i , 2]) - cantidad).ToString();
                }
            }
        }
    }

        static void ingresoDeInventario() {
            string codigo = "";
            string cantidad = "";
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Ingreso de Productos al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }

                static void salidaDeInventario() {
                string codigo = "";
                string cantidad ="";
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Salida de Productos del Inventario");
                Console.WriteLine("**********************************");
                Console.WriteLine("Ingrese el codigo del producto: ");
                codigo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese la cantidad del producto a dar salida: ");
                cantidad = Console.ReadLine();
                Console.WriteLine();

                movimientoInventario(codigo, Int32.Parse(cantidad), "-"); 
            }

                static void ajusteDeInventarioPositivo () {
                string codigo = "";
                string cantidad = "";
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Ajuste de Inventario positivo");
                Console.WriteLine("**********************************");
                Console.WriteLine("Consultar el codigo del producto: ");
                codigo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresar la cantidad del producto a ajustar en el inventario: ");
                cantidad = Console.ReadLine();
                Console.WriteLine();

                movimientoInventario(codigo, Int32.Parse(cantidad), "+");
            }

                static void ajusteDeInventarioNegativo() {
                string codigo = "";
                string cantidad = "";
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Ajuste de Inventario Negativo");
                Console.WriteLine("**********************************");
                Console.WriteLine("Consultar el codigo del producto: ");
                codigo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresar la cantidad del producto a ajustar en el inventario: ");
                cantidad = Console.ReadLine();
                Console.WriteLine();

                movimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }


        static void Main(string[] args)
        {
            string opcion = "";
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("**********************");
                Console.WriteLine(""); 
                Console.WriteLine("1 - Productos");
                Console.WriteLine("2 - Ingreso de Inventario");
                Console.WriteLine("3 - Salida de Inventario"); 
                Console.WriteLine("4 - Ajuste positivo de Inventario");
                Console.WriteLine("5 - Ajuste negativo de Inventario");
                Console.WriteLine("0 - Salir"); 
                opcion = Console.ReadLine(); 

                switch (opcion)
                {
                    case "1":{
                        listarProductos();
                        Console.ReadLine();
                        break;
                    }
                        case "2":
                        ingresoDeInventario();
                        break;
                        case "3":
                        salidaDeInventario();
                        break;
                        case "4":
                        ajusteDeInventarioPositivo();
                        break;
                        case "5":
                        ajusteDeInventarioNegativo();
                        break;
                        default:
                        break;
                }

                 if (opcion == "0"){
                    break;
                }
            }
        }

    }    
        
    
}

