# ochar

Get characters from ASCII codes or the other way in Windows Console.


## usage

```batch
> ochar [--ascii|-a] [--verbose|-v] [--input|-i <input string>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: get character of ESC (27)
> echo 27|ochar

:: get character of SOH (1)
> ochar --input 1

:: get verbosed character of STX (2)
> ochar --verbose -i 2

:: get verbosed ascii codes of 'a', 'b', 'c'
> ochar --ascii -v -i "abc"
```


## license

You have a Poké ball? That's enough!
