using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SmartCityWPF.Models;

namespace SmartCityWPF.Data
{
    class Repository
    {
        //følgende to funktioner at skrevet med udgangspunkt i løsningsforslag til agent assignment udleveret i GUI undervisningen
        internal static void ReadFile(string fileName, out ObservableCollection<Lokationer> lokationer)
        {
            // Create an instance of the XmlSerializer class and specify the type of object to deserialize.
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Lokationer>));
            TextReader reader = new StreamReader(fileName);
            // Deserialize all the varroataellinger.
            lokationer = (ObservableCollection<Lokationer>)serializer.Deserialize(reader);
            reader.Close();
        }

        internal static void SaveFile(string fileName, ObservableCollection<Lokationer> lokationer)
        {
            // Create an instance of the XmlSerializer class and specify the type of object to serialize.
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Lokationer>));
            TextWriter writer = new StreamWriter(fileName);
            // Serialize all the varroataellinger.
            serializer.Serialize(writer, lokationer);
            writer.Close();
        }
    }
}
