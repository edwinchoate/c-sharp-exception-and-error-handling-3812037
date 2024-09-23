
# Notes


## Chapter 2

The most generic exception - [`System.Exception`](https://learn.microsoft.com/en-us/dotnet/api/system.exception?view=net-8.0)

`e.Message`

```
catch (Exception e)
    Console.WriteLine(e.Message);
```

`try`

`catch`

`finally`

### Built-In Exceptions
- `System.DivideByZeroException`
- `System.IndexOutOfRangeException`
- `System.ArgumentException` - when a passed-in argument is invalid for some reason
- `System.ArgumentNullException` - an argument was null when it shouldn't have been 
- `System.ArgumentOutOfRangeException`
- `System.IO.FileNotFoundException`
- `System.InvalidOperationException` - when  you're trying to perform an operation on some object and that operation isn't valid given the current state of that object



### Useful `System.Exception` Properties/Methods
- `GetType()`
- `Message`
- `HelpLink` - can be used to provide a docs link 
- `Source` - the app/object where the exception occurred 
- `TargetSite` - the method that threw the exception 
- `StackTrace`


> It is generally the best practice to use the most specific exception class possible that meets your program's needs in order to keep your code simple and avoid having many different exception types being caught by your catch statements. 

