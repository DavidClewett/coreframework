using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clewtils.Extensions
{
    public static class StringUtilities
    {
        public static bool IsNumeric(this string s) {
            float f = 0f;
            return float.TryParse(s, out f);
        }
    }
}
