
# Notes


## Chapter 2

The most generic exception - [`System.Exception`](https://learn.microsoft.com/en-us/dotnet/api/system.exception?view=net-8.0)

`e.Message`

```C#
catch (Exception e)
    Console.WriteLine(e.Message);
```

`try`

`catch`

`finally` - always executes regardless of whether or not an exception occurred. Good for cleanup tasks, like closing a file. 

### Built-In Exceptions
- `System.DivideByZeroException`
- `System.IndexOutOfRangeException`
- `System.ArgumentException` - when a passed-in argument is invalid for some reason
- `System.ArgumentNullException` - an argument was null when it shouldn't have been 
- `System.ArgumentOutOfRangeException`
- `System.IO.FileNotFoundException`
- `System.InvalidOperationException` - when you're trying to perform an operation on some object and that operation isn't valid given the current state of that object



### Useful `System.Exception` Properties/Methods
- `GetType()`
- `Message`
- `HelpLink` - can be used to provide a docs link 
- `Source` - the app/object where the exception occurred 
- `TargetSite` - the method that threw the exception 
- `StackTrace`


> It is generally the best practice to use the most specific exception class possible that meets your program's needs in order to keep your code simple and avoid having many different exception types being caught by your catch statements. 

If you put your generic exceptions before a more specific exception, the compiler with throw an error because that makes the latter exceptions unreachable. 


## Chapter 3

_exception filtering_ - a given `catch` block only runs if an associated boolean evaluates to true

```C#
catch (Exception e) when (myBool) 
```

### Custom Exceptions

When creating custom exceptions in C# (e.g. creating a class that extends `System.Exception`), it's best-practice to create a few constructors...

1. The parameterless constructor
```C#
public MyException () : base ()
```

2. A constructor that takes a `string` arg (the message)
```C#
public MyException (string message) : base (message) 
```

3. A constructor that takes a `string` arg and an inner exception object 
```C#
public MyException (string message, Exception innerException) : base (message, innerException) 
```

### Inner Exceptions

_inner exception_ - the exception that caused another exception to happen. aka nested exceptions.

You can set an `innerException` by using a constructor like this...
```C#
throw new Exception("some message", innerException); // this sets Exception.InnerException
```

You can access the `InnerException` as a property
```C#
Console.WriteLine(e.InnerException.Message);
```

### Best Practices

- Try to prevent the need to throw an exception by proactively handling errors 
- Don't use exceptions to control the flow of the program 
- Start with specific exceptions and then move to the more generic ones 
- Don't catch `System.Exception` directly 
    - This catches every possible exception (including ones from .NET or the CLR) and that might cause issues 
- use `finally` for cleanup logic 
- Exception classes should end with the word "Exception" 
- Use pre-defined .NET Exception classes when you can
- Provide the three constructors (above) when creating custom exception classes
- 