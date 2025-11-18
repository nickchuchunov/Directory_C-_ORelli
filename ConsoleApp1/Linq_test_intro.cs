using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Linq_test_intro
    {


        internal StreamReader TextFlow(string patchFile  )
        {
            try { return File.OpenText(patchFile); }
            catch { throw new InvalidOperationException("Не верно задан путь к файлу или формат файла не потдерживается"); };
            
        }


        internal char[] NumberCharacters(StreamReader _stream) => _stream.ReadToEnd().ToString().ToCharArray();



        internal long CoubntChar(IEnumerable<char> t)
        {
            
            IEnumerable<char> enumerable = from z in t
                                             where z == ' '
                                             select z ;
            return enumerable.LongCount<char>();


          //long _countChar = t.Where(t => t == '1').LongCount(); 
          //return _countChar;  
        }



        internal void PrintCounNomber(string patchFile) 
        { 
         StreamReader text = TextFlow(patchFile);
         IEnumerable<char> t = NumberCharacters(text);
         long count = CoubntChar(t);
         Console.WriteLine($"Количество пробелов {count} в файле {patchFile}, ");
        }
    }
}
