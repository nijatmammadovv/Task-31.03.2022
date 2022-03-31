using System;
using System.Collections.Generic;
using System.Text;

namespace Task_31._03._2022.Models
{
    public class Pdf : IPrintable
    {
        public string FileName { get ; set ; }
        public int PageCount { get; set; }

        public Pdf(string fileName,int pageCount)
        {
            FileName = fileName;
            PageCount = pageCount;
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} created.Page Count : {PageCount}");
        }
    }
}
