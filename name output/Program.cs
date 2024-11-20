/*
Вывести имя в прямоугольник из символа, который введет сам пользователь. 

От пользователя получаете символ и имя и по этим данным выводите имя в прямоугольнике. 
Длина всех выводимых строк в прямоугольнике одинаковая, а узнать длину всегда можно у второй строки. Длину строки можно всегда узнать через свойство Length 
string someString = “Hello”; 
Console.WriteLine(someString.Length);  //5 

То есть при вводе символа % и имени Alexey получиться, что в каждой строке 8 символов (в консоли длина символа одинаковая)
%%%%%%%%
%Alexey% 
%%%%%%%%
*/
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введитe символ:");
            string inputSymbol = Console.ReadLine();
            char symbol = inputSymbol[0]; 
            string fromCharToString = Convert.ToString(symbol);            
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            string rectangleOfLines = symbol + name + symbol;
            int charLengyh = rectangleOfLines.Length;
            charLengyh = Convert.ToInt32(charLengyh);
            string symbols = new String(symbol, charLengyh);
            Console.WriteLine($"{symbols}\n{rectangleOfLines}\n{symbols}");            
        }   
    }
}