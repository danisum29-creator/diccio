Dictionary<int , string> empleados  = new Dictionary<int , string>();

empleados.Add(1, "raul");
empleados.Add(2, "joselu");
empleados.Add(3, "rodrigo");

empleados[3] = "daniel";

foreach (var item in empleados)
{
    Console.WriteLine(item);
}