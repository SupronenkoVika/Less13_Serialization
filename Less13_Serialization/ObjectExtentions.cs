using Newtonsoft.Json;

namespace Less13_Serialization
{
    public class ObjectExtentions
    {
        //public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        //{
        //    using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
        //    {
        //        var binaryFormater = new BinaryFormatter();
        //        binaryFormater.Serialize(stream, objectToWrite);
        //    }
        //}

        //public static T ReadFromBinaryFile<T>(string filePath)
        //{
        //    using (Stream stream = File.Open(filePath, FileMode.Open))
        //    {
        //        var binaryFormater = new BinaryFormatter();
        //        return (T)binaryFormater.Deserialize(stream);
        //    }
        //}

        public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = System.Text.Json.JsonSerializer.Serialize(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public static T ReadFromJsonFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
