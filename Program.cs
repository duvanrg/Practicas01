internal class Program
{
    private static void Main(string[] args)
    {
        int edad;
        Console.WriteLine("Ingrese su edad");
        try{
            edad = int.Parse(s: Console.ReadLine() ?? "0");
        }catch (Exception ex){
            Console.WriteLine("Error {0}", ex.Message.ToString());
        }
    }
}