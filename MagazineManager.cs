using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Task2
{
    internal class MagazineManager
    {
        public static void SerializeToXML(Magazine magazine, string path)
        {
            ArgumentNullException.ThrowIfNull(magazine);
            ArgumentNullException.ThrowIfNull(path);

            var xmlSerializer = new XmlSerializer(typeof(Magazine));
            using FileStream fileStream = new(path, FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fileStream, magazine);
        }

        public static void SerializeMagazinesToXML(Magazine[] magazine, string path)
        {
            ArgumentNullException.ThrowIfNull(magazine);
            ArgumentNullException.ThrowIfNull(path);

            var xmlSerializer = new XmlSerializer(typeof(Magazine[]));
            using FileStream fileStream = new(path, FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fileStream, magazine);
        }

        public static Magazine Deserialize(string path)
        {
            ArgumentNullException.ThrowIfNull(path);
            if(!File.Exists(path)) throw new FileNotFoundException();

            var formatter = new XmlSerializer(typeof(Magazine));
            using FileStream fileStream = new(path, FileMode.Open);
            return formatter.Deserialize(fileStream) as Magazine ?? throw new XmlException();
        }

        public static Magazine[] DeserializeMagazines(string path)
        {
            ArgumentNullException.ThrowIfNull(path);
            if (!File.Exists(path)) throw new FileNotFoundException();

            var formatter = new XmlSerializer(typeof(Magazine[]));
            using FileStream fileStream = new(path, FileMode.Open);
            return formatter.Deserialize(fileStream) as Magazine[] ?? throw new XmlException();
        }
    }
}
