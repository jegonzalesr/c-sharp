using System;
using System.Collections.Generic;
public class Inventario{

    //   string[,] productos = new string[5,3]
    //     {
    //         {"001","Iphone X",       "0"},
    //         {"002","Laptop Dell",    "5"},
    //         {"003","Monitor Samsung","2"},
    //         {"004","Mouse",          "100"},
    //         {"005","Headset",        "25"},
           
    //     };

    public List<Producto> ListadeProductos { get; set; }

            public Inventario()
            {
                ListadeProductos = new List<Producto>();

                Producto a = new Producto ("001", "iphoneX", 0);
                Producto b = new Producto ("002", "Laptop Dell", 5);
                Producto c = new Producto ("003", "Monitor Samsung", 2);
                Producto d = new Producto ("004", "Mouse", 100);
                Producto e = new Producto ("005", "Headset", 25);

                ListadeProductos.Add(a);
                ListadeProductos.Add(b);
                ListadeProductos.Add(c);
                ListadeProductos.Add(d);
                ListadeProductos.Add(e);
            }

          public void listarProductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de productos");
            Console.WriteLine("*********************");
            Console.WriteLine("Codigo , Descripcion , y Existencia");

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(productos[i , 0] + " | " + productos[i , 1] + " | " + productos[i , 2]); 
            // }
            foreach (var producto in ListadeProductos)
            {
                Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia.ToString());
            }
             Console.ReadLine();
        }
        
           
        public void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
    

       foreach (var producto in ListadeProductos)
       {
            if (producto.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    producto.Existencia = producto.Existencia + cantidad;
                } else {
                    producto.Existencia = producto.Existencia - cantidad;
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