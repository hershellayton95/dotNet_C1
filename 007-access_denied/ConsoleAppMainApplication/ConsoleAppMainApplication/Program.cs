/*
 * Create a class with private, protected, internal, and public access modifiers. 
 * In a separate class, try accessing these members and observe the compilation errors, if any. 
 * Fix the errors by modifying the access modifiers or using proper access techniques.
 */



MyClass myObj = new MyClass();

// Accessing private member (Compilation error)
// Console.WriteLine(myObj.privateMember);
// a private attribute (property, variable ...) can be used only inside its class

// Accessing protected member (Compilation error)
// Console.WriteLine(myObj.protectedMember);
// A protected attribute (property, variable, etc.) can only be used within its class and the classes that inherit from it.

// Accessing internal member (No compilation error)
Console.WriteLine(myObj.internalMember);
// An internal attribute (property, variable, etc.) can only be used within code within the same assembly.

// Accessing public member (No compilation error)
Console.WriteLine(myObj.publicMember);
// A public attribute (property, variable, etc.) can be accessed and used by code both within the same assembly and in other assemblies.


public class MyClass
{
    private int privateMember = 10;
    protected int protectedMember = 20;
    internal int internalMember = 30;
    public int publicMember = 40;
}