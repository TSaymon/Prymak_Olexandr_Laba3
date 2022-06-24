using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dictionary = new Dictionary<List<string>, string>();

            var studentsOfFirstCourse = new List<string>()
            {
                "Mark","Milly","Melissa"
            };
            var studentsOfSecondCourse = new List<string>()
            {
                "Bella","Danny","Maggy"
            };
            var studentsOfThirdCourse = new List<string>()
            {
                "Richard","Olaf","Emily"
            };

            dictionary.Add(studentsOfThirdCourse, "3 Course");
            dictionary.Add(studentsOfFirstCourse, "1 Course");
            dictionary.Add(studentsOfSecondCourse, "2 Course");

            Console.WriteLine("Before sort: ");
            foreach (var pair in dictionary)
                Console.WriteLine("Value: " + pair.Value);
            dictionary = Sort(dictionary);

            Console.WriteLine("After sort: ");
            foreach (var pair in dictionary)
                Console.WriteLine("Value: " + pair.Value);
            SerializeDictionary(dictionary);
        }

        private static Dictionary<List<string>, string> Sort(Dictionary<List<string>, string> dictionary)
        {
            dictionary = dictionary.OrderBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            return dictionary;
        }

        private static void SerializeDictionary(Dictionary<List<string>, string> dictionary)
        {
            var json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
            var fileName = "C:/Users/Sasha/OneDrive/Desktop/Лабы/ОП/ОП3/ОП3_2/ОП3_2/Lab_3_2/Dictionary.json";
            File.WriteAllText(fileName, json);
        }
    }
}