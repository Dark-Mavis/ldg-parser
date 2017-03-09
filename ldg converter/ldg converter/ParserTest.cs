using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ldg_converter
{
    using NUnit.Framework;
    [TestFixture]
    class ParserTest
    {
        LdgConverter fred = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/RGR-75.ldg"));
        LdgConverter fred0 = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/R-21.ldg"));
        LdgConverter fred1 = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/R-5.ldg"));
        LdgConverter fred2 = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/R-52.ldg"));
        LdgConverter fred3 = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/R-66.ldg"));
        LdgConverter fred4 = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/R-8.ldg"));
        LdgConverter fred5 = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/R-93.ldg"));
        LdgConverter fred6 = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/R-56.ldg"));
        LdgConverter fred7 = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/R-31.ldg"));
        LdgConverter fred8 = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/R-80.ldg"));
        LdgConverter fred9 = new LdgConverter(("C:/Users/Cerullium/OneDrive/Work/ldg-parser/ldg converter/ldg converter/T-31A.ldg"));

        [Test]
        public void TestEnum()
        {
            Assert.AreEqual(fred.Units, Units.Imperial2);
        }
        [Test]
        public void TestfredTruss0()
        {
            Assert.AreEqual(fred.trusses[0].TrussLabel, "RGR-75");
            Assert.AreEqual(fred.trusses[0].loads[0].LoadLabel, "R-70A");
            Assert.AreEqual(fred.trusses[0].loads[0].DistanceOfLoadCL, 5.0208);
            Assert.AreEqual(fred.trusses[0].loads[0].LoadOnTopChord, false);
            Assert.AreEqual(fred.trusses[0].loads[0].DistanceOfConnection, 0.000);
            Assert.AreEqual(fred.trusses[0].loads[0].TrussChord, 0);
            Assert.AreEqual(fred.trusses[0].loads[0].AngleInDegrees, 90.0000);
        }
        [Test]
        public void TestfredTruss1()
        {
            Assert.AreEqual(fred.trusses[0].loads[1].LoadLabel, "R-70C");
            Assert.AreEqual(fred.trusses[0].loads[1].DistanceOfLoadCL, 1.0208);
            Assert.AreEqual(fred.trusses[0].loads[1].LoadOnTopChord, false);
            Assert.AreEqual(fred.trusses[0].loads[1].DistanceOfConnection, 0.000);
            Assert.AreEqual(fred.trusses[0].loads[1].TrussChord, 0);
            Assert.AreEqual(fred.trusses[0].loads[1].AngleInDegrees, 90.0000);
        }
        [Test]
        public void TestfredTruss2()
        {
            Assert.AreEqual(fred.trusses[0].loads[2].LoadLabel, "R-70B");
            Assert.AreEqual(fred.trusses[0].loads[2].DistanceOfLoadCL, 3.0208);
            Assert.AreEqual(fred.trusses[0].loads[2].LoadOnTopChord, false);
            Assert.AreEqual(fred.trusses[0].loads[2].DistanceOfConnection, 0.000);
            Assert.AreEqual(fred.trusses[0].loads[2].TrussChord, 0);
            Assert.AreEqual(fred.trusses[0].loads[2].AngleInDegrees, 90.0000);
        }
        [Test]
        public void TestfredTruss3()
        {
            Assert.AreEqual(fred.trusses[1].TrussLabel, "R-76");
            Assert.AreEqual(fred.trusses[2].TrussLabel, "R-77");
            Assert.AreEqual(fred.trusses[3].TrussLabel, "R-78");
            Assert.AreEqual(fred.trusses[4].TrussLabel, "R-79");
            Assert.AreEqual(fred.trusses.Count, 5);
            Assert.AreEqual(fred.trusses[1].loads.Count, 0);

        }
        [Test]
        public void Testfred0Truss()
        {
            Assert.AreEqual(fred0.trusses[0].TrussLabel, "R-21");
            Assert.AreEqual(fred0.trusses[1].TrussLabel, "R-22");
            Assert.AreEqual(fred0.trusses[2].TrussLabel, "R-23");
            Assert.AreEqual(fred0.trusses[3].TrussLabel, "R-24");
            Assert.AreEqual(fred0.trusses[4].TrussLabel, "GR-25");
            Assert.AreEqual(fred0.trusses[5].TrussLabel, "GR-26");
            Assert.AreEqual(fred0.trusses.Count, 6);
        }
        [Test]
        public void Testfred1Truss()
        {
            Assert.AreEqual(fred1.trusses[0].TrussLabel, "R-5");
            Assert.AreEqual(fred1.trusses[1].TrussLabel, "R-6A");
            Assert.AreEqual(fred1.trusses[2].TrussLabel, "R-6B");
            Assert.AreEqual(fred1.trusses[3].TrussLabel, "R-6C");
            Assert.AreEqual(fred1.trusses[4].TrussLabel, "R-6D");
            Assert.AreEqual(fred1.trusses[5].TrussLabel, "R-7A");
            Assert.AreEqual(fred1.trusses[6].TrussLabel, "R-7B");
            Assert.AreEqual(fred1.trusses[7].TrussLabel, "R-7C");
            Assert.AreEqual(fred1.trusses[8].TrussLabel, "R-7D");
            Assert.AreEqual(fred1.trusses[9].TrussLabel, "R-7E");
            Assert.AreEqual(fred1.trusses[10].TrussLabel, "R-7F");
            Assert.AreEqual(fred1.trusses[11].TrussLabel, "R-7G");
            Assert.AreEqual(fred1.trusses[12].TrussLabel, "R-7H");
            Assert.AreEqual(fred1.trusses[13].TrussLabel, "R-7I");
            Assert.AreEqual(fred1.trusses.Count, 14);
        }
        [Test]
        public void Testfred2Truss()
        {
            Assert.AreEqual(fred2.trusses[0].TrussLabel, "R-52");
            Assert.AreEqual(fred2.trusses[1].TrussLabel, "R-53");
            Assert.AreEqual(fred2.trusses[2].TrussLabel, "R-54");
            Assert.AreEqual(fred2.trusses[3].TrussLabel, "R-55");
            Assert.AreEqual(fred2.trusses.Count, 4);
        }
        [Test]
        public void Testfred3Truss()
        {
            Assert.AreEqual(fred3.trusses[0].TrussLabel, "R-66");
            Assert.AreEqual(fred3.trusses[1].TrussLabel, "R-71");
            Assert.AreEqual(fred3.trusses[2].TrussLabel, "R-70C");
            Assert.AreEqual(fred3.trusses[3].TrussLabel, "R-70B");
            Assert.AreEqual(fred3.trusses[4].TrussLabel, "R-70A");
            Assert.AreEqual(fred3.trusses[5].TrussLabel, "R-69C");
            Assert.AreEqual(fred3.trusses[6].TrussLabel, "R-69B");
            Assert.AreEqual(fred3.trusses[7].TrussLabel, "R-69A");
            Assert.AreEqual(fred3.trusses[8].TrussLabel, "R-68");
            Assert.AreEqual(fred3.trusses[9].TrussLabel, "R-67");
            Assert.AreEqual(fred3.trusses.Count,10);
        }
        [Test]
        public void Testfred4Truss()
        {
            Assert.AreEqual(fred4.trusses[0].TrussLabel, "R-8");
            Assert.AreEqual(fred4.trusses[1].TrussLabel, "R-9");
            Assert.AreEqual(fred4.trusses[2].TrussLabel, "R-10");
            Assert.AreEqual(fred4.trusses[3].TrussLabel, "R-11");
            Assert.AreEqual(fred4.trusses.Count, 4);
        }
        [Test]
        public void Testfred5Truss()
        {
            Assert.AreEqual(fred5.trusses[0].TrussLabel, "R-93");
            Assert.AreEqual(fred5.trusses[1].TrussLabel, "R-94");
            Assert.AreEqual(fred5.trusses[2].TrussLabel, "R-95");
            Assert.AreEqual(fred5.trusses[3].TrussLabel, "R-96");
            Assert.AreEqual(fred5.trusses.Count, 4);
        }
        [Test]
        public void Testfred6Truss()
        {
            Assert.AreEqual(fred6.trusses[0].TrussLabel, "R-56");
            Assert.AreEqual(fred6.trusses[1].TrussLabel, "R-57");
            Assert.AreEqual(fred6.trusses[2].TrussLabel, "R-58");
            Assert.AreEqual(fred6.trusses.Count, 3);
        }
        [Test]
        public void Testfred7Truss()
        {
            Assert.AreEqual(fred7.trusses[0].TrussLabel, "R-31");
            Assert.AreEqual(fred7.trusses[1].TrussLabel, "R-32");
            Assert.AreEqual(fred7.trusses[2].TrussLabel, "R-33A");
            Assert.AreEqual(fred7.trusses[3].TrussLabel, "R-33B");
            Assert.AreEqual(fred7.trusses[4].TrussLabel, "R-33C");
            Assert.AreEqual(fred7.trusses[5].TrussLabel, "R-34A");
            Assert.AreEqual(fred7.trusses[6].TrussLabel, "R-34B");
            Assert.AreEqual(fred7.trusses[7].TrussLabel, "R-34C");
            Assert.AreEqual(fred7.trusses[8].TrussLabel, "R-34D");
            Assert.AreEqual(fred7.trusses[9].TrussLabel, "R-35A");
            Assert.AreEqual(fred7.trusses[10].TrussLabel, "R-35B");
            Assert.AreEqual(fred7.trusses[11].TrussLabel, "R-35C");
            Assert.AreEqual(fred7.trusses[12].TrussLabel, "R-35D");
            Assert.AreEqual(fred7.trusses[13].TrussLabel, "R-35E");
            Assert.AreEqual(fred7.trusses[14].TrussLabel, "R-35F");
            Assert.AreEqual(fred7.trusses[15].TrussLabel, "R-35G");
            Assert.AreEqual(fred7.trusses.Count,16);
        }
        [Test]
        public void Testfred8Truss()
        {
            Assert.AreEqual(fred8.trusses[0].TrussLabel, "R-80");
            Assert.AreEqual(fred8.trusses[1].TrussLabel, "R-81");
            Assert.AreEqual(fred8.trusses[2].TrussLabel, "R-82");
            Assert.AreEqual(fred8.trusses[3].TrussLabel, "R-83");
            Assert.AreEqual(fred8.trusses[4].TrussLabel, "R-89");
            Assert.AreEqual(fred8.trusses[5].TrussLabel, "R-88");
            Assert.AreEqual(fred8.trusses[6].TrussLabel, "R-87");
            Assert.AreEqual(fred8.trusses[7].TrussLabel, "R-86");
            Assert.AreEqual(fred8.trusses[8].TrussLabel, "R-85");
            Assert.AreEqual(fred8.trusses[9].TrussLabel, "R-84");
            Assert.AreEqual(fred8.trusses.Count, 10);
        }
        [Test]
        public void Testfred9Truss()
        {
            Assert.AreEqual(fred9.trusses[0].TrussLabel, "T-31A");
            Assert.AreEqual(fred9.trusses.Count, 1);
        }
    }
}
