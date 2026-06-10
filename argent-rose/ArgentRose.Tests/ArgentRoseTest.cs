
using NUnit.Framework;

namespace ArgentRose.Tests
{
    public class ArgentRoseTest
    {
        /*
         * Behavior: Update inventory
         * This will be executed at the end of each day
         * 
         * Small Behaviors:
                All the products in our inventory are valid.
                All products reduces selling by 1 (c1)
                2 products: Regular and Special
                Regular products: 
                    - Decrease in quality by 2 (c2)
                Special products:
                    - if selling greater than 5, quality increases by 1 (c3)
                    - if selling less or 5, quality increases by 3      (c4)
                    - If selling less or equals than 0, quality drops to 0  (c5)

        * Direct Inputs:
        Inventory

        * Direct Output: 
        Updated Inventory

        Examples:
        [] => []
        [{desc:"Theatre Pass", selling: 30, quality: 5}] => [{desc:"Theatre Pass", selling: 29, quality: 6}]   (c1, c3)
        [{desc:"Theatre Pass", selling: 5, quality: 5}] => [{desc:"Theatre Pass", selling: 4, quality: 8}]   (c1, c4)
        [{desc:"Theatre Pass", selling: 0, quality: 5}] => [{desc:"Theatre Pass", selling: -1, quality: 0}]   (c1, c5)
        [{desc:"Other Product", selling: 30, quality: 5}] => [{desc:"Other Product", selling: 29, quality: 3}]   (c1, c2)

        */


        [Test]
        public void Think_A_Good_Name_And_Change_It()
        {
            Assert.That(false, Is.True);
        }
    }
}
