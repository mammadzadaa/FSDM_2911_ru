using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Xml.Serialization;

namespace Lesson_15_09_20_Serialization
{
    class B<T>
    {
        public B()
        {
            MyProperty = default;
        }
        public B(T myProperty)
        {
            MyProperty = myProperty;
        }

        public T MyProperty { get; set; }
        
    }
    class A<T> where T: class,new()
    {
       public static void Foo(T val)
        {

        }
    }
    class MyClass<Tone,Ttwo> where Tone: class,IEnumerable,new()
                             where Ttwo: struct,IDisposable
    {

    }

    [Serializable] // Atribute
    public class Person //: IDisposable
    {
        public Person()
        {

        }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        //public void Dispose()
        //{
        //    Console.WriteLine("Disposed");
        //}

        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Binary, XML, SOAP, JSON



            // JSON

            string str = File.ReadAllText("people.json");
            var people = JsonSerializer.Deserialize<List<Person>>(str);

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

            //List<Person> people = new List<Person>()
            //{
            //    new Person("Aftandil", "Mammadov", 35),
            //    new Person("Israfil", "Haciyev", 45),
            //    new Person("Memmed", "Quliyev", 37),
            //    new Person("Ahmad", "Ibrahimov", 29)
            //};

            //string serialized = JsonSerializer.Serialize(people);
            //File.WriteAllText("people.json", serialized);



            //string str =  File.ReadAllText("person.json");
            //Person person = JsonSerializer.Deserialize<Person>(str);

            //Console.WriteLine(person);

            //Person person = new Person("Aftandil", "Mammadov", 35);
            //string serialized = JsonSerializer.Serialize(person);

            //File.WriteAllText("person.json", serialized);


            // XML


            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));

            //using (FileStream fs = new FileStream("people.xml", FileMode.Open))
            //{
            //    var people = xmlSerializer.Deserialize(fs) as List<Person>;

            //    foreach (var item in people)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //List<Person> people = new List<Person>()
            //{
            //    new Person("Aftandil", "Mammadov", 35),
            //    new Person("Israfil", "Haciyev", 45),
            //    new Person("Memmed", "Quliyev", 37),
            //    new Person("Ahmad", "Ibrahimov", 29)
            //};

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));

            //using (FileStream fs = new FileStream("people.xml", FileMode.Create))
            //{
            //    xmlSerializer.Serialize(fs, people);
            //}



            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            //using (FileStream fs = new FileStream("person.xml", FileMode.Open))
            //{
            //    var person =  xmlSerializer.Deserialize(fs) as Person;
            //    Console.WriteLine(person);
            //}



            //Person person = new Person("Aftandil", "Mammadov", 35);

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            //using (FileStream fs = new FileStream("person.xml", FileMode.Create))
            //{
            //    xmlSerializer.Serialize(fs, person);
            //}



            // Binary

            //using (FileStream fs = new FileStream("people.bin", FileMode.Open))
            //{

            //    BinaryFormatter binaryFormatter = new BinaryFormatter();
            //    var people = binaryFormatter.Deserialize(fs) as List<Person>;

            //    foreach (var item in people)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}



            //List<Person> people = new List<Person>()
            //{
            //    new Person("Aftandil", "Mammadov", 35),
            //    new Person("Israfil", "Haciyev", 45),
            //    new Person("Memmed", "Quliyev", 37),
            //    new Person("Ahmad", "Ibrahimov", 29)
            //};


            //using (FileStream fs = new FileStream("people.bin", FileMode.Create))
            //{
            //    BinaryFormatter binaryFormatter = new BinaryFormatter();
            //    binaryFormatter.Serialize(fs, people);
            //}


            //using (FileStream fs = new FileStream("person.bin", FileMode.Open))
            //{

            //    BinaryFormatter binaryFormatter = new BinaryFormatter();
            //    Person person =  binaryFormatter.Deserialize(fs) as Person;

            //    Console.WriteLine(person);
            //    Console.WriteLine(person.Age);
            //}


            //Person person = new Person("Aftandil", "Mammadov", 35);


            //using (FileStream fs = new FileStream("person.bin", FileMode.Create))
            //{

            //    BinaryFormatter binaryFormatter = new BinaryFormatter();
            //    binaryFormatter.Serialize(fs,person);
            //}

            //using (FileStream fs = new FileStream("log.txt", FileMode.Create))
            //{           
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        for (int i = 0; i < 10; i++)
            //        {
            //            Thread.Sleep(1000);
            //            sw.Write(DateTime.Now + "\n");
            //            Console.WriteLine(DateTime.Now);
            //        }
            //    }
            //}


            //using (FileStream fs = new FileStream("people.txt", FileMode.Open))
            //{
            //    // StreamWriter sw = new StreamWriter(fs);
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            Console.WriteLine(sr.ReadLine());
            //        }
            //    }                    
            //}

            //List<Person> people = new List<Person>()
            //{
            //    new Person("Aftandil", "Mammadov", 35),
            //    new Person("Israfil", "Haciyev", 45),
            //    new Person("Memmed", "Quliyev", 37),
            //    new Person("Ahmad", "Ibrahimov", 29)
            //};

            //using (Person person = new Person("Aftandil", "Mammadov", 35))
            //{

            //} // Dispose

            //using (FileStream fs = new FileStream("people.txt", FileMode.Create))
            //{
            //    foreach (var item in people)
            //    {
            //        byte[] buf = Encoding.UTF8.GetBytes(item.ToString() + "\n");
            //        fs.Write(buf, 0, buf.Length);
            //    }
            //}

            //FileStream fs = new FileStream("person.txt", FileMode.Open);
            //try
            //{
            //   byte[] buf = new byte[50];

            //    fs.Read(buf, 0, 50);

            //    Console.WriteLine(Encoding.UTF8.GetString(buf));
            //}
            //finally
            //{
            //    fs.Close();
            //}


            //Person person = new Person("Aftandil", "Mammadov", 35);

            //FileStream fs = new FileStream("person.txt",FileMode.Create);

            //byte[] buf = Encoding.UTF8.GetBytes(person.ToString());

            //fs.Write(buf, 0, buf.Length);

            //fs.Flush();

            //fs.Close();


            //Person person = new Person("Aftandil","Mammadov",35);
            //File.WriteAllText("person.txt", person.ToString());

            //A<B>.Foo(new B(12));
        }
    }
}
