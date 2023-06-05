using System;
using System.Collections.Generic;
using System.Text;

namespace ZealandClimate
{
    class IDBase
    {
        private int _id;
        private static int _nextID = 0;

        public IDBase()
        {
            _nextID++;
            _id = _nextID;
        }

        public int ID
        {
            get { return _id; }
        }

    }
    
    
}
