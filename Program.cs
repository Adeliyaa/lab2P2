using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2P2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\doo\text1.txt";
            //path which we want to manipulate 
            StreamReader sr = new StreamReader(path);
            //access to path for reading 
            string numbers = sr.ReadLine();
            //variable for reading the file 
            //var numbers = File.ReadAllText(path);
            //int[] numbers1 = numbers.Split(' ').Select(x => int.Parse(x)).ToArray();
            string[] numbers1 = numbers.Split(' ');
            //split the text from file by ' '(spaces) and save it to array 
            int[] numbers2 = new int[numbers1.Length];
            //new array for integer type and length is the same as array numbers

            for (int i = 0; i < numbers1.Length; i++)
            {
                //Console.Write(numbers1[i] + " ");
                numbers2[i] = int.Parse(numbers1[i]); 
                // save each element of array number1 to array number2 as int type
                //Console.Write(numbers2[i] + " ");
            }
            //Console.ReadKey();
            List<int> primeList = new List<int> { };
            //create a list which will contain prime numbers
            foreach (int number in numbers2)
            {
                int count = 0;
                Console.WriteLine(number);
                
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0) //finding all factors of a
                    {
                        count++; // if it is factor, increment the count variable
                    }
                }
                if (count == 2)
                // if the number of factors is equal to 2
                {
                   
                    primeList.Add(number); //add this element to List "primeList"

                }
            }

            string path2 = @"C:\doo\textOut.txt";
            StreamWriter ss = new StreamWriter(path2);
            //access to file in a path for writing the text

            foreach (int list in primeList)
                //iterate each element in a list 
            {
                Console.WriteLine(list); // display each element from the list 
                ss.Write(list);
                //File.WriteAllText(path, list);
            }
            
        }
    }
}
