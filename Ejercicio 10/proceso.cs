public class proceso{

public void calculo(){
        int A = Convert.ToInt32(Console.ReadLine());
        int contador = 1,factorial=1;
        while (contador <= A){
            factorial = factorial * contador;
            contador = contador + 1;
        }
        Console.WriteLine ("El factorial de "+A+" es: "+factorial);
    }
}