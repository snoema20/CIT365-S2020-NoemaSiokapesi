using System;
using System.Drawing;

namespace timeLeftLabel
{
    internal class Back
    {
        public Back Red { get; internal set; }

        public static implicit operator Back(Color v)
        {
            throw new NotImplementedException();
        }
    }
}