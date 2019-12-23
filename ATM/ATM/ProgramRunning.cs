using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ProgramRunning
    {
        public string UserPin { get; set; }
        int choose;
        decimal transferMoney;
        int transferChose;
        int transferPin;
        public ProgramRunning()
        {
            var userSelectedPin = UserList.AddUser();
            string jsonRead = File.ReadAllText("C:\\c#\\atm\\ATM\\json\\userlist.json");
           List<JsonObject> Data= Newtonsoft.Json.JsonConvert.DeserializeObject<List<JsonObject>>(jsonRead);
           
            Label:
            Console.WriteLine("Pin kodu daxil edin");
            UserPin = Console.ReadLine();
            
            var itemexist1 = Data.FirstOrDefault(i => i.creditCard.pin == UserPin);
            decimal chooseMoney;
            if (itemexist1 != null)
            {
                Console.WriteLine($"{itemexist1.name} {itemexist1.surname}-xos gelmisiniz zehmet olmasa asagidakilardan birini secin");
                Console.WriteLine("1.Balans");
                Console.WriteLine("2.Nagd pul");
                Console.WriteLine("3.Edilen emeliyatlarin siyahisi");
                Console.WriteLine("4.Pul kocurmesi");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine(itemexist1.creditCard.balans);
                        Console.ReadLine();
                        Console.Clear();
                        goto Label;
                        break;
                    case 2:
                        Console.WriteLine("1. 10AZN");
                        Console.WriteLine("2. 20AZN");
                        Console.WriteLine("3. 50AZN");
                        Console.WriteLine("4. 100AZN");
                        Console.WriteLine("5. Diger");
                        choose = 0;
                        choose = int.Parse(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                chooseMoney = 10;
                                if (chooseMoney > itemexist1.creditCard.balans)
                                {
                                    Console.WriteLine("kartda kifayet qeder mebleg yoxdur");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    itemexist1.creditCard.balans = itemexist1.creditCard.balans - chooseMoney;
                                    Console.Clear();
                                    goto Label;
                                }
                                break;
                            case 2:
                                chooseMoney = 20;
                                if (chooseMoney > itemexist1.creditCard.balans)
                                {
                                    Console.WriteLine("kartda kifayet qeder mebleg yoxdur");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    itemexist1.creditCard.balans = itemexist1.creditCard.balans - chooseMoney;
                                    Console.Clear();
                                    goto Label;
                                }
                                break;
                            case 3:
                                chooseMoney = 50;
                                if (chooseMoney > itemexist1.creditCard.balans)
                                {
                                    Console.WriteLine("kartda kifayet qeder mebleg yoxdur");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    itemexist1.creditCard.balans = itemexist1.creditCard.balans - chooseMoney;
                                    Console.Clear();
                                    goto Label;
                                }
                                break;
                            case 4:
                                chooseMoney = 100;
                                if (chooseMoney > itemexist1.creditCard.balans)
                                {
                                    Console.WriteLine("kartda kifayet qeder mebleg yoxdur");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    itemexist1.creditCard.balans = itemexist1.creditCard.balans - chooseMoney;
                                    Console.Clear();
                                    goto Label;
                                }
                                break;
                            case 5:
                                Console.WriteLine("Meblegi daxil edin");
                                chooseMoney = decimal.Parse(Console.ReadLine());
                                if (chooseMoney > itemexist1.creditCard.balans)
                                {
                                    Console.WriteLine("kartda kifayet qeder mebleg yoxdur");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    itemexist1.creditCard.balans = itemexist1.creditCard.balans - chooseMoney;
                                    Console.Clear();
                                    goto Label;
                                }
                                break;
                        }
                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("Hansi karta kocurme etmek isdeyirsiniz?Pini daxil edin:");
                        transferPin = int.Parse(Console.ReadLine());
                        var transferItem = Data.FirstOrDefault(t => t.creditCard.pin == transferPin.ToString());
                        if (Data.Any(t => t.creditCard.pin == transferPin.ToString()))
                        {
                            Console.WriteLine("Kocurmek isdediyiniz meeblegi daxil edin:");
                            transferMoney = decimal.Parse(Console.ReadLine());
                            itemexist1.creditCard.balans -= transferMoney;
                            transferItem.creditCard.balans += transferMoney;
                            Console.WriteLine("Isdediyiniz mebleg kocuruldu");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            goto Label;
                        }
                        else
                        {
                            Console.WriteLine("Bu Pin koda aid kart tapilmadi");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            goto Label;
                        }
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("pin sehfdir");
                goto Label;
            }

            #region Old
            //Label:
            //Console.WriteLine("Pin kodu daxil edin");
            //UserPin = Console.ReadLine();
            //var userSelectedPin = UserList.AddUser();
            //decimal chooseMoney;
            //var itemExists = userSelectedPin.FirstOrDefault(t => t.creditCard.pin == UserPin);
            //if (itemExists != null)
            //{
            //    Console.WriteLine($"{itemExists.name} {itemExists.surname}-xos gelmisiniz zehmet olmasa asagidakilardan birini secin");
            //    Console.WriteLine("1.Balans");
            //    Console.WriteLine("2.Nagd pul");
            //    Console.WriteLine("3.Edilen emeliyatlarin siyahisi");
            //    Console.WriteLine("4.Pul kocurmesi");
            //    choose = int.Parse(Console.ReadLine());
            //    switch (choose)
            //    {
            //        case 1:
            //            Console.WriteLine(itemExists.creditCard.balans);
            //            Console.ReadLine();
            //            Console.Clear();
            //            goto Label;
            //            break;
            //        case 2:
            //            Console.WriteLine("1. 10AZN");
            //            Console.WriteLine("2. 20AZN");
            //            Console.WriteLine("3. 50AZN");
            //            Console.WriteLine("4. 100AZN");
            //            Console.WriteLine("5. Diger");
            //            choose = 0;
            //            choose = int.Parse(Console.ReadLine());
            //            switch (choose)
            //            {
            //                case 1:
            //                    chooseMoney = 10;
            //                    if (chooseMoney > itemExists.creditCard.balans)
            //                    {
            //                        Console.WriteLine("kartda kifayet qeder mebleg yoxdur");
            //                        Console.ReadLine();
            //                    }
            //                    else
            //                    {
            //                        itemExists.creditCard.balans = itemExists.creditCard.balans - chooseMoney;
            //                        Console.Clear();
            //                        goto Label;
            //                    }
            //                    break;
            //                case 2:
            //                    chooseMoney = 20;
            //                    if (chooseMoney > itemExists.creditCard.balans)
            //                    {
            //                        Console.WriteLine("kartda kifayet qeder mebleg yoxdur");
            //                        Console.ReadLine();
            //                    }
            //                    else
            //                    {
            //                        itemExists.creditCard.balans = itemExists.creditCard.balans - chooseMoney;
            //                        Console.Clear();
            //                        goto Label;
            //                    }
            //                    break;
            //                case 3:
            //                    chooseMoney = 50;
            //                    if (chooseMoney > itemExists.creditCard.balans)
            //                    {
            //                        Console.WriteLine("kartda kifayet qeder mebleg yoxdur");
            //                        Console.ReadLine();
            //                    }
            //                    else
            //                    {
            //                        itemExists.creditCard.balans = itemExists.creditCard.balans - chooseMoney;
            //                        Console.Clear();
            //                        goto Label;
            //                    }
            //                    break;
            //                case 4:
            //                    chooseMoney = 100;
            //                    if (chooseMoney > itemExists.creditCard.balans)
            //                    {
            //                        Console.WriteLine("kartda kifayet qeder mebleg yoxdur");
            //                        Console.ReadLine();
            //                    }
            //                    else
            //                    {
            //                        itemExists.creditCard.balans = itemExists.creditCard.balans - chooseMoney;
            //                        Console.Clear();
            //                        goto Label;
            //                    }
            //                    break;
            //                case 5:
            //                    Console.WriteLine("Meblegi daxil edin");
            //                    chooseMoney = decimal.Parse(Console.ReadLine());
            //                    if (chooseMoney > itemExists.creditCard.balans)
            //                    {
            //                        Console.WriteLine("kartda kifayet qeder mebleg yoxdur");
            //                        Console.ReadLine();
            //                    }
            //                    else
            //                    {
            //                        itemExists.creditCard.balans = itemExists.creditCard.balans - chooseMoney;
            //                        Console.Clear();
            //                        goto Label;
            //                    }
            //                    break;
            //            }
            //            break;
            //        case 3:

            //            break;
            //        case 4:
            //            Console.WriteLine("Hansi karta kocurme etmek isdeyirsiniz?Pini daxil edin:");
            //            transferPin = int.Parse(Console.ReadLine());
            //            var transferItem = userSelectedPin.FirstOrDefault(t => t.creditCard.pin == transferPin.ToString());
            //            if (userSelectedPin.Any(t => t.creditCard.pin == transferPin.ToString()))
            //            {
            //                Console.WriteLine("Kocurmek isdediyiniz meeblegi daxil edin:");
            //                transferMoney = decimal.Parse(Console.ReadLine());
            //                itemExists.creditCard.balans -= transferMoney;
            //                transferItem.creditCard.balans += transferMoney;
            //                Console.WriteLine("Isdediyiniz mebleg kocuruldu");
            //                System.Threading.Thread.Sleep(2000);
            //                Console.Clear();
            //                goto Label;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Bu Pin koda aid kart tapilmadi");
            //                System.Threading.Thread.Sleep(2000);
            //                Console.Clear();
            //                goto Label;
            //            }
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine("pin sehfdir");
            //    goto Label;
            //}


            //            //if (Directory.Exists("c://json"))
            //            //{

            //            //}
            //            //else
            //            //{
            //            //    Directory.CreateDirectory("c://json//");
            //            //}
            //            //string jsonUser = Newtonsoft.Json.JsonConvert.SerializeObject(UserList.AddUser());
            //            //File.WriteAllText("c://json//userlist.json", jsonUser);
            #endregion
        }
    }
}

