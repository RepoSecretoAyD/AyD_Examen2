using System;
using System.Collections.Generic;

namespace AyD_Examen2.Template_Engine
{
    public class TemplateEngine
    {
        public static string Evaluate(string input, IDictionary<string, string> mapOfVariables)
        {
            var expressionsToTreat = new List<string>();
            while (input.Contains("{$"))
            {
                var value = input.Substring(input.IndexOf("{$", StringComparison.Ordinal)+2,
                    input.IndexOf("}", StringComparison.Ordinal) - (input.IndexOf("{$", StringComparison.Ordinal)+2));
                expressionsToTreat.Add(value);
                input = input.Replace("{$" + value + "}" + (value.Contains("{$") ? "}" : ""), "%%"+(expressionsToTreat.Count-1)+"%%");
            }
            var expressionsArray = expressionsToTreat.ToArray();
            for (var i = 0; i < expressionsArray.Length; i++)
            {
                try
                {
                    if (expressionsArray[i].Contains("{$"))
                    {
                        var secondValue = expressionsArray[i].Substring(2);
                        expressionsArray[i] = expressionsArray[i].Replace(secondValue, mapOfVariables[secondValue]);
                        input = input.Replace("%%" + i + "%%", expressionsArray[i] + "}");
                        continue;

                    }
                    input = input.Replace("%%" + i + "%%", mapOfVariables[expressionsArray[i]]);
                }
                catch (KeyNotFoundException)
                {
                    throw new MissingValueException(expressionsArray[i]);
                }
            }
            return input;
        }
    }
}
