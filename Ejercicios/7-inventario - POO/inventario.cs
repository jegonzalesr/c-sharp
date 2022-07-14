using System;
public class Inventario{

      string[,] productos = new string[5,3]
        {
            {"001","Iphone X",       "0"},
            {"002","Laptop Dell",    "5"},
            {"003","Monitor Samsung","2"},
            {"004","Mouse",          "100"},
            {"005","Headset",        "25"},
           
        };

            public Inventario()
            {
                
        }

          public void listarProductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de productos");
            Console.WriteLine("*********************");
            Console.WriteLine("Codigo , Descripcion , y Existencia");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i , 0] + " | " + productos[i , 1] + " | " + productos[i , 2]); 
            }
             Console.ReadLine();
        }
           
        public void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
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

        public void ingresoDeInventario() {
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

                public void salidaDeInventario() {
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

                public void ajusteDeInventarioPositivo () {
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

                public void ajusteDeInventarioNegativo() {
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



}