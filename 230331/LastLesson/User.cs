using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System .Threading .Tasks;

namespace LastLesson
{
    internal class User
    {
        string [ ] names = new string [] {"Иван","Андрей","Сергей","Василий","Геракл","Игнат","Лидия","Алена"};
        string [ ] surnames = new string [] {"Иванов","Андрейко","Сергеенко","Василенович","Геренов","Игонин","Лидика","Алеока"};

        public string Name;
        public string Surname;
        public int Age;

        public void Trim()
        {
            Surname = Surname.Trim();
            Name = Name.Trim();
        }
        public void Create ( )
        {
            var random = new Random ();
            Name = names [ random .Next ( 8 ) ];
            Surname = surnames [ random .Next ( 8 ) ];
            Age = random .Next ( 30 )+18;
        }
        public bool Validate()
        {
            bool isValid = true;
            if(Name == "" || Name == null)
            {
                isValid = false;
            }
            if(string.IsNullOrEmpty(Surname))
            {
                isValid = false;
            }
            if (Age < 18)
            {
                isValid = false;
            }
            return isValid;
            //Как вариант записи вышеизложенного, чтобы проверить что в строка не пустая и возраст больше либо равно 18
            //return !string .IsNullOrEmpty ( Name ) && !string .IsNullOrEmpty ( Surname ) && Age >= 18;
        }
        public void PrintAgeDifference ( User [ ] otherUsers)
        {
            for ( int i = 0 ; i < otherUsers.Length; i++ )
            {
                Console .WriteLine ( Age - otherUsers [ i ] .Age );
            }

        }

    }
}
