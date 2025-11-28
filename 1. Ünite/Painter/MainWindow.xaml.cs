using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Painter
{
   public partial class MainWindow : Window
   {
      private int daireCapi = (int) Sizes.MEDIUM;
      private Brush fircaRengi = Brushes.Black;
      private bool silmeModu = false;
      private bool cizimModu = false;
 
      private enum Sizes
      {
         SMALL = 4,
         MEDIUM = 8,
         LARGE = 10
      } 

      public MainWindow()
      {
         InitializeComponent();
      } 

      private void PaintCircle( Brush daireRengi, Point konum )
      {
         Ellipse yeniElips = new Ellipse();  
                                                                    
         yeniElips.Fill = daireRengi;   
         yeniElips.Width = daireCapi;
         yeniElips.Height = daireCapi;
         
         Canvas.SetTop( yeniElips, konum.Y ); 
         Canvas.SetLeft( yeniElips, konum.X );

         paintCanvas.Children.Add( yeniElips );
      } 


      private void paintCanvas_MouseLeftButtonDown( object sender, MouseButtonEventArgs e )
      {
         cizimModu = true;
      }

      private void paintCanvas_MouseLeftButtonUp( object sender, MouseButtonEventArgs e )
      {
         cizimModu = false;
      }

      private void paintCanvas_MouseRightButtonDown( object sender, MouseButtonEventArgs e )
      {
         silmeModu = true;
      }

      private void paintCanvas_MouseRightButtonUp( object sender, MouseButtonEventArgs e )
      {
         silmeModu = false;
      }

      private void paintCanvas_MouseMove( object sender, MouseEventArgs e )
      {
         if ( cizimModu )
         {
            Point fareKonumu = e.GetPosition( paintCanvas );
            PaintCircle( fircaRengi, fareKonumu );
         } 
         else if ( silmeModu )
         {
            Point fareKonumu = e.GetPosition( paintCanvas );
            PaintCircle( paintCanvas.Background, fareKonumu );
         } 
      }

      private void redRadioButton_Checked( object sender, RoutedEventArgs e )
      {
         fircaRengi = Brushes.Red;
      }

      private void blueRadioButton_Checked( object sender, RoutedEventArgs e )
      {
         fircaRengi = Brushes.Blue;
      }

      private void greenRadioButton_Checked( object sender, RoutedEventArgs e )
      {
         fircaRengi = Brushes.Green;
      }

      private void blackRadioButton_Checked( object sender, RoutedEventArgs e )
      {
         fircaRengi = Brushes.Black;
      }

      private void smallRadioButton_Checked( object sender, RoutedEventArgs e )
      {
         daireCapi = ( int ) Sizes.SMALL;
      }

      private void mediumRadioButton_Checked( object sender, RoutedEventArgs e )
      {
         daireCapi = ( int ) Sizes.MEDIUM;
      }

      private void largeRadioButton_Checked( object sender, RoutedEventArgs e )
      {
         daireCapi = ( int ) Sizes.LARGE;
      }

      private void undoButton_Click( object sender, RoutedEventArgs e )
      {
         int sayac = paintCanvas.Children.Count;

         if ( sayac > 0 )
            paintCanvas.Children.RemoveAt( sayac - 1 );
      }

      private void clearButton_Click( object sender, RoutedEventArgs e )
      {
         paintCanvas.Children.Clear(); 
      }
   }
}