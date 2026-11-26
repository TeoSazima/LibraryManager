using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class Author
    {
        private int _id;
        public int id { get => _id; set => _id = value; }
        private string _name;
        public string name { get => _name; set => _name = value; }
        private string _surename;
        public string surename { get => _surename; set => _surename = value; }

    }
}
