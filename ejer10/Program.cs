Dictionary<int,string>productos = new Dictionary<int,string>();
int codigo = 0; 
productos.Add(1, "pera");
productos.Add(2, "uva");
productos.Add(3, "manzana");
productos.Add(4, "melon");

foreach (var item in productos)
{
    Console.WriteLine(item);
}

Console.WriteLine("ingrese el codigo del producto que desea eliminar ");
codigo = int.Parse(Console.ReadLine());

if(productos.ContainsKey(codigo))
{
    productos.Remove(codigo);
    Console.WriteLine("el inventario actualizado es: ");
foreach(var item in productos)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("el codigo de producto no existe ");
}

