using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Un_Uncert_modSC
{
    public abstract class GraphicBuilder : GraphicParameters
    {
        public abstract void buildGraph<T>(T[,] data) where T : struct,IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>;
    }
}
