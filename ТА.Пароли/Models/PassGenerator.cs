using System;

namespace ТА.Пароли.Models
{
    public static class PassGenerator
    {
        private static string _pass = "";
        public static string Pass { get => _pass; private set => _pass = value; }
        private static readonly int _lenghtPass = 8;
        private static readonly string _alphavite = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz11223344556677889900__--!!%%^^**``~~(())==++$$@@";

        public static void GeneratePass()
        {
            Pass = "";
            Random rnd = new Random();
            for (int i = 0; i < _lenghtPass; i++)
            {
                Pass += _alphavite[rnd.Next(_alphavite.Length)];
            }
            Console.WriteLine(Pass);
        }
    }
}
