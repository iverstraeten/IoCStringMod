using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCStringMod.BusinessLogic
{
    public class TextScriptkiddify : ITextModifier
    {
        private IInputGenerator mygen;
        public TextScriptkiddify(IInputGenerator gen)
        {
            mygen = gen;
        }
        public string ModifyText()
        {
            string data = mygen.GetInput();
            string newString = string.Concat(
                data.ToLower().AsEnumerable().Select((c, i) => i % 2 == 0 ? c : char.ToUpper(c)));
            return newString;
        }
    }
}
