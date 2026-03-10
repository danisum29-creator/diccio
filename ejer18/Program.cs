Dictionary<string , string> usuarios = new Dictionary<string , string>();
int op = 0;
string usuario,clave; 
Console.WriteLine("ingrese un nombre de usuario "); 
usuario = Console.ReadLine();
Console.WriteLine("ingrese la clave del usuario");
clave = Console.ReadLine();
usuarios.Add(usuario, clave);

do
{
    Console.WriteLine("desea registrar un nuevo usuario ? \n1. si\n2.no");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("ingrese un nombre de usuario ");
            usuario = Console.ReadLine();
            if (usuarios.ContainsKey(usuario))
            {
                Console.WriteLine("el nombre de usuario ya existe");
            }
            else
            {


                Console.WriteLine("ingrese la clave del usuario");
                clave = Console.ReadLine();
                usuarios.Add(usuario, clave);
            }
            break;

        case 2:
            break;

        default: Console.WriteLine("error, opcion no valida"); break;

    }
} while (op != 2);
