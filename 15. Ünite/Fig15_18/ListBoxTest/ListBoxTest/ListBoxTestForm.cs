using System;
using System.Windows.Forms;

namespace ListeKutusuTesti
{
   public partial class ListeKutusuTestFormu : Form
   {
      public ListeKutusuTestFormu()
      {
         InitializeComponent();
      }

      private void ekleButonu_Tikla(object gonderen, EventArgs e)
      {
         goruntuListeKutusu.Items.Add(girisMetinKutusu.Text);
         girisMetinKutusu.Clear();
      }

      private void silButonu_Tikla(object gonderen, EventArgs e)
      {
         if (goruntuListeKutusu.SelectedIndex != -1)
         {
            goruntuListeKutusu.Items.RemoveAt(goruntuListeKutusu.SelectedIndex);
         }
      }

      private void temizleButonu_Tikla(object gonderen, EventArgs e)
      {
         goruntuListeKutusu.Items.Clear();
      }

      private void cikisButonu_Tikla(object gonderen, EventArgs e)
      {
         Application.Exit();
      }
   }
}