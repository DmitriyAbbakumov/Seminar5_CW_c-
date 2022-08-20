// See https://aka.ms/new-console-template for more information
//string str = "Hello, World!";
//Console.WriteLine(str[4]);
//Console.WriteLine(str);
//Console.WriteLine(str.Length);

//string str1 = "Hello, ";
//string str2 = "World!";
//string str3 = str1 + str2;
//Console.WriteLine(str3);
//string str3 = string.Concat(str1, str2, "+++");

int[] values = new int[] {1,2,3,4,5,6};
string str3 = string.Join(", ", values);
Console.WriteLine(str3);
