namespace RessamUygulamasi
{
   partial class RessamFormu
   {
      private System.ComponentModel.IContainer bilesenler = null;

      protected override void Dispose(bool imhaEdiliyorMu)
      {
         if (imhaEdiliyorMu && (bilesenler != null))
         {
            bilesenler.Dispose();
         }
         base.Dispose(imhaEdiliyorMu);
      }

      #region Windows Form Designer generated code

      private void InitializeComponent()
      {
         this.SuspendLayout();
         
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(331, 302);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "RessamFormu";
         this.Text = "Ressam";
         this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RessamFormu_FareTusuBasildi);
         this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RessamFormu_FareHareketEttirildi);
         this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RessamFormu_FareTusuBirakildi);
         this.ResumeLayout(false);

      }

      #endregion
   }
}