using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _35_ToDoApp
{
    internal class AllActions
    {
        List<Personel> persons = new List<Personel>();
        List<Card> cards = new List<Card>();
        public AllActions() {

            persons.Add(new Personel("kadir", 1));
            persons.Add(new Personel("erkan", 2));
            persons.Add(new Personel("ömer", 3));
            persons.Add(new Personel("betül", 4));
            persons.Add(new Personel("furkan", 5));
            persons.Add(new Personel("enes", 6));

            cards.Add(new Card("1.Başlık", "1.Content", persons[0].Name, Size.XS.ToString(), Line.TODO.ToString()));
            cards.Add(new Card("2.Başlık", "2.Content", persons[1].Name, Size.XS.ToString(), Line.TODO.ToString()));
            cards.Add(new Card("3.Başlık", "3.Content", persons[2].Name, Size.XS.ToString(), Line.TODO.ToString()));
            cards.Add(new Card("4.Başlık", "4.Content", persons[3].Name, Size.XS.ToString(), Line.TODO.ToString()));
            cards.Add(new Card("5.Başlık", "5.Content", persons[4].Name, Size.XS.ToString(), Line.TODO.ToString()));
        }
        public void anaEkran()
        {
            Console.Write(
                "Lütfen yapmak istediğiniz işlemi seçiniz:"+
                "\n(1) Board Listelemek" +
                "\n(2) Board'a Kart Eklemek " +
                "\n(3) Board'dan Kart Silmek" +
                "\n(4) Kart Taşımak"+
                "\n(5) Konsol Temizlemek" +
                "\n:");
            string secim=Console.ReadLine();
            switch(secim)
            {
                case "1":
                    list();break;
                case "2":
                    add();break;
                case "3":
                    remove();break;
                case "4":
                    update();break;
                case "5":
                    Console.Clear();
                    anaEkran();break;
            }
           
        }
        public void list() { 
            if(cards.Count > 0)
            {
                Console.WriteLine("TODO Line\n" + "************************");
                foreach (Card card in cards) {
                    if (card.Line.Equals("TODO"))
                    {
                        writeCard(card.Title, card.Content, card.Person, card.Size);
                    }
                }
                Console.WriteLine("IN_PROGRESS Line\n" + "************************");
                foreach (Card card in cards)
                {
                    if (card.Line.Equals("IN_PROGRESS"))
                    {
                        writeCard(card.Title, card.Content, card.Person, card.Size);
                    }
                }
                Console.WriteLine("DONE Line\n" + "************************");
                foreach (Card card in cards)
                {
                    if (card.Line.Equals("DONE"))
                    {
                        writeCard(card.Title, card.Content, card.Person, card.Size);
                    }
                }
            }
            else
            {
                Console.WriteLine("BOŞ");
            }
            anaEkran();
        }
        public void add() { 
            Console.Write("Başlık Giriniz                                   :"); string title=Console.ReadLine();
            Console.Write("İçerik Giriniz                                   :"); string content=Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)   :"); string size=Console.ReadLine();
            Console.Write("Kişi Seçiniz                                     :"); string name=Console.ReadLine();
            switch (size)
            {
                case "1":
                    size = "XS"; break;
                case "2":
                    size = "S"; break;
                case "3":
                    size = "M"; break;
                case "4":
                    size = "L"; break;
                case "5":
                    size = "XL"; break;
            }
            cards.Add(new Card(title,content,name.ToLower(), size, Line.TODO.ToString()));
            anaEkran();

        }
        public void remove() { 
            Console.Write("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\r\n Lütfen kart başlığını yazınız: ");
            string title =Console.ReadLine(); 
            foreach(Card card in cards)
            {
                if (card.Title.ToLower().Equals(title))
                {
                    cards.Remove(card);
                    Console.WriteLine("{0} silindi.",title);
                    anaEkran();
                }
            }
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\r\n " +
                "* Silmeyi sonlandırmak için : (1)\r\n " +
                "* Yeniden denemek için : (2)");
            Console.Write("Seçiminiz :"); string secim = Console.ReadLine();
            if (secim.Equals("1"))
                anaEkran();
            else if (secim.Equals("2"))
                remove();


        }
        public void update() {
            Console.Write("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\r\n Lütfen kart başlığını yazınız: ");
            string title = Console.ReadLine().ToLower();
            foreach (Card card in cards)
            {
                if (card.Title.ToLower().Equals(title))
                {
                    Console.WriteLine("Kart Bilgileri :");
                    writeCard(card.Title, card.Title, card.Person, card.Size, card.Line);
                    Console.Write("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) IN PROGRESS (3) DONE)"); string secim2 =Console.ReadLine();
                    if (secim2.Equals("1"))
                    {
                        card.Line = Line.TODO.ToString();
                        anaEkran();
                    }
                    else if (secim2.Equals("2"))
                    {
                        card.Line = Line.IN_PROGRESS.ToString();
                        anaEkran();
                    }
                    else if (secim2.Equals("3"))
                    {
                        card.Line = Line.DONE.ToString();
                        anaEkran();
                    }

                }
            }
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\r\n " +
                "* Güncellemeyi sonlandırmak için : (1)\r\n " +
                "* Yeniden denemek için : (2)");
            Console.Write("Seçiminiz :"); string secim = Console.ReadLine();
            if (secim.Equals("1"))
                anaEkran();
            else if (secim.Equals("2"))
                update();
        }

        public void writeCard(string title, string content, string person, string size)
        {
            Console.WriteLine("Başlık       :{0}",title);
            Console.WriteLine("İçerik       :{0}",content);
            Console.WriteLine("Atanan Kişi  :{0}",person);
            Console.WriteLine("Büyüklük     :{0}",size);
            Console.WriteLine("");
        }
        public void writeCard(string title, string content, string person, string size, string line)
        {
            Console.WriteLine("Başlık       :{0}", title);
            Console.WriteLine("İçerik       :{0}", content);
            Console.WriteLine("Atanan Kişi  :{0}", person);
            Console.WriteLine("Büyüklük     :{0}", size);
            Console.WriteLine("Line         :{0}", line);
            Console.WriteLine("");
        }





    }
}
