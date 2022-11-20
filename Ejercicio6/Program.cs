internal partial class Program
{
    private static void Main(string[] args)
    {
        int contador=0, numero1, total=0;
        do{

            Console.WriteLine("Ingrese un numero por favor (Si ingresa un 0, programa terminara)");
            numero1= int.Parse(Console.ReadLine());
            total=total+numero1;

        }while(contador!=numero1);
        Console.WriteLine("El resultado de la suma es: "+total);
    }
}