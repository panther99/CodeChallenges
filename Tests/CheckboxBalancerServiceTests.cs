using System;
using Xunit;
using Library;

namespace Tests
{
    public class CheckboxBalancerServiceTests
    {
        private readonly CheckboxBalancerService _checkboxBalancerService;

        public CheckboxBalancerServiceTests()
        {
            _checkboxBalancerService = new CheckboxBalancerService();
        }

        [Fact]
        public void BalanceCheckbox_Test1()
        {
            var checkbox = @"1233.00
125 Hardware;! 24.8?;
123 Flowers 93.5
127 Meat 120.90
120 Picture 34.00
124 Gasoline 11.00
123 Photos;! 71.4?;
122 Picture 93.5
132 Tires;! 19.00,?;
129 Stamps 13.6
129 Fruits{} 17.6
129 Market;! 128.00?;
121 Gasoline;! 13.6?;
";

            var balancedCheckbox = @"Current balance: 1233.00
125 Hardware 24.80 Balance 1208.20
123 Flowers 93.50 Balance 1114.70
127 Meat 120.90 Balance 993.80
120 Picture 34.00 Balance 959.80
124 Gasoline 11.00 Balance 948.80
123 Photos 71.40 Balance 877.40
122 Picture 93.50 Balance 783.90
132 Tires 19.00 Balance 764.90
129 Stamps 13.60 Balance 751.30
129 Fruits 17.60 Balance 733.70
129 Market 128.00 Balance 605.70
121 Gasoline 13.60 Balance 592.10
Total expense: 640.90
Average expense: 53.41
";
            var result = _checkboxBalancerService.BalanceCheckbox(checkbox);

            Assert.Equal(balancedCheckbox, result);
        }

        [Fact]
        public void BalanceCheckbox_Test2()
        {
            var checkbox = @"2653.00
125 Milk;! 41.8?;
123 Flowers 87.5::
127 Weath 138.90{
120 Boxes 27.00
124 Documents 15.65#
123 Statues;! 66.0?;
122 Grid 92.5
132 Windows;! 29.15,?;
129 Envelopes 153.7
129 Vegetables{} 19.8
129 Ethereum;! 13.10?;
121 Alcohol;! 22.6?;
";
            var balancedCheckbox = @"Current balance: 2653.00
125 Milk 41.80 Balance 2611.20
123 Flowers 87.50 Balance 2523.70
127 Weath 138.90 Balance 2384.80
120 Boxes 27.00 Balance 2357.80
124 Documents 15.65 Balance 2342.15
123 Statues 66.00 Balance 2276.15
122 Grid 92.50 Balance 2183.65
132 Windows 29.15 Balance 2154.50
129 Envelopes 153.70 Balance 2000.80
129 Vegetables 19.80 Balance 1981.00
129 Ethereum 13.10 Balance 1967.90
121 Alcohol 22.60 Balance 1945.30
Total expense: 707.70
Average expense: 58.98
";
            var result = _checkboxBalancerService.BalanceCheckbox(checkbox);

            Assert.Equal(balancedCheckbox, result);
        }
    }
}
