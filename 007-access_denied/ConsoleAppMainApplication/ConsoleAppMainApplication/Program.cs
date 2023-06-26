/*
 * Create a class with private, protected, internal, and public access modifiers. 
 * In a separate class, try accessing these members and observe the compilation errors, if any. 
 * Fix the errors by modifying the access modifiers or using proper access techniques.
 */


using ConsoleAppMainApplication.Model;

MyClass myObj = new MyClass();

// Accessing private member (Compilation error)
// A private attribute (property, variable, etc.) can be used directly only inside its own class.
// Console.WriteLine(myObj.privateMember);
// A getter method allows accessing the attribute in spite of the access modifiers
Console.WriteLine(myObj.GetPrivateMember());


// Accessing protected member (Compilation error)
// A protected attribute (property, variable, etc.) can only be used directly within its own class or in the classes that inherit from it.
//Console.WriteLine(myObj.protectedMember);
// A getter method allows accessing the attribute in spite of the access modifiers
Console.WriteLine(myObj.GetProtectedMember());


// Accessing internal member (No compilation error)
Console.WriteLine(myObj.internalMember);
// An internal attribute (property, variable, etc.) can only be used within code within the same assembly.

// Accessing public member (No compilation error)
Console.WriteLine(myObj.publicMember);
// A public attribute (property, variable, etc.) can be accessed and used by code both within the same assembly and in other assemblies.