using System;
using System.Windows.Forms;

class Sample6:Form{
  private Label lb;
  private CheckBox cb1,cb2;
  private FlowLayoutPanel;
  
  public static void Main(){
    Application.Run(new Sample6());  
  }

  public Sample6(){
    this.Text="sample";
    this.Width=250;
    this.Height=200;
    
    lb=new Label();
    lb.Text="hello";
    lb.Dock=Dockstyle.Top;  
  
    cb1=new CheckBox();
    cb2=new CheckBox();
    
    cb1.Text="car";
    cb2.Text="truck";
    
    flp=new FlowLayoutPanel();
    flp.Dock=DOckStyle.Bottom;
    cb1.Parent=flp;
    ch2.Parent=flp;
    
    lb.Parent=this;
    flp.Parent=this;
    
    cb1.CheckedChanged+=new EventHandler(cb_CheckedChanged);
    cb2.CheckedChanged+=new EventHandler(cb_CheckedChanged);
    
   }
   public void cb_CheckedChanged(Object sender,EventArgs e){
    CheckBox tmp=(CheckBox)sender;
    if (tmp.checked==true){
      lb.Text=tmp.Text+"is chosen";
    }else if (tmp.Checked==false{
      lb.Text=tmp.Text+"is stopped";
    }
   
   }
    
    
  }


}
