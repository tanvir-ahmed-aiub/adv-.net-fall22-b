using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = StudentService.GetStudents();
            foreach(var item in data)
            {
                Console.WriteLine("Name: {0}, Id: {1}",item.Name,item.Id);
            }
        }
    }
}
