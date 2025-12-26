using System;
using System.Windows.Forms;
using System.IO;
using BankLibrary;

namespace KrediSorgulama
{
   public partial class KrediSorgulamaFormu : Form
   {
      private FileStream dosyaAkisi; 
      private StreamReader dosyaOkuyucu;     

      public KrediSorgulamaFormu()
      {
         InitializeComponent();
      }

      private void acButonu_Tikla(object gonderen, EventArgs e)
      {
         DialogResult sonuc;
         string dosyaAdi;

         using (OpenFileDialog dosyaSecici = new OpenFileDialog())
         {
            sonuc = dosyaSecici.ShowDialog();
            dosyaAdi = dosyaSecici.FileName;
         }

         if (sonuc == DialogResult.OK)
         {
            if (string.IsNullOrEmpty(dosyaAdi))
            {
               MessageBox.Show("Geçersiz Dosya Adı", "Hata",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               dosyaAkisi = new FileStream(dosyaAdi,
                  FileMode.Open, FileAccess.Read);

               dosyaOkuyucu = new StreamReader(dosyaAkisi);

               acButonu.Enabled = false;
               alacakButonu.Enabled = true;
               borcButonu.Enabled = true;
               sifirButonu.Enabled = true;
            }
         }
      }

      private void bakiyeleriGetir_Tikla(object gonderen, System.EventArgs e)
      {
         Button gonderenButon = (Button)gonderen;
         string hesapTuru = gonderenButon.Text;

         try
         {
            dosyaAkisi.Seek(0, SeekOrigin.Begin);

            goruntulemeMetinKutusu.Text =
               $"{hesapTuru} olan hesaplar{Environment.NewLine}";

            while (true)
            {
               string girisKaydi = dosyaOkuyucu.ReadLine();

               if (girisKaydi == null)
               {
                  return;
               }

               string[] girisAlanlari = girisKaydi.Split(',');

               var kayit = new Record(int.Parse(girisAlanlari[0]), girisAlanlari[1],
                     girisAlanlari[2], decimal.Parse(girisAlanlari[3]));

               if (GoruntulenmeliMi(kayit.Balance, hesapTuru))
               {
                  goruntulemeMetinKutusu.AppendText($"{kayit.Account}\t" +
                     $"{kayit.FirstName}\t{kayit.LastName}\t" +
                     $"{kayit.Balance:C}{Environment.NewLine}");
               }
            }
         }
         catch (IOException)
         {
            MessageBox.Show("Dosya Okunamıyor", "Hata",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private bool GoruntulenmeliMi(decimal bakiye, string hesapTuru)
      {
         if (bakiye > 0M && hesapTuru == "Alacak Bakiyeleri")
         {
            return true;
         }
         else if (bakiye < 0M && hesapTuru == "Borç Bakiyeleri")
         {
            return true;
         }
         else if (bakiye == 0 && hesapTuru == "Sıfır Bakiyeler")
         {
            return true; 
         }

         return false;
      }

      private void tamamButonu_Tikla(object gonderen, EventArgs e)
      {
         try
         {
            dosyaOkuyucu?.Close(); 
         }
         catch (IOException)
         {
            MessageBox.Show("Dosya kapatılamıyor", "Hata",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

         Application.Exit();
      }
   }
}