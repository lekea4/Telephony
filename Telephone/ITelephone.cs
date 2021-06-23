using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony.Telephone
{
    interface ITelephone
    {

        string Keypad { get; set; }

        char RingTone { get; set; }
        char Model { get; }

        void MakeVoiceCall();


        void RecieveVoiceCall();


        void ConnectToService();
        

        void ConnectToPower();

        
    }
}
