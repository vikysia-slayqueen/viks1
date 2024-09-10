// милі в км

//ask
//calculate
//result

Console.WriteLine("---------Convert Miles to Km---------");
Console.Write("Enter miles");

float miles = float.Parse (Console.ReadLine());

Console.WriteLine($"Result: {miles * 1.60934} km");



Console.WriteLine("---------Circle Area by Radius---------");
Console.Write("Enter radius: ");

float r = float.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(r, 2);  

Console.WriteLine($"Result: {area} * cm`2 ");


