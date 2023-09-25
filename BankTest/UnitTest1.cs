using Bank;

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KontoMitGuthabenErstellen()
        {
            //arrange
            int guthaben = 120;

            //act
            Bank.Konto konto1 = new Bank.Konto(guthaben);

            //assert
            Assert.AreEqual(konto1.Guthaben, guthaben);
        }

        [TestMethod]
        public void Einzahlen_KontoGuthaben()
        {
            //arrange
            int startguthaben = 100;
            Konto test = new Konto(startguthaben);

            //act
            int einzahlbetrag = 50;
            test.Einzahlen(einzahlbetrag);

            //assert
            Assert.AreEqual(startguthaben+einzahlbetrag, test.Guthaben);
        }
    }
}