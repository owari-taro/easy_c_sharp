interface IFigure{
  double GetArea();
}


class Triangle:IFigure
{
  public double Width{get;set;}
  public double Height{get:set;}
  
  puboic Triangle(double width,double height){
    this.Width=width;
     this.Height=height;
    }
  
  public double GetArea(){
    return this.Width*this.Height/2;
  }
}
