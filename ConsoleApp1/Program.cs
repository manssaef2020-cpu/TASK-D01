// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.Write("Number of Small carpets: ");
int numsmall = Convert.ToInt32(Console.ReadLine());
int count = 25;
int totalsmall = numsmall * count;

Console.Write("Number of larg carpets: ");
int numlarg = Convert.ToInt32(Console.ReadLine());

int countl = 35;
int totalarg = numlarg * countl;

Console.WriteLine($"TOTAL SMAL: {totalsmall}");

Console.WriteLine($"TOTAL LARG: {totalarg}");
int total = totalsmall + totalarg;
double tax = 0.06;
double TOTALTAX = total * tax;
double TOTALESTIMATE = TOTALTAX + total;


Console.WriteLine($"TAX       : {TOTALTAX}");
Console.WriteLine($"TAXESTIMAT:  {TOTALESTIMATE}");
Console.WriteLine("This estimate is valid for 30 days");