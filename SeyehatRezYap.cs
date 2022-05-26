using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TatilRez
{
    public class SeyahatRez:RezBilgi
    {
    
        public string mesaj { get; set; }
        private SeyahatFabrikalari _SeyahatFabrikalari;
        private UlasimBase _UlasimBase;
        private KonaklamaBase _konaklamaBase;
        public int ToplamFiyat { get; set; }= 0;
        
        public SeyahatRez(SeyahatFabrikalari seyahatFabrikalari)
        {
            _SeyahatFabrikalari = seyahatFabrikalari;
            _UlasimBase = _SeyahatFabrikalari.UlasimYap();
            _konaklamaBase = _SeyahatFabrikalari.KonaklamaYap();

        }
        public void RezYap()
        {
            _UlasimBase.Ulas();
            _konaklamaBase.Konak();
            UlasimTuru = _UlasimBase.UlasimTipi;
            KonaklamaTuru = _konaklamaBase.KonaklamaTipi;
            TimeSpan fark = DonusTarih - GidisTarih;
            int KonaklamaSuresi=Convert.ToInt16(fark.Days);
            ToplamFiyat = _UlasimBase.UlasimFiyati + (KonaklamaSuresi * _konaklamaBase.KonaklamaFiyati);

            mesaj = "Ulaşım Türü: " + UlasimTuru + "\n Konaklama Türü: " + KonaklamaTuru + "\n Toplam Fiyat: " + ToplamFiyat;
                SqlCommand komut = new SqlCommand("INSERT INTO tblRezBilgileri(TCKN,Ad,Soyad,Ulasim,Konaklama,Nereden,Nereye,GidisTarih,DonusTarih,Fiyat) VALUES(@TCKN,@MusteriAd,@MusteriSoyad,@UlasimTuru,@KonaklamaTuru,@Nereden,@Nereye,@GidisTarih,@DonusTarih,@Fiyat)", Datacon.baglanti());
                komut.Parameters.AddWithValue("@TCKN", TCKN);
                komut.Parameters.AddWithValue("@MusteriAd", MusteriAd);
                komut.Parameters.AddWithValue("@MusteriSoyad", MusteriSoyad);
                komut.Parameters.AddWithValue("@KonaklamaTuru", KonaklamaTuru);
                komut.Parameters.AddWithValue("@UlasimTuru", UlasimTuru);
                komut.Parameters.AddWithValue("@Nereden", Nereden);
                komut.Parameters.AddWithValue("@Nereye", Nereye);
                komut.Parameters.AddWithValue("@GidisTarih", GidisTarih);
                komut.Parameters.AddWithValue("@DonusTarih", DonusTarih);
                komut.Parameters.AddWithValue("@Fiyat", ToplamFiyat);
            int cmd = komut.ExecuteNonQuery();
                if (cmd != 0)
                {
                Datacon.baglanti().Close();
                
                }
                else { Datacon.baglanti().Close(); }

            

        }

    }

}
