using System;

namespace Library
{
    public class StringDiamondService
    {
        public string GenerateDiamond(int width)
        {
            if (width % 2 == 0 || width < 0)
            {
                return null;
            }

            string diamond = "";

            for (int i = width / 2; i >= -(width / 2); i--)
            {
                string spaces = new String(' ', Math.Abs(i));
                string stars = new String('*', width - Math.Abs(i * 2));
                diamond += spaces + stars + spaces + "\n";
            }

            return diamond;
        }
    }
}
