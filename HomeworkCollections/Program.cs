using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        public class Comparer : IComparer
        {
            readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
            public int Compare(object x, object y)
            {
                if(x is int && y is int)
                    return ((int)x == (int)y) ? 0 : ((int)x > (int)y) ? 1 : -1;
                if (x is string && y is string)
                {
                    string waste = (string)x, waste2 = (string)y;
                    return (waste == waste2) ? 0 : (waste[0] > waste2[0]) ? 1 : -1;
                }
                if(x is char && y is char)
                    return ((char)x == (char)y) ? 0 : ((char)x > (char)y) ? 1 : -1;
                else return -1;
            }
        }
        static void Main(string[] args)
        {
            /*
             * Создать массив типа ArrayList, наполните разными данными (int, string и тп.) и отсортируйте каждый тип с помощью пользовательского интерфейса IComparer
             */
            var arr = new ArrayList() { 1, 6, 111, 43, 'c', 11, 'b', 'a', "hi", 'k', "qq" };
            arr.Sort(new Comparer());
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
