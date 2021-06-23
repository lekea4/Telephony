using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Telephony.Phone
{
    class BlockPhone : MobilePhone 
    {
        private readonly string _phoneName;
        private readonly string _phoneBrand;

        public string PhoneName
        {
            get => _phoneName
        }

        public string PhoneBrand
        {
            get => _phoneBrand;
        }

        

        public BlockPhone(string phoneName, string phoneBrand)
        {
            _phoneName = phoneName;
            _phoneBrand = phoneBrand;
        }

    }
}
