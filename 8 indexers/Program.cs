using _8_indexers;

IP ip = new IP(192, 168, 1, 1);
var firstSegment = ip[2];
Console.WriteLine(firstSegment);
Console.WriteLine(ip.GetIP);
