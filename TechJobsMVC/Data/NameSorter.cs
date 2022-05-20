using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace TechJobsMVC.Data
{
    public class NameSorter : IComparer<object>
    {
        public int Compare([AllowNull] object x, [AllowNull] object y) //wdf is AllowNull??
        {
            return x.ToString().ToLower().CompareTo(y.ToString().ToLower());
        }
    }
}
