using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ldg_converter
{
    public enum Units
    {
        Imperial2,
        Metric3
    }
    class LdgConverter
    {
        public Units Units { get; set; }
        private ArrayList file = new ArrayList();
        private string[] data;
        private List<Truss> trusses { get; set; }
        public LdgConverter(string location)
        {
            trusses = new List<Truss>();
            createData(location);
        }
        private void readInFile(string location)
        {
            using (StreamReader sr = File.OpenText(location))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    file.Add(s);
                }
            }
        }
        private void createData(string location)
        {
            readInFile(location);
            data = new string[file.Count];
            for(int i = 0; i < file.Count; i++)
            {
                data[i] = (string)file[i];
            }
            if (data[0] == "Imperial2")
            {
                Units = Units.Imperial2;
            }
            else if (data[0] == "Metric3")
            {
                Units = Units.Metric3;
            }
            for(int i = 1; i < data.Count(); i++)
            {

                if (data[i][0] == '0' || data[i][0]=='1')
                {
                    string[] tokens = data[i].Split(' ');
                    if (tokens.Length > 1)
                    {
                        trusses.Add(new Truss(Convert.ToInt32(tokens[0]), tokens[1]));
                    }
                }
                if (data[i][0] == '1')
                {
                    while (i<data.Count()-1&&data[i + 1][0] == '2')
                    {
                        i++;
                        string[] tokens = data[i].Split(' ');
                        Debug.Assert(tokens.Count() == 8);
                            if (tokens[4] == "1")
                            {
                                trusses[trusses.Count - 1].addLoad(tokens[1], Convert.ToDouble(tokens[2]), true, Convert.ToDouble(tokens[5]), Convert.ToInt32(tokens[6]), Convert.ToDouble(tokens[7]));
                            }
                            else
                            {
                                trusses[trusses.Count - 1].addLoad(tokens[1], Convert.ToDouble(tokens[2]), false, Convert.ToDouble(tokens[5]), Convert.ToInt32(tokens[6]), Convert.ToDouble(tokens[7]));
                            }
                    }
                }
            }
        }
    }
}
