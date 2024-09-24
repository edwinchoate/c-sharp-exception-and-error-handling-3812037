// Exercise file for C# Exception and Error Handling by Joe Marini
// Challenge for Ch3: The Coin Counter

string[] TestCoins = {
    "Nickel",
    "Penny",
    "Dime",
    "Quarter",
    "Washer",
    "Spacer",
    "HalfDollar",
    "Dollar",
    "Dime",
    "Penny",
    "Washer",
    "Token",
    "Quarter",
    "Medallion",
    "Nickel",
    "Nickel",
    "Dollar"
};

// The code that your solution will be called with
CoinCounter Counter = new();
foreach (string Coin in TestCoins)
{
    Counter.CountCoin(Coin);
}
Console.WriteLine($"Total amount counted is: {Counter.Total:C}");
Counter.ListBadCoins();

// YOUR SOLUTION CODE GOES HERE:
// =============================
public class CoinCounter
{
    private decimal _totalAmount = 0;
    private List<string> _badCoins = new();

    // valid coin types are:
    // Penny, Nickel, Dime, Quarter, HalfDollar, Dollar
    public CoinCounter() { }

    public void CountCoin(string CoinType)
    {
        try {
            switch(CoinType)
            {
                case "Penny":
                    _totalAmount += 0.01M;
                    break;
                case "Nickel":
                    _totalAmount += 0.05M;
                    break;
                case "Dime":
                    _totalAmount += 0.10M;
                    break;
                case "Quarter":
                    _totalAmount += 0.25M;
                    break;
                case "HalfDollar":
                    _totalAmount += 0.50M;
                    break;
                case "Dollar":
                    _totalAmount += 1.00M;
                    break;
                default: 
                    throw new CoinException(CoinType, $"{CoinType} is not a valid coin.");
            }
        }
        catch (CoinException e) 
        {
            _badCoins.Add(e.CoinType);
        }s
    }

    public void ListBadCoins()
    {
        foreach (string badCoin in _badCoins) 
        {
            Console.WriteLine(badCoin);
        }
    }

    public decimal Total
    {
        get => _totalAmount;
    }
}

public class CoinException : Exception
{

    public CoinException () : base () {}

    public CoinException (string message) : base (message) {}

    public CoinException (string message, Exception innerException) : base (message, innerException) {}

    public CoinException (string coinType, string message) 
    {
        CoinType = coinType;
    }

    public string CoinType { get; set; } = "";

}
