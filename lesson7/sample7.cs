using System;
using System.Windows.Forms;


class Sample7:Form{
 private Label lb;
 private RadioButton rb1,rb2;
 private GroupBox gb;
 
 
 public static void Main(){
  Application.Run(new Sample7());
 
 }
 public Sample7(){
  this.Text="sample";
  this.Width=300
  this.Height=200;
  
  lb=new Label();
  lb.Text="hello";
  lb.dock=DockStyle.Top;
  
  rb1=new RadioButton();
  rb2=new RadioButton();
  
  rb1.Text="car";
  rb2.Text="track";
  rb1.Checked=True;
  
  rb1.Dock=DockStyle.Left;
  rb2.Dock=DockStyle.Right;
  
  gb=new GroupBox();
  gb.Text="type:";
  gb.Dock=DockStyle.Bottom;
  
  rb1.Parent=gb;
  rb2.Parent=gb;
  
  lb.Parent=this;
  gb.Parent=this;
  
  rb1.Click+=new EventHandler(rb_Click);
  rb2.Click+=new EventHandler(rb_Click);
  
 }
 pulic void rb_Click(Object sender,EventArgs e){
  RadioButton tmp=(RadioButton)sender;
  lb.Text=tmp.Text + ' is chosed'
 }
 }



}
