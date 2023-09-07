// See https://aka.ms/new-console-template for more information\

using System.Security.Cryptography;

/*
เรียกใช้ เครื่องมือของภาษา

int firstValue = 500;
int secondValue = 600;
int largerValue;
 
 largerValue = RandomNumberGenerator.GetInt32(firstValue, secondValue);

Console.WriteLine(largerValue);
*/

/*
int hero = 10;
int monster = 10;

การใช้ do while
Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/


// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
// Console.WriteLine(" ");
// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

/* solution for combining string array values as strings and as integers challenge */
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     } else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");


/*------------------ Sort & Reverse ------------------------*/

// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/*----------------- Clear & Resize -----------------*/

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// if (pallets[0] != null)
//     Console.WriteLine($"Before Array[0]: {pallets[0]}");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After Array[0]: {pallets[0]}");

// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// ////Reduce the size of array to 6 fields.
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// ////add data in new fields array
// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// ////Reduce the size of the array to 3 fields. 
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/* ----------------------- Split & Join -----------------------  */

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// // Console.WriteLine(result);

// ////join char ',' between array
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// ////If ',' is found, start a new array field. 
// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

/*----------------- String formatting -----------------------*/

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// Console.WriteLine($"Measurement: {measurement:N4} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// decimal priceD = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (priceD - salePrice), priceD);

// Console.WriteLine(yourDiscount);
// Console.WriteLine("");
// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!";
// Console.WriteLine(yourDiscount);

// string input = "Pad this";
// Console.WriteLine(input.PadRight(12) + input.PadLeft(12));

// string paymentId = "769";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// ////field in padding check by sting + field to padding
// Console.WriteLine("1234567890123456789012345678901234567890");
// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine(formattedLine);

////example
// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;



// Console.WriteLine($"Dear: {customerName}");
// Console.WriteLine("As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine("Currently, you own {0:C2} shares at a return of {1:P2}\n", currentShares, currentReturn);
// Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P2}.".PadRight(63) + $"Given your current volume, your potential profit would be {newProfit:C2}\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";


// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += currentReturn.ToString("P2");
// comparisonMessage += currentProfit.ToString("C2").PadLeft(17);
// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += newReturn.ToString("P2");
// comparisonMessage += newProfit.ToString("C2").PadLeft(17);

// Console.WriteLine(comparisonMessage);

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// openingPosition += 1;
// length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// message = "What is the value <span>between the tags</span>?";
// openingPosition = message.IndexOf("<span>");
// closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// length = closingPosition - openingPosition;
// Console.WriteLine("");
// Console.WriteLine(message.Substring( length));

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// openingPosition = message.IndexOf(openSpan);
// closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// length = closingPosition - openingPosition;
// Console.WriteLine("");
// Console.WriteLine("Set const string");
// Console.WriteLine(message.Substring(openingPosition, length));
// Console.WriteLine("");

// Console.WriteLine("*****Use the string's IndexOfAny() and LastIndexOf() helper methods****\n");
// message = "(What if) there are (more than) one (set of parentheses)?";
// Console.WriteLine("Message is: " + message + "\n");
// Console.WriteLine("Use openingPosition in While loop\n");
// while (true)
// {
//     openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     closingPosition = message.IndexOf(')');
//     length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

// message = "Help (find) the {opening symbols}";
// Console.WriteLine($"\nSearching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 6;
// openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");

////Example 
// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here

// // Extract the quantity
// int quantityStart = input.IndexOf("<span>");
// int quantityEnd = input.IndexOf("</span>");
// quantityStart += "<span>".Length; // Added length of the tag so index moves to end of the tag
// int quantityLength = quantityEnd - quantityStart;
// quantity = input.Substring(quantityStart, quantityLength); //Extracts from end of open tag to beginning of close tag
// quantity = $"Quantity: {quantity}";

// // Set output to input, replacing the trademark symbol with the registered trademark symbol
// output = input.Replace("&trade;", "&reg;");

// // Remove the opening <div> tag
// int divStart = input.IndexOf("<div>");
// int divLength = "<div>".Length;
// output = output.Remove(divStart, divLength);

// // Remove the closing <div> tag
// int divCloseStart = output.IndexOf("</div>");
// int divCloseLength = "</div>".Length;
// output = output.Remove(divCloseStart, divCloseLength);
// output = $"Output: {output}";

// Console.WriteLine("Result:" + input);
// Console.WriteLine(quantity);
// Console.WriteLine(output);

/*---------------------------- Use method to structure code -----------------------------*/

// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         if (int.Parse(number) > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// TellFortune();
// luck = random.Next(100);
// TellFortune();

// void TellFortune() 
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++) 
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }

/*-------------------- Create a method with parameters ------------------------*/

// int[] schedule = { 800, 1200, 1600, 2000 };

// DisplayAdjustedTimes(schedule, 6, -6);

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }
//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }

//     for (int i = 0; i < times.Length; i++)
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }

// }

// string[,] corporate =
// {
//     { "Robert", "Bavin"}, { "Simon", "Bright"},
//     { "Kim", "Sinclair"}, { "Aashrita", "Kamath"},
//     { "Sarah", "Delucchi"}, { "Sinan", "Ali"}
// };

// string[,] external =
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// for (int i = 0; i < corporate.GetLength(0); i++)
// {
//     DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
// }

// for (int i = 0; i < external.GetLength(0); i++)
// {
//     DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
// }

// void DisplayEmail(string first, string last, string domain = "contoso.com")
// {
//     string email = first.Substring(0, 2) + last;
//     email = email.ToLower();
//     Console.WriteLine($"{email}@{domain}");
// }


// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose!";
}