using System;
using System.Text.RegularExpressions;

namespace RegexEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao verificador de e-mail! Digite CTRL + C para parar a aplicação");
            string padraoEmailRegex = @"^(?i)[a-z0-9\._]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$";
            do{
            Console.Write("Digite seu e-mail: ");
            string eMailObter = Console.ReadLine();
            string eMail = eMailObter;
            if(Regex.IsMatch(eMail, padraoEmailRegex))
            {
                System.Console.WriteLine($"Seu e-mail: {eMail} é válido!");
            }
            else
            {
                System.Console.WriteLine($"Seu e-mail: {eMail} não é válido");
            }
            }while (true);

        }
    }
}
