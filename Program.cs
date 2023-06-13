//agora estamos usando o C#, a biblioteca é diferente
using System;
//o "System.Globalization é uma biblioteca para tudo. É algo mais completo, não precisa destacar tanto no começo do código.
using System.Globalization;
namespace Course
{
    //criando uma classe para que possa ser referida depois
    public class Program
        {
        //aqui está criando a parte principal da programação, destacando os valores de cada coisa.
        public static void Main(string[] args)
        {
            //está colocando os valores utilizando o double, já que é necessário mais espaço, diferente do float que é muito simples para se utilizar 
            double[] medidasX = LerMedidasTriangulo("X");
            double[] medidasY = LerMedidasTriangulo("Y");
            //aqui está criando o array da área utilizando o double também
            double areaX = CalcularAreaTriangulo(medidasX);
            double areaY = CalcularAreaTriangulo(medidasY);
            //Não estamos mais no C++, agora utilizamos o Console.WriteLine para que a mensagem apareça na tela.
            //A mensagem está como double. O "To string´" está convertando para o string, deixando-o mais leve.
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //aqui é o mesmo do c++. O "if" é o "se". Ou seja, se áreaX for maior que áreaY, a resposta será uma. Se não (else), será outra
            if (areaX > areaY)
            {
                //mensagem na tela caso a área X seja realmente maior
                Console.WriteLine("Maior área: X");
            }
            //caso não seja:
            else
            {
                //áreaY maior
                Console.WriteLine("Maior área: Y");
            }
        }
        //aqui é uma parte para decidir o peso das medidas
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            //está criando um novo array, tendo o peso de 3 valores, justo o necessário para calcular o triângulo
            double[] medidas = new double[3];
            //invés de ficar digitando várias vezes o código, só digita uma vez e coloca o "nome triângulo", que é uma resposta variável
            Console.WriteLine("Entre com as medidas dos triângulos " + nomeTriangulo + ":");
            //aqui está mostrando o peso necessário para rodar. No caso, só se utiizará 3 valores para cada triângulo
            for (int i = 0; i < 3; i++)
            {
                medidas [i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //aqui retornará os valores para medidas
            return medidas;
        }
        //aqui está criando uma parte específica para entrar com as medidas, associando com os valores criados antes e a fórmula que aparecerá à seguir
        public static double CalcularAreaTriangulo(double [] medidas)
        {
            //aqui está associando as novas variáveis que serão utilizadas para a fórmula, todas utilizando o double
            double a = medidas[0];
            double b = medidas[1];
            double c = medidas[2];
            //criando a fórmula que será utilizada
            double p = (a + b + c) / 2.0;
            //agora que utilizará meios que o programa em si não reconhece, o Math.Sqrt é colocado para que aí então o programa entenda.
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //retorna o valor pra área
            return area;    
        }
            

    }
}
