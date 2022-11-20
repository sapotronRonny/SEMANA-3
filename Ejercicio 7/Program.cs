internal class Program
{
    private static void Main(string[] args)
    {
        string confirmacion;
        Console.WriteLine("Programa para identificar un tipo de triangulo conociendo sus longitudes");
        proceso proceso1 = new proceso(0,0,0);

        do{
        Console.WriteLine("agrege el longitud lado uno");
        proceso1.lado1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("agrege el longitud lado dos");
        proceso1.lado2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("agrege el longitud lado tres");
        proceso1.lado3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine (proceso1.identificar());
        Console.WriteLine ("Desea continuar, escriba Si o NO");
        confirmacion = Console.ReadLine(); 
        }while(confirmacion == "Si");
        Console.WriteLine ("El programa a terminado");
    }
}