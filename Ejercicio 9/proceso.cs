public class proceso{


    public void calculo(){
        int a=0,b=0;
        int contador = 1;
        double calculototal = 0;
        while (contador <= 5){
        contador = contador + 1;
        Console.WriteLine ("Agrege dos variables");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        double calculo = a * b;Console.WriteLine (calculo);
        calculototal = calculototal + calculo;
        }
        double promedio = calculototal / 5;
        Console.WriteLine ("El promedio de dichos resultados es: "+promedio);
    }
    
}