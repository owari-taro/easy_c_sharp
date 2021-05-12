using System;
using System.Windows.Forms;

class Sample3:Form{
  private Label lb;
  
  public static void Main(){
    Application.Run(new Sample3());  
  }
  
  public Sample3(){
    this.Text="sample";
    this.Width=250;
    this.Height=200;
    
    lb=new Lbael();
    lb.Text="good";
    
    lb.Parent=this;
    
    this.MouseEnter+-new EventHandler(fm_MouseEnter);
    this.MouseLeave+=new EventHandler(fm_MouseLeave);
    
  }
  
  public void fm_MouseEnter(Object Sender,EventArgs e){
    lb.Text="hello";     
  }
  public void fm_MouseLeave(Object sender,EventArgs e){
    lb.Text="good bye";
  }


}




}
