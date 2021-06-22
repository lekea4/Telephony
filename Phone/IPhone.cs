using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Telephone;

namespace Telephony.Phone
{
    interface IPhone : ITelephone
    {
        string Battery { get; }
        string Screen { get; set; }
        string SimHolder { get; set; }

        void Sms();

        void Charging();

    }
}
