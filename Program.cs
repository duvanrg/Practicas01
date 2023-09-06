using System.Collections;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.Clear();
        int idx;
        List<String> Materias = new List<String>();
        Materias.Add("Calculo");
        Materias.Add("Español");
        Materias.Add("Dibujo Tecnico");
        Materias.Add("Ingles");
        ContarLista(Materias);
        // ############################################################
        Console.WriteLine("Ingrese la posicion: ");
        idx = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El elemento en el indice {idx} es:  {ObtenerElemento(idx, Materias)}");
        // ############################################################
        Materias.Add(AddItemData());
        // ############################################################
        Console.WriteLine("Ingrese la palabra a buscar: ");
        if (ValidarItem(Materias, Console.ReadLine())){
            Console.WriteLine("Elemento encontrado");
        }else{
            Console.WriteLine("Elemento no encontrado");
        }
        // ############################################################
        Console.ReadKey();
    }

    public static String AddItemData()
    {
        Console.WriteLine("Ingrese el titulo del elemento: ");
        return Console.ReadLine();        
    }

    public static void ContarLista(List<String> lista)
    {
        Console.WriteLine($"Total de elementos de la lista {lista.Count()}");
    }

    /// <summary>
    /// Metodo para obtener el elemento de una posicion de una lista generica
    /// </summary>
    /// <param name="idx">Indice de la posicion a obtener</param>
    /// <param name="lista">Coleccion generica de los datos</param>
    /// <returns></returns>
    public static String ObtenerElemento(int idx, List<String> lista)
    {
        return lista[idx];
    }

    public static bool ValidarItem(List<String> lista, string valor){
        return lista.Exists(l => l.Equals(valor));
    }
}