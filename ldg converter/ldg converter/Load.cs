using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ldg_converter
{
    class Load
    {
        public string LoadLabel { get; set; }
        public double DistanceOfLoadCL { get; set; }
        public bool LoadOnTopChord { get; set; }
        public double DistanceOfConnection { get; set; }
        public int TrussChord { get; set; }
        public double Angle { get; set; }
        public Load(string loadLabel, double distanceOfLoadCL, bool loadOnTopChord, double distanceOfConnection, int trussChord, double angle)
        {
            LoadLabel = loadLabel;
            DistanceOfLoadCL = distanceOfLoadCL;
            LoadOnTopChord = loadOnTopChord;
            DistanceOfConnection = distanceOfConnection;
            TrussChord = trussChord;
            Angle = angle;
        }
    }
}
