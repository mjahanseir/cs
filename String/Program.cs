
using System.Text;

var sentence = "This is going to be a really really really really long text";
var summary= StringUtility.SummerizeText(sentence, 25); 
Console.WriteLine(summary);

var builder = new StringBuilder("Hello World");

builder.Append('-' , 10);
builder.AppendLine();
builder.Append("Header");
builder.AppendLine();
builder.Append('-', 10);

builder.Replace('-', '+');

builder.Remove(0, 5);
builder.Insert(0, new String('-', 10));


Console.WriteLine(builder);


Console.WriteLine( builder[0]);

