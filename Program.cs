﻿namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++) 
            buffer[i] = (char)('a' + random.Next(0, 26));

           


            var password = new string(buffer);

            //Console.Write((char)('a' + random.Next(0, 26)));
            Console.WriteLine(password);

            //Console.WriteLine((int)'a');
        }
    }
}
