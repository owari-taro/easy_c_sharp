class Circle{
  double radius;
  public Circle(double radius){
    this.radius=radius;
  }
  public double GetArea(){
    return this.radius*this.radius*Math.PI;
  
  }


}




class Circle2{
  double radius;
  public Circle(double radius=1){
    this.radius=radius;
  }
  
  public double GetArea(){
    return this.radius*this.radius*Math.PI;
  
  }
  
  public double GetAverage(params double[] values ){
    double sum=0d
    foreach(var value in values){
      sum+=value;
    }
    return sum/values.Length:
  
  }


}
