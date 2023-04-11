using RomanNumerals;

string passedValue = args.Length > 0 ? args[0].ToString() : "";

if (passedValue == "")
{
    Console.WriteLine("Please enter an integer or Roman Numeral to convert:");

    var response = Console.ReadLine();
    if (response != null) passedValue = response;
}

if (passedValue =="")
{
    Console.WriteLine("Nothing to convert!");
    return;
}

RomanNumeralConverter rnc = new RomanNumeralConverter();

try
{
    int value = int.Parse(passedValue);
    Console.WriteLine(rnc.ConvertToRomanNumerals(value));
} catch {
    Console.WriteLine(rnc.ConvertFromRomanNumerals(passedValue));
}
