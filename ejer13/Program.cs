Dictionary<string, double> notas = new Dictionary<string, double>();
double suma = 0, promedio = 0;
int contnotas = 0; 
notas.Add("fisica 3", 80);
notas.Add("programacion 3", 76);
notas.Add("circuitos electricos ", 67);
notas.Add("matematicas", 93);
notas.Add("proceso economico 1 ", 81);
notas.Add("matematica 4", 76);
foreach(var i in notas)
{
    Console.WriteLine(i);
}

foreach (var item in notas)
{
   suma = suma+item.Value;
    contnotas++;
}

promedio = suma/contnotas; 
Console.WriteLine("el promedio de las notas es: " +promedio);
