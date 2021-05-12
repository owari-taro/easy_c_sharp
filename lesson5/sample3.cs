using System.Windows.Forms;
using System.Drawing;

class Sample3{
  public static void Main(){
    Form fm=new FOrm();
     fm.Text="sample";
     fm.Width=250;
     fm.Height=100;
     Label lb=new Label();
      
      Car c1= new Car();
      Car c2= new Car();
      lb.Text=Car.CounterCar();
      
      lb.Parent=fm;
      
      Application.Run(fm);
  
  }



}

class aCar{
//クラス変数
  pubic static int Count=0;
  private  Image img;
  private int top;
  private int left;
  
  public Car(){
    Count++;
    img=Image.FromFile("c:\\car.bmp");
    top=0;
    left=0;
  }

  public static string CountCar(){
    return "there are " +Count+" cars!"
  
  }
  public void Move(){
    top=top+10;
    left=left+10;
  }
  
  public voi SetImage(Image i){
    img=i;
  }
  
  public Image GetImage(){
    return img;
    }
    
   public int Top{
    set{top=value;}
    get {return top;}
   
   }
   public int Left{
    set{left=value;}
    get{return left}    
   }

}
