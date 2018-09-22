Get characters from ASCII codes or the other way in Windows Console.
> 1. Download [exe file](https://github.com/cmdf/extra-char/releases/download/1.0.0/echar.exe).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
> echar [--ascii|-a] [--verbose|-v] [--input|-i <input string>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: get character of ESC (27)
> echo 27|echar

:: get character of SOH (1)
> echar --input 1

:: get verbosed character of STX (2)
> echar --verbose -i 2

:: get verbosed ascii codes of 'a', 'b', 'c'
> echar --ascii -v -i "abc"
```


[![cmdf](https://i.imgur.com/BjHhnuJ.jpg)](https://cmdf.github.io)
