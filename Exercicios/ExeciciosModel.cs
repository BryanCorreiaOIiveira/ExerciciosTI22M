using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class ExeciciosModel
    {

        //Área de variáveis
        private double area;
        private double IMC;
        //Método Contrutor
        public ExeciciosModel()
        {

            this.area = 0;
            this.IMC = 0;
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

        public double CalculeOTempoDeUmeViagemComBaseNaDistânciaEVelocidade(double tempo)
        {
            if (horas <= 0)
            {
                return -1;
            }
            else
            {
                return horas * 60;
            }
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

    }//fim do classe
}//fim do projeto
