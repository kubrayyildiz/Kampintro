using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidation userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            this.userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (userValidation.Validate(gamer) == true) 
            {
                Console.WriteLine("Kayıt Olundu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız,kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
