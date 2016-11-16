# PropertiesVsFields
This projects shows performance difference between properties and fields in .NET.

Properties in .NET are inlined by the compiler, which improves their performance to be on par with public fields. But if the program is run from the debugger a performance hit should be expected.

This project illustrates that.

## Sample Output:
* Release Binary Run:
```
Field operations took 40923 ticks.
Property operations took 40928 ticks.
```
* Debug Binary Run:
```
Field operations took 79336 ticks.
Property operations took 145491 ticks.
```
* Debug Debugger Run:
```
Field operations took 78161 ticks.
Property operations took 165692 ticks.
```
