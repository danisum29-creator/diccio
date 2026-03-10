Dictionary<int, (string,int, string)> estudiantes = new Dictionary<int, (string,int, string)>();
int cont = 0, carne, edad ;
string nombre, carrera;
do
{
    Console.WriteLine("ingrese el numero de carnet del estudiante ");
    carne = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el nombre del estudiante");
    nombre = Console.ReadLine();
    Console.WriteLine("ingrese la edad del estudiante: ");
    edad = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese la carrera del estudiante");
    carrera = Console.ReadLine();
    cont++;
} while (cont < 3);


