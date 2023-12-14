using caSelenium;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

var web = new Automator();
var text = web.TesteWeb();

Console.WriteLine(text);
Console.ReadLine();