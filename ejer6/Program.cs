Dictionary<int , string>estudiantes = new Dictionary<int , string>();

estudiantes.Add(1, "daniel");
estudiantes.Add(2, "diana");
estudiantes.Add(3, "bruce");

estudiantes.Remove(3);
foreach ( var item in estudiantes)
{
    Console.WriteLine(item);
}