internal partial class Program
{
    private static void Main(string[] args)
    {
        int numero1;
        do{
        Console.WriteLine("Ingrese un numero por favor(el programa terminara si el numero ingresado es 0)");
        numero1= int.Parse(Console.ReadLine());
        }while(numero1!=0);
        
    }
}