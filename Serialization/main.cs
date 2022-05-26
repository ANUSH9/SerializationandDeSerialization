using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;
using System.IO;
using System.Text.Json;

namespace Serialization
{
    public class main
    {
        public static void Main()
        {
            SerializationAndDeserialization obj = new SerializationAndDeserialization();
            obj.SerializeBinary();
            obj.DeSerializeDataBinary();


            var weatherForecast = new Json
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);

            Console.WriteLine(jsonString);


            
        }


    }
}
