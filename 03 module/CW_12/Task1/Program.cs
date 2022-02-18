using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using System.Text.Json.Serialization;

namespace Task1
{
    [Serializable]
    public class Student
    {
        public string LastName { get; set; }
        public int Course { get; set; }

        public Student(string lastName, int course)
        {
            LastName = lastName;
            Course = course;
        }

        public Student()
        {
        }
    }

    [Serializable]
    public class Group
    {
        public string Title { get; set; }
        
        [JsonInclude]
        public List<Student> Students = new List<Student>();

        public Group(string title)
        {
            Title = title;
        }

        public Group()
        {
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var student in Students)
            {
                stringBuilder.Append("\t" + student.LastName + " " + student.Course + "\n");
            }
            return stringBuilder.ToString();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group("group 1")
            {
                Students = {new Student("Mike", 1), 
                    new Student("Bob", 2)}
            };
            var group2 = new Group("group 2")
            {
                Students = {new Student("Dany", 3), 
                    new Student("Michael", 4)}
            };
            Console.WriteLine("*********XML*********");
            SerializeUsingXML(new []{group1, group2});
            Console.WriteLine("*********JSON********");
            SerializeUsingJSON(new []{group1, group2});
        }

        static void SerializeUsingXML(Group[] groups)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Group[]));
            using (FileStream file = new FileStream("output.txt", FileMode.Create))
            {
                xmlSerializer.Serialize(file, groups);
            }
            using (FileStream file = new FileStream("output.txt", FileMode.Open))
            {
                groups = (Group[])xmlSerializer.Deserialize(file);
                if (groups!=null)
                    Array.ForEach(groups, group => Console.WriteLine(group));
            }
        }
        
        static void SerializeUsingJSON(Group[] groups)
        {
            var jsonGroup = JsonSerializer.Serialize(groups);
            using (StreamWriter file = new StreamWriter("output_json.txt"))
            {
                file.WriteLine(jsonGroup);
            }

            using (StreamReader file = new StreamReader("output_json.txt"))
            {
                jsonGroup = file.ReadToEnd();
                groups = (Group[]) JsonSerializer.Deserialize(jsonGroup, typeof(Group[]));
                if (groups!=null)
                    Array.ForEach(groups, group => Console.WriteLine(group));
            }
        }
    }
}