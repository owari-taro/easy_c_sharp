using System;
using System.Windows.Forms;

class Sample9:Form{
  private Label lb;
  private ListBox lbx;
  
  public static void Main(){
    Application.Run(new Sample9());
  }
 public Sample9(){
    string[] str={"car","track","open car","taxi","sports car","mini car",
            "bicycle","tricycle","bike","airplane","helicopter","rocket"};
    this.Text="sample";
    this.Width=250;
    this.Height=200;
    lb=new Label();
    lb.Text="hello";
    lb.Dock=DockStyle.Top;
    lbx=new ListBox();
    
    for(int i=0;i<str.Length;i++){
      lbx.Items.Add(str[i]);
    }
    
    lbx.Top=lb.Bottom;
    lb.Parent=this;
    lbx.Parent=this;
    lbx.SelectedIndexChanged+=new EventHandler(lbx_SelectedIndexChanged);
    
  }
 public void lbx_SelectedIndexChanged(Object sender,Eventargs e){
    ListBox tmp=(ListBOx)sender;
    lb.Text=tmp.Text+"is chosen!";    
 
 }


}
