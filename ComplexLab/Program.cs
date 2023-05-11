using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Web.Extension.dll;


using Lab_Atoms;
using System.Xml.Linq;

namespace Lab_Atoms
{
    internal class Program
    {
        static void WriteJson(List<Atom> atoms, string filename)
        {
            TextWriter writer = new StreamWriter(filename);
            writer.Write(JsonSerializer.Serialize(atoms));

            File.WriteAllText(filename, atoms);

        }

        static void ReadJson(string filename)
        {
            TextReader reader = new StreamReader(filename);
            Atom atom = JsonSerializer.Deserialize <Atom> (reader.ReadToEnd());

        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            File.ReadAllText(filename);
        }
        private static void DisplayAllElements()
        {
            foreach (Atom atom in )
            {
                Console.WriteLine(atom);
            }
        }





    }
}
