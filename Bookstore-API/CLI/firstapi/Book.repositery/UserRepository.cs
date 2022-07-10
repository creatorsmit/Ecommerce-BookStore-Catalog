using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Data.ViewModels;

namespace Book.repositery
{
    public class UserRepository
    {
        testContext _context = new testContext();
        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
