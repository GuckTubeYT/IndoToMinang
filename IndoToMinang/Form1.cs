using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndoToMinang
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, string> pdictonary;
        public Form1()
        {
            InitializeComponent();
            pdictonary = new Dictionary<string, string>();
            pdictonary.Add("saya", "awak");
            pdictonary.Add("aku", "ambo");
            pdictonary.Add("orang", "urang");
            pdictonary.Add("belajar", "baraja");
            pdictonary.Add("gak", "ndak");
            pdictonary.Add("nggak", "ndak");
            pdictonary.Add("enggak", "ndak");
            pdictonary.Add("engga", "ndak");
            pdictonary.Add("tidak", "indak");
            pdictonary.Add("pak", "apak");
            pdictonary.Add("bapak", "apak");
            pdictonary.Add("ibu", "amak");
            pdictonary.Add("bunda", "bundo");
            pdictonary.Add("kakak", "uda");
            pdictonary.Add("abang", "uda");
            pdictonary.Add("pasar", "pasa");
            pdictonary.Add("semangka", "kambojo");
            pdictonary.Add("membeli", "mamabali");
            pdictonary.Add("beli", "bali");
            pdictonary.Add("jual", "jua");
            pdictonary.Add("menjual", "manjua");
            pdictonary.Add("mobil", "oto");
            pdictonary.Add("kereta", "kareta");
            pdictonary.Add("hidup", "iduik");
            pdictonary.Add("alat", "alaik");
            pdictonary.Add("tempat", "tampek");
            pdictonary.Add("tinggal", "tingga");
            pdictonary.Add("rumah", "gadang");
            pdictonary.Add("desa", "koroang");
            pdictonary.Add("kampung", "kampuang");
            pdictonary.Add("lorong", "labuah");
            pdictonary.Add("goa", "guo");
            pdictonary.Add("gua", "guo");
            pdictonary.Add("jembatan", "jambektan");
            pdictonary.Add("sungai", "batang aia");
            pdictonary.Add("semua", "kasado");
            pdictonary.Add("semuanya", "kasadonyo");
            pdictonary.Add("sekolah", "sikola");
            pdictonary.Add("anjing", "anjiang");
            pdictonary.Add("monyet", "baruak");
            pdictonary.Add("babi", "kandiak");
            pdictonary.Add("bodoh", "ongok");
            pdictonary.Add("goblok", "ongok");
            pdictonary.Add("bego", "ongok");
            pdictonary.Add("tolol", "ongok");
            pdictonary.Add("kamu", "waang");
            pdictonary.Add("kau", "ang");
            pdictonary.Add("lu", "waang"); //lu = bahasa betawi, dan rata-rata, lu = kamu, jadi bahasa padang nya kamu = waang
            pdictonary.Add("gw", "ambo"); //gw = bahasa betawi, dan rata rata, gw = aku, jadi bahasa padang nya "aku" = ambo
            pdictonary.Add("gue", "ambo"); //gue = bahasa betawi, dan rata rata, gue = aku, jadi bahasa padang nya "aku" = ambo
            pdictonary.Add("abu-abu", "kulabu");
            pdictonary.Add("warna", "warno");
            pdictonary.Add("aba-aba", "parentah");
            pdictonary.Add("saja", "sajo");
            pdictonary.Add("aja", "sajo");
            pdictonary.Add("bentar", "banta");
            pdictonary.Add("sebentar", "sabanta");
            pdictonary.Add("hitam", "itam");
            pdictonary.Add("kuning", "kuniang");
            pdictonary.Add("uang", "pitih");
            pdictonary.Add("berapa", "bara");
            pdictonary.Add("harga", "arago");
            pdictonary.Add("hitung", "etoang");
            pdictonary.Add("menghitung", "maetoang");
            pdictonary.Add("acak", "aciak");
            pdictonary.Add("acara", "acaro");
            pdictonary.Add("cukup", "cukuik");
            pdictonary.Add("banyak", "sambuah");
            pdictonary.Add("absen", "mangkia");

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            string translate = IDLineToMinang(textBox1.Text.ToLower());
            textBox2.Text = translate;
        }
        static string IDLineToMinang(string line)
        {
            // array of words:
            string[] words = line.Split(' ');
            string ToReturn = "";

            foreach (string word in words)
            {
                string temp = IDToMinang(word) + " ";
                ToReturn += temp;
            }
            return ToReturn;
        }
        static string IDToMinang(string EngWord)
        {
            string key1 = EngWord;
            // if not has the meaning return the same word!
            if (!pdictonary.ContainsKey(key1)) return EngWord;
            else return pdictonary[key1];
        }
    }
}
