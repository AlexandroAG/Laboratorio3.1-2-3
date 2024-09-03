class Circulo 
{ 
    public double CalculoArea( double radio )
    { 
        return Math.PI * Math.Pow(radio,2);  
    }


    class Program
    {
        private static void Main(string[] args)
        {
            Circulo circulo = new Circulo();

            Console.Write("Introduzca el radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = circulo.CalculoArea( radio );

            Console.WriteLine($"El calculo del circulo con radio {radio} es: {area}");

        }
    }
}