Dictionary<int , string> empleados  = new Dictionary<int , string>();
string empleado;
int codigos = 1,op=0;
Console.WriteLine("ingrese el nombre del empleado/a");
empleado = Console.ReadLine();
empleados.Add(codigos, empleado);

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

            break;

        case 2:
            Console.WriteLine("error, opcion no valida");
            break;

        default:
            break;
    }
} while (op != 2); 

