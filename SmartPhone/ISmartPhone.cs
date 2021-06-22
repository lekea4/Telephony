using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Phone;

namespace Telephony.SmartPhone
{
    interface ISmartPhone : IPhone
    {

        char Gps { get; }

        char Camera { get; }

        void MMS();

        void Browsing();


    }
}
