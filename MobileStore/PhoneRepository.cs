using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MobileStore
{
    public static class PhoneRepository
    {
        
        public static BindingList<PhoneInfo> phones;
        public static BindingList<Option> options;
        static PhoneRepository()
        {
            phones = new BindingList<PhoneInfo>()
            {
                new PhoneInfo(){Id = 1, Model = "Samsung Galaxy S8 DualSim 64 GB", OS = "Android", Processor = "Exynos 8895", Price = 1639.00m, Picture = "Samsung Galaxy S8.jpg" },
                new PhoneInfo(){Id = 2, Model = "Apple iPhone X 64GB", OS = "Apple iOS", Processor = "Apple A11 Bionic", Price = 2500.00m, Picture = "Iphone X.jpeg" },
                new PhoneInfo(){Id = 3, Model = "Xiaomi Redmi 4X 16GB Black", OS = "Android", Processor = "Qualcomm Snapdragon", Price = 410.00m, Picture = "Redmi 4x.jpg" },
                new PhoneInfo(){Id = 4, Model = "HTC One X10", OS = "Android", Processor = "Mediatek", Price = 520.00m, Picture = "HTC One X.jpg" },
                new PhoneInfo(){Id = 5, Model = "Sony Xperia XA2 Dual 32GB", OS = "Android", Processor = "Qualcomm Snapdragon", Price = 1019.16m, Picture = "Sony Xperia.jpg" },
            };

            options = new BindingList<Option>()
            {
                new Option(){OptionName = "WiFi"},
                new Option(){OptionName = "GPS"},
                new Option(){OptionName = "Bluetooth"},
                new Option(){OptionName = "Dual SIM"}
            };
        }
        public static void AddPhone(PhoneInfo phone)
        {
            phones.Add(phone);
        }
        public static void DeletePhone(PhoneInfo phone)
        {
            phones.Remove(phone);
        }
        public static IReadOnlyList<PhoneInfo> GetListOfPhones()
        {
            return phones;
        }
        public static void SavePhones()
        {           
            using (FileStream fs = new FileStream("phones.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<PhoneInfo>));
                serializer.Serialize(fs, phones);
            }
        }
        public static IReadOnlyList<PhoneInfo> LoadPhones()
        {
            
            using (FileStream fs = new FileStream("phones.xml", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<PhoneInfo>));
                phones = serializer.Deserialize(fs) as BindingList<PhoneInfo>;
            }
            return phones;
        }
        public static void SaveOptions()
        {
            using (FileStream fs = new FileStream("Options.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Option>));
                serializer.Serialize(fs, options);
            }
        }
        public static IReadOnlyList<Option> LoadOptions()
        {
            using(FileStream fs = new FileStream("Options.xml", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Option>));
                options = serializer.Deserialize(fs) as BindingList<Option>;
            }
            return options;
        }
        public static void AddOption(string optionName)
        {
            Option op = new Option() { OptionName = optionName };
            options.Add(op);
            SaveOptions();
        }
        public static IReadOnlyList<Option> GetOptions()
        {
            return options;
        }
    }
}
