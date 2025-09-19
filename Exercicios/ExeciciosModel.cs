using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class ExeciciosModel
    {

        //Área de variáveis
        private double area;
        private double IMC;
        public int[] vet;
        public string[] nomes;
        public int[ , ] matriz;//Declarar a Matriz - Cria
        public int[,] matriz1;//Declarar a Matriz - Cria
        //Método Contrutor
        public ExeciciosModel()
        {

            this.area = 0;
            this.IMC = 0;
            this.vet = new int[10];
            this.nomes = new string[10];
            //instanciar a matriz
            this.matriz = new int [3, 3] ;//Criando uma Matriz3x3
            this.matriz1 = new int [4, 4] ;//Criando uma Matriz4x4
        }//fim do Contrutor

        //Método GET e SET

        public double ModificarArea
        {
            get { return this.area; }
            set { this.area = value; }
        }//fim do método getset

        public double ModificarIMC
        {
            get { return this.IMC; }
            set { this.IMC = value; }
        }//fim do método getset
        //1. leia um número e exiba seu triplo

        public int Triplo(int num)
        {
            return num * 3;
        }//fim do método

        //2. leia um número e exiba sua metade

        public int Metade(int num)
        {
            return num / 2;
        }//fim do método

        //8. Calcula a área de um losango com base nas diagonais
        //area = (diagonalMaior * diagonalMenor) / 2

        public double AreaLosango(double diagonalMaior, double diagonalMenor)
        {
            //validação
            if (diagonalMaior > 0 && diagonalMenor > 0)
            {
                ModificarArea = (diagonalMaior * diagonalMenor) / 2;
            }
            else
            {
                ModificarArea = -1;//Criando um alerta com um símbolo
            }//fim do if...else
            return ModificarArea;
        }// fim do método

        //9. Calcule o volume de um cilindro a partis do raio e altura.
        //volume = Math.pi * Math.poe(raio,2)* altura

        public double VolumeCilindro(double raio, double altura)
        {
            if (raio > 0 && altura > 0)
            {
                return Math.PI * Math.Pow(raio, 2) * altura;
            }
            else
            {
                return -1;
            }
        }//Fim do método

        //16. Leia a altura e peso de uma pessoa e calcule o IMC
        //se IMC < 18.5 Abaixo do Peso
        //se IMC >= 18.5 e IMC < 24.9 - Peso Normal
        //se IMC >= 24.9 e IMC < 29.9 - sobrepeso
        //se IMC >= 29.9 e IMC < 34.4 - Obesidade Grau I
        //se IMC >= 34.4 e IMC < 39.9 - Obesidade Grau II
        //se IMC >= 39.9 - Obesidade Grau III
        //Devolva o grau

        public string CalcularIMC(double peso, double altura)
        {
            string resultado = " ";//Declaração local
            if (peso >= 0 && altura >= 0)
            {
                //calculei
                ModificarIMC = peso / Math.Pow(altura, 2);
                // Verificando a resposta
                if (ModificarIMC < 18.5)
                {
                    resultado += "- Abaixo do peso";
                }
                else if (ModificarIMC < 24.9)
                {
                    resultado += "- Peso normal";
                }
                else if (ModificarIMC < 29.9)
                {
                    resultado += "- Sobrepeso";
                }
                else if (ModificarIMC < 34.9)
                {
                    resultado += "- Obesidade grau I";
                }
                else if (ModificarIMC < 39.9)
                {
                    resultado += "- Obesidade grau II";
                }
                else
                {
                    resultado += "- Obesidade grau III";
                }//fim do if resutaldo
            }// fim do if
            else
            {
                resultado = "Impossível calcular IMC com peso e/ou altura negativos";
            }
            return resultado;
        }//fim do IMC

        public double ConverteDolarReral(double valordolar, double cotacao)
        {
            if (valordolar <= 0 || cotacao <= 0)
            {
                return -1;
            }
            else
            {
                return valordolar * cotacao;
            }
        } //fim do método

        public double PerimetroQuadrado(double lado)
        {
            if (lado <= 0)
            {
                return -1;
            }
            else
            {
                return lado * 4;
            }
        }//fim do método 

        public double ConveterHorasParaMinutos(double horas)
        {
            if (horas <= 0)
            {
                return -1;
            }
            else
            {
                return horas * 60;
            }
        }//fim do método

        public double LeiaUmNumeroEExibal10Dele(double num)
        {
            return num * 0.10;

        }//fim do método

        public double LeiaUmNumeroEExibal25Dele(double num)
        {
            return num * 0.25;

        }//fim do método

        public double LeiaUmNúmeroEExibaSeuValorAbsoluto(double num)
        {
            if (num <= 0)
            {
                return num * -1;
            }
            else
            {
                return num;
            }
        }//fim do método

        public double ConvertaUmaValorDeQuilômetrosParaMetros(double metros)
        {

            if (metros <= 0)
            {
                return -1;
            }
            else
            {
                return metros * 1000;
            }
        }//fim do método

        public double LeiaUmMúmeroEExibaSuaQuintaPotência(double num)
        {
            return Math.Pow(num, 5);
        }//fim do método

        public double CalcularTempo(double distancia, double velocidade)
        {
            return distancia / velocidade;
        }//fim do método

        public double CalcularConsumo(double km, double litros)
        {
            return km / litros;
        }

        public int CacularFatorial(int num)
        {
            int fatorial = 1;
            for (int i = num; i > 0; i--)
            {
                fatorial *= i;
            }
            return fatorial;
        }//fim do método

        public double CalculeSalario(double valor)
        {
            return 12 * valor;
        }//fim do método

        public double LeiaLog(int num)
        { 
            return Math.Log(num);
        }//fim do método


        public double LeiaSeno(int num)
        {
            return Math.Sin(num);
        }

        public double LeiaCosseno(int num)
        {
            return Math.Cos(num);
        }
        public int ContarLetras(int num)
        {
            int somar = 0;
            //validação
            if (num < 0)
            {
                num = num * -1;
            }

            string nume = "" + num;
            for (int i = 0; i < nume.Length; i++)
            {
                somar += Convert.ToInt32(nume.Substring(i, 1));
            }//fim do for
            return somar;
        }//fim do método

        //Leia 10 números e armazene em um vetor
        public void PreecherVet()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}ª Posição: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }//fim de for
        }//fim de método


        //criar um método para MOSTRAR O VETOR

        //1. Leia 10 números e armazene em um vetor.
        public void MostrarVet()
        {
            for(int i = 0; i < 10;i++)
            {

                Console.WriteLine($"{i + 1}ª posição: {vet[i]}");
            }//fim do método
        }//fim do método

        //2. Leia 10 números e exiba-os na ordem inversa
        public void MostrarInverso()
        {
            for( int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"{i+1}ª Posição: {vet[i]}");
            }//fim do for
        }//fim do método

        //3. Leia 10 números e exibar apenas os pares.
        public void MostrarPares()
        {
            for( int i = 0; i < 10; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.WriteLine(vet[i]);
                }//fim do if
            }//fim do for
        }//fim do método
        
        //4. Leia 10 números e exiba a média.
        public void MostrarMédia()
        {
            double soma = 0;
            for (int i = 0; i < 10; i++) 
            {
                soma += vet[i];   
            }//fim do for
            Console.WriteLine($"Média é: {soma / 10}");
        }//fim do método

        //5. Leia 10 nome e exiba os que começam com "a".
        public void PreencherNomes()
        {
           for (int i = 0;i < 10;i++)
           {
                Console.WriteLine($"{i + 1}ª Posição: ");
                nomes[i] = (Console.ReadLine());
           }//fim do for
        }//fim do método

        public void Buscarnomescomecacoma()
        {
            for (int i = 0;i < 10;i++)
            {
                if(nomes[i].Substring(0,1) == "a")
                {
                    Console.WriteLine(nomes[i]);
                }//fim do if
            }//fim do for
        }//fim do método

        //6. Leia 10 números e conte quantos são maiores que a média.
        public void MostrarMédiaMaiores()
        {
            double soma = 0;
            for(int i = 0;i < 10; i++)
            {
               soma += vet[i];
            }//fim do for
            double media = soma/ 10;
            Console.WriteLine($"média é: {media}");
            int contador = 0;
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] > media)
                {
                    contador++;
                }//fim do if
            }//fim do for
            Console.WriteLine(contador);
        }//fim do método

        //7. leia 10 idades e exiba a maior.

        public void MostrarIdadesMaior()
        {
            int idades = 0;
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] > idades)
                {
                    idades = vet[i];
                }//fim do if
            }//fim do for 
            Console.WriteLine($"o maior elemento é: {idades}");
        }//fim do método

        //8. leia 10 altura e exibar a média.

        public void MostrarAlturarMédia()
        {
            double altura = 0;
            for (int i = 0; i < 10; i++)
            {
                altura += vet[i];
            }//fim do for
            Console.WriteLine($"Média é: {altura / 10}");
        }//Fim do método

        //criar o preenche matriz - método de preencher

        public void PreencherMatriz()
        {
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 2; coluna++)
                {
                    Console.WriteLine($" matriz {linha} {coluna}: ");
                    this.matriz[linha,coluna] = Convert.ToInt32(Console.ReadLine());
                }//Fim do for de coluna
            }//Fim do for de linha
        }//fim do método

        public void MostrarMatriz()
        {
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 2; coluna++)
                {
                    Console.Write($"{matriz[linha, coluna]} ");
                }//Fim da coluna
                Console.WriteLine("");//Pular linha
            }//Fim da linha
        }//fim do método

        public void PreencherZero()
        { 
            for(int linha = 0;linha <= 2; linha++)
            {
                for (int coluna = 0;coluna <= 2; coluna++)
                {
                    if (linha == coluna)
                    {
                        matriz[linha, coluna] = 0;
                    }
                    else
                    {
                        matriz[linha, coluna] = 1;
                    }
                }//Fim do for de coluna
            }//Fim do for de linha
        }//fim do método

        public void SomarMatriz()
        {
            int soma = 0;
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 2; coluna++)
                {

                    soma += matriz[linha, coluna];

                }//Fim do for de coluna
            }//Fim do for linha
            Console.WriteLine($"a soma e {soma}");
        }//Fim do método

        public void MostrarMatriz1()
        {
            for (int linha = 0; linha <= 3; linha++)
            {
                for (int coluna = 0; coluna <= 3; coluna++)
                {
                    Console.WriteLine($"matriz {linha} {coluna}: ");
                    matriz1[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }//Fim do for coluna
                Console.WriteLine("");//Pular Linha
            }//Fim do for linha
        }//Fim do método
        

            public void MediaMatriz()
            { 
                int soma = 0;
                for(int linha = 0;linha <= 3; linha++)
                {
                    for(int coluna = 0;coluna <= 3; coluna++)
                    {
                        soma += matriz1[linha, coluna];  
                    }//Fim do for coluna
                }//Fim do  for linha
                Console.WriteLine($"a Média e = {soma / 16}");
            }//Fim do método

            public void DiagonalPrincipal()
            {
                for (int linha = 0; linha <= 2; linha++)
                {
                    for (int coluna = 0; coluna <= 2; coluna++)
                    {

                        if (linha == coluna)
                        {
                            Console.WriteLine($"Diagonal é: {matriz[linha,coluna]}");
                        }//fim do if
                    }//fim do coluna
                }//fim do linha
            }//fim do método

            public void DiagonalSecundária()
            { 
                for ( int linha = 0; linha <= 2; linha++)
                { 
                    for (int coluna =0; coluna <= 2;coluna++)
                    {
                        if(linha + coluna == 2)
                        {
                            Console.WriteLine($"Diagonal Secundária é: {matriz[linha,coluna]}");
                        }//fim do if
                    }//fim do for coluna
                }//fim do for linha
            }//fim do método

        public void ContaElementos()
        {
            int contar = 0;
            for (int linha = 0; linha <= 3; linha++)
            {
                for (int coluna = 0; coluna <= 3; coluna++)
                {
                    if (matriz1[linha,coluna] > 10)
                    {
                        contar++;
                    }//fim do if
                }//fim do for coluna
            }//fim do for linha
            Console.WriteLine($"Há {contar} números maiores que 10");
        }//fim do método
        
    }//fim do classe
}//fim do projeto