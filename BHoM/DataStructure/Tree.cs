﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.DataStructure
{
    public class Tree<T>
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public Dictionary<string, Tree<T>> Children { get; set; } = new Dictionary<string, Tree<T>>();

        public string Name { get; set; } = "";

        public T Value { get; set; } = default(T);


        /***************************************************/
    }
}
