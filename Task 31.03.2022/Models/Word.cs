using System;
using System.Collections.Generic;
using System.Text;

namespace Task_31._03._2022.Models
{
    public class Word : IPrintable
    {
        public string FileName { get; set ; }
        public int WordCount { get; set; }

        public Word(string fileName,int wordCount)
        {
            FileName = fileName;
            WordCount = wordCount;
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} is created.Word count : {WordCount}");
        }
    }
}
