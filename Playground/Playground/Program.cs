﻿// See https://aka.ms/new-console-template for more information

using Playground;

Console.WriteLine("Hello, World!");

ParamsCollections.MyMethod(1,2,3,4);
ParamsCollections.MyMethod2("one", "two", "three", "four");
ParamsCollections.MyMethod3("alpha", "beta", "gamma", "delta");
ParamsCollections.MyMethod4(2.3, 4.5, 6.7);

var partial = new PartialProperties();

partial.Name = "funky new name";
Console.WriteLine(partial.Name);

var nlo = new NewLockObject();
nlo.LockThingWithNewLockObject();

var newRefStruct = new RefStruct
{
    MyNumber = 5
};
RefStructExample.DoStuff2(newRefStruct);
