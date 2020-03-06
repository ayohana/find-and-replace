# Find And Replace

#### C# Basics & Behavior Driven Development Exercise for [Epicodus](https://www.epicodus.com/), 03.05.2020

#### By **Adela Darmansyah**

## Description

**This C# console application finds a word in a sentence and replaces the word with another.** A user will be able to enter a sentence, choose a word to be replaced and provide a replacement for that word.

## Specs

<details>
  <summary>Click to expand!</summary>

| Spec | `Console` Input | `Console` Output |
| :-------------     | :------------- | :------------- |
| **Program Gathers and Stores User Input of Original Sentence** | Hello world | `Stored:` Hello world |
| **Program Gathers and Stores User Input of a Word to be Searched For Replacement** | world | `Stored:` world |
| **Program Gathers and Stores User Input of a Replacement World** | universe | `Stored:` universe |
| **Program Finds Word to be Replaced** | world | `Returns index of word found in sentence` |
| **Program Finds and Replaces Word** | Hello world, world, universe | Hello universe |
| **Program Finds and Replaces Word Mid-Sentence** | Good morning world, morning, night | Good night world |

</details>

## Setup/Installation Requirements

* Download [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Clone this repository.
* Open the `Command Line Interface`.
  * Navigate into the `FindAndReplace` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the application.
    * Type in the command `dotnet run` to run the application.
  * Navigate into the `FindAndReplace.Tests` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the tests.
    * Type in the command `dotnet test` to run the tests. 

## Known Bugs

No known bugs at this time.

## Support and contact details

Feel free to provide feedback via email: adela.yohana@gmail.com.

## Technologies Used

* C#
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Markdown

### License

This C# console application is licensed under the MIT license.

Copyright (c) 2020 **Adela Darmansyah**