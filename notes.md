
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

### Exceptions
- `System.DivideByZeroException`
- `System.IndexOutOfRangeException`


Useful `System.Exception` Properties/Methods
- `GetType()`
- `Message`
- `HelpLink` - can be used to provide a docs link 
- `Source` - the app/object where the exception occurred 
- `TargetSite` - the method that threw the exception 
- `StackTrace`