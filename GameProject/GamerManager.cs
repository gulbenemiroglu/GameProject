using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı kullanıcı sisteme eklenmiştir!");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız! Bilgilerinizin doğruluğu sağlanmamıştır.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı kullanıcı sistemden silinmiştir!");
            }
            else
            {
                Console.WriteLine("Oyuncu bulunamadı.");
            }
           

        }

        public void Update(Gamer gamer, string newUserName)
        {
            
            gamer.userName = newUserName;

            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Yeni kullanıcı adınız " + gamer.userName +" olarak güncellenmiştir!");
            }
            else
            {
                Console.WriteLine("Oyuncu bulunamadı");
            }


        }
    }
}
