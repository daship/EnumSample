using ConsoleAppEnum.CustomAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEnum.Enums
{
    public enum SoundsEnum
    {
        [AnimalColorAttribute("Tiger Color")]
        [Description("Cat")]
        Miao = 2,
        [AnimalColorAttribute("Black Color")]
        [Description("Dog")]
        Wong = 3
    }
}
