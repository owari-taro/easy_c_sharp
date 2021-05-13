using System.Windows.Forms;
using System.Drawing;


class Sample4:Form{
private Label[] lb=new Label[3];
private TableLayoutPanel tl;

public static void Main(){
  Application.Run(new Sample4());
}

public Sample4(){
  this.Text="sample";
  this.Width=250;
  this.Height=200;
  tlp=new TableLayoutPanel();
  tlp.Dock=DockStyle.Fill;
  tlp.CoumnCount=1;
  tl.RowCount=3;
  
  for(int i=0;i<lb.Length;i++){
  lb[i]=new Label();
  lb[i].Text="this is a acar";
  lb[i].Width=200;  
  }
  
  lb[0].Font=new Font("arial",12,FontStyle.Bold);
  lb[1].Font=new FOnt("times new roman",14,FontStyle.Bold);
  lb[2].Font=new Font("courier new ",16,FontStle.Bond);
  
  for(int i=0;i<lb.Length;i++){
  lb[i].Parent=tlp;
  }
  tlp.Parent=this;

}



}
