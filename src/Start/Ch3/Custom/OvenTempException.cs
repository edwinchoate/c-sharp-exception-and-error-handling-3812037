// Exercise file for C# Exception and Error Handling by Joe Marini
// Creating custome exception types

public class OvenTempException : Exception {
    public int OvenTemp { init; get; }

    public OvenTempException () : base () 
    {
        OvenTemp = 0;
    }

    public OvenTempException (string message) : base (message) 
    {
        OvenTemp = 0;
    }

    public OvenTempException (string message, Exception innerException) : base (message, innerException) 
    {
        OvenTemp = 0;
    }

    public OvenTempException (int value) : base ($"You can't set oven temp to {value}") 
    {
        OvenTemp = value;
    }

}
