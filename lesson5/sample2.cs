using System.Windows.Forms;
using System.Drawing;


calss Sample2{
  public static void Main(){
    Form fm=new Form();
    fm.Text="sample";
    fm.Width=300;
    fm.Height=200;
    
    PictureBox pb=new PictureBox();
    
    Car c=new Car();
    c.Move();
    c.Move();

  
  }
}



class Car{
  private Image img;
  private int top;
  private int left;
  public Car(){
    img=Image.FromFile("c:\\car.bmp");
    top=0;
    left=0;
    }
    public void Move(){
      top=top+10;
      left=left+10;
      }
      
     public void SetImage(Image i){
      img=i;
     }
    
    public Image GetImage(){
      return img;
    }
    public int Top{
      set{top=value;}
      get{return top;}
    }
    
     public int Left{
        set{left=value;}
        get{return left; }
    
    }
    }

}
