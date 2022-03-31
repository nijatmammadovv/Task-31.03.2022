using System;
using System.Collections.Generic;
using System.Text;

namespace Task_31._03._2022.Models
{
    public class Excel : IPrintable
    {
        public string FileName { get ; set ; }
        public int ColumCount { get; set; }
        public int RowCount { get; set; }

        public Excel(string fileName,int columCount,int rowCount)
        {
            FileName = fileName;
            ColumCount = columCount;
            RowCount = rowCount;
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} created.Colum Count: {ColumCount} Row Count:{RowCount}");
        }
    }
}
