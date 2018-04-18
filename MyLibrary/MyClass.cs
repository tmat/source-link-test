using System;

public class MyClass
{
    public static void DoSomething()
    {
       GeneratedClass.GeneratedMethod();
       ClassInSubmodule.M();
       ClassInVstsSubmodule.M();
    }
}
