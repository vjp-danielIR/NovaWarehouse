using System.Text;

string wareHouse = "Nova";
int packageCount = 45;

Console.WriteLine("Texto normal");
Console.WriteLine($"2+2={2 + 2}");
Console.WriteLine($"El nombre de mi warehouse es: {wareHouse}");



StringBuilder sb = new();

sb.Append("2+2=");

sb.Append(2 + 2);

Console.WriteLine(sb);
var persona = new Persona();

Persona persona1 = new();
Persona persona2 = new();

var persona3 = new();

class Persona { }