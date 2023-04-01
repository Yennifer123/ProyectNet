using ProyectNet.Controller;
using ProyectNet.Model;
using System;

namespace View
{
    class View
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la maquina dispensadora ParqueSoft");

          ConsumableController controller = new ConsumableController(new Consumable [2] {new Consumable(1,2000,5,"papitas"),new Consumable(2,1000,3,"Choclitos")});
            Console.WriteLine("Es cliente o proveedor?");

            string input_client_type = Console.ReadLine();


            if (input_client_type == "proveedor")
            {
                Console.WriteLine("Los productos en stock son: ");

                foreach (Consumable product in controller.GetProducts())
                {
                    Console.WriteLine("id:" + product.id + " precio: " + product.precio + " cantidad: " + product.cantidad + " Nombre: " + product.nombre);

                }
                Console.WriteLine("Señor proveedor que desea hacer: 1) actualizar stock o 2) adicionar un nuevo producto");

                string input_proveedor = Console.ReadLine();

                if (input_proveedor == "1")
                {
                    Console.WriteLine("por favor ingrese el id del producto actualizar: ");

                    int input_idProduct = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("por favor ingrese la cantidad del producto actualizar: ");

                    int input_CantidadProduct = Convert.ToInt32(Console.ReadLine());

                    controller.ActualizarStock(input_idProduct, input_CantidadProduct);

                   

                }
                else if (input_proveedor == "2")

                {
                    Console.WriteLine("por favor ingrese el id del producto agregar: ");

                    int input_idProductAdd = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("por favor ingrese el precio del producto agregar: ");

                    int input_PrecioProductAdd = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("por favor ingrese la cantidad del producto agregar: ");

                    int input_CantidadProductAdd = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("por favor ingrese la nombre del producto agregar: ");

                    String input_NombreProductAdd = Console.ReadLine();

                    controller.addProduct(new Consumable(input_idProductAdd, input_PrecioProductAdd, input_CantidadProductAdd, input_NombreProductAdd));


                }
            }


            else if (input_client_type == "cliente")
            
                {
                    Console.WriteLine("Señor cliente Los productos para su consumo son: ");

                    foreach (Consumable product in controller.GetProducts())
                    {
                        Console.WriteLine("id:" + product.id + " precio: " + product.precio + " cantidad: " + product.cantidad + " Nombre: " + product.nombre);

                    }
                    Console.WriteLine("Señor usuario ingrese el id correspondiente al producto que desea: ");

                    int input_cliente = Convert.ToInt32(Console.ReadLine());
                             
                    Consumable productElegido = controller.obtenerproduct(input_cliente);

                    Console.WriteLine("El monto a pagar es:  " +productElegido.precio);

                    Console.WriteLine("Digite el monto con que va a pagar: ");

                    int montoIngresado= Convert.ToInt32(Console.ReadLine());

                    controller.venta(input_cliente);

                    String devolucion= controller.CalcularDevolucion(productElegido.precio, montoIngresado);

                    Console.WriteLine("el producto comprado es :"+ productElegido.nombre +" su devolucion en monedas es : "+ devolucion );




            }

            Console.WriteLine("El stock actual es:  ");

            foreach (Consumable product in controller.GetProducts())
            {
                Console.WriteLine("id:" + product.id + " precio: " + product.precio + " cantidad: " + product.cantidad + " Nombre: " + product.nombre);

            }
        }

    }

}
