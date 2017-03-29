using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ldg_converter
{
    using NUnit.Framework;
    using Properties;

    [TestFixture]
    class ParserTest
    {
        LdgConverter multipleLoadsOnATruss = new LdgConverter(Encoding.UTF8.GetString(Resources.RGR_75));
        LdgConverter sixEmptyTrusses = new LdgConverter(Encoding.UTF8.GetString(Resources.R_21));
        LdgConverter fourteenEmptyTrusses = new LdgConverter(Encoding.UTF8.GetString(Resources.R_5));
        LdgConverter fourEmptyTrusses = new LdgConverter(Encoding.UTF8.GetString(Resources.R_52));
        LdgConverter nineEmptyTrusses = new LdgConverter(Encoding.UTF8.GetString(Resources.R_66));
        LdgConverter threeEmptyTrusses = new LdgConverter(Encoding.UTF8.GetString(Resources.R_56));
        LdgConverter sixteenEmptyTrusses = new LdgConverter(Encoding.UTF8.GetString(Resources.R_31));
        LdgConverter tenEmptyTrusses = new LdgConverter(Encoding.UTF8.GetString(Resources.R_80));
        LdgConverter oneEmptyTruss = new LdgConverter(Encoding.UTF8.GetString(Resources.T_31A));

        [Test]
        public void TestmultipleLoadsOnATrussTruss1to4()
        {
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[1].TrussLabel, "R-76");
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[2].TrussLabel, "R-77");
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[3].TrussLabel, "R-78");
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[4].TrussLabel, "R-79");
            Assert.AreEqual(multipleLoadsOnATruss.Trusses.Count, 5);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[1].loads.Count, 0);

        }
        [Test]
        public void TestEnum()
        {
            Assert.AreEqual(multipleLoadsOnATruss.Units, UnitType.Imperial2);
        }
        [Test]
        public void TestmultipleLoadsOnATrussTruss0Load0()
        {
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].TrussLabel, "RGR-75");
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[0].LoadLabel, "R-70A");
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[0].DistanceOfLoadCLInches, 5.0208);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[0].LoadOnTopChord, false);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[0].DistanceOfConnectionInches, 0.000);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[0].TrussChord, 0);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[0].AngleInDegrees, 90.0000);
        }
        [Test]
        public void TestmultipleLoadsOnATrussTruss0Load1()
        {
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[1].LoadLabel, "R-70C");
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[1].DistanceOfLoadCLInches, 1.0208);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[1].LoadOnTopChord, false);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[1].DistanceOfConnectionInches, 0.000);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[1].TrussChord, 0);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[1].AngleInDegrees, 90.0000);
        }
        [Test]
        public void TestmultipleLoadsOnATrussTruss0Load2()
        {
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[2].LoadLabel, "R-70B");
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[2].DistanceOfLoadCLInches, 3.0208);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[2].LoadOnTopChord, false);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[2].DistanceOfConnectionInches, 0.000);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[2].TrussChord, 0);
            Assert.AreEqual(multipleLoadsOnATruss.Trusses[0].loads[2].AngleInDegrees, 90.0000);
        }
        [Test]
        public void TestsixEmptyTrussesTruss()
        {
            Assert.AreEqual(sixEmptyTrusses.Trusses[0].TrussLabel, "R-21");
            Assert.AreEqual(sixEmptyTrusses.Trusses[1].TrussLabel, "R-22");
            Assert.AreEqual(sixEmptyTrusses.Trusses[2].TrussLabel, "R-23");
            Assert.AreEqual(sixEmptyTrusses.Trusses[3].TrussLabel, "R-24");
            Assert.AreEqual(sixEmptyTrusses.Trusses[4].TrussLabel, "GR-25");
            Assert.AreEqual(sixEmptyTrusses.Trusses[5].TrussLabel, "GR-26");
            Assert.AreEqual(sixEmptyTrusses.Trusses.Count, 6);
        }
        [Test]
        public void TestfourteenEmptyTrussesTruss()
        {
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[0].TrussLabel, "R-5");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[1].TrussLabel, "R-6A");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[2].TrussLabel, "R-6B");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[3].TrussLabel, "R-6C");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[4].TrussLabel, "R-6D");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[5].TrussLabel, "R-7A");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[6].TrussLabel, "R-7B");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[7].TrussLabel, "R-7C");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[8].TrussLabel, "R-7D");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[9].TrussLabel, "R-7E");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[10].TrussLabel, "R-7F");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[11].TrussLabel, "R-7G");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[12].TrussLabel, "R-7H");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses[13].TrussLabel, "R-7I");
            Assert.AreEqual(fourteenEmptyTrusses.Trusses.Count, 14);
        }
        [Test]
        public void TestfourEmptyTrussesTruss()
        {
            Assert.AreEqual(fourEmptyTrusses.Trusses[0].TrussLabel, "R-52");
            Assert.AreEqual(fourEmptyTrusses.Trusses[1].TrussLabel, "R-53");
            Assert.AreEqual(fourEmptyTrusses.Trusses[2].TrussLabel, "R-54");
            Assert.AreEqual(fourEmptyTrusses.Trusses[3].TrussLabel, "R-55");
            Assert.AreEqual(fourEmptyTrusses.Trusses.Count, 4);
        }
        [Test]
        public void TestnineEmptyTrussesTruss()
        {
            Assert.AreEqual(nineEmptyTrusses.Trusses[0].TrussLabel, "R-66");
            Assert.AreEqual(nineEmptyTrusses.Trusses[1].TrussLabel, "R-71");
            Assert.AreEqual(nineEmptyTrusses.Trusses[2].TrussLabel, "R-70C");
            Assert.AreEqual(nineEmptyTrusses.Trusses[3].TrussLabel, "R-70B");
            Assert.AreEqual(nineEmptyTrusses.Trusses[4].TrussLabel, "R-70A");
            Assert.AreEqual(nineEmptyTrusses.Trusses[5].TrussLabel, "R-69C");
            Assert.AreEqual(nineEmptyTrusses.Trusses[6].TrussLabel, "R-69B");
            Assert.AreEqual(nineEmptyTrusses.Trusses[7].TrussLabel, "R-69A");
            Assert.AreEqual(nineEmptyTrusses.Trusses[8].TrussLabel, "R-68");
            Assert.AreEqual(nineEmptyTrusses.Trusses[9].TrussLabel, "R-67");
            Assert.AreEqual(nineEmptyTrusses.Trusses.Count,10);
        }
        [Test]
        public void TestthreeEmptyTrussesTruss()
        {
            Assert.AreEqual(threeEmptyTrusses.Trusses[0].TrussLabel, "R-56");
            Assert.AreEqual(threeEmptyTrusses.Trusses[1].TrussLabel, "R-57");
            Assert.AreEqual(threeEmptyTrusses.Trusses[2].TrussLabel, "R-58");
            Assert.AreEqual(threeEmptyTrusses.Trusses.Count, 3);
        }
        [Test]
        public void TestsixteenEmptyTrussesTruss()
        {
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[0].TrussLabel, "R-31");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[1].TrussLabel, "R-32");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[2].TrussLabel, "R-33A");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[3].TrussLabel, "R-33B");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[4].TrussLabel, "R-33C");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[5].TrussLabel, "R-34A");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[6].TrussLabel, "R-34B");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[7].TrussLabel, "R-34C");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[8].TrussLabel, "R-34D");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[9].TrussLabel, "R-35A");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[10].TrussLabel, "R-35B");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[11].TrussLabel, "R-35C");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[12].TrussLabel, "R-35D");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[13].TrussLabel, "R-35E");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[14].TrussLabel, "R-35F");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses[15].TrussLabel, "R-35G");
            Assert.AreEqual(sixteenEmptyTrusses.Trusses.Count,16);
        }
        [Test]
        public void TesttenEmptyTrussesTruss()
        {
            Assert.AreEqual(tenEmptyTrusses.Trusses[0].TrussLabel, "R-80");
            Assert.AreEqual(tenEmptyTrusses.Trusses[1].TrussLabel, "R-81");
            Assert.AreEqual(tenEmptyTrusses.Trusses[2].TrussLabel, "R-82");
            Assert.AreEqual(tenEmptyTrusses.Trusses[3].TrussLabel, "R-83");
            Assert.AreEqual(tenEmptyTrusses.Trusses[4].TrussLabel, "R-89");
            Assert.AreEqual(tenEmptyTrusses.Trusses[5].TrussLabel, "R-88");
            Assert.AreEqual(tenEmptyTrusses.Trusses[6].TrussLabel, "R-87");
            Assert.AreEqual(tenEmptyTrusses.Trusses[7].TrussLabel, "R-86");
            Assert.AreEqual(tenEmptyTrusses.Trusses[8].TrussLabel, "R-85");
            Assert.AreEqual(tenEmptyTrusses.Trusses[9].TrussLabel, "R-84");
            Assert.AreEqual(tenEmptyTrusses.Trusses.Count, 10);
        }
        [Test]
        public void TestoneEmptyTrussTruss()
        {
            Assert.AreEqual(oneEmptyTruss.Trusses[0].TrussLabel, "T-31A");
            Assert.AreEqual(oneEmptyTruss.Trusses.Count, 1);
        }
    }
}
