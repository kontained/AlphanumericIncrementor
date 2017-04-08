# AlphanumericIncrementor

AlphanumericIncrementor is a small utility that will increment an alphanumeric string.

# Usage
Include the AlphanumericIncrementor.Helpers namespace to assist in building the incrementor object.
```C#
using AlphanumericIncrementor.Helpers;
```
Then use the builder to get a new incrementor.
```C#
var incrementor = IncrementorBuilder.Build();
```
You're now ready to increment an alphanumeric string!
```C#
string result = incrementor.Increment("AAAA"); //returns "AAAB"
```

# Incrementation examples
0000 -> 0001  
0009 -> 000A  
000Z -> 0010  
ABCD -> ABCE  
ABCZ -> ABD0  
