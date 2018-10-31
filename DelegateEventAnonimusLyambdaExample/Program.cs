using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace jsonXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Anymal anymal = new Anymal() { Name = "Dog", Age = 3, Gender = "male" };
            Anymal anymal2 = new Anymal() { Name = "Cat", Age = 2, Gender = "male" };
            Product product = new Product() { Name = "Компьютер", Price = 100000 };
            Product product2 = new Product() { Name = "Телефон", Price = 40000 };
            User user = new User() { Login = "anuar", Password = "asd234", NumbersPhone =   "+7623845735" };
            User user2 = new User() { Login = "anuar2", Password = "234asd", NumbersPhone = "+7073453453" };
            string serialized = JsonConvert.SerializeObject(anymal);
            serialized += JsonConvert.SerializeObject(anymal2);
            serialized += JsonConvert.SerializeObject(product);
            serialized += JsonConvert.SerializeObject(product2);
            serialized += JsonConvert.SerializeObject(user);
            serialized += JsonConvert.SerializeObject(user2);
            string fileName1 = "data1.json";
            string fileName2 = "data2.json";
            if (!File.Exists(fileName1))
            {
                File.Create(fileName1).Close();
            }
            File.WriteAllText(fileName1, serialized);
        }
    }
}
