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

            IEnumerable enumerable = model as IEnumerable;

            if (enumerable != null)
            {
                result.Append("[");
                foreach (var item in enumerable)
                {
                   ConvertProperties(item, result);
                }
                result.Remove(result.Length - 1, 1);
                result.Append("]");
            }

            else
            {
                ConvertProperties(model, result);
                result.Remove(result.Length - 1, 1);
            }
            return result.ToString();
        }
        private void ConvertProperties(object model, StringBuilder stringBuilder)
        {
            Type modelType = model.GetType();
            var properties = modelType.GetProperties();
            stringBuilder.Append("{");
            foreach (var property in properties)
            {
                if (!property.IsDefined(typeof(MyIgnoreAttribute), false))
                {
                    stringBuilder.Append($"\"{property.Name}\": \"{property.GetValue(model)}\",");
                }
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            stringBuilder.Append("},");
        }
    }
}


