Dictionary<int, string> inventario = new Dictionary<int, string>();
int codigos = 1, opMenu;
string productos,eliminarproducto;
bool ver = false;
do
{
    Console.WriteLine("seleccione una opcion para el inventario");
    Console.WriteLine("1. agregar producto\n2. eliminar producto\n3. mostrar producto\n4. salir");
    opMenu = int.Parse(Console.ReadLine());

    switch (opMenu)
    {
        case 1:
            Console.WriteLine("ingrese el nombre de un producto");
            productos = Console.ReadLine();
            inventario.Add(codigos, productos);
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


                foreach (var produc in inventario)
                {
                    if (inventario.ContainsValue(eliminarproducto)) ;
                    {
                        inventario.Remove(codigos);
                    }
                }
            }

            break;

        case 3:
           

            break;
    }

} while (opMenu != 4);
