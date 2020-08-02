using BusinessLayer.Attributes;
using BusinessLayer.Interfaces;
using System;
using System.Collections;

namespace BusinessLayer
{
    public class JSonConvertor : IJsonConvertor
    {
        public string Convert(object model)
        {
            string result = "[";
            IEnumerable enumerable = (model as IEnumerable);

            if (enumerable != null)
            {
                foreach (var item in enumerable)
                {
                    Type type = item.GetType();
                    var properties = type.GetProperties(); 
                    
                    foreach(var property in properties)
                    {
                        if(!property.IsDefined(typeof(MyIgnoreAttribute), false))
                        {
                            result += "{";
                            result += $"\"{property.Name}\": ";
                            result += $"\"{property.GetValue(item)}\"";
                            result += "},";
                        }
                    }
                }
            }
            result += " ]";
            
            return result;
        }
    }
}