Dictionary<int , string>  productos =  new Dictionary<int , string>();

int codigo = 1;
int op = 0;
string producto; 
Console.WriteLine("ingrese un producto "); 
producto =  Console.ReadLine();
productos.Add(codigo, producto);

do
{
    Console.WriteLine("desea ingresar otro producto?\n1. si\n2. no");
    op = int.Parse(Console.ReadLine());
    switch(op)
    {
        case 1:
            Console.WriteLine("ingrese un producto ");
            producto = Console.ReadLine();
            codigo = codigo + 1;

            productos.Add(codigo, producto);

            
            break;
        case 2:
            break;

        default:
            Console.WriteLine("error, opcion no valida");
            break;

    }
}while (op != 2);

