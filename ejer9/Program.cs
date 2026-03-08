Dictionary<string , double>notas =  new Dictionary<string , double>();

string nombre;
int op; 

notas.Add("daniel", 70);
notas.Add("eli ", 75);
notas.Add("rodri", 40);
notas.Add("shirley", 50);
notas.Add("diana", 60);

foreach (var item in notas)
{
    Console.WriteLine(item);
}

Console.WriteLine("ingrese un nombre");
nombre = Console.ReadLine();

if (notas.ContainsKey(nombre))
{
    Console.WriteLine("la nota de: " + nombre + " es: " + notas[nombre]);
}
else
{
    Console.WriteLine("el nombre no existe");
}
    do
    {
        Console.WriteLine("desea ingresar otro nombre?\n1. si\n2. no");
        op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                Console.WriteLine("ingrese un nombre");
                nombre = Console.ReadLine();
            if (notas.ContainsKey(nombre))
            {
                Console.WriteLine("la nota de: " + nombre + " es: " + notas[nombre]);
            }
            else
            {
                Console.WriteLine("el nombre no existe");
            }
            break;
            case 2:

                break;

            default:
                Console.WriteLine("error, opcion no valida");
                break;
        }
    } while (op != 2);

