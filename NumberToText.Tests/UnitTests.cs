using NUnit.Framework;
using NumberToWordsLib;

namespace NumberToText.Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void NumberToText_Should_Display_3000000_En_Correctly()
        {
            var res = (3000000).NumberToText(Language.English);
            Assert.AreEqual("Three Million", res);
        }

        [Test]
        public void NumberToText_Should_Display_0_Correctly()
        {
            var res = (0).NumberToText(Language.Persian);
            Assert.AreEqual("صفر", res);
        }

        [Test]
        public void NumberToText_Should_Display_Minus_1_Correctly()
        {
            var res = (-1).NumberToText(Language.Persian);
            Assert.AreEqual("منهاي يك", res);
        }

        [Test]
        public void NumberToText_Should_Display_3_Correctly()
        {
            var res = (3).NumberToText(Language.Persian);
            Assert.AreEqual("سه", res);
        }

        [Test]
        public void NumberToText_Should_Display_30_Correctly()
        {
            var res = (30).NumberToText(Language.Persian);
            Assert.AreEqual("سي", res);
        }

        [Test]
        public void NumberToText_Should_Display_32_Correctly()
        {
            var res = (32).NumberToText(Language.Persian);
            Assert.AreEqual("سي و دو", res);
        }

        [Test]
        public void NumberToText_Should_Display_300_Correctly()
        {
            var res = (300).NumberToText(Language.Persian);
            Assert.AreEqual("سيصد", res);
        }

        [Test]
        public void NumberToText_Should_Display_310_Correctly()
        {
            var res = (310).NumberToText(Language.Persian);
            Assert.AreEqual("سيصد و ده", res);
        }

        [Test]
        public void NumberToText_Should_Display_3000_Correctly()
        {
            var res = (3000).NumberToText(Language.Persian);
            Assert.AreEqual("سه هزار", res);
        }

        [Test]
        public void NumberToText_Should_Display_3020_Correctly()
        {
            var res = (3020).NumberToText(Language.Persian);
            Assert.AreEqual("سه هزار و بيست", res);
        }

        [Test]
        public void NumberToText_Should_Display_30000_Correctly()
        {
            var res = (30000).NumberToText(Language.Persian);
            Assert.AreEqual("سي هزار", res);
        }

        [Test]
        public void NumberToText_Should_Display_30110_Correctly()
        {
            var res = (30110).NumberToText(Language.Persian);
            Assert.AreEqual("سي هزار و يكصد و ده", res);
        }

        [Test]
        public void NumberToText_Should_Display_300000_Correctly()
        {
            var res = (300000).NumberToText(Language.Persian);
            Assert.AreEqual("سيصد هزار", res);
        }

        [Test]
        public void NumberToText_Should_Display_301010_Correctly()
        {
            var res = (301010).NumberToText(Language.Persian);
            Assert.AreEqual("سيصد و يك هزار و ده", res);
        }

        [Test]
        public void NumberToText_Should_Display_3000000_Correctly()
        {
            var res = (3000000).NumberToText(Language.Persian);
            Assert.AreEqual("سه ميليون", res);
        }

        [Test]
        public void NumberToText_Should_Display_3101010_Correctly()
        {
            var res = (3101010).NumberToText(Language.Persian);
            Assert.AreEqual("سه ميليون و يكصد و يك هزار و ده", res);
        }

        [Test]
        public void NumberToText_Should_Display_30000000_Correctly()
        {
            var res = (30000000).NumberToText(Language.Persian);
            Assert.AreEqual("سي ميليون", res);
        }

        [Test]
        public void NumberToText_Should_Display_30101010_Correctly()
        {
            var res = (30101010).NumberToText(Language.Persian);
            Assert.AreEqual("سي ميليون و يكصد و يك هزار و ده", res);
        }

        [Test]
        public void NumberToText_Should_Display_300000000_Correctly()
        {
            var res = (300000000).NumberToText(Language.Persian);
            Assert.AreEqual("سيصد ميليون", res);
        }

        [Test]
        public void NumberToText_Should_Display_310101010_Correctly()
        {
            var res = (310101010).NumberToText(Language.Persian);
            Assert.AreEqual("سيصد و ده ميليون و يكصد و يك هزار و ده", res);
        }

        [Test]
        public void NumberToText_Should_Display_3000000000_Correctly()
        {
            var res = (3000000000).NumberToText(Language.Persian);
            Assert.AreEqual("سه ميليارد", res);
        }

        [Test]
        public void NumberToText_Should_Display_Correctly()
        {
            var res = (3010101010).NumberToText(Language.Persian);
            Assert.AreEqual("سه ميليارد و ده ميليون و يكصد و يك هزار و ده", res);
        }

        [Test]
        public void NumberToText_Should_Display_30000000000_Correctly()
        {
            var res = (30000000000).NumberToText(Language.Persian);
            Assert.AreEqual("سي ميليارد", res);
        }

        [Test]
        public void NumberToText_Should_Display_31010101010_Correctly()
        {
            var res = (31010101010).NumberToText(Language.Persian);
            Assert.AreEqual("سي و يك ميليارد و ده ميليون و يكصد و يك هزار و ده", res);
        }

        [Test]
        public void NumberToText_Should_Display_300000000000_Correctly()
        {
            var res = (300000000000).NumberToText(Language.Persian);
            Assert.AreEqual("سيصد ميليارد", res);
        }

        [Test]
        public void NumberToText_Should_Display_301010101010_Correctly()
        {
            var res = (301010101010).NumberToText(Language.Persian);
            Assert.AreEqual("سيصد و يك ميليارد و ده ميليون و يكصد و يك هزار و ده", res);
        }

        [Test]
        public void NumberToText_Should_Display_3000000000000_Correctly()
        {
            var res = (3000000000000).NumberToText(Language.Persian);
            Assert.AreEqual("سه تريليون", res);
        }

        [Test]
        public void NumberToText_Should_Display_3101010101010_Correctly()
        {
            var res = (3101010101010).NumberToText(Language.Persian);
            Assert.AreEqual("سه تريليون و يكصد و يك ميليارد و ده ميليون و يكصد و يك هزار و ده", res);
        }
    }
}

