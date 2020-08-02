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
            StringBuilder result = new StringBuilder("[ ");

            IEnumerable enumerable = (model as IEnumerable);

            if (enumerable != null)
            {
                foreach (var item in enumerable)
                {
                    Type type = item.GetType();
                    var properties = type.GetProperties();

                    foreach (var property in properties)
                    {
                        if (!property.IsDefined(typeof(MyIgnoreAttribute), false))
                        {
                            result.Append($"{{\"{property.Name}\": \"{property.GetValue(item)}\"}},");
                        }
                    }
                }
            }

            else
            {
                Type modelType = model.GetType();
                var properties = modelType.GetProperties();

                foreach (var property in properties)
                {
                    if (!property.IsDefined(typeof(MyIgnoreAttribute), false))
                    {
                        result.Append($"{{\"{property.Name}\": \"{property.GetValue(model)}\"}},");
                    }
                }
            }
            result.Append(" ]");

            return result.ToString();
        }
    }
}