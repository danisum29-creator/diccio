Dictionary<int , string> ciudades = new Dictionary<int , string>();
int cod; 
ciudades.Add(1, "monaco");

ciudades.Add(2, "paris");
ciudades.Add(3, "buenos aires");
ciudades.Add(4, "madrid");
ciudades.Add(5, "rio de Janeiro");

foreach (var ci in ciudades)
{
    Console.WriteLine(ci);
}    
Console.WriteLine("buscar ciudad, ingrese su codigo ");
cod = int.Parse(Console.ReadLine());    

Console.WriteLine(ciudades[cod]);