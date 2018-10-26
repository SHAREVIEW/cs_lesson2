using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;      //声明变量
            string myString;
            myInteger = 17;          //赋值
            myString = "\"myInteger\" is ";         
            Console.WriteLine("{0}{1}.", myString, myInteger);   //输出
            Console.ReadKey();
        }
    }
}
