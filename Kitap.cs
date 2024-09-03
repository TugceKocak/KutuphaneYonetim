using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetim
{
    

    internal class Kitap(int id, string adi,string yazar,int isbn, int turKodu)
    {
        private string adi = adi;
        private string yazar = yazar;
        private int isbn=isbn;
        private int id = id;
        private int turKodu = turKodu;

        public string Adi { get => adi; set => adi = value; }
        public string Yazar { get => yazar; set => yazar = value; }
        public int Isbn { get => isbn; set => isbn = value; }
        public int Id { get => id; set => id = value; }
        public int TurKodu { get => turKodu; set => turKodu = value; }
    }
}
