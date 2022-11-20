class proceso{
    
    public int variables {get;set;}
    public int aumento {get;set;}
    public void calculo(){
        variables = 3;aumento = 0;
        int total=variables * aumento;
        while (total <= 2997){
        aumento = aumento + 1;
        total = variables * aumento;
        Console.WriteLine (total);
        }
    }
}