using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetim
{
    internal class Kullanici(string kullaniciAdi,string sifre)

    {
        private string kullaniciAdi = kullaniciAdi;
        private string sifre = sifre;

        ArrayList oduncKitaplar = new ArrayList();

        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Sifre { get => sifre; set => sifre = value; }

        public void oduncAl(Kitap k)
        {
            if (oduncKitaplar.Count < 5)
            {
                oduncKitaplar.Add(k);
            }
            else
            {
                MessageBox.Show("5 kitapdan fazla ödünç kitap alamazsınız!");
            }
        }
        public void iadeEt(Kitap k)
        {
            if (oduncKitaplar.Contains(k))
            {
                oduncKitaplar.Remove(k);
            }
        }

    }

}
