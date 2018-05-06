using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LINQQuery
{
    public static class CdCollection
    {       
        static List<CD> cdList;
        static CdCollection()
        {
            CreateCdList();
        }
        private static void CreateCdList()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CD>));
            using (FileStream fs = new FileStream("cd_catalog1.xml", FileMode.Open))
            {
                cdList = serializer.Deserialize(fs) as List<CD>;
            }
        }
        public static IReadOnlyList<CD> GetCDs()
        {
            return cdList;
        }
        
    }
}
