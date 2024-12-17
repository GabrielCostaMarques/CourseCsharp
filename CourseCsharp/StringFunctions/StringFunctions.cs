using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.StringFunctions
{
    internal class StringFunctions
    {
        public void StringFunctionsShow()
        {
            var original = "abcde ABC FGHIJ abc DEFG";

            var s1 = original.ToLower();
            var s2 = original.ToUpper();
            var s3 = original.Trim();
            var s4 = original.IndexOf("bc");
            var s5 = original.LastIndexOf("bc");
            var s6 = original.Substring(3);
            var s7 = original.Substring(3,5);

            //verifica se está vazio
            bool b1 = String.IsNullOrEmpty(original);
            //verifica se está com espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);



            //troca todo caracter A, pelo X
            var s8 = original.Replace("a","x");

        }

    }
}
