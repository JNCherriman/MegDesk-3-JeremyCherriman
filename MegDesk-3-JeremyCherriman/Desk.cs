using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegDesk_3_JeremyCherriman
{
    class Desk
    {
        #region Constraints/Constants
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        #endregion

        #region Members/Methods
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public string DesktopMaterial { get; set; }
        public int RushDays { get; set; }
        public int SurfaceArea { get; set; }
        #endregion
    }
}
