using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWordGame
{
    public enum Sex
    {
        Male = 1,
        Female = 2
    }
    public class User
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Sex sex { get; set; }
        public string login { get; set; }
        public string passwordHash { get; set; }
        public int score { get; set; }
        public int currentQuestion { get; set; }
    }
}
