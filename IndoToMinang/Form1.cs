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
            pdictonary.Add("Saya", "Awak");
            pdictonary.Add("aku", "ambo");
            pdictonary.Add("Aku", "Ambo");
            pdictonary.Add("orang", "urang");
            pdictonary.Add("Orang", "Urang");
            pdictonary.Add("belajar", "baraja");
            pdictonary.Add("Belajar", "Baraja");
            pdictonary.Add("gak", "ndak");
            pdictonary.Add("Gak", "Ndak");
            pdictonary.Add("nggak", "ndak");
            pdictonary.Add("Nggak", "Ndak");
            pdictonary.Add("enggak", "ndak");
            pdictonary.Add("Enggak", "Ndak");
            pdictonary.Add("engga", "ndak");
            pdictonary.Add("Engga", "Ndak");
            pdictonary.Add("tidak", "indak");
            pdictonary.Add("Tidak", "Indak");
            pdictonary.Add("pak", "apak");
            pdictonary.Add("Pak", "Apak");
            pdictonary.Add("bapak", "apak");
            pdictonary.Add("Bapak", "Apak");
            pdictonary.Add("ibu", "amak");
            pdictonary.Add("Ibu", "Amak");
            pdictonary.Add("bunda", "bundo");
            pdictonary.Add("Bunda", "Bundo");
            pdictonary.Add("kakak", "uda");
            pdictonary.Add("Kakak", "Uda");
            pdictonary.Add("abang", "uda");
            pdictonary.Add("Abang", "Uda");
            pdictonary.Add("pasar", "pasa");
            pdictonary.Add("Pasar", "Pasa");
            pdictonary.Add("semangka", "kambojo");
            pdictonary.Add("Semangka", "Kambojo");
            pdictonary.Add("membeli", "mamabali");
            pdictonary.Add("Membeli", "Mamabali");
            pdictonary.Add("beli", "bali");
            pdictonary.Add("Beli", "Bali");
            pdictonary.Add("jual", "jua");
            pdictonary.Add("Jual", "Jua");
            pdictonary.Add("menjual", "manjua");
            pdictonary.Add("Menjual", "Manjua");
            pdictonary.Add("mobil", "oto");
            pdictonary.Add("Mobil", "Oto");
            pdictonary.Add("kereta", "kareta");
            pdictonary.Add("Kereta", "Kareta");
            pdictonary.Add("hidup", "iduik");
            pdictonary.Add("Hidup", "Iduik");
            pdictonary.Add("alat", "alaik");
            pdictonary.Add("Alat", "Alaik");
            pdictonary.Add("tempat", "tampek");
            pdictonary.Add("Tempat", "Tampek");
            pdictonary.Add("tinggal", "tingga");
            pdictonary.Add("Tinggal", "Tingga");
            pdictonary.Add("rumah", "gadang");
            pdictonary.Add("Runah", "Gadang");
            pdictonary.Add("desa", "koroang");
            pdictonary.Add("Desa", "Koroang");
            pdictonary.Add("kampung", "kampuang");
            pdictonary.Add("Kampung", "Kampuang");
            pdictonary.Add("lorong", "labuah");
            pdictonary.Add("Lorong", "Labuah");
            pdictonary.Add("goa", "guo");
            pdictonary.Add("Goa", "Guo");
            pdictonary.Add("gua", "guo");
            pdictonary.Add("Gua", "Guo");
            pdictonary.Add("jembatan", "jambektan");
            pdictonary.Add("Jembatan", "Jambektan");
            pdictonary.Add("sungai", "batang aia");
            pdictonary.Add("Sungai", "Batang aia");
            pdictonary.Add("semua", "kasado");
            pdictonary.Add("Semua", "Kasado");
            pdictonary.Add("semuanya", "kasadonyo");
            pdictonary.Add("Semuanya", "Kasadonyo");
            pdictonary.Add("sekolah", "sikola");
            pdictonary.Add("Sekolah", "Sikola");
            pdictonary.Add("anjing", "anjiang");
            pdictonary.Add("Anjing", "Anjiang");
            pdictonary.Add("monyet", "baruak");
            pdictonary.Add("Monyet", "Baruak");
            pdictonary.Add("babi", "kandiak");
            pdictonary.Add("Babi", "Kandiak");
            pdictonary.Add("bodoh", "ongok");
            pdictonary.Add("Bodoh", "Ongok");
            pdictonary.Add("goblok", "ongok");
            pdictonary.Add("Goblok", "Ongok");
            pdictonary.Add("bego", "ongok");
            pdictonary.Add("Bego", "Ongok");
            pdictonary.Add("tolol", "ongok");
            pdictonary.Add("Tolol", "Ongok");
            pdictonary.Add("kamu", "ang");
            pdictonary.Add("Kamu", "Ang");
            pdictonary.Add("kau", "ang");
            pdictonary.Add("Kau", "Ang");
            pdictonary.Add("lu", "ang"); //lu = bahasa betawi
            pdictonary.Add("Lu", "Ang"); //Lu = bahasa betawi
            
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            string translate = IDLineToMinang(textBox1.Text);
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
