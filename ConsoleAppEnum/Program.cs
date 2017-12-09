using ConsoleAppEnum.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ConsoleAppEnum.CustomAttribute;

namespace ConsoleAppEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundsEnum animal_miao = SoundsEnum.Miao;
            SoundsEnum animal_wong = SoundsEnum.Wong;

            //get description
            string desc_animal_miao = Utility.EnumExt.GetAttributeFromEnum<DescriptionAttribute>(animal_miao).Description;
            string desc_animal_wong = Utility.EnumExt.GetAttributeFromEnum<DescriptionAttribute>(animal_wong).Description; ;
            Console.WriteLine(desc_animal_miao);
            Console.WriteLine(desc_animal_wong);

            //get color description
            string customColorDesc_animal_miao = Utility.EnumExt.GetAttributeFromEnum<AnimalColorAttribute>(animal_miao).ToString();
            string customColorDesc_animal_wong = Utility.EnumExt.GetAttributeFromEnum<AnimalColorAttribute>(animal_wong).ToString();
            Console.WriteLine(customColorDesc_animal_miao);
            Console.WriteLine(customColorDesc_animal_wong);


            //get size
            string customSizeDesc_animal_miao = Utility.EnumExt.GetAttributeFromEnum<AnimalSizeAttribute>(animal_miao).ToString();
            string customSizeDesc_animal_wong = Utility.EnumExt.GetAttributeFromEnum<AnimalSizeAttribute>(animal_wong).ToString();
            Console.WriteLine(customSizeDesc_animal_miao);
            Console.WriteLine(customSizeDesc_animal_wong);

            //get value
            Console.WriteLine((int)Utility.EnumExt.GetValueFromCustomDescription<AnimalSizeAttribute, SoundsEnum>(customSizeDesc_animal_miao));
            Console.WriteLine((int)Utility.EnumExt.GetValueFromCustomDescription<AnimalSizeAttribute, SoundsEnum>(customSizeDesc_animal_wong));


            //description
            Console.WriteLine((int)Utility.EnumExt.GetValueFromCustomDescription<DescriptionAttribute, SoundsEnum>("Cat"));

            Console.WriteLine("Done");
            Console.Read();
            
        }
    }
}
