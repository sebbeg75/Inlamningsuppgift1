using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("> Enter first operator: ");
            string op1 = Console.ReadLine();
             
            Console.Write("> Enter second operator: ");
            string op2 = Console.ReadLine();

            Console.Write("> Enter first term: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("> Enter second term: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("> Enter third term: ");
            double num3 = double.Parse(Console.ReadLine());

            if (op1 == "+" && op2 == "+")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 + num2 + num3}");
            }
            else if (op1 == "+" && op2 == "-")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 + num2 - num3}");
            }
            else if (op1 == "+" && op2 == "*")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 + num2 * num3}");
            }
            else if (op1 == "+" && op2 == "/")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 + num2 / num3}");
            }
            else if (op1 == "-" && op2 == "+")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 - num2 + num3}");
            }
            else if (op1 == "-" && op2 == "-")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 - num2 - num3} = ");
            }
            else if (op1 == "-" && op2 == "*")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 - num2 * num3}");
            }
            else if (op1 == "-" && op2 == "/")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 - num2 / num3}");
            }
            else if (op1 == "*" && op2 == "+")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 * num2 + num3}");
            }
            else if (op1 == "*" && op2 == "-")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 * num2 - num3}");
            }
            else if (op1 == "*" && op2 == "*")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 * num2 * num3}");
            }
            else if (op1 == "*" && op2 == "/")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 * num2 / num3}");
            }
            else if (op1 == "/" && op2 == "+")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 / num2 + num3}");
            }
            else if (op1 == "/" && op2 == "-")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 / num2 - num3}");
            }
            else if (op1 == "/" && op2 == "*")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 / num2 * num3}");
            }
            else if (op1 == "/" && op2 == "/")
            {
                Console.WriteLine($"> Your result is: {num1} {op1} {num2} {op2} {num3} = {num1 / num2 / num3}");
            }
        }
    }
}
