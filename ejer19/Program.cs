Dictionary<string, double> estudiantes = new Dictionary<string, double>();

int opMenu;
double notas, modnota; 
string estudiante,modest;
do
{
    Console.WriteLine("1. agregar estudiantes\n2. modificar notas\n3. mostrar notas\n4. salir");
    opMenu = int.Parse(Console.ReadLine());

    switch (opMenu)
    {
        case 1:
            Console.WriteLine("ingrese el nombre del estudiante: ");
            estudiante = Console.ReadLine();
            Console.WriteLine("ingrese la nota del estudiante");
            notas = double.Parse(Console.ReadLine());
            if (estudiantes.ContainsKey(estudiante))
            {
                Console.WriteLine("el estudiante ya fue ingresado");
            }
            else
            {
                estudiantes.Add(estudiante, notas);
            }

            break;

        case 2:

            if (estudiantes.Count == 0)
            {
                Console.WriteLine("no se han registrado estudiantes");
            }
            else
            {
                Console.WriteLine("ingrese el nombre del estudiante al que desea modificar la nota");
                modest = Console.ReadLine();
                if (estudiantes.ContainsKey(modest))
                {
                    Console.WriteLine("ingrese la nueva nota del estudiante");
                    modnota = double.Parse(Console.ReadLine());
                    estudiantes[modest] = modnota;
                }

            }
            break;

        case 3:

            if (estudiantes.Count == 0)
            {
                Console.WriteLine("no hay estudiantes registrados");
            }
            else
            {


                Console.WriteLine("las notas son: ");
                foreach (var est in estudiantes )
                {
                    Console.WriteLine(est.Key + " = " + est.Value);
                }
                    }
            break;

        case 4:
            break;

        default:
            Console.WriteLine("error, opcion no valida");
            break;
    }


} while (opMenu != 4);