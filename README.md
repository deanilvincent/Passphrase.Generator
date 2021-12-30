[![Build Status](https://dev.azure.com/dv-github-repos/generate-passphrase/_apis/build/status/deanilvincent.generate-passphrase?branchName=main)](https://dev.azure.com/dv-github-repos/generate-passphrase/_build/latest?definitionId=7&branchName=main)

# Overview

NuGet package that generates passphrase.

# Installation

You can install using the following options: Package Manager

**Package Manager**
```
Install-Package Passphrase.Generator
```
**.NET CLI**
```
dotnet add package Passphrase.Generator
```
**PackageReference**
```
<PackageReference Include="Passphrase.Generator" Version="1.0.0" />
```
**Paket CLI**
```
paket add Passphrase.Generator
```

# Setup & Basic Usage
Import the package.
```
public class MyClass {
    public void Test(){
        var option = new Option { Length = 5, StartsWith = 'a'' };
        var result = PassphraseGenerator.Create(option);
        
        // the result will be a list of strings: e.g. ['acceptable', 'wilderness', 'carsick', 'bypass', 'crossly']
    }
}
```

## Additional Info

### Options

| Property   | Desc.                                          |
| ---------- | ---------------------------------------------- |
| length     | word(s) that will return as array              |
| startsWith | return words that start with the given letter |

### Contribute

Feel free to clone or fork this project: `https://github.com/deanilvincent/Passphrase.Generator.git`

Contributions & pull requests are welcome!

I'll be glad if you give this project a ★ on [Github](https://github.com/deanilvincent/Passphrase.Generator) :))

### License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/deanilvincent/Passphrase.Generator/blob/master/LICENSE) file for details.

