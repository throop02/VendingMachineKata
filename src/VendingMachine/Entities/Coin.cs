namespace VendingMachine.Entities
{
    public class Coin
    {
        public int Size { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }
        public decimal Denomination { get; set; }
        public bool RejectCoin { get; set; }
    }
}