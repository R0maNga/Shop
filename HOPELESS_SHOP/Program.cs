using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HOPELESS_SHOP
{
    class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string ListOfProducts { get; set; }  //List<Product>
    }
    class Program
    {

        


        static void Main(string[] args)
        {
            Shop ShopInfo = new Shop();
            ShopInfo.Id = 1;
            ShopInfo.Name = "Магазигн все по 300 BUCKS";
            ShopInfo.Discription = "Все по 300 БАКС";

            Manager ManagerInfo = new Manager();
            ManagerInfo.Login = "Manager";
            ManagerInfo.Password = "12";

            Basket BasketInfo = new Basket();
            






            //Hashtable ht = new Hashtable();
            //ht.Add("roman", "pms");

            //ICollection keys = ht.Keys;
            //ht.Remove("roman");
            //string isEmpty = $"1{ht["roman1"]}1";
            //Console.WriteLine(ht["roman1"]);
            //foreach (string s in keys)
            //{
            //    Console.WriteLine(s);
            //}


            Product ProductInfo1 = new Product();
            ProductInfo1.Name = "DangeonMaster";
            Product ProductInfo2 = new Product();
            ProductInfo2.Name = "PerformArtist";
            Product ProductInfo3 = new Product();
            ProductInfo3.Name = "Master";
            Product ProductInfo4 = new Product();
            ProductInfo4.Name = "Slaves";
            Product ProductInfo5 = new Product();
            ProductInfo5.Name = "Club";

            ProductInfo1.Description ="q";
            ProductInfo2.Description = "w";
            ProductInfo3.Description = "e";
            ProductInfo4.Description = "r";
            ProductInfo5.Description = "t";

            Buyer BuyerInfo = new Buyer();
            
            User UserInfo = new User();

            Order OrderInformation = new Order();
            OrderInformation.DateOfOrder = DateTime.Now;

            

           
            




            void firstCase()
            {
                Console.WriteLine($" Список товаров: \n{ProductInfo1.Name} \n{ProductInfo2.Name} \n{ProductInfo3.Name} \n{ProductInfo4.Name} \n {ProductInfo5.Name} ");
                Console.WriteLine("1-для назад");
                goBack();
            }

            void userCase()  //P.S Я знаю что это ужасно, но я чет не придумал как по другому((((((
            {

                Console.WriteLine(" 1-добавить товар в корзину \n 2- удалить товар из корзины \n 3-редактировать корзину \n 4-оформить заказ с корзины \n 5-просмотр списка заказов \n 6-посмотреть подробности заказа \n 7-для выхода");
                string vibor= Console.ReadLine();
                                
                switch (vibor)
                {
                    case "1":
                       {
                            Console.WriteLine("Нажмите на товар для добавления");
                            Console.WriteLine("\n товар 1\n товар 2\n товар 3\n товар 4\n товар 5");
                            string tovar = Console.ReadLine();
                            switch (tovar)
                            {
                                case "1":
                                    {   
                                        Console.WriteLine("Товар добавлен" + ProductInfo1.Name);
                                        string ProductIfoName1 = ProductInfo1.Name;
                                        BasketInfo.ListofOrderItem = ProductIfoName1;

                                        Console.WriteLine("1- для выхода в главное меню\n 2-для просмотра корзины \n3-для выхода из магазина ");
                                        string key=Console.ReadLine();

                                        switch (key)
                                        {
                                            case "1":
                                                {
                                                    userCase();                                                   
                                                }
                                                break;

                                            case "2":
                                                {
                                                    CheckBasket();
                                                }
                                                break;
                                            case "3":
                                                {

                                                }
                                                break;
                                        }



                                        break;

                                    }
                                case "2":
                                    {
                                        Console.WriteLine("Товар добавлен" + ProductInfo2.Name);
                                        string ProductIfoName2 = ProductInfo2.Name;
                                        BasketInfo.ListofOrderItem = ProductIfoName2;
                                        Console.WriteLine("1- для выхода в главное меню\n 2-для просмотра корзины \n3-для выхода из магазина ");
                                        string key = Console.ReadLine();

                                        switch (key)
                                        {
                                            case "1":
                                                {
                                                    userCase();
                                                }
                                                break;

                                            case "2":
                                                {
                                                    CheckBasket();
                                                }
                                                break;
                                            case "3":
                                                {
                                                    

                                                }
                                                break;
                                        }





                                        break;


                                    }
                                    

                                case "3":
                                    {
                                        Console.WriteLine("Товар добавлен" + ProductInfo3.Name);
                                        string ProductIfoName3 = ProductInfo3.Name;
                                        BasketInfo.ListofOrderItem = ProductIfoName3;

                                        Console.WriteLine("1- для выхода в главное меню\n 2-для просмотра корзины \n3-для выхода из магазина ");
                                        string key = Console.ReadLine();

                                        switch (key)
                                        {
                                            case "1":
                                                {
                                                    userCase();
                                                }
                                                break;

                                            case "2":
                                                {
                                                    CheckBasket();
                                                }
                                                break;
                                            case "3":
                                                {

                                                }
                                                break;
                                        }
                                    }
                                    break;

                                case "4":
                                    {
                                        Console.WriteLine("Товар добавлен" + ProductInfo4.Name);
                                        string ProductIfoName4 = ProductInfo4.Name;
                                        BasketInfo.ListofOrderItem = ProductIfoName4;

                                        Console.WriteLine("1- для выхода в главное меню\n 2-для просмотра корзины \n3-для выхода из магазина ");
                                        string key = Console.ReadLine();

                                        switch (key)
                                        {
                                            case "1":
                                                {
                                                    userCase();
                                                }
                                                break;

                                            case "2":
                                                {
                                                    CheckBasket();
                                                }
                                                break;
                                            case "3":
                                                {

                                                }
                                                break;
                                        }


                                    }
                                    break;

                                case "5":
                                    {
                                        Console.WriteLine("Товар добавлен" + ProductInfo5.Name);
                                        string ProductIfoName5 = ProductInfo5.Name;
                                        BasketInfo.ListofOrderItem = ProductIfoName5;
                                        Console.WriteLine("1- для выхода в главное меню\n 2-для просмотра корзины \n3-для выхода из магазина ");
                                        string key = Console.ReadLine();
                                        switch (key)
                                        {
                                            case "1":
                                                {
                                                    userCase();
                                                }
                                                break;

                                            case "2":
                                                {
                                                    CheckBasket();
                                                }
                                                break;
                                            case "3":
                                                {

                                                }
                                                break;
                                        }
                                    }
                                    break;

                            }

                            break;

                           
                        }

                    case "2":
                        {
                            DeleteBasket();

                        }
                        break;
                    case "3":
                        {
                            ChangeBasket();
                        }
                        break;
                    case "4":
                        {
                            GetOrderFormBasket();
                        }
                        break;
                    case "5":
                        {
                            CheckBasket();
                        }
                        break;
                    case "6":
                        {
                            ShowOrderInfo();
                        }
                        break;
                    case "7":
                        {

                        }
                        break;

                }

            }
            void deleteUser()
            {
                BuyerInfo.Login.Remove(0,20);
                BuyerInfo.Password.Remove(0, 20);
                    
            }
            void deleteManager()
            {
                ManagerInfo.Login.Remove(0, 20);
                ManagerInfo.Password.Remove(0, 20);

            }
            void goBack()
            {
                string value = Console.ReadLine();
                if (value == "1")
                {
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Введите корректное число");
                    goBack();
                }
            }

            void secondCase()
            {
                Console.WriteLine("Введите логин введите пароль ");
                Console.WriteLine("Login:");
                string login = Console.ReadLine();
                Console.WriteLine("Password:");
                string password = Console.ReadLine();
                BuyerInfo.Login = login;
                BuyerInfo.Password = password;
                Console.WriteLine("User has been created!\nPress 1 to go back");
                goBack();
            }

            void thirdCase()
            {
                Console.WriteLine("Введите логин и праоль");
                Console.WriteLine("Login:");
                string login = Console.ReadLine();
                Console.WriteLine("Password:");
                string password = Console.ReadLine();
                bool IsvalidLog = login == BuyerInfo.Login;
                bool IsvalidPin = password == BuyerInfo.Password;
                bool IsvalidManagerLog = ManagerInfo.Login == login ;
                bool IsvalidManagerPass = ManagerInfo.Password == password;
                if (IsvalidLog && IsvalidPin)
                {
                    Console.WriteLine("вы вошли как юзер");
                    userCase();
                }
                else if (IsvalidManagerLog&&IsvalidManagerPass)
                {
                    ManagerSet();
                }
                else
                {
                    if (IsvalidLog)
                    {
                        Console.WriteLine("Неправильный пароль, попробуйте снова");
                    }
                    else
                    {
                        Console.WriteLine("Неправильный логин, попробуйте снова");
                    }
                    thirdCase();
                }
            }



            void ManagerSet()
            {
                Console.WriteLine("Вы вошли как менеджер");
                Console.WriteLine("1- добавлять новый продукт в каталог \n 2-удалить товар \n3-редоктивровать продукт \n \n 4-выход");
                string value = Console.ReadLine();
                switch (value)
                {
                    case "1":
                        {
                            
                            Product a = new Product();
                            Console.WriteLine("Введите название продукта");
                            string nameOfProduct = Console.ReadLine();
                            a.Name = nameOfProduct;
                            ManagerSet();
                        }
                        break;             

                    case "2":
                        {
                            Console.WriteLine("Какой товар удалить");
                            Console.WriteLine($"1-{ ProductInfo1.Name} \n 2-{ProductInfo1.Name} \n3-{ProductInfo2.Name} \n4- {ProductInfo3.Name} \n 5-{ProductInfo5.Name} \n 6-для выйти в меню");
                            string key= Console.ReadLine();

                            switch (key)
                            {
                                case "1":
                                    {
                                        int q= ProductInfo1.Name.Length;
                                        ProductInfo1.Name.Remove(0, q);
                                        ManagerSet();
                                        
                                    }
                                    break;

                                case "2" :
                                    {
                                        int q = ProductInfo1.Name.Length;
                                        ProductInfo2.Name.Remove(0, q);
                                        ManagerSet();
                                    }
                                    break;
                                case "3":
                                    {
                                        int q = ProductInfo1.Name.Length;
                                        ProductInfo3.Name.Remove(0, q);
                                        ManagerSet();
                                    }
                                    break;
                                case "4":
                                    {
                                        int q = ProductInfo1.Name.Length;
                                        ProductInfo4.Name.Remove(0, q);
                                        ManagerSet();
                                    }
                                    break;
                                case "5":
                                    {
                                        int q = ProductInfo1.Name.Length;
                                        ProductInfo5.Name.Remove(0, q);
                                        ManagerSet();
                                    }
                                    break;
                                default:
                                    {
                                        ManagerSet();
                                    }
                                    break;
                                    
                            }   

                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("Какой товар отредактировать");
                            Console.WriteLine($"1-{ ProductInfo1.Name} 2-{ProductInfo2.Name} 3-{ProductInfo3.Name} 4- {ProductInfo4.Name} 5- {ProductInfo5.Name} 6-для выйти в меню");
                            string key = Console.ReadLine();

                            switch (key)
                            {
                                case "1":
                                    {
                                        string q=Console.ReadLine();
                                        char qCon=Convert.ToChar(q);
                                        
                                        ProductInfo1.Description.Replace('y', qCon);

                                    }
                                    break;

                                case "2":
                                    {
                                        string q = Console.ReadLine();
                                        char qCon = Convert.ToChar(q);

                                        ProductInfo2.Description.Replace('y', qCon);
                                    }
                                    break;
                                case "3":
                                    {
                                        string q = Console.ReadLine();
                                        char qCon = Convert.ToChar(q);

                                        ProductInfo3.Description.Replace('y', qCon);
                                    }
                                    break;
                                case "4":
                                    {
                                        string q = Console.ReadLine();
                                        char qCon = Convert.ToChar(q);

                                        ProductInfo4.Description.Replace('y', qCon);
                                    }
                                    break;
                                case "5":
                                    {
                                        string q = Console.ReadLine();
                                        char qCon = Convert.ToChar(q);

                                        ProductInfo5.Description.Replace('y', qCon);
                                    }

                                    break;
                                default:
                                    {
                                        ManagerSet();
                                    }
                                    break;

                            }

                        }
                        break;
                }



            }


            void MainMenu()
            {   Console.WriteLine("Магазигн 1 товар за раз");
                Console.WriteLine("||||||||||||||||||||||||||||||\n||||||||||||||||||||||||||||||");

                Console.WriteLine("1-для просмотра товара \n2-для регистрации \n3-для входа ");
                string vibor = Console.ReadLine();
                
                switch (vibor)
                {
                    case "1":
                        firstCase();
                        break;
                    case "2":
                        secondCase();
                        break;
                    case "3":
                        thirdCase();
                        break;
                    default:
                        Console.WriteLine("Не та кнопка ");
                        MainMenu();
                        break;
                }
            }



           void DeleteBasket()
            {
                var q =BasketInfo.ListofOrderItem.Length;
                BasketInfo.ListofOrderItem.Remove(0, q);
                userCase();
            }

            
                void CheckBasket()
            {
                Console.WriteLine(BasketInfo.ListofOrderItem);
                userCase();
            }
           
            void ChangeBasket()
            {

               
                Console.WriteLine("Введите сколько штук нужно");
                string w = Console.ReadLine();
                


                if (int.TryParse(w, out int n))
                {
                    int we = Convert.ToInt32(w);
                    BasketInfo.Copacity = we;
                    userCase();
                }
                else
                {
                    Console.WriteLine("Введите число");
                    ChangeBasket();
                    userCase();
                }
                              
            }

           void  GetOrderFormBasket()
            {
             Console.WriteLine($"Вы заказали: {BasketInfo.ListofOrderItem} Количество - {BasketInfo.Copacity} ");
                userCase();
            }


            void ShowOrderInfo()
            {

                Console.WriteLine("Заказ был совершен в:");
                Console.WriteLine(OrderInformation.DateOfOrder = DateTime.Now);
                userCase();
            }







            string GetHashString(string s)
            {
                //переводим строку в байт-массим  
                byte[] bytes = Encoding.Unicode.GetBytes(s);

                //создаем объект для получения средст шифрования  
                MD5CryptoServiceProvider CSP =
                    new MD5CryptoServiceProvider();

                //вычисляем хеш-представление в байтах  
                byte[] byteHash = CSP.ComputeHash(bytes);

                string hash = string.Empty;

                //формируем одну цельную строку из массива  
                foreach (byte b in byteHash)
                    hash += string.Format("{0:x2}", b);

                return hash;
            }




            MainMenu();

            GetHashString(BuyerInfo.Password);








        }


    }
}
