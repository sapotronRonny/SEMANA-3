internal partial class Program
{
    private static void Main(string[] args)
    {
        int numero1, numero2,numero3;
        Console.WriteLine("Ingrese dos numeros por favor");

        Console.WriteLine("Ingrese el primero por favor");
        numero1= int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo por favor");
        numero2= int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercero por favor");
        numero3= int.Parse(Console.ReadLine());

        if(numero1>numero2 && numero1>numero3){
            Console.WriteLine("El numero mayor es: "+numero1);
        }
        if(numero2>numero1 && numero2>numero3){
            Console.WriteLine("El numero mayor es: "+numero2);
        }
        if(numero3>numero1 && numero3>numero2){
            Console.WriteLine("El numero mayor es: "+numero3);
        }
        if(numero1==numero2 && numero1==numero3){
            Console.WriteLine("Los tres numero son iguales");
        }
    }
}