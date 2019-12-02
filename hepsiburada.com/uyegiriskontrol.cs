using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hepsiburada.com
{
    class uyegiriskontrol     
    {
        string şifre;
        string mail;
        
           
        public Boolean login(string mail, string sifre)

        {
            sifre = this.şifre;
            mail = this.mail;

            if (mail == "esraaerdim@hotmail.com")
            {
                if (sifre == "1234")
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }

            else if (mail == "esraaerdim@gmail.com")
            {
                if (sifre == "12345")
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }

            else
            {
                return false;

            }


            
        }












       
    }
}
