using System.Windows.Forms;
using System.Drawing;

class Sample4{
  public static void Main(){
    Form fm =new Form();
    fm.Text="sample";
    fm.Width=300;
    fm.Height=200;
    
    PictureBox[] pb= new PictureBox[2];
    for(int i=0;i<pb.Length;i++){
       pb[i]=new PictureBox();
       pb[i].Parent=fm;
      }
  Car[] c=new Car[2];
  c[0]=new Car();
  c[1]=new RacingCar();
  
  for(int i=0;i<c.Length;i++){
    c[i].Move();
    pb[i].Image=c[i].GetImage();
    pb[i].Top=c[i].Top;
    pb[i].Left=c[i].Left;  
  }
  Application.Run(fm);
  
  }
a
