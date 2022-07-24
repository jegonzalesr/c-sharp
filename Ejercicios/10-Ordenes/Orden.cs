using System;
using System.Collections.Generic;
public class Orden

{
    public int Codigo { get; set; }

    public DateTime Fecha { get; set; }

    public string NumerodeOrden { get; set; }

    public Cliente Cliente { get; set; }

    public Vendedor Vendedor { get; set; }

    public List<OrdenDetalle> ListaOrdenDetalle{ get; set; }


    public Orden(int codigo, DateTime fecha, string numerodeOrden, Cliente cliente, Vendedor vendedor)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrden = numerodeOrden;
        Cliente = cliente;
        Vendedor = vendedor;
    }
    
    public void AgregarProducto(Producto producto)
    {
        int nuevoCodigo = ListaOrdenDetalle.Count + 1;
        OrdenDetalle ordenDetalle = new OrdenDetalle(1, 1 , producto);
        ListaOrdenDetalle.Add(producto);
    }
       






}