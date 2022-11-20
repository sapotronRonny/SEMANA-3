internal class Program
{
    private static void Main(string[] args)
    {
        int numero1, numero2;
        Console.WriteLine("Ingrese dos numeros por favor");

        Console.WriteLine("Ingrese el primero por favor");
        numero1= int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo por favor");
        numero2= int.Parse(Console.ReadLine());

        if(numero1>numero2){
            Console.WriteLine("El numero "+numero1+" es mayor que "+numero2);
        };
        if(numero1<numero2){
            Console.WriteLine("El numero "+numero2+" es mayor que "+numero1);
        }
        if(numero1==numero2){
            Console.WriteLine("Los dos numeros son iguales");
        }
    }
}