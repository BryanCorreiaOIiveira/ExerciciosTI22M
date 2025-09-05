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
                              "\n11. Exercício 11" +
                              "\n12. Exercício 12" +
                              "\n13. Exercício 13" +
                              "\n14. Exercício 14" +
                              "\n15. Exercício 15" +
                              "\n16. Exercício 16" +
                              "\n17. Exercício 17" +
                              "\n18. Exercício 18" +
                              "\n19. Exercício 19" +
                              "\n20. Exercício 20" +
                              "\n23. Exercício 23");
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
                        break;
                    case 4:
                        Console.WriteLine("Exercício 04");
                        Console.WriteLine("informe o lado");
                        double lado = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.PerimetroQuadrado(lado);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Impossívelm calcular perímetro negativo!");
                        }
                        else
                        {
                            Console.WriteLine($"0 perímetro é {resultado}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exercício 05");
                        Console.WriteLine("informe o horas Minutos");
                        double horas = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.ConveterHorasParaMinutos(horas);
                        if (resultado == -1)
                        {
                            Console.WriteLine("impossívelm multiplicar por número negativo!");
                        }
                        else
                        {
                            Console.WriteLine($"o resultado é {resultado}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Exercício 06");
                        Console.WriteLine("informe o num 10%");
                        double nume = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.LeiaUmNumeroEExibal10Dele(nume);
                        {
                            Console.WriteLine($"o resultado é {resultado}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Exercício 07");
                        Console.WriteLine("informe o num 25%");
                        nume = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.LeiaUmNumeroEExibal25Dele(nume);
                        {
                            Console.WriteLine($"o resultado é {resultado}");
                        }
                        break;
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
                        Console.WriteLine("leia um número e exiba seu valor absoluto!");
                        nume = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.LeiaUmNúmeroEExibaSeuValorAbsoluto(nume);
                        Console.WriteLine(resultado);
                        break;
                    case 11:
                        Console.WriteLine("Exercícios 11");
                        Console.WriteLine("converta um valor de quilômetros para metros");
                        double metro = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.ConvertaUmaValorDeQuilômetrosParaMetros(metro);
                        Console.WriteLine(resultado);
                        break;
                    case 12:
                        Console.WriteLine("Exercíocios12");
                        Console.WriteLine("informe um número: ");
                        double numero = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.LeiaUmMúmeroEExibaSuaQuintaPotência(numero);
                        Console.WriteLine($"O resultado de {numero} Multiplicado por ele mesmo cinco vezes é: {resultado}");
                        break;
                    case 13:
                        Console.WriteLine("Exercícios 13");
                        Console.WriteLine("Informe a distancia: ");
                        double distancia = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Infome o velocidade: ");
                        double velocidade = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.CalcularTempo(distancia, velocidade);
                        Console.WriteLine($"O resultado de {resultado}");
                        break;
                    case 14:
                        Console.WriteLine("Exercícios 14");
                        Console.WriteLine("Informe km: ");
                        double km = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe litros: ");
                        double litros = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.CalcularConsumo(km, litros);
                        Console.WriteLine($"O resultado de {resultado}");
                        break;
                    case 15:
                        Console.WriteLine("Exercícios 15");
                        Console.WriteLine("informe número: ");
                        int numer = Convert.ToInt32(Console.ReadLine());

                        resultado = modelo.CacularFatorial(numer);
                        Console.WriteLine($"O resultado de {resultado}");
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
                    case 17:
                        Console.WriteLine("Exercício 17");
                        Console.WriteLine("informe o Salario");
                        double valor = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.CalculeSalario(valor);
                        Console.WriteLine($"O Salario e {resultado}");
                        break;
                    case 18:
                        Console.WriteLine("Exercício 18");
                        Console.WriteLine("informe um número");
                        int log = Convert.ToInt32(Console.ReadLine());

                        resultado = modelo.LeiaLog(log);
                        Console.WriteLine($"O logaritmo e {resultado}");
                        break;
                    case 19 :
                        Console.WriteLine("Execicio 19");
                        Console.WriteLine("informe um número");
                        int sin = Convert.ToInt32(Console.ReadLine());

                        resultado = modelo.LeiaSeno(sin);
                        Console.WriteLine($"O seno e {resultado}");
                        break;
                    case 20:
                        Console.WriteLine("Execício 20");
                        Console.WriteLine("informe um número");
                        int cos = Convert.ToInt32(Console.ReadLine());

                        resultado = modelo.LeiaCosseno(cos);
                        Console.WriteLine($"O cosseno e {resultado}");
                        break; 
                    case 21:
                    case 23:
                        Console.WriteLine("Exercícios 23");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        //Mostrar
                        Console.WriteLine($"A soma dos digitos é: {modelo.ContarLetras(num)}");
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha       
            } while (ModificarOpcao != 0);
        }//fim do método
    }//fim da clase 
}//fim do projeto
