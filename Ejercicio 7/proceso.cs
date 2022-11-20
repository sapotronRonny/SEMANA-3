class proceso:triangulo{
    
    public proceso(int lado1,int lado2,int lado3):base(lado1,lado2,lado3){

    }
    public string identificar(){
       if ((lado1 == lado3) && (lado1==lado2)&&(lado2==lado3)){
           return "es un triangulo equilatero";
       }else{
        if ((lado1==lado2) || (lado1==lado3) || (lado2==lado3)){
            return "es un triangulo isoceles";
        }else{
            return "es un triangulo escaleno";
        }
       }     
}
}