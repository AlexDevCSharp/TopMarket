﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopMarket.Client.Helpers
{
    public class MultipleSelectorModel
    {
        public MultipleSelectorModel(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}
