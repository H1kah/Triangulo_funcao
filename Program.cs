using System;
using System.Globalization;
//como todo código, todo o arquivo precisa de uma biblioteca para que cada code seja compreendido, já que, sem eles, será apenas palavras sem signigicado nenhum.
namespace Course
//é um recurso que ajuda a organizar e evitar conflitos de nomes em um código
{
    public class Triangulo
    //Aqui está criando uma classe triângulo, sendo a fórmula que vai ser mencionada depois de forma simples.
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        //aqui são as variáveis que vão ser utilizadas para fazer a calculadora
        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            //a grandiosa fórmula, dando um valor para o p
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //já sabendo o que é o p, agora vai calcular a área. Ou seja, primeiro o programa calcula o p e depois a área.
            return area;
        }
    }
    public class Program
        //aqui agora vai criar mais variáveis, sendo a variável X e Y, mostrando ao programa qeu será necessário fazer mais uma conta.
    {

    public static void Main(string[] args)
    //Não é mais int main, e sim, void main. Nessa parte, está criando outro public, citando o peso do comando(string), etc.
    {
        Triangulo x = LerTriangulo("x");
        Triangulo y = LerTriangulo("y");

        //aqui está criando dois triângulos, associando com x e y.

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();
            //aqui está criando mais uma variável, sendo a área X e Y.

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //mensagens, são elas que aparecerão na tela com o resultado
            if (areaX > areaY)
            //If, sendo justamente o que diz "se". Se a área X for maior...
            {
                Console.WriteLine("Maior área: X");
                //...essa será a resposta, Maior área X
            }
            else
            //Se não corresponder o requisito anterior, a resposta será o que está à seguir: Maior área: Y
        {
            Console.WriteLine("Maior área: Y");
        }
    }
    public static Triangulo LerTriangulo(string nomeTriangulo)
    {
            //aqui é o public para a mensagem qeu vai aparecer na tela. Está sendo criada depois de todas as fórmulas e esquemais criados anteriormente
        Triangulo triangulo = new Triangulo();

        Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
        triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //aqui são as questões que vão aparecer. Tudo que for digitado será associado com a, b e c. Para isso, vai precisar digitar o número, apertar enter, digitar o número e assim por diante

            return triangulo;
      }
    }
}
