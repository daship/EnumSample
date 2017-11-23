using ConsoleAppEnum.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundsEnum animal_miao = SoundsEnum.Miao;
            SoundsEnum animal_wong = SoundsEnum.Wong;

            //get description
            string desc_animal_miao = Utility.EnumExt.GetDescriptionFromValue(animal_miao);
            string desc_animal_wong = Utility.EnumExt.GetDescriptionFromValue(animal_wong);
            Console.WriteLine(desc_animal_miao);
            Console.WriteLine(desc_animal_wong);

            //get value
            Console.WriteLine((int)Utility.EnumExt.GetValueFromDescription<SoundsEnum>(desc_animal_miao));
            Console.WriteLine((int)Utility.EnumExt.GetValueFromDescription<SoundsEnum>(desc_animal_wong));

            //get custom description
            string customDesc_animal_miao = Utility.EnumExt.GetCustomDescriptionFromValue(animal_miao);
            string customDesc_animal_wong = Utility.EnumExt.GetCustomDescriptionFromValue(animal_wong);
            Console.WriteLine(customDesc_animal_miao);
            Console.WriteLine(customDesc_animal_wong);

            Console.WriteLine("Done");
            Console.Read();
            
        }
    }
}
