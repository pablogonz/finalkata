using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataver3
{
    public class finalisbn
    {
        public static bool isbnfinal(string storage)
        {
            storage = storage.Replace("-", "").Replace(" ", "");
            if(storage.Length !=13)
            {
                return false;
            }
            int totalsum = 0;
            foreach(var(start,end)in storage.Select((end,start)=>(start,end)))
            {
                if (char.IsDigit(end)) totalsum += (end - '0') * (start % 2 == 0 ? 1 : 3);
                else return false;
            }
            return totalsum % 10 == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isbnfinal("978-1734314502"));
            Console.WriteLine(isbnfinal("978-173431450adsadada2"));
            Console.ReadKey();
        }
    }
}
