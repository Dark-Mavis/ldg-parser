using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ldg_converter
{
    class ldgconverter
    {
        private static bool impOrFeet;
        private static ArrayList file = new ArrayList();
        private static String[] data;
        private List<TrussMe> trusses;
        public ldgconverter(String location)
        {
            trusses = new List<TrussMe>();
        }
        private static void readInFile(String location)
        {
            using (StreamReader sr = File.OpenText(location))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    file.Add(sr.ReadLine());
                }
            }
        }
        private void createData(String location)
        {
            readInFile(location);
            data = new String[file.Count];
            for(int i = 0; i < file.Count; i++)
            {
                data[i] = (String)file[i];
            }
            if (data[0] == "Imperial2")
            {
                impOrFeet = true;
            }
            else if (data[0] == "Metric3")
            {
                impOrFeet = false;
            }
            else
            {
                //make problem catcher
            }
            for(int i = 1; i < data.Count(); i++)
            {

                if (data[i][0] == '0' || data[i][0]=='1')
                {
                    String[] tokens = data[i].Split(' ');
                    if (tokens.Length > 1)
                    {
                        trusses.Add(new TrussMe(Convert.ToInt32(tokens[0]), tokens[1]));
                    }
                }
                if (data[i][0] == '1'&&i<data.Count()-1)
                {
                    while (data[i + 1][0] == '2')
                    {
                        i++;
                        String[] tokens = data[i].Split(' ');
                        if (tokens.Length == 8)
                        {
                            if (tokens[4] == "1")
                            {
                                trusses[trusses.Count - 1].addLoad(tokens[1],Convert.ToDouble(tokens[2]),true,Convert.ToDouble(tokens[5]),Convert.ToDouble(tokens[6]),Convert.ToDouble(tokens[7]));
                            }
                            else
                            {
                                trusses[trusses.Count - 1].addLoad(tokens[1], Convert.ToDouble(tokens[2]), false, Convert.ToDouble(tokens[5]), Convert.ToDouble(tokens[6]), Convert.ToDouble(tokens[7]));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Something isn't right about the input on line " + (i + 1)+" of "+location);
                        }
                    }
                }
            }
        }
        public bool measureFeet()
        {
            return !impOrFeet;
        }
        public bool measureMeters()
        {
            return impOrFeet;
        }
        static void Main(string[] args)
        { 
       
        }
    }
}
