Dictionary<int , string> productos = new Dictionary<int , string>();

productos.Add(1, "computadora");
productos.Add(2, "mouse");
productos.Add(3, "procesador");
productos.Add(4, "memorias");
productos.Add(5, "teclados");

foreach (var product in productos)
{
    Console.WriteLine(product.Key +" " +product.Value);
}