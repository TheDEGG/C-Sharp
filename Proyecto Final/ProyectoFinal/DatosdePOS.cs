using System;
using System.Collections.Generic;
public class DatosdePOS
{
    public List<Producto> ListadeInventario { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Factura> ListaOrdenes { get; set; }

    public DatosdePOS()
    {
        ListadeInventario = new List<Producto>();
        cargarInventario();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Factura>();
    }

        private void cargarInventario()
        {
            Producto p1 = new Producto(1, "Mouse    ", 250);
            ListadeInventario.Add(p1);

            Producto p2 = new Producto(2, "Teclado  ", 350);
            ListadeInventario.Add(p2);

            Producto p3 = new Producto(3, "Monitor  ", 4000);
            ListadeInventario.Add(p3);
        }

        private void cargarClientes()
        {
            Cliente c1 = new Cliente(1, "Manuel Gutierrez   ", "99-89-08-78");
            ListadeClientes.Add(c1);

            Cliente c2 = new Cliente(2, "Gloria Mejia       ", "93-88-34-21");
            ListadeClientes.Add(c2);

            Cliente c3 = new Cliente(3, "Ramon Juarez       ", "88-89-08-78");
            ListadeClientes.Add(c3);

            Cliente c4 = new Cliente(4, "Krisna Dubon       ", "93-88-34-21");
            ListadeClientes.Add(c4);
        }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Mario Baltazar ", "V00001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Vladimir Putin ", "V00002");
        ListadeVendedores.Add(v2);
        Vendedor v3 = new Vendedor(3, "Mabel Paz      ", "V00003");
        ListadeVendedores.Add(v3);
        Vendedor v4 = new Vendedor(4, "Josue Pequeño   ", "V00004");
        ListadeVendedores.Add(v4);
    }

    public void ListarInventaio()
    {
        Console.Clear();
        Console.WriteLine("===============================================");
        Console.WriteLine("|        *        INVENTARIO       *          |");
        Console.WriteLine("===============================================");
        Console.WriteLine("|                                             |");
        
        foreach (var producto in ListadeInventario)
        {
            Console.WriteLine(producto.Codigo + " )     " + producto.Descripcion + " Lps." + producto.Precio);
        }
        Console.WriteLine("|                                             |");
        Console.WriteLine("===============================================");
        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("=======================================================");
        Console.WriteLine("|             Lista de Clientes Guardados             |");
        Console.WriteLine("=======================================================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " ) " + cliente.Nombre + " Cel. " + cliente.Telefono);
            Console.WriteLine("");
            Console.WriteLine("=======================================================");

        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("=======================================================");
        Console.WriteLine("|                Lista de Vendedores                  |");
        Console.WriteLine("=======================================================");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | Codigo " + vendedor.CodigoVendedor);
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
        }

        Console.ReadLine();
    }

    public void Venta()
    {
        Console.Clear();
        Console.WriteLine("=======================================================");
        Console.WriteLine("|                    FACTURA NUEVA                    |");
        Console.WriteLine("=======================================================");
        Console.WriteLine("=======================================================");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del CLIENTE: ");
        
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);  

        if (cliente == null)
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("              Cliente no encontrado                   ");
            Console.WriteLine("=======================================================");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("              Vendedor no encontrado                   ");
            Console.WriteLine("=======================================================");

            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Factura nuevaOrden = new Factura(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeInventario.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
            Console.WriteLine("=======================================================");
            Console.WriteLine("              Producto no encontrado                   ");
            Console.WriteLine("=======================================================");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
                Console.WriteLine();
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
            
        }
            Console.WriteLine ("Subtotal de orden: " + nuevaOrden.Subtotal);
            Console.WriteLine ("Impuesto de orden: " + nuevaOrden.Impuesto);
            Console.WriteLine ("Total de orden: " + nuevaOrden.Total);
            Console.WriteLine ();
        Console.WriteLine("");
        Console.WriteLine("El total de la orden es de: " + nuevaOrden.Total);
        Console.ReadLine();
    }

    public void ListarFacturas()
    {
        Console.Clear();
        Console.WriteLine("=======================================================");
        Console.WriteLine("|                Lista de Ordenes                     |");
        Console.WriteLine("=======================================================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha ");
        Console.WriteLine("Cliente | Vendedor");
        Console.WriteLine(" Subtotal | Impuesto | Total");
        Console.WriteLine("=======================================================");
        Console.WriteLine("");  

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine("");  
            Console.WriteLine("Codigo  : "+orden.Codigo + "|  Fecha :" + orden.Fecha);
            Console.WriteLine("Cliente : " + orden.Cliente.Nombre + "|  Vendedor: " + orden.Vendedor.Nombre);
            
            
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }
            Console.WriteLine("");  
            Console.WriteLine("Subtotal : Lps. " + orden.Subtotal + " | ISV : Lps. " + orden.Impuesto + " | Total : Lps " + orden.Total);
            Console.WriteLine();
            Console.WriteLine("=======================================================");
        } 

        Console.ReadLine();
    }
}