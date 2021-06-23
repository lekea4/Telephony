using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Telephone;

namespace Telephony.Phone
{
    public abstract class MobilePhone :  IPhone
    {
        public string Keypad { get; set; }
        public char RingTone { get; set ; }

        public string Battery { get; set; }

        public string Screen { get; set; }

        public string SimHolder { get; set; }

        public char Model { get; }

        public void Charging()
        {
            Console.WriteLine("This phone can has an in built battery and does not need to constantly be connected to a power source ");


        }

        public void ConnectToPower()
        {
            // Method intentionally left empty.
        }

        public void ConnectToService()
        {
            Console.WriteLine("This phone is connected to a carrier service ");
        }

        public void MakeVoiceCall()
        {
            Console.WriteLine("This phone can make a phone call");
        }

        public void RecieveVoiceCall()
        {
            Console.WriteLine("This phone can receive calls");
        }

        public void Sms()
        {
            Console.WriteLine("This phone can send and receive SMS");
        }
    }
}
