using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWordGame
{
    public interface UserDao
    {
        User add(User user);
        User findUser(String email, String password);
        List<User> all();
        User update(User user);
    }
}
