using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Observer
{
    public class Service
    {
        public delegate void OpenEventHandler();
        public event OpenEventHandler Opened;

        public void Open()
        {
            Opened();
        }
    }
}
