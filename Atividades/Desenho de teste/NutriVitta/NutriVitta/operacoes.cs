using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriVitta
{
    public static class operacoes
    {
        public static string ClassificacaoIMC(double peso, double altura)
        {
            if (peso <= 0 || altura <= 0)
            {
                return "Peso e/ou altura não podem ser negativos ou ter valor igual a zero.";
            }

            double imc = peso / (altura * altura);
            string classificacao = "";

            if (imc < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                classificacao = "Peso normal";
            }
            else if (imc < 30)
            {
                classificacao = "Sobrepeso";
            }
            else if (imc < 35)
            {
                classificacao = "Obesidade grau I";
            }
            else if (imc < 40)
            {
                classificacao = "Obesidade grau II";
            }
            else if (imc >= 40)
            {
                classificacao = "Obesidade grau III";
            }

            return $"IMC: {imc:0.00} kg/m²\n{classificacao}";
        }

    }
}
