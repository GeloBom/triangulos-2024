namespace Triangulos.ConsoleApp
{
    public class Triangulo
        {
            public decimal LadoX;
            public decimal LadoY;
            public decimal LadoZ;

            public void ParametrosTriangulo()
            {
                if (LadoX + LadoY < LadoZ ||
                    LadoY + LadoZ < LadoX ||
                    LadoZ + LadoX < LadoY)
                    Console.WriteLine("Triangulo invalido, a soma de dois lados não pode ser menor que um numero ");

                else if (LadoX == LadoY &&
                    LadoY == LadoZ &&
                    LadoZ == LadoX)
                    Console.WriteLine("Seu triangulo é equilatero");

                else if (LadoX == LadoY && LadoY != LadoZ ||
                    LadoY == LadoZ && LadoZ != LadoX ||
                    LadoZ == LadoX && LadoX != LadoZ ||
                    LadoX == LadoZ && LadoZ != LadoY)
                    Console.WriteLine("Seu triangulo é isóceles");

                else Console.WriteLine("Seu triangulo é escaleno");
            }
        }
    }