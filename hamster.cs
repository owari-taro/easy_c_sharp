class Hamster{
  private string name;
  private int age;
  
  public Hamster(string name,int age){
    this.name=name;
    this.age=age;
  }
  
  public Hamster():this("gombei",0){}

  public string Show(string format="{0} is {1} years old!" ){
    return String.Format(format,this.name,this.age);
  }


}
