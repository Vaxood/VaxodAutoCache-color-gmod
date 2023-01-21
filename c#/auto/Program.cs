
using System.Text.RegularExpressions;
Console.Write("Path?:");
string path = Console.ReadLine();
string alltext = File.ReadAllText(path);
List<string> myList = new List<string>();
int k = 0;
string textfinial =""; 
foreach (Match match in Regex.Matches(alltext, @"Color\((?<r>\d{1,3}),(?<g>\d{1,3}),(?<b>\d{1,3})\)"))
{
    alltext = alltext.Replace(match.Value,"color"+k);
    textfinial = textfinial + "local color"+k+" = "+match.Value+"\n";
    k++;
}
textfinial = textfinial +"\n\n"+alltext;

Console.Write("done");
File.WriteAllText(path,textfinial);
Console.ReadLine();