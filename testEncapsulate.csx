class MyClass
{
    readonly int variable; // Default protection level is private.
}

/*class MyChildren : MyClass
{
    public int MyMethod()
    {
        this.variable = 0; // Can't assign it.
    }
}*/

var myClass = new MyClass();
