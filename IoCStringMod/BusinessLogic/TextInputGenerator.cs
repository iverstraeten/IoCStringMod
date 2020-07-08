using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoCStringMod.BusinessLogic
{
    public class TextInputGenerator : IInputGenerator
    {
        public string GetInput()
        {
            return "This is my string";
        }
    }
}
