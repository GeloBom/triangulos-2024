namespace Triangulos.ConsoleApp
{
    public class Triangulo
        {
            public decimal primeiroLado;
            public decimal segundoLado;
            public decimal terceiroLado;

            public void ParametrosTriangulo()
            {
                if (primeiroLado + segundoLado < terceiroLado ||
                    segundoLado + terceiroLado < primeiroLado ||
                    terceiroLado + primeiroLado < segundoLado)
                    Console.WriteLine("Triangulo invalido, a soma de dois lados não pode ser menor que um numero ");

                else if (primeiroLado == segundoLado &&
                    segundoLado == terceiroLado &&
                    terceiroLado == primeiroLado)
                    Console.WriteLine("Seu triangulo é equilatero");

                else if (primeiroLado == segundoLado && segundoLado != terceiroLado ||
                    segundoLado == terceiroLado && terceiroLado != primeiroLado ||
                    terceiroLado == primeiroLado && primeiroLado != terceiroLado ||
                    primeiroLado == terceiroLado && terceiroLado != segundoLado)
                    Console.WriteLine("Seu triangulo é isóceles");

                else Console.WriteLine("Seu triangulo é escaleno");
            }
        }
    }