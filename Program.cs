using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso em kg e sua altura em m");
            Console.Write("Digite seu peso: ");
            double peso=Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            double altura=Convert.ToDouble(Console.ReadLine());

            double resultado=peso / (altura * altura);

            Console.Clear();

            if(resultado<17)
            Console.WriteLine($"Seu IMC é {resultado} kg/m². Diagnóstico: Muito abaixo do peso");
            else if(resultado>17 && resultado<18.49)
            Console.WriteLine($"Seu IMC é {resultado} kg/m². Diagnóstico: Abaixo do peso");
            else if(resultado>18.5 && resultado<24.99)
            Console.WriteLine($"Seu IMC é {resultado} kg/m². Diagnóstico: Peso normal");
            else if(resultado>25 && resultado<29.99)
            Console.WriteLine($"Seu IMC é {resultado} kg/m². Diagnóstico: Acima do peso");
            else if(resultado>30 && resultado<34.99)
            Console.WriteLine($"Seu IMC é {resultado} kg/m². Diagnóstico: Obesidade I");
            else if(resultado>35 && resultado<39.99)
            Console.WriteLine($"Seu IMC é {resultado} kg/m². Diagnóstico: Obesidade II (severa)");
            else if(resultado>40)
            Console.WriteLine($"Seu IMC é {resultado} kg/m². Diagnóstico: Obesidade III (mórbida)");

            





            

            




            

        }
    }
}
