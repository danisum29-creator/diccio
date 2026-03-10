Dictionary<string, double> estudiantes = new Dictionary<string, double>();

int opMenu;
double notas; 
string estudiante;
do
{
    Console.WriteLine("1. agregar estudiantes\n2. modificar notas\n3. mostrar notas\n4. salir");
    opMenu = int.Parse(Console.ReadLine());

    switch(opMenu)
    {
        case 1:
            Console.WriteLine("ingrese el nombre del estudiante: "); 
            estudiante = Console.ReadLine();
            Console.WriteLine("ingrese la nota del estudiante");
            notas = double.Parse(Console.ReadLine());
            if(estudiantes.ContainsKey(estudiante))
            {
                Console.WriteLine("el estudiante ya fue ingresado");
            }
            else
            {
                estudiantes.Add(estudiante, notas);
            }
                
            break;

        case 2: 
            if
    }
}