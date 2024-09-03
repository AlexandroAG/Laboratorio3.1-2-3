class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Introduce la altura del rectangulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce la base del Rectangulo: ");
        double bas3 = Convert.ToDouble(Console.ReadLine());

        double perimetro = 2 * (altura + bas3);

        Console.WriteLine($"La suma del perimetro {altura} para la altura y {bas3} para la base su resultado es:{perimetro} ");

    }

}