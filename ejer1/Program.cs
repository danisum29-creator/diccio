Dictionary<int, string> estudiantes = new Dictionary<int, string>();
string estudiante;
int cod,cont=0;
do
{
    cont = cont + 1;
    Console.WriteLine("ingrese el nombre de un estudiante ");
    estudiante = Console.ReadLine();
    estudiantes.Add(cont, estudiante);

} while (cont != 3);

foreach(var est in estudiantes)
{
    Console.WriteLine(est); 
}
Console.WriteLine("ingrese id de estudiante a buscar ");
cod = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("el estudiante que busca es: " + estudiantes[cod]);