using System.Windows.Forms;
using System.Drawing;

class Sample5{
  public static void Main(){
    Application.Rum(new Sample5())  
  }

  public Sample5(){
    this.Text="sample";
    this.Width=400;
    this.Height=200;
    this.BackGroundImage=Image.FromFile("c:\\car.bmp");
  }



}
