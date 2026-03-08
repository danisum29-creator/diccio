Dictionary<string, string>usuarios = new Dictionary<string, string>();

string clave,usuario;
int ver = 0; 

do
{
    Console.WriteLine("ingrese su usuario ");
    usuario = Console.ReadLine();
    Console.WriteLine("ingrese su clave ");
    clave = Console.ReadLine();

    usuarios.Add(usuario, clave);
    Console.WriteLine("desea ingresar otro usuario ?\n1. si\n2.no");
    ver = int.Parse(Console.ReadLine());
    if( ver <=0 || ver >=3)
    {
        Console.WriteLine("error");
    }
}while(ver != 2 );

Console.WriteLine("ingrese un usuario");
usuario = Console.ReadLine();
Console.WriteLine(usuarios[usuario]);