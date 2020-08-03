using BusinessLayer.Attributes;
using BusinessLayer.Interfaces;
using System;
using System.Collections;
using System.Text;

namespace BusinessLayer
{
    public class JSonConvertor : IJsonConvertor
    {
        public string Convert(object model)
        {
            StringBuilder result = new StringBuilder();
            string temp;

            IEnumerable enumerable = model as IEnumerable;

            if (enumerable != null)
            {
                result.Append("[");
                foreach (var item in enumerable)
                {
                    temp = ConvertProperties(item);
                    result.Append(temp);
                }
                result.Append("]");
            }

            else
            {
                temp = ConvertProperties(model);
                result.Append(temp);
            }

            return result.ToString();
        }
        public static string ConvertProperties(object model)
        {
            Type modelType = model.GetType();
            var properties = modelType.GetProperties();
            StringBuilder result = new StringBuilder("{");

            foreach (var property in properties)
            {
                if (!property.IsDefined(typeof(MyIgnoreAttribute), false))
                {
                    result.Append($"\"{property.Name}\": \"{property.GetValue(model)}\",");
                }
            }
            result.Append("}");

            return result.ToString();
        }
    }
}


