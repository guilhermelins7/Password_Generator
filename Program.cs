using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;

namespace Password_Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int passwordSize;
            string password = "";
            string charList = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz@#%&!";

            Console.WriteLine("Informe o tamanho da senha que deve ser gerada:");
            passwordSize = int.Parse(Console.ReadLine());

            for (int i = 0; i < passwordSize; i++)
            {
                int index = random.Next(charList.Length);
                password += charList[index];
            }

            Console.WriteLine(password);
        }
    }
}