using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projektCF;
using NUnit.Framework;

namespace projektCF_Testing
{
    [TestFixture]
    public class ProjektCF_Testing
    {
        [Test, Category ("Akzeptanztest")]
        public void Zahlen_zwischen_UG_OG()
        {
            var result = ProjektCF.Start_Zahlen_testen(23, 26);
            Assert.AreEqual(new[] { 23, 24, 25, 26 }, result);
        }

        [Test, Category ("Gerüsttest")]
        public void Anzahl_Zahlen_zwischen_UG_OG()
        {
            var result = ProjektCF.Zahlen_testen(23, 46);
            Assert.AreEqual(24, result.Count());
        }
    }
}
