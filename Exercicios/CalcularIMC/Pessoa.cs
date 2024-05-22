using System;
namespace CalcularIMC
{
    class Pessoa
    {
        public double altura , peso;
       
        // método para IMC
        public double IMC()
        {
            return peso / (altura * altura);
        }

        // retorna o IMC
        public string coeficienteIMC()
        {
            if (IMC() < 18.5)
            {
                return "Abaixo do peso";
            }else
            if (IMC() < 25)
            {
                return "peso normal";
            }else
            if(IMC() < 30)
            {
                return "acima do peso";
            }else
            if(IMC() < 35)
            {
                return "obesidade I";
            }else
            if (IMC() < 40)
            {
                return "obesidade II";
            }else
            {
                return "obesidade III";
            }
        }

        // escreve em tela o resultado
        public void resultado()
        {
            Console.WriteLine("de acordo com seu IMC você está: " + coeficienteIMC());
        }
    }


}