using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ProxyImage : IImage
    {
        private RealImage _RealImage;
        private string _fileName;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }
        public void Display()
        {
            if(_RealImage == null)
            {
                _RealImage = new RealImage(_fileName);
            }
            _RealImage.Display();
        }
    }
}
