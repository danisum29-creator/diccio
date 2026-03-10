Dictionary<string , string> usuarios = new Dictionary<string , string>();
int op = 0;
string usuario,clave; 
bool registro = false;
Console.WriteLine("ingrese un nombre de usuario "); 
usuario = Console.ReadLine();
Console.WriteLine("ingrese la clave del usuario");
clave = Console.ReadLine();
usuarios.Add(usuario, clave);
registro = true;

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
                registro = true;
            }
            break;

        case 2:
            break;

        default: Console.WriteLine("error, opcion no valida"); break;

    }
} while (op != 2);

Console.WriteLine("usuarios registrados con exito: ");
foreach(var i in usuarios)
{
    Console.WriteLine(i.Key);
}