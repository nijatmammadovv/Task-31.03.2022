using System;
using System.Collections.Generic;
using System.Text;

namespace Task_31._03._2022.Models
{
     class PrintFile<T> where T:IPrintable
    {
        public void  Print(T task)
        {
            task.Print();
        }
        }
    }
