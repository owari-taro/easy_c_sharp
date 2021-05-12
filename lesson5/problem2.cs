using System.Windows.Forms;
using System.Drawing;

class Sample2:Form{
  public static void Main(){
   Application.Run(new Sample2()):
  }

  public Sample2(){
    this.Text="sample";
    this.Width=400;
    this.Height=200;
    
    WhiteLabel w11 =new WhiteLabel();
    w11.Text="hello";
    
    WhhiteLabel w12~new WhiteLabel();
    w12.Text="thank you";
    w12.Left=w11.Left+150;
    
    w11.Parent=this;
    w12.Parent=this;
  }
}

class WhiteLabel:label
{
  public WhiteLabel(){
    this.BackColor=Color.White;
  }

}
