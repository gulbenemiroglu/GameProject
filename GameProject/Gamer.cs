using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }

        private string UserName;

        public string userName
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }
       
    }
}
