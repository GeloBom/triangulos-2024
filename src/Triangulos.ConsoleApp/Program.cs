namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo mainTriangulo = new Triangulo();

            Console.WriteLine("Digite o primeiro lado do triângulo: ");
            mainTriangulo.primeiroLado = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado do triângulo: ");
            mainTriangulo.segundoLado = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado do triângulo: ");
            mainTriangulo.terceiroLado = Convert.ToDecimal(Console.ReadLine());

            mainTriangulo.ParametrosTriangulo();

            Console.ReadLine();
        }
    }
}