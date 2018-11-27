using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumptiousSolution.LogicTier
{
    /// <summary>
    /// Admin class is a user class with more priveleges. Is derived from User.
    /// TODO: Implement
    /// </summary>
    public class Admin:User
    {

        public Admin(string username,string password):base(username,password)
        {

        }
    }
}
