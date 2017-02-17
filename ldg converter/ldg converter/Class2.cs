using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ldg_converter
{
    class Load
    {
        private String loadLabel;
        private double distanceOfLoadCL;
        private bool loadOnTopChord;
        private double distanceOfConnection;
        private double trussChord;
        private double angle;
        public Load(String loadLabels, double distanceOfLoadCLs, bool loadOnTopChords, double distanceOfConnections, double trussChords, double angles)
        {
            loadLabel = loadLabels;
            distanceOfLoadCL = distanceOfLoadCLs;
            loadOnTopChord = loadOnTopChords;
            distanceOfConnection = distanceOfConnections;
            trussChord = trussChords;
            angle = angles;
        }
        public String getloadLabel()
        {
            return loadLabel;
        }
        public void setloadLabel(String newstr)
        {
            loadLabel = newstr;
        }
        public double getdistanceOfLoadCL()
        {
            return distanceOfLoadCL;
        }
        public void setdistanceOfLoadCL(double newstr)
        {
            distanceOfLoadCL = newstr;
        }
        public bool getloadOnTopChord()
        {
            return loadOnTopChord;
        }
        public void setdistanceOfConnection(double newstr)
        {
            distanceOfConnection = newstr;
        }
        public double getdistanceOfConnection()
        {
            return distanceOfConnection;
        }
        
        public double gettrussChord()
        {
            return trussChord;
        }
        public void settrussChord(double newstr)
        {
            trussChord = newstr;
        }
        public double getangle()
        {
            return angle;
        }
        public void setangle(double newstr)
        {
            angle = newstr;
        }
    }
}
