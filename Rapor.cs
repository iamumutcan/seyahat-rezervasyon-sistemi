using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace TatilRez
{
    public class RaporViewModel : RezBilgi
    {
        public string RaporlamaTipi { get; set; }

    }
    public abstract class RaporBuilder
    {
        public abstract void RaporCiktisi(int ID);
        public abstract RaporViewModel GetModel();
    }
    public class XmlRapor : RaporBuilder
    {
        RaporViewModel model = new RaporViewModel();
        public override void RaporCiktisi(int ID)
        {
            model.RaporlamaTipi = ID + "Numaralı Müşterinin XML Raporu Oluşturludu.";
            SqlCommand komut = new SqlCommand("SELECT * FROM tblRezBilgileri WHERE RezId=@Id", Datacon.baglanti());
            komut.Parameters.AddWithValue("@Id", ID);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                XmlTextWriter xmlR = new XmlTextWriter("yolcu.xml",Encoding.UTF8);
                xmlR.Formatting = Formatting.Indented;
                xmlR.WriteStartDocument();
                xmlR.WriteStartElement("Seyahat");
                xmlR.WriteElementString("TCKN", Convert.ToString(dr[1]));
                xmlR.WriteElementString("Ad", Convert.ToString(dr[2]));
                xmlR.WriteElementString("Soyad", Convert.ToString(dr[3]));
                xmlR.WriteElementString("Konaklama Türü", Convert.ToString(dr[4]));
                xmlR.WriteElementString("Ulaşım Türü", Convert.ToString(dr[5]));
                xmlR.WriteElementString("Nereden", Convert.ToString(dr[6]));
                xmlR.WriteElementString("Nereye", Convert.ToString(dr[7]));
                xmlR.WriteElementString("Gidiş Tarihi", Convert.ToString(dr[8]));
                xmlR.WriteElementString("Dönüş Tarihi", Convert.ToString(dr[9]));
                xmlR.WriteEndElement();
                xmlR.Close();
                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }
        }
        public override RaporViewModel GetModel()
        {
            return model;
        }
    }
    public class HtmlRapor : RaporBuilder
    {
        RaporViewModel model = new RaporViewModel();
        public override void RaporCiktisi(int ID)
        {
            model.RaporlamaTipi = ID +"Numaralı Müşterinin HTML Raporu Oluşturludu.";
            SqlCommand komut = new SqlCommand("SELECT * FROM tblRezBilgileri WHERE RezId=@Id", Datacon.baglanti());
            komut.Parameters.AddWithValue("@Id", ID);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string html = "<!DOCTYPE html><html><head> <title>UCY MEDYA</title> <link href='https://fonts.googleapis.com/css?family=Lobster|Kreon:400,700' rel='stylesheet' type='text/css'> <!-- <link rel='stylesheet' href='styles/main.css' media='screen' charset='utf-8'/> --> <meta content='width=device-width, initial-scale=1.0' name='viewport'> <meta http-equiv='content-type' content='text-html; charset=utf-8'></head><link rel='stylesheet' href='main.css'><body> <div class='container'> <section> <div class='circle'> <div class='event'>İyi <br> Yolculuklar</div> <div class='title'>" + Convert.ToString(dr[2]) + Convert.ToString(dr[3]) + "</div> </div> <div class='special'></div> <div class='special'></div> <div class='special'></div> <div class='special'></div> <div class='special'> <div class='seats'> <span class='label'></span><span>TCKN</span> </div>" + Convert.ToString(dr[1]) + "</div> <div class='special'> <div class='seats'> <span class='label'></span><span>Ulaşım Tipi:</span> </div>" + Convert.ToString(dr[4]) + " </div> <div class='special'> <div class='seats'> <span class='label'></span><span>Konaklama Tipi:</span> </div>" + Convert.ToString(dr[5]) + " </div> <div class='special'> <div class='seats'> <span class='label'></span><span>Nereden:</span> </div>" + Convert.ToString(dr[6]) + " </div> <div class='special'> <div class='seats'> <span class='label'></span><span>Nereye:</span> </div>" + Convert.ToString(dr[7]) + " </div> <div class='special'> <div class='seats'> <span class='label'></span><span>Gidiş Tarihi</span> </div>" + Convert.ToString(dr[8]) + "</div> <div class='special'> <div class='seats'> <span class='label'></span><span>Dönüş Tarihi</span> </div>" + Convert.ToString(dr[9]) + " </div> </section> <aside> </aside> </div> </body> </html> ";
            File.WriteAllText(@"yolcu.htm", html);
                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }
        }
        public override RaporViewModel GetModel()
        {
            return model;
        }
    }
    public class JsonRapor : RaporBuilder
    {
        RaporViewModel model = new RaporViewModel();
        public override void RaporCiktisi(int ID)
        {
            model.RaporlamaTipi = ID + "Numaralı Müşterinin JSON Raporu Oluşturludu.";
            SqlCommand komut = new SqlCommand("SELECT * FROM tblRezBilgileri WHERE RezId=@Id FOR JSON AUTO;", Datacon.baglanti());
            komut.Parameters.AddWithValue("@Id", ID);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string json = Convert.ToString(dr[0]);
                json = json.Substring(1, json.Length - 1);
                json = json.Substring(0, json.Length - 1);
                File.WriteAllText(@"yolcu.json", json);
                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }
        }
        public override RaporViewModel GetModel()
        {
            return model;
        }
    }

    public class RaporDirector
    {
        public void GenereteProduct(RaporBuilder raporBuilder,int MusteriId)
        {
            raporBuilder.RaporCiktisi(MusteriId);

        }
    }
}
