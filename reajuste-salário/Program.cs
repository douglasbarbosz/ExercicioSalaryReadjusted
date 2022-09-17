/*
 Faça um algoritmo que calcule e exiba o salário reajustado de três 
funcionários de acordo com a seguinte regra: Salário até 300, reajuste de 50%; 
Salários maiores que 300, reajuste de 30%.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using Salary;

namespace salario_reajuste
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                List<SalaryReadjusted> list = new List<SalaryReadjusted>();

                for (int i = 1; i <= 3; i++) {
                    Console.WriteLine($"Employee #{i}: ");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Salary: ");
                    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new SalaryReadjusted(name, salary));
                }

                Console.WriteLine();
                Console.WriteLine("Readjustment: ");
                foreach (SalaryReadjusted salary in list) {
                    Console.WriteLine($"{salary.Name}: $ {salary.Readjustment().ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}