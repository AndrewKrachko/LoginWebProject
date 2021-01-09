using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWebProject
{
    public static class UserDb
    {
        public static IEnumerable<Tuple<string, string>> GetUsers() => new List<Tuple<string, string>>() { new Tuple<string, string>("User", "1234"), new Tuple<string, string>("AnotherUser", "4321") };
        
        public static IEnumerable<int> GetNumbers() => new[] { 2, 4, 8, 14, 1, 9 };
        
    }
}
