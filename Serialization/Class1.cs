using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace Serialization
{
    public class SerializationAndDeserialization
    {
        public void SerializeBinary()
        {
            string empName = "Anush";
            string Company = "Kellton";
            string Phone = "8076485558";
            FileStream obj = new FileStream("F:\\132\\serialization.txt", FileMode.Create);
            BinaryFormatter Binaryformat = new BinaryFormatter();
            Binaryformat.Serialize(obj, empName);
            Binaryformat.Serialize(obj, Company);
            Binaryformat.Serialize(obj, Phone);
            obj.Close();
        }
        public void DeSerializeDataBinary()
        {

            FileStream fs = new FileStream("F:\\132\\serialization.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string data = "";
            data = (string)bf.Deserialize(fs);
            fs.Close();
            Console.WriteLine("Your deserialize data is ");
            Console.WriteLine(data);
        }


    }
    public class Json
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
    }
    
}