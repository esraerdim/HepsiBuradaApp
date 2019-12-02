using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace mailkontrol
{
    public class ControlService : IControl
    {
        List<string> mailler = new List<string>();
        public void mailekle()
        {
            mailler.Add("esraaerdim@hotmail.com");
            mailler.Add("esraaerdim@hotmail.com");
            mailler.Add("huseyinsavran@gmail.com");
            mailler.Add("esindortkardesler@hotmail.com");

        }
        public string kontrol(string a)
        {
            string acıklama = " ";
            for (int i = 0; i < mailler.Count; i++)
            {
                if(mailler[i]== a)
                {
                    acıklama = "şifre değiştirme talebiniz alındı,lütfen mailinizi kontrol edin.";
                }
                else
                {
                    acıklama = " ";
                }
                
            
        }
            if (acıklama == " ")
            {
                acıklama = "Böyle bir kayıt bulunamadı lütfen kontrol edin ya da üye olun.";
            }
            return acıklama;
        }

    }
    
}