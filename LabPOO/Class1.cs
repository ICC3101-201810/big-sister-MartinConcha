using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{
    public class BigSisters
    {
        public delegate void BigSisterEventHandler(object source, EventArgs args);

        public event BigSisterEventHandler BigSister;

        protected virtual void OnBigSister()
        {
            if (BigSister != null)
            {
                BigSister(this, EventArgs.Empty);
            }
        }
    }
}
