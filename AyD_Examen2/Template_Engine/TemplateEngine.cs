using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace AyD_Examen2.Template_Engine
{
    public class TemplateEngine
    {
        public static string Evaluate(string input, IDictionary<string, string> mapOfVariables)
        {
            var expressionsToTreat = new List<string>();
            while (input.Contains("{$"))
            {
                var value = input.Substring(input.IndexOf("{$", StringComparison.Ordinal),
                    input.IndexOf("}", StringComparison.Ordinal) - input.IndexOf("{$", StringComparison.Ordinal));
                value = value.Substring(2, value.Length - 2);
                expressionsToTreat.Add(value);
                input = input.Replace("{$" + value + "}", "%%"+(expressionsToTreat.Count-1)+"%%");
                if (value.Contains("{$"))
                {
                    input = input.Remove(input.IndexOf("}", StringComparison.Ordinal), 1);
                }
            }
            var expressionsArray = expressionsToTreat.ToArray();
            for (var i = 0; i < expressionsArray.Length; i++)
            {
                if (expressionsArray[i].Contains("{$"))
                {
                    var secondValue = expressionsArray[i].Substring(2);
                    try
                    {
                        expressionsArray[i] = expressionsArray[i].Replace(secondValue, mapOfVariables[secondValue]);
                        input = input.Replace("%%" + i + "%%", expressionsArray[i] + "}");
                        continue;
                    }
                    catch (KeyNotFoundException ex)
                    {
                        throw new MissingValueException(expressionsArray[i]);
                    }
                }
                try
                {
                    input = input.Replace("%%" + i + "%%", mapOfVariables[expressionsArray[i]]);
                }
                catch (KeyNotFoundException ex)
                {
                    throw new MissingValueException(expressionsArray[i]);
                }
            }
            return input;
        }
    }
}
