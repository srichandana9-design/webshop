using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7
{
    public class dbManager
    {
        public static List<Users> GetUsers()
   
{

            List<Users> userList = new List<Users>()

{

new Users(){id=0, name="Sri", email_id="sri.g@gmail.com",password="12345",address="Hyderabad", pin_code = 424550},

new Users(){id=1, name="win", email_id="wins@gmail.com",password="54321",address="Mysore",pin_code = 429551},

new Users(){id=2, name="Nawaz", email_id="Nawaz123@gmail.com",password="1234",address="Mumbai",pin_code = 424952},

new Users(){id=3, name="Aryan", email_id="Aryan123@gmail.com",password="123",address="Hyderabad",pin_code = 42485},

new Users(){id=4, name="Anshuman", email_id="Anshuman123@gmail.com",password="qwert",address="Chennai",pin_code = 42855},

new Users(){id=5, name="Kartik", email_id="Kartik123@gmail.com",password="abcde",address="Jaipur",pin_code = 42555}

};

         return userList;

        }
    }

    }

