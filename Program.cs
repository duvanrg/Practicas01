using System.Collections;

internal class Program
{

    private static void Main(string[] args)
    {
        // ArrayList Carnivoros = new ArrayList();
        // ArrayList Acuaticos = new ArrayList();
        // ArrayList Animales = new ArrayList();
        // Carnivoros.Add("Tigre");
        // Carnivoros.Add("Leon");
        // Carnivoros.Add("Pantera");
        // Carnivoros.Add("Leopardo");
        // Acuaticos.Add("Tiburon");
        // Acuaticos.Add("Delfin");
        // Acuaticos.Add("Ballena");
        // Acuaticos.Add("Pulpo");
        // Animales.AddRange(Carnivoros);
        // foreach (Object n in Animales)
        // {
        //     Console.WriteLine(n.ToString());
        // }
        // Console.WriteLine("Presiona Enter para continuar");
        // Console.ReadLine();
        // Console.WriteLine("===================================");

        // Console.Clear();
        // Animales.AddRange(Acuaticos);
        // foreach (Object n in Animales)
        // {
        //     Console.WriteLine(n.ToString());
        // }

        // string? palabra;
        // int idx;
        // ArrayList Materias = new ArrayList();
        // ArrayList Cursos = new ArrayList();

        // Materias.Add("Calculo");
        // Materias.Add("Español");
        // Materias.Add("Dibujo Tecnico");
        // Materias.Add("Ingles");

        // Cursos.Add("Octavo");
        // Cursos.Add("Noveno");

        // Console.Write("Escriba una materia a buscar: ");
        // palabra = Console.ReadLine();
        // Console.WriteLine(Materias.Contains(palabra) ? "La materia esta disponible" : "La materia no se encontro");
        // Console.WriteLine(Materias.IndexOf(palabra));

        // idx = Materias.LastIndexOf(palabra);
        // Console.WriteLine($"La asignatura {palabra} se encontro en la ultima posicion {idx}");


        // do
        // {
        //     Console.Write("Ingrese la posicion donde desea insertar la Asignatura: ");
        //     idx = Convert.ToInt32(Console.ReadLine()); 
        // } while (idx > Materias.Count);
        // Materias.InsertRange(idx, Cursos);

        // Console.Write("Excribe una materia para insertar: ");
        // palabra = Console.ReadLine();
        // Materias.Insert(idx, palabra);

        // foreach (Object n in Materias)
        // {
        //     Console.WriteLine(n.ToString());
        // }


        // ArrayList miArrayList = new ArrayList();
        // miArrayList.Add("Manzana");
        // miArrayList.Add("Banana");
        // miArrayList.Add("Naranja");

        // for (var i = 0; i < 10; i++)
        // {
        //     miArrayList.Add(i);
        // }
        // miArrayList.RemoveAt(1);

        // String[] myArray = (String[])miArrayList.ToArray(typeof(string));

        // foreach (Object n in myArray)
        // {
        //     Console.WriteLine(n);
        // }

        // foreach (Object n in miArrayList)
        // {
        //     Console.WriteLine(n.ToString());
        // }


        ArrayList Materias =  new ArrayList();
        String[] especialidad =  {"Sistemas", "Mecatronica", "Industrial", "Gestion Empresarial", "Energiar Renovables", "Tecnologias de la Informacion"};

        foreach (Object dato in  Materias)
        {
            if(dato.GetType() == typeof(System.String[])){
                foreach (String dato2 in (String[]) dato)
                {
                    Console.WriteLine(dato2);
                    
                }
            }
        }
    }
}