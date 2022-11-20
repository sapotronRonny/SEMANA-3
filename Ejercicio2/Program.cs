internal class Program
{
    private static void Main(string[] args)
    {
        int numero1;
        Console.WriteLine("Ingrese un numero por favor");
        numero1= int.Parse(Console.ReadLine());

        if(numero1%2==0){
            Console.WriteLine("El numero es par");
        }else{
            Console.WriteLine("El numero es impar");
        }
    }
}