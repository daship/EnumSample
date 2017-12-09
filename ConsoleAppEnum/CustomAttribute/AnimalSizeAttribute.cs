using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEnum.CustomAttribute
{
    /// <summary>
    /// 這是動物尺寸
    /// </summary>
    public class AnimalSizeAttribute : Attribute
    {
        public string Description { get; set; }

        public AnimalSizeAttribute(string Description)
        {
            this.Description = Description;
        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
