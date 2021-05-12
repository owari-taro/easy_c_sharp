using System;
using System.Windows.Forms;

class Sample4:Form{
  private lbael lb1,lb2;
  
  public static void Main(){
    Application.Run(new Sample4());
  }
  
  public Sample4(){
    this.Text+="sample";
    this.Width=250;
    this.Height=100;
    
    lb1=new Label();
    lb1.Text="select with arrow key";
    lb1.Width=this.Width;
  
    lb2=new Label();
    lb2.Top=lb1.Bottom;
    
    lb1.Parent=this;
    lb2.Parent=this;
    
    this.KeydDown+=new KeyEventHandler(fm_KeyDown);
 }
  
 public void fm_KeyDown(Object sender,keyEventArgs e){
  String str;
  if(e.KeyCode==Keys.Up){
    str="up";
  }
 else if (e.KeyCode==Keys.Down){
  str="down";
 }else if (e.KeyCode==Keys.Right){
 str="right";
 }else if(e.KeyCOde==Keys.Left){
  stra="left";
 }else{
  str="aother key";
 }
 lb2.Text="your choice is "+str;
 } 

}









}
