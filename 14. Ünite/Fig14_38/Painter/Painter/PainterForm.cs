using System;
using System.Drawing;
using System.Windows.Forms;

namespace RessamUygulamasi
{
   public partial class RessamFormu : Form
   {
      bool BoyamaliMi { get; set; } = false;

      public RessamFormu()
      {
         InitializeComponent();
      }

      private void RessamFormu_FareTusuBasildi(object gonderen, MouseEventArgs e)
      {
         BoyamaliMi = true;
      }

      private void RessamFormu_FareTusuBirakildi(object gonderen, MouseEventArgs e)
      {
         BoyamaliMi = false;
      }

      private void RessamFormu_FareHareketEttirildi(object gonderen, MouseEventArgs e)
      {
         if (BoyamaliMi)
         {
            using (Graphics grafik = CreateGraphics())
            {
               grafik.FillEllipse(
                  new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
            }
         }
      }
   }
}