using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegDesk_3_JeremyCherriman
{
    class DeskQuote
    {
        #region Members/Methods
        private string CustomerName;
        private DateTime QuoteDate;
        private Desk Desk = new Desk();
        private int RushDays;
        private int QuoteAmount;
        #endregion

        #region Local Variables
        private int SurfaceArea = 0;
        
        private const int PRICE_BASE = 200;
        private const int PRICE_ADDL_DRAWER = 50;
        private const int SIZE_THRESHOLD = 1000;
        private const int PRICE_EXTRA_SQ_INCH = 1;
        #endregion

        public DeskQuote(string customerName, DateTime quoteDate, int width, int depth, int drawers, string material, int rushDays)
        {
            CustomerName = customerName;
            QuoteDate = quoteDate;

            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberOfDrawers = drawers;
            Desk.DesktopMaterial = material;
            Desk.RushDays = rushDays;
            Desk.SurfaceArea = Desk.Width * Desk.Depth;
        }

        public int CalculateQuoteTotal ()
        {
            return PRICE_BASE + DrawerCost() + SurfaceAreaCost() + MaterialCost() + RushCost();
        }

        private int DrawerCost()
        {
            return Desk.NumberOfDrawers * PRICE_ADDL_DRAWER;
        }

        private int SurfaceAreaCost()
        {
            if (Desk.SurfaceArea > SIZE_THRESHOLD)
            {
                return (Desk.SurfaceArea - SIZE_THRESHOLD) * PRICE_EXTRA_SQ_INCH;
            }
            return (Desk.SurfaceArea - SIZE_THRESHOLD);
        }

        private int MaterialCost()
        {
            // Temp return of $125.
            return 125;
        }

        private int RushCost()
        {
            // Temp return of $50.
            return 50;
        }

    }
}
