using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XMLÖvning
{
    class Program
    {
        static void Main(string[] args)
        {

            NPC villageMayor = new NPC();

            Console.WriteLine("What is the NPC's name?");
            villageMayor.name = Console.ReadLine();

            Console.WriteLine("What is his/hers age?");
            villageMayor.age = Console.ReadLine();

            Console.WriteLine("What will he say when greeting you?");
            villageMayor.greeting = Console.ReadLine();


            XmlSerializer npcSerializer = new XmlSerializer(typeof(NPC));

            using (FileStream file = File.Open(@"npc.xml", FileMode.OpenOrCreate))

            {

            npcSerializer.Serialize(file, villageMayor);

            }

            



        }
    }
}
