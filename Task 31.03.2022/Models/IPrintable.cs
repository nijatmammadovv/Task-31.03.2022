using System;
using System.Collections.Generic;
using System.Text;

namespace Task_31._03._2022.Models
{
    public interface IPrintable
    {
        public string FileName { get; set; }
        public void Print();
    }
}
