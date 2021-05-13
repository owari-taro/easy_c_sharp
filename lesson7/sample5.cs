using System;
using System.Windows.Forms;



class Sample5:Form{
  private Label lb;
  private Button bt;
  
  public stati void Main(){
    Application.Run(new Sample5());
  }
  
  public Sample5(){
    this.Text="sample";
    this.Width=250;
    this.Height=100;
    
    lb=new Label();
    lb.Text="hello"
    lb.Dock=DockStyle.Top;
    
    bt=new Button();
    bt.Text="buy";
    bt.Dock=DockStyle.Bottom;
    
    bt.Click+=new EventHandler(bt_click);
    lb.Parent=this;
    bt.Parent=this;
  }
  public void bt_click(Object sender,EventArgs e){
    lb.Text="thank you for your purchase";
    bt.Enabled=false;  
  } 


}
