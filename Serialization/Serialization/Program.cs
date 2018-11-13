using System;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Cloth[] cloths = new Cloth[5]
            {
                new Cloth { Color = "Red", Gender = "Male", Size = 42, Style = "Asav"},
                new Cloth { Color = "Green", Gender = "Female", Size = 36, Style = "Mads"},
                new Cloth { Color = "Blue", Gender = "Male", Size = 43, Style = "LoaS"},
                new Cloth { Color = "Pink", Gender = "Female", Size = 34, Style = "Wani"},
                new Cloth { Color = "Yellow", Gender = "Male", Size = 40, Style = "Vasf"}
            };

             DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Cloth[]));

            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, cloths);
            }

            Console.WriteLine("Serialization is done!");
            Console.ReadKey();

        }
    }
}
