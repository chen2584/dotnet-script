
class MyClass
{
    static ref readonly int RefDemo(in int x, int y)
    {
        //x++;
        return ref x;
    }

    public void Run()
    {
        var a = 100;
        var b = 200;
        ref readonly int c = ref RefDemo(a, b);
        //c++;
        WriteLine($"a = {a}, b = {b}, c = {c}");
    }

}

var myClass = new MyClass();
myClass.Run();
