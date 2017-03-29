using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ldg_converter.Properties;

namespace ldg_converter
{
    public enum UnitType
    {
        Imperial2,
        Metric3
    }
    class LdgConverter
    {
        public UnitType Units { get; set; }
        private List<string> file = new List<string>();
        public List<Truss> Trusses { get; set; }
        public LdgConverter(string location)
        {
            Trusses = new List<Truss>();
            createData(location);
        }
        //takes in file reference and stores each line as a string into file
        private void readInFile(string data)
        {
            string[] lines = data.Split('\n');
            //it's lines.count-1 because the data split always adds a final line with nothing in it
            for(int i = 0; i < lines.Count()-1; i++)
            {
                //getting rid of \r at the end of each string
                lines[i] = lines[i].Substring(0, (lines[i].Count()- 1));
                file.Add(lines[i]);
            }
        }
        private void createData(string data)
        {
            readInFile(data);
            //determining which unit type file is written in
            if (file[0] == "Imperial2")
            {
                Units = UnitType.Imperial2;
            }
            else
            {
                Units = UnitType.Metric3;
            }
            //runs through the file creating truss items
            for(int i = 0; i < file.Count(); i++)
            {
                //since a 0 and a 1 both mean a new truss, this makes a truss
                if (file[i][0] == '0' || file[i][0]=='1')
                {
                    string[] tokens = file[i].Split(' ');
                    if (tokens.Length > 1)
                    {
                        Trusses.Add(new Truss(Convert.ToInt32(tokens[0]), tokens[1]));
                    }
                }
                //since 1 means that there can be loads on that truss on the following lines, so it looks for them
                if (file[i][0] == '1')
                {
                    i++;
                    //if the line starts with a 2, then that means it is a load for the truss
                    //this while loop adds loads to the truss for every 2 line
                    while (i<file.Count()-1&&file[i][0] == '2')
                    {
                        string[] tokens = file[i].Split(' ');
                        Debug.Assert(tokens.Count() == 8);
                            string loadLabel = tokens[1];
                            double distanceOfLoadCL = Convert.ToDouble(tokens[2]);//not sure what CL means
                            bool loadOnTopChord;
                            //here a one means that the load is on the Top Chord, and a 0 means it is on the Bottom Chord
                            if (tokens[4] == "1")
                            {
                                loadOnTopChord = true;
                            }
                            else
                            {
                                loadOnTopChord = false;
                            }
                            double distanceOfConnection = Convert.ToDouble(tokens[5]);
                            int trussChord = Convert.ToInt32(tokens[6]);
                            double angle = Convert.ToDouble(tokens[7]);
                            Trusses[Trusses.Count - 1].addLoad(loadLabel, distanceOfLoadCL, loadOnTopChord, distanceOfConnection, trussChord, angle);
                        i++;
                    }
                }
            }
        }
    }
}
