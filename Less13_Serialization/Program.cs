
using Less13_Serialization;

Members memb = new Members();
ObjectExtentions.WriteToJsonFile<Members>(@"D:\TMS .Net\Less13_Serialization\Less13_Serialization\Member.json", memb);

Squad squadRestored = ObjectExtentions.ReadFromJsonFile<Squad>(@"D:\TMS .Net\Less13_Serialization\Less13_Serialization\SuperHeroSquad.json");

ObjectExtentions.WriteToXmlFile<Squad>(@"D:\TMS .Net\Less13_Serialization\Less13_Serialization.XmlFile.xml", squadRestored);