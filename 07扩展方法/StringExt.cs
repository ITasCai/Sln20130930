using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07扩展方法
{
    public static class StringExt
    {
        public static bool IsEmail(this string obj)
        {
            return Regex.IsMatch(obj, @"^\w+@\w+\.\w+$");
        }
    }
}
