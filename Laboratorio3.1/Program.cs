class CalculosMatematicos
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, resultado , suma , resta ;

        Console.Write("Introduce el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el Segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        suma = (primerNumero + segundoNumero);

        resta = (primerNumero - segundoNumero);

        resultado = (suma) * (resta);

        Console.WriteLine("El resultado {0} de la suma y {1} de la resta , su resultado total es {2} : ",suma, resta, resultado);
    }

}