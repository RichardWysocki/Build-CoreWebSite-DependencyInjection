using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Shared
{
    public class SiteCounter : ISiteCounter
    {
        public int _counter { get; set; }
 
        public void AddCounter()
        {
            _counter++;
        }

        public int GetCounter()
        {
            return _counter;
        }
    }
}
