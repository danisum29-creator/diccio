Dictionary<string, string>usuarios = new Dictionary<string, string>();

string clave,usuario;

bool ver = true;
int op = 0;

Console.WriteLine("ingrese su usuario ");
usuario = Console.ReadLine();
Console.WriteLine("ingrese su clave ");
clave = Console.ReadLine();
usuarios.Add(usuario, clave);

do
{
   
    
    Console.WriteLine("desea ingresar otro usuario ?\n1. si\n2.no");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:

            Console.WriteLine("ingrese su usuario ");
            usuario = Console.ReadLine();
            Console.WriteLine("ingrese su clave ");
            clave = Console.ReadLine();
         
            if (usuarios.ContainsKey(usuario))
            {
                Console.WriteLine("erro, usuario ya registrado");
            }
            else
            {
                usuarios.Add(usuario, clave);

            }

            break;

        case 2:

            break;
        default:
            Console.WriteLine("error , opcion no valida");
            break;
    }
  
}while(op!=2);

Console.WriteLine("ingrese nombre de usuario para mostrar su clavae");
usuario = Console.ReadLine();

if(usuarios.ContainsKey(usuario))
{
    Console.WriteLine("la calve es: ");
    Console.WriteLine(usuarios[usuario]);
}
else
{
    Console.WriteLine("el usuario que busca no existe");
}

