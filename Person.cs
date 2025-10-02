using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Booking_System
{
    public class Person
    {

        #region Field Members
        private string id;
        private string name;
        private string phone;
        private string email;
        #endregion

        #region Property methods
        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }

        #endregion

        #region Constructors 
        public Person() { }
        
        public Person(String id, string name, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Name: {name}, Phone: {phone}";
        }

        #endregion

    }
}
