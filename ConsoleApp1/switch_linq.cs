using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class switch_linq
    {
      void  switch_SQL_number(int i) 
        {
            string t = i switch { 13 => "thitteen ",  _ => "everything else" };
            Console.WriteLine(t);
             
        }
        void switch_SQL_tupe(dynamic s)
        {
            string t = s switch { int s1 => "the int", string s2 => "string" };
            Console.WriteLine(t);
        }

        void clasic_switch_tupe(dynamic s) 
        {
            string t;
            switch (s) 
            {
                case int: t="это число"; 
                break;
                case string z when z.Length<100  : t = "Строка длиной меньше 100";
                break;
                case object z when z is bool : t = "это bool";
                break;
            }
        
        }

     }
  
}
