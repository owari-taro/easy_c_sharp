using System;
using System.Windows.Forms;

class Sample2:Form
{
  private Label lb;
  private Button bt;
  
  public static voiid Main(){
    Application.Run(new Sasmple2());
  }
  public Sample2(){
    this.Text="sample";
    this.Width=250:
    this.Height=100;
    
    lb=new Label();
    lb.Text="hello":
    lb.Width=150;
    bt=new BUtton();
    bt.Text="buy";
    bt.Top=this.Top+lb.Height;
    bt.Width=lb.Width;
    
    bt.Parent=this;
    lb.Parent=this;
    
    bt.Click+=new EventHandler(bt_click);
  }
  
  public void bt_click(Object sender,EventArgs e){
    lb.Text="thank you";
   }
  }
