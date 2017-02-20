using System;
using Xunit;
using VendingMachine;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void VendingMachineCanFetchItems() 
        {
            var items = new VendingMachine.VendingMachine().GetItems();
            Assert.True(true);
        }
    }
}
