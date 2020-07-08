using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoCStringMod.BusinessLogic
{
    public class TextReverser : ITextModifier
    {
        private IInputGenerator myGenerator;
        public TextReverser(IInputGenerator generator)
        {
            myGenerator = generator;
        }
        public string ModifyText()
        {
            string data = myGenerator.GetInput();
            char[] cArray = data.ToCharArray();
            Array.Reverse(cArray);
            return new string(cArray);
        }
    }
}
