using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 4, 9, 7, 3, 8, 1 };

            var qnums = from num in nums
                        where num % 2 == 1
                        orderby num
                        select num * 2; //deffered execution - late binding

            nums[1] = 5;

            foreach (var item in qnums)
            {
                Console.WriteLine(item);
            }


            string[] names = new string[] { "avi", "ben", "gil", "aviel", "avigail", "charlie" };

            List<string> namesSWAV =
                (from name in names
                where name.StartsWith("av") 
                select name.Substring(2)).ToList(); //run the query!

            names[1] = "avben";
            Console.WriteLine(namesSWAV[0]);

            Console.WriteLine();
            foreach (var item in namesSWAV)
            {
                Console.WriteLine(item);
            }

        }
    }
}
