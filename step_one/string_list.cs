using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_one
{
    class string_list
    {
        public string a=Console.ReadLine();
      
        public void List()
        {
            Random rand = new Random();
           
             List<string> list1 = new List<string>() {"A","B" ,"C", "D", "E", "F", "G","H","I","J","K","L","M","N","O","P","Q",
            "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g",
            "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "w", "z"," ","y" };
            list1 = list1.OrderBy(v => rand.Next()).ToList();
            for(int i=0;i<list1.Count;i++)
            {
                Console.Write(list1[i]+" ");
                
            }
            Console.WriteLine();
            char[] b = this.a.ToCharArray();
            foreach( char x in b)
            {
                Console.WriteLine(x);
            }
            //int num = 10;
            //string str = Convert.ToString(num);
            for (int i=0;i<b.Length;i++)
            {
                int position = list1.IndexOf(Convert.ToString(a[i]));
                Console.WriteLine(position);
            }
        }

    }
}
