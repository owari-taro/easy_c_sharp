interface IHoge{
  void Foo(string str);
}

interface IHoge2{
  void Foo(string str2);
}

class MyClass:IHoge,IHoge2
{
  public void Foo(string str){
    Console.WriteLine($"implicict={str}");
    }
  void IHoge.Foo(string str){
    Console.WriteLine($"IHoge.Foo={str}")
  }
  
  void IHoge2.Foo(string str){
    COnsole.WriteLine($"IHoge2.Foo={str}";
    }
}


class InterfaceOverlap{
static void Main(string[] args){
  var mc =new MyClass();
  mc.Foo("ii");
  var ih =(IHoge)mc;
  ih.Foo("ro");
  
  var ih2=(IHoge2)mc;
  ih2.Foo("ha");
}



}
