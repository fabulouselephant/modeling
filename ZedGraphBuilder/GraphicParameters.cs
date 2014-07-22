using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Un_Uncert_modSC
{
    public class GraphicParameters
    {
        public virtual string Title { set; get; }
        public virtual string XAxisTitle { set; get; }
        public virtual string YAxisTitle { set; get; }
        /// <summary>
        /// Property set and get a current type of diagram. Default is a line type;
        /// </summary>
        public virtual GraphicType TypeOfGraphic { set; get; }

        public enum GraphicType { LINE, POINT, HISTOGRAM };
    }
}
