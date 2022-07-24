using System;
using System.Collections.Generic;

public class DatosdePrueba{

    public List <Producto>  ListadeProductos { get; set; }

    public List <Cliente>  ListadeClientes { get; set; }

    public List <Vendedor>  ListadeVendedores { get; set; }

    public List <Orden>  ListadeOrdenes { get; set; }

    

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        CargarProductos();

        ListadeClientes = new List<Cliente>();
        CargarClientes();

        ListadeVendedores = new List<Vendedor>();
        CargarVendedores();

        ListadeOrdenes = new List<Orden>();
       
    }

        private void CargarProductos()
        {
            Producto p1 = new Producto(1, "Mouse", 250);
            ListadeProductos.Add(p1);

            Producto p2 = new Producto(2, "Monitor", 350);
            ListadeProductos.Add(p2);

            Producto p3 = new Producto(3, "Teclado", 5000);
            ListadeProductos.Add(p3);
        }


        private void CargarClientes()
        {
            Cliente c1 = new Cliente(1, "Juan", "12345678");
            ListadeClientes.Add(c1);

            Cliente c2 = new Cliente(2, "Pedro", "87654321");
            ListadeClientes.Add(c2);

            
        }

        private void CargarVendedores()
        {
            Vendedor v1 = new Vendedor(1, "Juan", "V001");
            ListadeVendedores.Add(v1);

            Vendedor v2 = new Vendedor(2, "Peter", "V002");
            ListadeVendedores.Add(v2);

        }




    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("=================");
        foreach (Producto p in ListadeProductos)
        {
            Console.WriteLine(p.Codigo + " | " + p.Descripcion + " | " + p.Precio);
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
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }
        
        
        Console.ReadLine();
    }


    public void CrearOrden()
    {
        Console.WriteLine("Creando Orden");
        Console.WriteLine("=================");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
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

        Console.WriteLine("Ingrese el codigo del vendedor: ");
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

        int nuevoCodigo = ListadeOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
         ListadeOrdenes.Add(nuevaOrden);



         while(true)
         {
            Console.WriteLine("Ingrese el codigo del producto:  ");
            string codigoProducto = Console.ReadLine();

               Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);
                    if (producto == null)
                    {
                        Console.WriteLine("Producto no encontrado");
                        return;
                    }
                    else
                    {
                      Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                      nuevaOrden.AgregarProducto(producto);
                    }


            Console.WriteLine("Desea Continuar: s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n"){
                break;
            }
       


         } 
    }

}