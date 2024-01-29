using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace _34_telefon_rehberi
{
    internal class AllActions
    {
        List<Person> persons = new List<Person>(); 

        public AllActions() { 
        
            persons.Add(new Person("osman","yılmaz","905486598596"));
            persons.Add(new Person("bulut", "kaya", "905463333333"));
            persons.Add(new Person("alya", "gök", "905321526390"));
            persons.Add(new Person("asel", "korkmaz", "905302225820"));
            persons.Add(new Person("doğa", "biber", "905427488531"));
        }
        public void anaEkran()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz : " +
            "\n(1) Yeni Numara Kaydetmek " +
            "\n(2) Varolan Numarayı Silmek " +
            "\n(3) Varolan Numarayı Güncelleme" +
            "\n(4) Rehberi Listelemek" +
            "\n(5) Rehberde Arama Yapmak﻿" +
            "\n(6) Konsolu Temizlemek\r\n");
            Console.Write("Seçiminiz: "); string secim = Console.ReadLine();

            switch(secim)
            {
                case "1":
                    add(); break;
                case "2":
                    remove(); break;
                case "3":
                    update(); break;
                case "4":
                    list(); break;
                case "5":
                    search(); break;
                case "6":
                    Console.Clear();
                    anaEkran(); break;
            }

        }
        
        public void add()
        {
            Console.Write(" Lütfen isim giriniz :"); String name = Console.ReadLine(); name = name.ToLower();
            Console.Write(" Lütfen soyisim giriniz :"); String surname = Console.ReadLine(); name = name.ToLower();
            Console.Write(" Lütfen telefon numarası giriniz :"); String number = Console.ReadLine(); name = name.ToLower();

            Person newPerson = new Person(name,surname,number);
            persons.Add(newPerson);
            Console.WriteLine(name +" " + surname + " rehbere eklenmiştir.");
            Console.WriteLine("\n****************************\n");
            anaEkran();
        }

        public void remove()
        {

                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string name = Console.ReadLine().ToLower();
                foreach (Person person in persons)
                {
                if (person.Name.Equals(name) || person.SurName.Equals(name))
                {
                    Console.WriteLine(name + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?");
                    Console.Write("(y/n) :"); string secim = Console.ReadLine();
                    if (secim.ToLower().Equals("y"))
                    {
                        persons.Remove(person);
                        anaEkran();
                    }
                    else if (secim.ToLower().Equals("n")) { 
                        break;
                }
                    }
   
                }
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            Console.Write("Seçiminizi giriniz :"); string secim2 = Console.ReadLine();
            if (secim2.Equals("1")) {
                Console.WriteLine("\n****************************\n");
                anaEkran();
            }
                
            else if (secim2.Equals("2")) {
                Console.WriteLine("\n****************************\n");
            remove(); }
               
        }

        public void update()
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string name = Console.ReadLine().ToLower();
            foreach (Person person in persons)
            {
                if (person.Name.Equals(name) || person.SurName.Equals(name))
                {   
                    Console.WriteLine(name + " isimli kişinin numarası :"+ person.Number);
                    Console.Write("Yeni numarayı girer misiniz ? :"); string newNumber= Console.ReadLine();
                    Console.WriteLine(name + " isimli kişinin numarası {0} olarak güncellenmek üzere, onaylıyor musunuz ?",newNumber);
                    Console.Write("(y/n) :"); string secim = Console.ReadLine();
                    if (secim.ToLower().Equals("y"))
                    {
                        person.Number = newNumber;
                        anaEkran();
                    }
                    else if (secim.ToLower().Equals("n"))
                    {
                        break;
                    }
                }

            }

            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için           : (2)");
            Console.Write("Seçiminizi giriniz :"); string secim2 = Console.ReadLine();
            if (secim2.Equals("1"))
            {
                Console.WriteLine("\n****************************\n");
                anaEkran();
            }

            else if (secim2.Equals("2"))
            {
                Console.WriteLine("\n****************************\n");
                update();
            }

        }

        public void list()
        {
            Console.WriteLine("Telefon Rehberi ");
            Console.WriteLine("****************");
            foreach (Person person in persons)
            {
                Console.WriteLine("İsim :{0}, Soyisim :{1}, Telefon Numarası :{2}",person.Name, person.SurName, person.Number);
            }
            Console.WriteLine("\n****************************\n");
            anaEkran() ;
        }

        public void search()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz lütfen.");
            Console.WriteLine("* İsim veya soyisime göre arama yapmak için : (1)");
            Console.WriteLine("* Telefon numarasına göre arama yapmak için : (2)");
            Console.Write("Seçiminizi yapınız :"); string secim=Console.ReadLine();
            if (secim.Equals("1"))
            {
                Console.Write("İsmi veya soyisimi giriniz :"); string name = Console.ReadLine();
                SearchByName(name);
            }

            else if (secim.Equals("2"))
            {
                Console.Write("Telefon numarasını giriniz :"); string phone = Console.ReadLine();
                searchByPhone(phone);
            }

        }
        public void SearchByName(string name)
        {
            name = name.ToLower();
            foreach (Person person in persons)
            {
                if (person.Name.Equals(name) || person.SurName.Equals(name))
                {
                    Console.WriteLine("Aradığınız kişinin bilgileri :{0} {1} {2}",person.Name, person.SurName, person.Number);
                    anaEkran();
                }

            }
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Aramayı sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            Console.Write("Seçiminizi giriniz :"); string secim2 = Console.ReadLine();
            if (secim2.Equals("1"))
            {
                Console.WriteLine("\n****************************\n");
                anaEkran();
            }

            else if (secim2.Equals("2"))
            {
                Console.WriteLine("\n****************************\n");
                search();
            }


        }

        public void searchByPhone(string phone)
        {
            phone = phone.ToLower();
            foreach (Person person in persons)
            {
                if (person.Number.Equals(phone) )
                {
                    Console.WriteLine("Aradığınız kişinin bilgileri :{0} {1} {2}", person.Name, person.SurName, person.Number);
                    anaEkran();
                }

            }
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Aramayı sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            Console.Write("Seçiminizi giriniz :"); string secim2 = Console.ReadLine();
            if (secim2.Equals("1"))
            {
                Console.WriteLine("\n****************************\n");
                anaEkran();
            }

            else if (secim2.Equals("2"))
            {
                Console.WriteLine("\n****************************\n");
                search();
            }
        }


    }
}
