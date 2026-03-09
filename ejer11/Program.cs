Dictionary<int , string> estudiantes =  new Dictionary<int , string>();

estudiantes.Add(1, "daniel");
estudiantes.Add(2, "danna");
estudiantes.Add(3, "julio");
estudiantes.Add(4, "rosario");
estudiantes.Add(5, "ramiro");

foreach (var item in estudiantes)
{
    Console.WriteLine(item.Key +" " +item.Value);
}