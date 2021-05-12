using System.Window.Forms;

class Sample01{
  Form fm =new Form();
  fm.Text="sample";
  fm.Width=250;
  fm.Height=100;
  
  Label lb=new Label();
  Ball bl= new Ball();
  
  bl.Move();
  lb.Text="ball's position top:"+b1.Top+" left:"+b1.Left;
  lb.Parent=fm;
  
  Application.Run(fm);
  }
}

class Ball{
  private int top;
  private int left;
  
  public Ball(){
    top=0;
    left=0;
  }
  public void Move(){
    top=top+10;
    left=left+10;
  }
  public int Top{
    set {top=value;}
    get {return top;} 
  }
  public int Left{
    set {left=value;}
    get {return left:}
  }
}
