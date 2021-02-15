using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApplication
{
    class Personel
    {
        string _TCKNo;
        public string TCKNo
        {
            get
            {
                return _TCKNo;
            }
            set
            {
                if (value.Length == 11 && Convert.ToInt64(value) % 2 == 0)
                {
                    _TCKNo = value;
                }
                else
                {
                    throw new Exception("TC Kimlik Numarası Hatalı");
                }
            }
        }

        string _Ad;

        public string Ad
        {
            get
            {
                return _Ad;
            }
            set
            {
                if (value.Length > 2)
                {
                    _Ad = value;
                }
                else
                {
                    throw new Exception("Girilen İsim Doğru Değil");
                }
            }
        }

        string _Soyad;

        public string Soyad
        {
            get
            {
                return _Soyad;
            }
            set
            {
                if (value.Length > 2)
                {
                    _Soyad = value;
                }
                else
                {
                    throw new Exception("Girilen Soyisim Doğru Değil");
                }
            }
        }

        DateTime _DogumTarihi;

        public DateTime DogumTarihi
        {
            get
            {
                return _DogumTarihi;
            }
            set
            {
                if ((DateTime.Now.Year - value.Year) > 18)
                {
                    _DogumTarihi = value;
                }
                else
                {
                    throw new Exception("18 Yaşından Küçük Olanalar Kayıt Olamazlar!");
                }
            }
        }

        string _Telefon;

        public string Telefon
        {
            get
            {
                return _Telefon;
            }
            set
            {
                if (value.Length == 14)
                {
                    _Telefon = value;
                }
                else
                {
                    throw new Exception("Girilen Telefon Numarası Hatalı");
                }
            }
        }

        string _EMail;

        public string EMail
        {
            get
            {
                return _EMail;
            }
            set
            {
                if (value.IndexOf("@") > -1 && value.IndexOf(".com") > -1)
                {
                    _EMail = value;
                }
                else
                {
                    throw new Exception("Girilen E-Mail Adresi Hatalı.");
                }
            }
        }

        string _Adres;

        public string Adres
        {
            get
            {
                return _Adres;
            }
            set
            {
                if (value.Length > 10)
                {
                    _Adres = value;
                }
                else
                {
                    throw new Exception("Girilen Adres Bilgisini Koltrol Ediniz.");
                }
            }
        }
        private DateTime _IseGisisTarihi;

        public DateTime IseGirisTarihi
        {
            get
            {
                return _IseGisisTarihi;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    _IseGisisTarihi = value;
                }
                else
                {
                    throw new Exception("İşe Giriş Tarihi bu gününe veya daha sonraki bir güne eşit olamaz.");
                }
            }
        }

        string _ResimDosyaYolu;
        public string ResimDosyaYolu
        {
            get
            {
                return _ResimDosyaYolu;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("Lütfen Resim Seçiniz");
                }
                else
                {
                    _ResimDosyaYolu = value;
                }
            }
        }

        Departmanlar _departman;
        public Departmanlar departman
        {
            get 
            { 
                return _departman; 
            }
            set 
            { 
                if (value == null)
                {
                    throw new Exception("Lütfen Bir Ünvan Seçiniz");
                }
                else
                {
                    _departman = value;
                }
            }
        }




    }

    enum Departmanlar
    {
        İsçi,
        MüdürYardımcısı,
        BirimMüdürü,
        GenelMüdürYardımcısı,
        GenelMüdür,
        YönetimKurulu,
        YönetimKuruluBaşkanYardımcısı,
        YönetimKuruluBaşkanı
    }
}
