namespace Calidad.Test
{
    
    public class Tests
    {
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(10);
            Assert.AreEqual("X", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(100);
            Assert.AreEqual("C", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(1);
            Assert.AreEqual("I", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(22);
            Assert.AreEqual("XXII", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(15);
            Assert.AreEqual("XV", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(120);
            Assert.AreEqual("CXX", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(14);
            Assert.AreEqual("XIV", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(28);
            Assert.AreEqual("XXVIII", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(210);
            Assert.AreEqual("CCX", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(300);
            Assert.AreEqual("XXX", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(90);
            Assert.AreEqual("XC", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(150);
            Assert.AreEqual("CL", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(85);
            Assert.AreEqual("LXXXV", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(99);
            Assert.AreEqual("XCIX", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(39);
            Assert.AreEqual("XXXIX", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(500);
            Assert.AreEqual("D", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(600);
            Assert.AreEqual("DC", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(890);
            Assert.AreEqual("DCCCXC", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(690);
            Assert.AreEqual("DCXC", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(388);
            Assert.AreEqual("CCCLXXXVIII", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(688);
            Assert.AreEqual("DCLXXXVIII", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(510);
            Assert.AreEqual("DX", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(66);
            Assert.AreEqual("LXVI", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(445);
            Assert.AreEqual("CDLXV", test);
        }
        [Test]
        public void RomanoGeneratorTest()
        {
            var nromano = RomanoGenerator();
            var test = nromano.GetRomano(111);
            Assert.AreEqual("CXI", test);
        }





    }
}