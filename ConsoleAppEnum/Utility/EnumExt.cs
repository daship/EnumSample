using ConsoleAppEnum.CustomAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEnum.Utility
{
    public static class EnumExt
    {
        public static E GetValueFromCustomDescription<A, E>(this string description) 
          where A : System.Attribute
          where E:  IComparable, IFormattable, IConvertible //enum
        {
            var type = typeof(E);
            string attribute_description = string.Empty;
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(A)) as A;
                if (attribute != null)
                {
                    if (typeof(A) == typeof(DescriptionAttribute))
                        attribute_description = (attribute as DescriptionAttribute).Description;
                    else
                        //需確定客製化的attribute是否有overwite tostring
                        attribute_description = attribute.ToString();

                    if (attribute_description == description)
                        return field.GetValue(null).GetJsonString().JsonConvertToModel<E>();
                }
                else
                {
                    if (field.Name == description)
                        return field.GetValue(null).GetJsonString().JsonConvertToModel<E>();
                }
            }
            throw new ArgumentException("Not found.", "description");
            // or return default(T);
        }

        public static T GetAttributeFromEnum<T>(this System.Enum enumVal) where T : System.Attribute
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }
    }
}
