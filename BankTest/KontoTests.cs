namespace BankTests
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void Konto_WirdMitGuthabenErstellt()
        {
            //arrange
            int guthaben = 120;

            //act
            Bank.Konto konto1 = new Bank.Konto(guthaben);

            //assert
            Assert.AreEqual(konto1.Guthaben, guthaben);
        }

        [TestMethod]
        public void Konto_GuthabenVerringertSich()
        {
            //arrange
            int guthaben = 200;
            int auszahlen = 150;
            int sollEndGuthaben = 50;

            Bank.Konto konto2 = new Bank.Konto(guthaben);

            //act
            konto2.Auszahlen(auszahlen);

            //assert
            Assert.AreEqual(konto2.Guthaben, sollEndGuthaben);
        }
    }
}