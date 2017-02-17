using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ldg_converter
{
    class Truss
    {
        private ArrayList loads;
        public Truss(int trussType, String label)
        {
            loads = new ArrayList();
        }
        public void addLoad(String loadLabel, double distanceOfLoadCL, bool loadOnTopChord, double distanceOfConnection, int trussChord, double angle)
        {
            loads.Add(new Load(loadLabel, distanceOfLoadCL, loadOnTopChord, distanceOfConnection, trussChord, angle));
        }

    }
}
