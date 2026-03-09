Dictionary<int , string> empleados  = new Dictionary<int , string>();
string empleado;
int codigos = 1,op=0;
Console.WriteLine("ingrese el nombre del empleado/a");
empleado = Console.ReadLine();
empleados.Add(codigos, empleado);
codigos++;

do
{
    Console.WriteLine("desea ingresar el nombre de otro empleado? \n1. si\n2. no");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Console.WriteLine("ingrese el nombre del empleado/a");
            empleado = Console.ReadLine();
            empleados.Add(codigos, empleado);
            codigos++;
            break;

        case 2:
           
            break;

        default:
            Console.WriteLine("error, opcion no valida");
            break;
            break;
    }
} while (op != 2);
Console.WriteLine("los empleados son: ");
foreach (var i in empleados)
{
    Console.WriteLine("ID: " +i.Key + "  Nombre: " +i.Value);
}