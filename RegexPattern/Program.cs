﻿using System;
namespace RegexPattern
{
    class program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            // Console.WriteLine(pattern.validateFirstName("Raj"));

            //Console.WriteLine(pattern.validateLastName("Roy"));

            string a = Console.ReadLine();

            Console.WriteLine(pattern.valiadtaeEmail(a));
        }
    }
}