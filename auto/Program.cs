using System.Text.RegularExpressions;
Console.Write("Path?:");
string path = Console.ReadLine();
string alltext = File.ReadAllText(path);
List<string> myList = new List<string>();
int k = 0;
string textfinial =""; 
foreach (Match match in Regex.Matches(alltext, @"Color\s*\(\s*(\d{1,3})\s*,\s*(\d{1,3})\s*,\s*(\d{1,3})\s*(,\s*(\d{1,3}))?\s*\)"))
{
    alltext = alltext.Replace(match.Value,"color"+k);
    textfinial = textfinial + "local color"+k+" = "+match.Value+"\n";
    k++;
}
textfinial = textfinial +"\n\n"+alltext;
Console.Write("Done ! u can close this window now!");

File.WriteAllText(path,textfinial);
Console.ReadLine();
