﻿using System;
using System.Collections.Generic;
namespace Cities.Comparers

{
    public class StateComparers : IComparer<City>
    {
        public int Compare (City x, City y)
        {
            return string.Compare(x.State, y.State);
        }

       
    }
    
}