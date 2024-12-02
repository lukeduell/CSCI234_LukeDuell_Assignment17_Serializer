using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CSCI234_LukeDuell_Assignment17_3
{
    [Serializable]
    public class RecordSerializable
    {
        public string FirstandLast { get; set; }
        public int id { get; set; }
        public string STDNTclass { get; set; }
        public string GRADE { get; set; }


        public RecordSerializable(string firstandlast, int ID, string Stdntclass, string grade)
        {
            FirstandLast = firstandlast;
            id = ID;
            STDNTclass = Stdntclass;
            GRADE = grade;
        }

    }
    class Program
    {
        

        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "test.txt"))
            {
                writer.WriteLine("Jones, Bob: 1 Introduction to Computer Science A-");
                writer.WriteLine("Johnson, Sara: 2 Data Structures B+");
                writer.WriteLine("Smith, Sam: 3 Data Structures C");
            }
            // Read a file
            string readText = File.ReadAllText(Environment.CurrentDirectory + "test.txt");
            Console.WriteLine(readText);
        }
    }
}
