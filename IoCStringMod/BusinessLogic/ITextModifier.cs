using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoCStringMod.BusinessLogic
{
    public interface ITextModifier
    {
        string ModifyText();
    }
}
