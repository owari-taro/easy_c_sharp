using System;
using System.Windows.Forms;

class Sample1:Form{
  private Label lb;
  public static void Main(){
    Application.Run(new Sample1());
  }
  
  public Sample1(){
    this.Text="sample";
    this.width=250;
    this.Height=300;
    lb=new Label();
     lb.Text="hello";
     
     lb.Parent=this;
     
     this.Click+=new EventHandler(fm_click);
  }

 puboic void fm_cclick(Object sender,EventArgs e){
    lb.Text="hello";
 }

}
