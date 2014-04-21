using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string searchWord = Console.ReadLine().ToLower();
        string upperSearchWord = searchWord.ToUpper();
        int numberOfParagraphs = int.Parse(Console.ReadLine());
        string[] input   = new string[numberOfParagraphs];
        string[] text = new string[input.Length];
        string[] testArray = new string[numberOfParagraphs];
        int[] numberOfTimesMet = new int[numberOfParagraphs];

        for (int i = 0; i < numberOfParagraphs; i++)
        {
            input[i] = Console.ReadLine().ToLower();
        }
       
        for (int i = 0; i < input.Length; i++)
        {
            text[i] = Regex.Replace(input[i], "[!(),-.;?]", " ");
        }

        for (int i = 0; i < text.Length; i++)
        {
            string[] currentText = text[i].Split(' ');
            for (int j = 0; j < currentText.Length; j++)
            {
                if (currentText[j] == searchWord)
                {
                    currentText[j] = currentText[j].ToUpper();
                }
                testArray[i] += currentText[j] + " ";
            }
        }

        for (int i = 0; i < testArray.Length; i++)
        {
            testArray[i] = testArray[i].TrimEnd();
        }
        
        for (int i = 0; i < numberOfParagraphs; i++)
        {
            for (int j = 0; j < testArray[i].Length - upperSearchWord.Length+1; j++)
            {
                if (testArray[i].Substring(j, upperSearchWord.Length) == upperSearchWord)
                {
                    numberOfTimesMet[i]++;
                }
            }          
        }

        Array.Sort(numberOfTimesMet,testArray);
        Array.Reverse(testArray);       
        
        foreach (var sentence in testArray)
        {
            Console.WriteLine(sentence);
        }
    } 
}