using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class UserList
    {
        static List<User> users = new List<User>();
        static User u1;
        static User u2;
        static User u3;
        static User u4;
        static User u5;

        public static List<User>  AddUser()
        {
            u1 = new User();
            Random rnd = new Random();
            u1.name =FakeData.NameData.GetFirstName();
            u1.surname = FakeData.NameData.GetSurname();
            u1.creditCard = new Card
            {
                pan=$"{rnd.Next(10000000,1000000000)}",
                pin="1234",
                cvc="123",
                expireDate="01/01",
                balans = 1500M
            };
            u2 = new User() {
                name = FakeData.NameData.GetFirstName(),
                surname=FakeData.NameData.GetSurname(),
                creditCard=new Card()
                {
                    pan = $"{rnd.Next(10000000, 1000000000)}",
                    pin = "1111",
                    cvc = "122",
                    expireDate = "02/03",
                    balans = 1200M
                }
                
            };
            u3 = new User()
            {
                name = FakeData.NameData.GetFirstName(),
                surname = FakeData.NameData.GetSurname(),
                creditCard = new Card()
                {
                    pan = $"{rnd.Next(10000000, 1000000000)}",
                    pin = "2222",
                    cvc = "112",
                    expireDate = "02/03",
                    balans = 500.60M
                }
            };

            u4 = new User()
            {
                name = FakeData.NameData.GetFirstName(),
                surname = FakeData.NameData.GetSurname(),
                creditCard = new Card()
                {
                    pan = $"{rnd.Next(10000000, 1000000000)}",
                    pin = "3333",
                    cvc = "112",
                    expireDate = "02/03",
                    balans = 200.60M
                }
            };
            u5 = new User()
            {
                name = FakeData.NameData.GetFirstName(),
                surname = FakeData.NameData.GetSurname(),
                creditCard = new Card()
                {
                    pan = $"{rnd.Next(10000000, 1000000000)}",
                    pin = "4444",
                    cvc = "112",
                    expireDate = "02/03",
                    balans = 150M
                }
            };
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            users.Add(u5);
            


            if (Directory.Exists("C:\\c#\\atm\\ATM\\json"))
            {

            }
            else
            {
                Directory.CreateDirectory("C:\\c#\\atm\\ATM\\json");
            }
            string jsonUser = Newtonsoft.Json.JsonConvert.SerializeObject(users);
            File.WriteAllText("C:\\c#\\atm\\ATM\\json\\userlist.json", jsonUser);

            return users;
        }
    }
}
