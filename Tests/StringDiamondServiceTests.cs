using System;
using Xunit;
using Library;

namespace Tests
{
    public class StringDiamondServiceTests
    {
        private readonly StringDiamondService _stringDiamondService;

        public StringDiamondServiceTests()
        {
            _stringDiamondService = new StringDiamondService();
        }

        [Fact]
        public void GenerateDiamond_InputIs1()
        {
            var result = _stringDiamondService.GenerateDiamond(1);
            var asterixDiamond = @"*
";

            Assert.Equal(asterixDiamond, result);
        }

        [Fact]
        public void GenerateDiamond_InputIs3()
        {
            var result = _stringDiamondService.GenerateDiamond(3);
            var asterixDiamond = @" * 
***
 * 
";

            Assert.Equal(asterixDiamond, result);
        }

        [Fact]
        public void GenerateDiamond_InputIs9()
        {
            var result = _stringDiamondService.GenerateDiamond(9);
            var asterixDiamond = @"    *    
   ***   
  *****  
 ******* 
*********
 ******* 
  *****  
   ***   
    *    
";

            Assert.Equal(asterixDiamond, result);
        }

        [Fact]
        public void GenerateDiamond_InputIs11()
        {
            var result = _stringDiamondService.GenerateDiamond(11);
            var asterixDiamond = @"     *     
    ***    
   *****   
  *******  
 ********* 
***********
 ********* 
  *******  
   *****   
    ***    
     *     
";

            Assert.Equal(asterixDiamond, result);
        }
    }
}
