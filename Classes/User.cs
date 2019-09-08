using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studrex.Classes
{
    public class User
    {
        private string username, firstname, lastname;
        private int role;

        public string getUsername()
        {
            return this.username;
        }

        public string getFirstname()
        {
            return this.firstname;
        }

        public string getLastName()
        {
            return this.lastname;
        }

        public int getRole()
        {
            return this.role;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setFirstname(string firstname)
        {
            this.firstname = firstname;
        }

        public void setLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public void setRole(int role)
        {
            this.role = role;
        }

        public User()
        {

        }

        public User(string username, string firstname, string lastname, int role)
        {
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.role = role;
        }
    }

    
}
