class Program
{
    static void Main()
    {
        //explicit declaration
        int quantity = 5;
        string msg = "Hello world!";
        decimal price = 10.89m; //se escribe m, solo para indicarle al programa que usaremos decimal
        WriteLine($"Qty: {quantity}, Greeting: { msg }, Price: {price:C}"); // se pone C en price por currency para moneda

        //var declaration - inferir tipo de dato
        var greeting = "Hi!";
        decimal percentage = 20.00m;
        WriteLine($"Greeting: {greeting}, Porcentage: { percentage }"); // se pone C en price por currency para moneda
    }
}