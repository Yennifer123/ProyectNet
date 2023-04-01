using ProyectNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectNet.Controller
{
    public class ConsumableController
    {
       public Consumable[] products { get; set; }
       public ConsumableController (Consumable[] products)
        {
            this.products = products;
        }

       public Consumable[] GetProducts()
        {
            return this.products;

        }

        public void ActualizarStock(int id, int cantidadnueva)

        {
            bool productfueActualizado = false;
            foreach (Consumable product in this.products)
                
            { 
                if(product.id == id)
                {
                    product.cantidad = cantidadnueva + product.cantidad;
                    productfueActualizado = true;
                }
                    
                       
            }
            if(productfueActualizado==false)
            {
                Console.WriteLine("El id no es valido ");
            }        

        }

        public void addProduct(Consumable product)

        {
            int nuevoNumeroProducts = this.products.Length+1;
            Consumable[] nuevosProducts = new Consumable[nuevoNumeroProducts];

            int indice = 0;
            foreach (Consumable productoAnterior in this.products)
            {
                nuevosProducts[indice] = productoAnterior;
                indice++;
            }
            nuevosProducts[indice] = product;
            this.products = nuevosProducts;    

        }

        public void venta(int id )

        {
            bool productfueVendido = false;
            
            foreach (Consumable product in this.products)

            {
                if (product.id == id && product.cantidad > 0)
                {
                    product.cantidad =  product.cantidad-1;
                    productfueVendido = true;
                }
                else if (product.cantidad==0)
                {
                    Console.WriteLine("El producto no se encuentra disponible");
                }

            }
            if (productfueVendido == false)
            {
                Console.WriteLine("El id seleccionado no existe ");
            }

        }

        public Consumable obtenerproduct(int id)
        {
            bool producExist = false;
            
            foreach (Consumable product in this.products)

            {
                if (product.id == id)
                {
                    return product;
                  
                }
            }
            return null;

        }

        public string CalcularDevolucion(int precio, int montoIngresado)
        {
            String devolucion ="";
            int devolucionMonto = montoIngresado - precio;
            while (devolucionMonto > 0)
            {
                if (devolucionMonto % 500 ==0 )
                {
                    devolucion = devolucion + " 500 ";
                    devolucionMonto = devolucionMonto - 500;
                }
                else if (devolucionMonto % 200 == 0)
                {
                    devolucion = devolucion + " 200 ";
                    devolucionMonto = devolucionMonto - 200;
                }
                else if (devolucionMonto % 100 == 0)
                {
                    devolucion = devolucion + " 100 ";
                    devolucionMonto = devolucionMonto - 100;
                }
            }
            return devolucion;

        }



    }
}
