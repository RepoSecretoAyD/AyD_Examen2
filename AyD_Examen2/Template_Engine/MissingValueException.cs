using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyD_Examen2.Template_Engine
{
    public class MissingValueException : Exception
    {
        public MissingValueException(string missingValue) : base("Value representation for "+ missingValue + " not found!") {}

        public MissingValueException() : base("Value representation not found!") { }
    }
}
