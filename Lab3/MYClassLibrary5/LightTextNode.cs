﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    // Клас LightTextNode, що представляє текстовий вузол
    public class LightTextNode : LightNode
    {
        private string text;

        public LightTextNode(string text)
        {
            this.text = text;
        }

        public override string OuterHTML => text;
        public override string InnerHTML => text;
    }
}
