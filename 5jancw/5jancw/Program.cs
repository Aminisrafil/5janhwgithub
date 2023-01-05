using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

namespace _5jancw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product phone1 = new Phone { Name = "Iphone 13", Price = 3499, Simcount = 2 };
            Product phone2 = new Phone { Name = "Iphone 11", Price = 2299, Simcount = 3 };
            Product notebook1 = new Notebook { Name = "Asus TUF A15", Price = 2999, Ram = 16, Storage = 512};
            Product notebook2 = new Notebook { Name = "Asus TUF F15", Price = 2799, Ram = 16, Storage = 512};
            Product[] products = { phone1,phone2,notebook2, notebook1 };
            int phonecount = 0;
            int notebookcount = 0;
            double phonesum = 0;
            double notebooksum = 0;

            string opt;
            do
            {
                Console.WriteLine("1. Butun mehsullara bax");
                Console.WriteLine("2. Notebooklara bax");
                Console.WriteLine("3. Telefonlara bax");
                Console.WriteLine("4. Telefonlarin sayina bax bax");
                Console.WriteLine("5. Notebooklarin sayina bax bax");
                Console.WriteLine("6. Telefonlarin ortalama qiymetine bax");
                Console.WriteLine("7. Notebooklarin ortalama qiymetine bax");
                Console.WriteLine("0. Cix");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine(products[i].Name + "||" + products[i].Price);
                        }
                        break;
                    case "2":
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                                Console.WriteLine(products[i].ToString());    
                        }
                        break;
                    case "3":
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                                Console.WriteLine(products[i].ToString());
                        }
                        break;
                    case "4":
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                                phonecount++;


                        }
                        break;
                    case "5":
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                                notebookcount++;
                        }
                        break;
                    case "6":
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                            {
                                phonecount++;
                                phonesum += products[i].Price;
                            }
                        }
                        if(phonecount > 0)
                            Console.WriteLine(phonesum / phonecount);
                        else
                            Console.WriteLine("Telefonlarin sayi 0dir!");
                        break;
                    case "7":
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {
                                notebookcount++;
                                notebooksum += products[i].Price;
                            }
                        }
                        if (notebookcount > 0)
                            Console.WriteLine(notebooksum / notebookcount);
                        else
                            Console.WriteLine("Notebooklarin sayi 0dir!");
                        break;

                    default:
                        Console.Beep();
                        Console.WriteLine("Seciminiz yanlisdir!");
                        break;
                }
            } while (opt != "0");
            
        }
        
            
        
    }
}
