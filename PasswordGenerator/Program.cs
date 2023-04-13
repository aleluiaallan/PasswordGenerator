using System.Text;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVXYZ".ToLower() +
                "0123456789" +
                "!@#$%¨&*()_-+=,.<>;:?/|~^´`{}ªº[]";

            Console.WriteLine("Quantos digitos sua senha precisa?");
            int digitos = int.Parse(Console.ReadLine());

            Random random = new Random();
            int sorted = 0;
            StringBuilder password = new StringBuilder();
            for(int i = 0; i < digitos; i++)
            {
                sorted=random.Next(0,characters.Length -1);
                password.Append(characters[sorted]);
            }

            Console.WriteLine();
            Console.WriteLine("Senha gerada:");
            Console.WriteLine(password);
            Console.ReadKey();

            
            

        }
    }
}