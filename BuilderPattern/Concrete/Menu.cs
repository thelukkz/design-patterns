﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Concrete
{
    class Menu
    {
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public void Add(string part)
        {
            _parts.Add(part, part);
        }

        public override string ToString()
        {
            return String.Join(", ", _parts.Values);
        }
    }
}
