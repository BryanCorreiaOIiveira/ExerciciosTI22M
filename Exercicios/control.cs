using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Control
    {
        private int opcao;
        public ExeciciosModel modelo;
        public Control()
        {
            this.opcao = 0;
            modelo = new ExeciciosModel();
        }//fim do método

        public int ModificarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//fim do modificaropcao

        public void MostrarMenu()
        {
            Console.WriteLine("\nMenu" +
                              "\n0. sair" +
                              "\n1. Exercício 1" +
                              "\n2. Exercício 2" +
                              "\n3. Exercício 3" +
                              "\n4. Exercício 4" +
                              "\n5. Exercício 5" +
                              "\n6. Exercício 6" +
                              "\n7. Exercício 7" +
                              "\n8. Exercício 8" +
                              "\n9. Exercício 9" +
                              "\n10. Exercício 10" +
                              "\n16. Exercício 16");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do método MostrarMenu

        public void ExecutarMenu()
        {
            do
            {


                //Chamar o Menu
                MostrarMenu();
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("obrigado");
                        break;
                    case 1:
                        Console.WriteLine("Exercício 01");
                        Console.WriteLine("Isforme um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Chamar a ExercícioModel
                        Console.WriteLine(modelo.Triplo(num));
                        break;
                    case 2:
                        Console.WriteLine("Exercício 02");
                        Console.WriteLine("Isforme um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.Metade(num));
                        break;
                    case 3:
                        Console.WriteLine("exercicio 03");
                        Console.WriteLine("informe o valor em vdólar: ");
                        double dolar = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("informe a cotação do dia : ");
                        double cotacao = Convert.ToDouble(Console.ReadLine());
                        //Operação
                        double resultado = modelo.ConverteDolarReral(dolar, cotacao);
                        if (resultado == -1)
                        {
                            Console.WriteLine("valores informandos não são válidos, digite novamente!");
                        }
                        else
                        {
                            Console.WriteLine($"0 valor U${dolar} em real é R$ {resultado}");
                        }
                        break ; 
                    case 4:
                        Console.WriteLine("Exercício 04");
                        Console.WriteLine("informe o lado");
                        double lado = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.PerimetroQuadrado(lado);
                        if(resultado == -1)
                        {
                            Console.WriteLine("Impossívelm calcular perímetro negativo!");
                        }
                        else
                        {
                            Console.WriteLine($"0 perímetro é {resultado}");
                        }
                        break ;
                    case 5:
                        Console.WriteLine("Exercício 05");
                        Console.WriteLine("informe o horas Minutos");
                        double horas = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.ConveterHorasParaMinutos(horas);
                        if(resultado == -1) 
                        {
                            Console.WriteLine("impossívelm multiplicar por número negativo!");
                        }
                        else
                        {
                            Console.WriteLine($"o resultado é {resultado}");
                        }
                        break ;
                    case 6:
                        Console.WriteLine("Exercício 06");
                        Console.WriteLine("informe o num 10%");
                        double nume = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.LeiaUmNumeroEExibal10Dele(nume);
                        {
                            Console.WriteLine($"o resultado é {resultado}");
                        }
                        break ;
                    case 7:
                        Console.WriteLine("Exercício 07");
                        Console.WriteLine("informe o num 25%");
                        nume = Convert.ToDouble(Console.ReadLine()) ;

                        resultado = modelo.LeiaUmNumeroEExibal25Dele(nume);
                        {
                            Console.WriteLine($"o resultado é {resultado}");
                        }
                        break ;
                    case 8:
                        Console.WriteLine("Exercício 08");
                        Console.WriteLine("Informe a diagonal maior");
                        double diagonalMaior = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a diagonal menor");
                        double diagonalMenor = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado
                        if (modelo.AreaLosango(diagonalMaior, diagonalMenor) == -1)
                        {
                            Console.WriteLine("os números digitados não são válidos!");
                        }
                        else
                        {
                            Console.WriteLine($"A área do losango é : {modelo.AreaLosango(diagonalMaior, diagonalMenor)}");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Exercícios 09");
                        Console.WriteLine("informe o valor do raio: ");
                        double raio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("informe o valor do altura: ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        //Mostrar
                        if (modelo.VolumeCilindro(raio, altura) == -1)
                        {
                            Console.WriteLine("Os número digitados não são válido!");
                        }
                        else
                        {
                            Console.WriteLine($"O volume do cilindro é: {modelo.VolumeCilindro(raio, altura)}");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Exercícios 10");
                        Console.WriteLine("informe leia um número e exiba seu valor absoluto!");
                        nume = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.LeiaUmNúmeroEExibaSeuValorAbsoluto(nume);
                        Console.WriteLine(resultado);
                        break;

                    case 16:
                        Console.WriteLine("Exercícios 16");
                        Console.WriteLine("informe o seu peso: ");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("informe sua altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        //Mostrar
                        Console.WriteLine(modelo.CalcularIMC(peso, altura));
                        break;
                    default:
                        Console.WriteLine("opção escolhida não é válido");
                        break;

                }//fim do escolha       
            } while (ModificarOpcao != 0);
        }//fim do método
    }//fim da clase 
}//fim do projeto
