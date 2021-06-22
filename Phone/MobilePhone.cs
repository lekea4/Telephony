using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Telephone;

namespace Telephony.Phone
{
    abstract class MobilePhone :  IPhone
    {
        public string Keypad { get; set; }
        public char RingTone { get; set ; }

        public string Battery { get; }

        public string Screen { get; set; }
        public string SimHolder { get; set; }

        public char Model { get; }

        public void Charging()
        {
            // Method intentionally left empty.
        }

        public void ConnectToPower()
        {
            // Method intentionally left empty.
        }

        public void ConnectToService()
        {
            // Method intentionally left empty.
        }

        public void MakeVoiceCall()
        {
            // Method intentionally left empty.
        }

        public void RecieveVoiceCall()
        {
            // Method intentionally left empty.
        }

        public void Sms()
        {
            // Method intentionally left empty.
        }
    }
}
