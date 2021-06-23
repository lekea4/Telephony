using System;
using Telephony.Phone;

namespace Telephony
{
      static class Program
    {
        static void Main(string[] args)
        {
            BlockPhone tecnoPalasa = new("Camon One", "Tecno");
           
            tecnoPalasa.Charging();
            tecnoPalasa.ConnectToService();
            tecnoPalasa.MakeVoiceCall();
            tecnoPalasa.RecieveVoiceCall();
            Console.WriteLine(tecnoPalasa.PhoneName);
         
        }
    }
}
