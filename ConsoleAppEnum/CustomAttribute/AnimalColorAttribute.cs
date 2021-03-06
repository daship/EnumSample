﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEnum.CustomAttribute
{
    /// <summary>
    /// 這是動物顏色
    /// </summary>
    public class AnimalColorAttribute : Attribute
    {
        public string Description { get; set; }

        public AnimalColorAttribute(string Description)
        {
            this.Description = Description;
        }

        public override string ToString()
        {
            return this.Description;
        }

    }
}
