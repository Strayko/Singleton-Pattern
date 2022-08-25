// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

var s1 = Singleton.GetInstance();
var s2 = Singleton.GetInstance();
var s3 = Singleton.GetInstance();

Console.WriteLine(s1 == s2);
Console.WriteLine(s2 == s3);