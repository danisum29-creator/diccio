using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

Dictionary<int, string> inventario = new Dictionary<int, string>();
int codigos = 1, opMenu;
string productos,eliminarproducto;
bool ver = false, eliminado;
do
{
   

Console.WriteLine("seleccione una opcion para el inventario");
    Console.WriteLine("1. agregar producto\n2. eliminar producto\n3. mostrar producto\n4. salir");
    opMenu = int.Parse(Console.ReadLine());

    switch (opMenu)
    {
        
        case 1:

            Console.Clear();


            Console.WriteLine("ingrese el nombre de un producto");
            productos = Console.ReadLine();
            inventario.Add(codigos, productos);
            codigos++;
            ver = true;
            break;

        case 2:
            if (ver == false)
            {
                Console.WriteLine("no se ha registrado ningun producto");

            }
            else
            {
                Console.WriteLine("escriba el nombre del producto a eliminar");
                eliminarproducto = Console.ReadLine();

               foreach(var prod in inventario)
                {
                    if(prod.Value==eliminarproducto)
                    {
                        inventario.Remove(prod.Key); 
                       
                    }
                }
              
                 
                
            }

            break;

        case 3:
           
            if (ver == false || inventario.Count==0)
            {
                Console.WriteLine("inventario vacio ");
            }
            else
            {
                Console.WriteLine("el inventario de productos es: ");
                foreach(var produc in inventario)
                {
                    Console.WriteLine(produc.Key +" " + produc.Value);
                }
            }
                break;
    }

} while (opMenu != 4);
