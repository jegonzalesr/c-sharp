using System;
using System.Collections.Generic;

public class DatosdePrueba{

    public List <Producto>  ListadeProductos { get; set; }

    public List <Cliente>  ListadeClientes { get; set; }

    public List <Vendedor>  ListadeVendedores { get; set; }

    public List <Orden>  ListaOrdenes { get; set; }

        

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        CargarProductos();

        ListadeClientes = new List<Cliente>();
        CargarClientes();

        ListadeVendedores = new List<Vendedor>();
        CargarVendedores();

        ListaOrdenes = new List<Orden>();
       
    }

        private void CargarProductos()
        {
            Producto p1 = new Producto(1, "Mouse  ", 250 );
            ListadeProductos.Add(p1);

            Producto p2 = new Producto(2, "Monitor", 350 );
            ListadeProductos.Add(p2);

            Producto p3 = new Producto(3, "Teclado", 550 );
            ListadeProductos.Add(p3);
        }


        private void CargarClientes()
        {
            Cliente c1 = new Cliente(01, "Juan Guzman",   "12345678");
            ListadeClientes.Add(c1);

            Cliente c2 = new Cliente(02, "Pedro Cardona", "87654321");
            ListadeClientes.Add(c2);

            Cliente c3 = new Cliente(03, "Carlos Rodolfo","87654321");
            ListadeClientes.Add(c3);

            
        }

        private void CargarVendedores()
        {
            Vendedor v1 = new Vendedor(01, "Juan Miguel",      "V001");
            ListadeVendedores.Add(v1);

            Vendedor v2 = new Vendedor(02, "Gustavo Gonzales", "V002");
            ListadeVendedores.Add(v2);

            Vendedor v3 = new Vendedor(03, "Mario Lainez",     "V003");
            ListadeVendedores.Add(v3);

        }




    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("=================");
        foreach (var producto  in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

     public void ListarCliente()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }
        
        Console.ReadLine();
    }

       public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("=================");
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | "+ vendedor.Nombre + " | "+ vendedor.CodigoVendedor);
        }
        
        
        Console.ReadLine();
    }


    public void CrearOrden()
    {
        Console.WriteLine("Creando Orden");
        Console.WriteLine("=================");
        Console.WriteLine("");

        Console.Write("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
            } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.Write("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();        

        Vendedor vendedor = ListadeVendedores.Find(v=> v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null)
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
             } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
         ListaOrdenes.Add(nuevaOrden);



         while(true)
         {
            Console.Write("Ingrese el codigo del producto:  ");
            string codigoProducto = Console.ReadLine();

               Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);
                    if (producto == null)
                    {
                        Console.WriteLine("Producto no encontrado");
                        Console.ReadLine();
                    }
                    else
                    {
                      Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                      Console.WriteLine("");
                      nuevaOrden.AgregarProducto(producto);
                    }


            Console.Write("Desea Continuar s/n : ");
            string continuar = Console.ReadLine();            
            Console.WriteLine("");
            Console.WriteLine("*******************************");
            if (continuar.ToLower() == "n"){
                break;
            }
        }

            Console.WriteLine("");
            Console.WriteLine("El valor total de la orden es : " + nuevaOrden.SubTotal);
            Console.ReadLine();    

    }
                 public void ListarOrdenes()
                 {
                    Console.WriteLine("Lista de Ordenes:");
                    Console.WriteLine("=================");
                    Console.WriteLine("");

                        foreach (var orden in ListaOrdenes)
                        {
                            Console.WriteLine("ID orden: " + orden.Codigo + " || Fecha: " + orden.Fecha + " || " + "Total Orden: " + orden.Total);
                            Console.WriteLine("Cliente : " + orden.Cliente.Nombre +" || Vendedor: " + orden.Vendedor.Nombre);
                            Console.WriteLine("");
                            Console.WriteLine("Descripción: ");

                            foreach (var detalle in orden.ListaOrdenDetalle)
                            {
                                
                                Console.WriteLine("|"+detalle.Producto.Descripcion +  "|"  + detalle.Cantidad + "|" + detalle.Precio+"|");
                                                                         
                            }
                            Console.WriteLine("_________________________________________");
                            Console.WriteLine("Sub-Total: "+ orden.SubTotal);
                            Console.WriteLine(" Impuesto: "+ orden.Isv);
                            Console.WriteLine("    TOTAL: "+ orden.Total);
                            Console.WriteLine("");
                        }

                        Console.ReadLine();
                 } 

}