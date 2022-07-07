using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HOMEWORK 3
            
            //Q1

            Console.WriteLine("Please enter a string: ");
            string userstring = Console.ReadLine();

            string last2 = userstring.Substring(userstring.Length - 2);
            Console.WriteLine("Last two characters in your entry is:" + last2);

            int length = userstring.Length;
            Console.WriteLine("Your entry has: " + length + " characters");

            string upper = userstring.ToUpper();
            Console.WriteLine("The UPPERCASE value of the string you entered is:" + upper);

            string lower = userstring.ToLower();
            Console.WriteLine("The lowercase value of the string you entered is:" + lower);

            //C# da uppercase lowercase etmenin toplam 3 yolu varmış.
            //ikisini de lowera ya da uppera alıyorsun: if (var1.ToLower() == var2.ToLower())
            //ya da "ordinalignorecase" kullanıyormuşsun. Ne bu bilmiyorum ama iki şekilde geçiyor, "ordinal" ya da "culture" "ignorecase" olarak.
            //bu ordinal ve culture neymiş bir araştırayım.
            if (upper.Equals(lower, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Are they equal? true");

            int ap = userstring.IndexOf("a");
            Console.WriteLine("Index of character 'a' in your entry is:" + ap);

            string newstring;
            string fourth = userstring.Substring(3);
            newstring = userstring.Replace(fourth, "#");
            Console.WriteLine("The forth character is replaced with #:" + newstring);


            string thatsit = ". That's it";

            string concat = userstring + thatsit;
            Console.WriteLine("The strings are concatenated: " + concat);
            int Length1 = concat.Length;
            Console.WriteLine("It's length becomes:" + Length1);

            //Q2

            Console.WriteLine("Please give me a string: ");
            string usergiven = Console.ReadLine();
            Console.WriteLine($"{usergiven} /");

            //Q3

            string deepwords = "Mutlu olmak istiyorsan, bir \"amaca\" bağlan; \n \t 'insanlara' ya da 'eşyalara' değil.";
            Console.WriteLine(deepwords);
            
            //Q4

            Console.WriteLine("Enter 1st integer: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd integer: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 <= 0)
                Console.WriteLine("input can not be a negative number or 0!");
            if (number2 <= 0)
                Console.WriteLine("input can not be a negative number or 0!");
            if (number1 % number2 == 0)
                Console.WriteLine("first number is devisible by second number!");
            if (number1 % number2 != 0)
                Console.WriteLine("second number is not devisible by first number");
            if (number2 % number1 == 0)
                Console.WriteLine("first number is devisible by second number!");
            if (number2 % number1 != 0)
                Console.WriteLine("second number is not devisible by first number");
            if (number1 == number2)
                Console.WriteLine("numbers are equal.");
            if (number1 != number2)
                Console.WriteLine("numbers are not equal.");
            

            //Q5
            
            Console.WriteLine("What is your sentence: ");
            string userstr = Console.ReadLine();
            char char1 = 'a';
            int count = userstr.Count(a => a == char1);
            if (count > 0)
            { 
                count++;
                Console.WriteLine($"Your sentence consists of {count} \"a\" characters ");
            }
            else         
                Console.WriteLine("There is no letter \'a\' in this string");

            char char2 = 'e';
            int count1 = userstr.Count(e => e == char2);
            if (count1 > 0)
            {
                count++;
                Console.WriteLine($"Your sentence consists of {count1} \"e\" characters ");
            }
            else
                Console.WriteLine("There is no letter \'e\' in this string");

            char char3 = 'i';
            int count2 = userstr.Count(i => i == char3);
            if (count2 > 0)
            {
                count++;
                Console.WriteLine($"Your sentence consists of {count2} \"i\" characters ");
            }
            else
                Console.WriteLine("There is no letter \'i\' in this string");

            char char4 = ' ';
            int count3 = userstr.Count(space => space == char4);
            if (count3 > 0)
            {
                count++;
                Console.WriteLine($"Your sentence consists of {count3} \"space\" characters ");
            }
            else
                Console.WriteLine("There is no letter \'space\' in this string");


            /* SORU: NEDEN BU ŞEKİLDE YAZIM SONUÇ VERMİYOR?
            
            Console.WriteLine("What is your sentence: ");
            string userstr = Console.ReadLine();
            int countLetters(char countableLetter)
            {
                int count = 0;
                foreach (char a in userstr)
                {
                    if (countableLetter == a)
                        count++;
                }
                return count;                
            }
            Console.WriteLine();
            


             SORU: "INDEX OF" YALNIZCA HARFIN KACINCI SIRADA OLDUĞUNU VERIYOR, KAÇ TANE O HARF OLDUĞUNU VERMİYOR.
             AŞAĞIDAKİNİ BU SEBEPLE KULLANAMADIM.
            
            Console.WriteLine("What is your sentence: ");
            string userstr = Console.ReadLine();
            int howmanya = userstr.IndexOf("a");
            if (howmanya > 0)
            {
                Console.WriteLine($"Your sentence consists of {howmanya} \"a\" characters ");
                while (howmanya > 0)
                    howmanya++;

            }
            else
                Console.WriteLine("There is no letter \'a\' in this string");

            int howmanye = userstr.IndexOf("e");
            if (howmanye > 0)
            {
                Console.WriteLine($"Your sentence consists of {howmanye} \"e\" characters.");
                while (howmanye > 0)
                    howmanye++;
            }
            else
                Console.WriteLine("There is no letter \'e\' in this string");

            int howmanyi = userstr.IndexOf("i");
            if (howmanyi > 0)
            {
                Console.WriteLine($"Your sentence consists of {howmanyi} \"i\" characters.");
                while (howmanyi > 0)
                    howmanyi++;
            }
            else
                Console.WriteLine("There is no letter \'i\' in this string");

            int howmanyspace = userstr.IndexOf(" ");
            if (howmanyspace > 0)
            { 
                Console.WriteLine($"Your sentence consists of {howmanyspace} \"space\" characters.");
                while (howmanyspace > 0)
                howmanyspace++;
            }
            else
                Console.WriteLine("There is no letter \'space\' in this string");
            
             konuyla alakasız ama:
            "=>" NE DEMEK? (lambda?)
            Func cube = x => x * x * x;
            Console.WriteLine(x); 
            olmuyor?
            */

            
            
            //Q6 -> neyi yanlış yaptığımı anlayamadım

            Console.WriteLine("Enter a positive number: ");
            int usernumber = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            while (n % 2 == 1 & usernumber >= n)
            {
                Console.WriteLine((usernumber * (usernumber + 1)) / 2);
                n++;
            }
            if (usernumber <= 0)
                Console.WriteLine("Number is not valid.Please reenter: ");
                return;
            
            //Console.ReadKey(); ne demek ve console.readline'dan ne farkı var?

            //Q7
            
            Console.WriteLine("Please enter the length of array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter 5 different Strings: ");
            string[] arraynames = new string[size];
            int count = 1;
            for (int item = 0; item < size; item++)
                {
                    arraynames[item] = Console.ReadLine();
                    count++;
                }
            Console.Write("The Original Array is:[");
            arraynames.ToList().ForEach(item => Console.Write($" {item} "));
            Console.Write("] ");
            Console.WriteLine("The largest item is " + arraynames.Max());
            //virgül koyamıyorum itemlarına rasına HELP please!


        }
    }
}
