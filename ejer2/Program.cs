Dictionary<int, string> productos = new Dictionary<int, string>();
productos.Add(1, "manzana");
productos.Add(2, "pera");
productos.Add(3, "uvas");

foreach (var item in productos)
{
    Console.WriteLine(item);
}