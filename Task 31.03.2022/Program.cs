using System;
using Task_31._03._2022.Models;

namespace Task_31._03._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pdf pdf = new Pdf("Pdf", 100);
            Word word = new Word("Word", 150);
            Excel excel = new Excel("Excel", 75, 15);

            
            PrintFile<Word> word1 = new PrintFile<Word>();
            PrintFile<Pdf> pdf1 = new PrintFile<Pdf>();
            PrintFile<Excel> excel1 = new PrintFile<Excel>();

            word1.Print(word);
            Console.WriteLine("--------------------------");
            pdf1.Print(pdf);
            Console.WriteLine("--------------------------");
            excel1.Print(excel);
            

        }
    }
}
