using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        public class Person
        {
            public string Name;
            public string Birthday;
            public int PassN;
            public Person(string name, string birthday, int passn)
            {
                Name = name;
                PassN = passn;
                Birthday = birthday;
            }
        }
        static void Main(string[] args)
        {
        	Person p1 = new Person("1", "1", 1);
            Person p4 = new Person("Вася", "1.1.1", 13);
            Person p2 = new Person("Петя", "1.1.2", 12);
            Person p3 = new Person("Гриша", "1.1.3", 14);
            Dictionary<Person, string> d1 = new Dictionary<Person, string>
            {
                {p1,"ВЭС" },
                {p2,"ГЭС" },
                {p3,"DEX" }
            };
            Console.Write("Введите Имя : ");
            string s1 = Console.ReadLine();
            Console.Write("Введите дату рождения : ");
            string s2 = Console.ReadLine();
            Console.Write("Введите номер паспорта : ");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Person searchperson = new Person(s1,s2,s3);
            foreach(var pers in d1)
            {
            	if (pers.Key.Birthday==searchperson.Birthday&&pers.Key.Name==searchperson.Name&&pers.Key.PassN==searchperson.PassN)
            	    Console.WriteLine("Место работы : "+pers.Value);
            }
            Console.ReadLine();

        }
    }
}
