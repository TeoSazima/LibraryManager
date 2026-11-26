using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class Film
    {
        private int _id;
        public int id { get => _id; set => _id = value; }
        private string _nazev;
        public string nazev { get => _nazev; set => _nazev = value; }
        private int _rokvydani;
        public int rokvydani { get => _rokvydani; set => _rokvydani = value; }
        private int _pocetstran;
        public int pocetstran { get => _pocetstran; set => _pocetstran = value; }
        private string _zanr;
        public string zanr { get => _zanr; set => _zanr = value; }
        private int _autorId;
        public int autorId { get => _autorId; set => _autorId = value; }

    }
}
