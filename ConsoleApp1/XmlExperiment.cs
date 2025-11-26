using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    // создать клас для чтения и записи XML

    internal class DtoXML
    {
        string Surname { get; set; }
        string Name { get; set; }

        string BancAccount { get; set; }

        public void ReadXml(XmlReader xml)
        {
            

            while (xml.Read())
            {
                if (xml.NodeType == XmlNodeType.Element) 
                {

                     // string r1 = xml.ReadContentAsString();
                    string r2 = xml.ReadElementContentAsString();
                    Console.WriteLine($"ReadContentAsString  ReadElementContentAsStringc {r2}");
                   

                }


                xml.Read();

            }

        }



        public void WriteXml(XmlWriter xml)
        {
         
            xml.WriteStartDocument();
            xml.WriteStartElement("DtoXML");
            xml.WriteElementString("surname", "surname1");
            xml.WriteElementString("name", "name1");

            xml.WriteEndElement();
            
            xml.WriteEndDocument();
            xml.Close();

        }
    }

    internal class XmlExperiment
    { 
        




    }
}
