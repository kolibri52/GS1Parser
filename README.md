# GS1Parser Library C# .NET Framework
Contains a GS1 Parser written in C# (.NET Framework) with an integrated GTIN Validator. The core functionallity is encapsulated in a class library which is optimized for an easy integration in other programming languages like NI LabVIEW.

# Sources
The majority of the codebase is a clone from mschneidbauer/GS1Parser and from a stackoverflow discussion (https://stackoverflow.com/questions/9721718/ean128-or-gs1-128-decode-c-sharp/28854802#28854802).
The GTIN Validator is from https://github.com/dominiklessel/node-barcoder/blob/master/lib/barcoder.js.

Thank you very much for sharing and providing of this GS1 Parser.

# Usage-Example for LabVIEW Code
The c# library "GS1Parser.dll" can easily called from other programming languages like LabVIEW:
1. Call the .NET constructor GS1Parser().
2. Execute the method Parse(string data).
3. This method returns the parsed results as a dictionary,
which can be converted and read by several other functions.
![Snippet Default](https://github.com/kolibri52/GS1Parser/assets/121813005/198a834d-8375-4b2b-ad59-7c14535691ba)

The GS1 Application Identifiers are updated and extended from time to time by the GS1 organisation (https://www.gs1.org/standards/barcodes/application-identifiers).
However, the GS1Definition object can be extended and the customized Definition-Object
can be used by the alternative constructor:
![Snippet_Extend_GS1Definition](https://github.com/kolibri52/GS1Parser/assets/121813005/45780103-4654-456b-bd19-5ff898046998)

# Disclaimer
All parts here are provided as is, and no promises or guarantees regarding quality of the results can be made.
