
using ConsoleApp1;
using System.Xml;




DtoXML dtoXML = new DtoXML();

XmlReader xmlReader = XmlReader.Create(@"C:\Users\Nikolay_Chuchunov\Downloads\xmlexpiriens\13.xml");

//XmlWriter xmlWriter = XmlWriter.Create(@"C:\Users\Nikolay_Chuchunov\Downloads\xmlexpiriens\13.xml");

// dtoXML.WriteXml(xmlWriter);

dtoXML.ReadXml(xmlReader);