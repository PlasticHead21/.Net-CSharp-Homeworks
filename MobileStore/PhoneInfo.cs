using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;

namespace MobileStore
{
   [Serializable]
    public class PhoneInfo
    {
  
        public int Id{ get; set; }
   
        public string Model { get; set; }
    
        public string OS { get; set; }
   
        public string Processor { get; set; }
 
        public decimal Price { get; set; }

        public string Picture { get; set; }

        public BindingList<Option> options;
        public PhoneInfo()
        {
            options = new BindingList<Option>();
        }
        public IReadOnlyList<Option> GetPhoneOptions()
        {
            return options;
        }
    }
}
