/*using System.Text;

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

 class Persona { }*/

/*
Console.Write("paquete weight (kg): ");
string? input = Console.ReadLine(); // "" por defecto

 //double weight = double.Parse(input!);

if (input is null)
{
    Console.WriteLine("No has puesto un valor");
    return;
}

if (!double.TryParse(input, out  double weight))
{
    Console.WriteLine("El valor introducido no es numerico ");
    return;
}

const double baseCost = 3.50;
const double costPerKg = 0.80;
const double kgToLibRate = 2.2046;

double totalCost = baseCost + (costPerKg * weight);

bool isExpress = false;
const double expressRate = 5.00;

if (isExpress)
{
    totalCost += expressRate;
}

Console.WriteLine($"Shipping cost: ${totalCost:C2}");

Console.WriteLine($"Lbs: {KgToLib(weight)}");

double KgToLib(double weight)
{
    return weight * kgToLibRate;
}
*/
/*OPERADORES 

Aritmeticos: +, -, *, /, %

Comparacion: ==, !=, >, <, >=, <=

Logicos: &&, ||, !

Null-coalescing: ?? si no tiene valor, ??=.  
*/


/*
PROBAR LOS NULL-COALESCING OPERATORS

 string? note = GetTrackingNote(orderId);
string display = note ?? "no tiene valor";

string? label = null;
label ??= "Standard shipping"; // ??= sasign solo si l vaiable actual es null

Console.WriteLine(display);

*/

/*
int quantity = 10;
double quantityAsDouble = quantity; // Implicita

double weight = 4.9;
int roundedWeight = (int)weight; // Explicita es cocmo el cast en java trunca a 4 hay perdida de datos
*/

/*
// CONVERS PARSE Y TRY PARSE 
String input ="25";

int a = Convert.ToInt32(input!); // Convert convierte a 0 si no puede convertir

int b = int.Parse(input!); // Parse lanza una excepcion si no puede convertir

//mejor usar tryparse en c#
if (int.TryParse(input, out int quantity) 0)
{
    Console.WriteLine($"Conversion exitosa: {quantity}");
}
else
{
    Console.WriteLine("Conversion fallida por defecto 0");
}

*/


//EJERCICIO DE  guard clauses

/*

static decimal CalculateDiscount(Customer customer, Order order)
{
    decimal discount = 0;
     if (customer == null)
    {
        Console.WriteLine("Null customer");
        return discount;
    }
        if (customer.Active)
    {
        customer.IsVip = false;
        return discount;
    }
            if (order == null)
    {
        Console.WriteLine("Null order");
        return discount;
    }
                if (order.Total <= 0)
    {
        Console.WriteLine("Order has no total");
        return discount;

    }
                    if (customer.IsVip)
                    {
            
                        if (order.Total > 1000)
                        {
                            discount = order.Total * 0.20m;
                        }
                        else
                        {
                            discount = order.Total * 0.10m;
                        }
                    } else
    {
        Console.WriteLine("Customer is not VIP");
        return discount;
    }
               
}


class Customer
{
    public bool Active { get; internal set; }
    public bool IsVip { get; internal set; }
}

class Order
{
    public int Total { get; internal set; }
}

*/

/*
Console.Write("Enter quantity for SKU-4471: ");
string? rawQuantity = Console.ReadLine();

Console.Write("peso  del paquete (kg): ");
string? input = Console.ReadLine();


if (!double.TryParse(input, out double weight) || weight <= 0)
{
    Console.WriteLine("El valor introducido no es numerico ");
    return;
}

if (!int.TryParse(rawQuantity, out int quantity) || quantity <= 500 || quantity <= 500)
{
    Console.WriteLine("Invalid quantity. Order line rejected.");
    return;
}

Console.WriteLine($"Added {quantity} units of SKU-4471 to the order.");
*/

/*
sinstasis del switch expression
enum CustomerType { Regular, Premium, Vip }
decimal discount = customerType switch
{
CustomerType.Regular => 0.00m,
CustomerType.Premium => 0.10m,
CustomerType.Vip => 0.20m,
_ => 0.00m
};
*/



//Pattern matching: is y patrones
/*

// Patrón de tipo
if (shipment is ExpressPackage express)
{
Console.WriteLine($"Express, priority {express.PriorityLevel}");
}
// Patrón relacional.
string sizeCategory = weightKg switch
{
< 1.0 => "Small",
< 10.0 => "Medium",
_ => "Large"
};
*/

/*
// if/else clásico: equivalente al switch expression anterior
string Classify(Order order)
{
    if (order.Status == "Cancelled") return "Ignore";
    if (order.Total > 1000 && order.Status == "Pending") return "Priority review";
    if (order.Total > 1000) return "High value";
    if (order.Status == "Pending") return "Awaiting confirmation";
    if (order.Total  == 0 ) return "Free order";
    return "Standard";
}

CustomerType customerType = CustomerType.Regular;

decimal discount = customerType switch
{

    CustomerType.Regular => 0.00m,
    CustomerType.Premium => 0.10m,
    CustomerType.Vip => 0.20m,
    _ => 0.00m
};


record Order(int Total, string Status)
{
    public int Total { get; internal set; }
    public string Status { get; internal set; }
}

class Customer
{
    public bool Active { get; internal set; }
    public bool IsVip { get; internal set; }
}
enum CustomerType { Regular, Premium, Vip }

*/

//Record modelar datos inmutables no se pueden cambiar las propiedades 
/*
record Product(string Name, decimal Price, int Stock);
var bracket = new Product("Steel Bracket", 4.25m, 120);
var restocked = bracket with { Stock = 200 }; // copia inmutable con un cambio
*/