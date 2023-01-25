using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO.Datas
{
    public class Database
    {
        private static List<Card> _defaultCard;
        private static List<Person> _person;
        static Database()
        {
            _person = new List<Person>()
            {
                new Person{Id=1,Name="Ferit Aslan"},
                new Person{Id=2,Name="Ela Koç"},
                new Person{Id=3,Name="Murat İkizler"},
                new Person{Id=4,Name="Buket Terazi"}
            };

            _defaultCard = new List<Card>()
            {
                new Card{Title="Giyim",Content="Kazak",Member="Ali Anapalar",Size="L",Line="TODO"},
                new Card{Title="Giyim",Content="SweatShirt",Member="Ali Anapalar",Size="XS",Line="TODO"},
                new Card{Title="Aksesuar",Content="Saat",Member="Ali Anapalar",Size="S",Line="INPROGRESS"},
                new Card{Title="Elektronik",Content="Bilgisayar",Member="Derin Deniz",Size="L",Line="DONE"},
            };

        }

        public static List<Card> defaultCard => _defaultCard;
        public static List<Person> defaultPersons => _person;
    }
}
