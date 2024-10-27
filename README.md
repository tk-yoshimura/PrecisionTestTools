# PrecisionTestTools
 Generic Precision Test Tools

## Requirement
.NET 8.0  
MSTest  

## Install

[Download DLL](https://github.com/tk-yoshimura/PrecisionTestTools/releases)  
[Download Nuget](https://www.nuget.org/packages/tyoshimura.PrecisionTestTools/)  

## Usage

```csharp
PrecisionAssert.AreEqual(expected: 1, actual: 1 + 1e-10, abserr: 1e-11);
PrecisionAssert.AlmostEqual(expected: 1, actual: 1 + 1e-10, relerr: 1e-11);
PrecisionAssert.AlmostEqual(expected: 1, actual: 1 + 1e-10, relerr: 1e-11, abserr: 1e-12);
```

## Licence
[MIT](https://github.com/tk-yoshimura/PrecisionTestTools/blob/main/LICENSE)

## Author

[T.Yoshimura](https://github.com/tk-yoshimura)
