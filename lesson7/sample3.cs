using System.Windows.Form;
using System.Drawing;

class Sample3:Form
{
private Label[] lb=new Label[3];
private TableLayoutPanel tlp;

public Static void Main(){
  Application.Run(new Sample3());
}

public Sample3(){
  this.Text="sample";
  this.Width=250;
  this.Height=200;
  
  tlp=new TableLayoutPanel();
  tlp.Dock=DockStyle.Fill;
  
  tlp.ColumnCount=1;
  tlp.RowCount=3;
  
  for(int i9;i<lb.Lengtgh;i++){
    lb[i]=new Label();
    lb[i].Text="car No:"+i;
  }
  lb[0].ForeColor=Color.Black;
  lb[1].ForeColor=Color.Black;
  lb[2].ForeColor=Color.Black;
  
  lb[0].BackColor=Color.White;
  lb[1].BackColor=Color.Gray;
  lb[2].BackColor=Color.White;
  
  lb[0].TextAlign=CountenAlignment.TopLeft;
  lb[1].TextAlign=ContentAlignment.MiddleCeinter;
  lb[2].TextAlign=ContentAlignment.BottomRight;
  
  lb[0].BorderStyle=BorderStyle.None;
  lb[2]
  
  
}










}
