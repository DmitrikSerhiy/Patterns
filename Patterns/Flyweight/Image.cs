using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Image //this class emulates a high-cost memory class f.e. download image
    {
        private string ImageName;
        public static int LoadCount { get; private set; } = 0;

        public Image()
        {
            ImageName = "It's big Image";
        }
        
        public static Image Load()//that's just simple example
        {
            LoadCount++;
            return new Image();
        }
    }
}
