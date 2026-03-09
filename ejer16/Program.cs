Dictionary<int , string> estudiantes = new Dictionary<int , string>();

int op = 0, codigo = 1 ;
string estudiante; 
Console.WriteLine("ingrese el nombre de un estudiante"); 
estudiante = Console.ReadLine();
estudiantes.Add(codigo, estudiante);
codigo++;

do
{
    Console.WriteLine("desea ingresar mas estudiantes ? \n1. SI\n2. NO ");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("ingrese el nombre de un estudiante");
            estudiante = Console.ReadLine();
            estudiantes.Add(codigo, estudiante);
            codigo++;
            break;
        case 2:

            break;

        case 3:
            Console.WriteLine("error, opcion no valida");
            break;
    }
    Console.Clear();
    Console.WriteLine("los estudiantes ingresados son: ");
    foreach(var est in estudiantes)
    {
        Console.WriteLine("id: "+est.Key +" estudiante: " +est.Value);
    }
   
} while (op != 2);

