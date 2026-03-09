Dictionary<int, string> ciudades = new Dictionary<int, string>();
string ciudad;
int codigos=0, op;

Console.WriteLine("ingrese una ciudad ");
ciudad = Console.ReadLine();
codigos++;
ciudades.Add(codigos,ciudad);

do

{
    Console.WriteLine("desea ingresar otra ciudad?  \n1. si\n2. no ");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("ingrese una ciudad ");
            ciudad = Console.ReadLine();
            codigos++;
            ciudades.Add(codigos, ciudad);
            break;

        case 2:

            break;

        default:
            Console.WriteLine("error, opcion no valida");
            break;
    }


} while (op != 2);
Console.WriteLine("los codigos de las ciudades son: ");

foreach (var codigo in ciudades)
{
    Console.WriteLine(codigo.Key);
}
Console.WriteLine("las ciudades son: ");
foreach(var cid in ciudades)
{
    Console.WriteLine(cid.Value);
}