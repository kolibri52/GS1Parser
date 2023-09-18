# GS1Parser Library C# .NET Framework
Contains a GS1 Parser written in C# (.NET Framework) with an integrated GTIN Validator. The core functionallity is encapsulated in a class library which is optimized for an easy integration in other programming languages like NI LabVIEW.

# Sources
The majority of the codebase is a clone from mschneidbauer/GS1Parser and from a stackoverflow discussion (https://stackoverflow.com/questions/9721718/ean128-or-gs1-128-decode-c-sharp/28854802#28854802).
The GTIN Validator is from https://github.com/dominiklessel/node-barcoder/blob/master/lib/barcoder.js.

Thank you very much for sharing and providing of this GS1 Parser.

# Usage and Content
The c# library "GS1Parser.dll" can easily called from other programming languages like LabVIEW.
Call the .NET constructor GS1Parser().
Execute the method Parse(string data). This method returns the parsed results as a dictionary,
which can be converted and read by several other functions.
