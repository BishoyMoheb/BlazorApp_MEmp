using Microsoft.AspNetCore.Components.Forms;//To use InputSelect<TValue>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gen_RCLib
{
    public class RCL_Cust_InputSelect<TValue> : InputSelect<TValue>
    {
        protected override bool TryParseValueFromString(string valueTobeParsed,
                                out TValue TVResult, out string validationErrorMessage)
        {
            if (typeof(TValue) == typeof(int))
            {
                if (int.TryParse(valueTobeParsed, out var intResult))
                {
                    TVResult = (TValue)(object)intResult;
                    validationErrorMessage = null;
                    return true;
                }
                else
                {
                    TVResult = default;
                    validationErrorMessage = $"The selected value {valueTobeParsed} "
                                             + "is not a valid number";
                    return false;
                }
            }
            return base.TryParseValueFromString(valueTobeParsed, out TVResult, out validationErrorMessage);
        }
    }
}
