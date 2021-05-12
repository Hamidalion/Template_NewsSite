using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_NewsSite.PL.Extensions
{
    public static class Extension
    {
        public static string CutController(this string str)
        {
            return str.Replace("Controller", "");
        }
    }
}
