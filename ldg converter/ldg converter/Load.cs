using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitClassLibrary.AngleUnit;
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace ldg_converter
{
    class Load
    {
        public string LoadLabel { get; set; }
        public double DistanceOfLoadCLInches { get; set; }//not sure what CL means
        public bool LoadOnTopChord { get; set; }
        public double DistanceOfConnectionInches { get; set; }
        public int TrussChord { get; set; }
        public double AngleInDegrees { get; set; }
        public Load(string loadLabel, double distanceOfLoadCL, bool loadOnTopChord, double distanceOfConnection, int trussChord, double angle)
        {
            LoadLabel = loadLabel;
            DistanceOfLoadCLInches = distanceOfLoadCL;
            LoadOnTopChord = loadOnTopChord;
            DistanceOfConnectionInches = distanceOfConnection;
            TrussChord = trussChord;
            AngleInDegrees = angle;
        }
        public Angle Angle
        {
            get
            {
                return new Angle(new Degree(), AngleInDegrees);
            }
            set
            {
                this.AngleInDegrees = value.InDegrees.Value;
            }
        }
        public Distance DistanceOfLoadCL
        {
            get
            {
                return new Distance(new Inch(), DistanceOfLoadCLInches);
            }
            set
            {
                this.DistanceOfLoadCLInches = value.ValueInInches;
            }
        }
        public Distance DistanceOfConnection
        {
            get
            {
                return new Distance(new Inch(), DistanceOfConnectionInches);
            }
            set
            {
                this.DistanceOfConnectionInches = value.ValueInInches;
            }
        }
    }
}
