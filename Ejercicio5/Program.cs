internal partial class Program
{
    private static void Main(string[] args)
    {
        int contador=0, numero1;
        do{
            contador++;
            Console.WriteLine("Ingrese un numero por favor");
            numero1= int.Parse(Console.ReadLine());
        }while(contador<8);
    }
}