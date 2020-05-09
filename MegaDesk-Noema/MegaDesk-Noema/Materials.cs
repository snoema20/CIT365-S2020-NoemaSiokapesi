using System;

namespace MegaDesk_Noema
{
    internal class Materials
    {
        public static object Oak { get; internal set; }

        public static implicit operator Materials(DesktopMaterial v)
        {
            throw new NotImplementedException();
        }
    }
}