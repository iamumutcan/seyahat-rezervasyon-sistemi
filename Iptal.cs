using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TatilRez
{
    public class Iptal
    {
        public void RezIptal(int Id)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM tblRezBilgileri WHERE RezId=@RezId", Datacon.baglanti());
            komut.Parameters.AddWithValue("@RezId", Id);
            komut.ExecuteNonQuery();
            Datacon.baglanti().Close();
        }
        public void UlasimIptal(int Id)
        {
            SqlCommand komut = new SqlCommand("Update tblRezBilgileri set Ulasim=NULL WHERE RezId=@RezId", Datacon.baglanti());
            komut.Parameters.AddWithValue("@RezId", Id);
            komut.ExecuteNonQuery();
            Datacon.baglanti().Close();
        }
        public void KonaklamaIptal(int Id)
        {
            SqlCommand komut = new SqlCommand("Update tblRezBilgileri set Konaklama=NULL WHERE RezId=@RezId", Datacon.baglanti());
            komut.Parameters.AddWithValue("@RezId", Id);
            komut.ExecuteNonQuery();
            Datacon.baglanti().Close();

        }
    }
}
