
using Less13_Serialization;

Members memb = new Members();
ObjectExtentions.WriteToJsonFile<Members>(@"D:\TMS .Net\Less13_Serialization\Member", memb);

Members membRestored = ObjectExtentions.ReadFromJsonFile<Members>(@"D:\TMS .Net\Less13_Serialization\Member");
