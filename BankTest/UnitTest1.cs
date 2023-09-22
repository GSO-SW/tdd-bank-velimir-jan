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
    }
}