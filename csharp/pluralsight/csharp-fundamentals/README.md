# [C# Fundamentals, Scott Allen, 2019-04-19](https://app.pluralsight.com/library/courses/csharp-fundamentals-dev/table-of-contents)

- [C# Fundamentals, Scott Allen, 2019-04-19](#c-fundamentals-scott-allen-2019-04-19)
  - [Course Overview](#course-overview)
    - [Course Overview](#course-overview-1)
  - [Introducing C# and .NET](#introducing-c-and-net)
    - [Introduction](#introduction)
    - [Downloading .NET for Windows, macOS, and Linux](#downloading-net-for-windows-macos-and-linux)
    - [Understanding .NET and .NET Core](#understanding-net-and-net-core)
    - [Understanding the .NET Runtime and Framework](#understanding-the-net-runtime-and-framework)
    - [Using the .NET Command Line Interface](#using-the-net-command-line-interface)
    - [Creating the First C# Project](#creating-the-first-c-project)
    - [Editing C# Code with Visual Studio Code](#editing-c-code-with-visual-studio-code)
    - [Running and Building Your Project](#running-and-building-your-project)
    - [Saying Hello with C#](#saying-hello-with-c)
    - [Debugging a C# Application](#debugging-a-c-application)
    - [Summary](#summary)
  - [Learning the C# Syntax](#learning-the-c-syntax)
    - [Introduction](#introduction-1)
    - [Reviewing Your Assignment](#reviewing-your-assignment)
    - [Working with Code Blocks and Statements](#working-with-code-blocks-and-statements)
    - [Adding Numbers and Creating Arrays](#adding-numbers-and-creating-arrays)
    - [Looping through Arrays](#looping-through-arrays)
    - [Using a List](#using-a-list)
    - [Computing and Formatting the Result](#computing-and-formatting-the-result)
    - [Summary](#summary-1)
  - [Working with Classes and Objects](#working-with-classes-and-objects)
    - [Introduction](#introduction-2)
    - [Creating a Class](#creating-a-class)
    - [Adding State and Behavior](#adding-state-and-behavior)
    - [Defining a Method](#defining-a-method)
    - [Defining a Field](#defining-a-field)
    - [Adding a Constructor](#adding-a-constructor)
    - [Requiring Constructor Parameters](#requiring-constructor-parameters)
    - [Working with Static Members](#working-with-static-members)
    - [Computing Statistics](#computing-statistics)
    - [Solving the Statistics Challenge](#solving-the-statistics-challenge)
    - [Summary](#summary-2)
  - [Testing Your Code](#testing-your-code)
    - [Introduction](#introduction-3)
    - [The Many Benefits of Unit Testing](#the-many-benefits-of-unit-testing)
    - [Creating a Unit Test Project](#creating-a-unit-test-project)
    - [Writing and Running a Test](#writing-and-running-a-test)
    - [Referencing Projects and Packages](#referencing-projects-and-packages)
    - [Refactoring for Testability](#refactoring-for-testability)
    - [Summary](#summary-3)
  - [Working with Reference Types and Value Types](#working-with-reference-types-and-value-types)
    - [Introduction](#introduction-4)
    - [Reference Types and Value Types](#reference-types-and-value-types)
    - [Creating a Solution File](#creating-a-solution-file)
    - [Testing Object References](#testing-object-references)
    - [Referencing Different Objects](#referencing-different-objects)
    - [Passing Parameters by Value](#passing-parameters-by-value)
    - [Returning Object References](#returning-object-references)
    - [Passing Parameters by Reference](#passing-parameters-by-reference)
    - [Working with Value Types](#working-with-value-types)
    - [Value Type Parameters](#value-type-parameters)
    - [Looking for Reference Types and Value Types](#looking-for-reference-types-and-value-types)
    - [The Special Case of Strings in .NET](#the-special-case-of-strings-in-net)
    - [Taking Advantage of Garbage Collection](#taking-advantage-of-garbage-collection)
    - [Summary](#summary-4)
  - [Controlling the Flow of Execution](#controlling-the-flow-of-execution)
    - [Introduction](#introduction-5)
    - [Branching with if Statements](#branching-with-if-statements)
    - [Looping with for, foreach, do, and while](#looping-with-for-foreach-do-and-while)
    - [Jumping with break and continue](#jumping-with-break-and-continue)
    - [Switching with the switch Statement](#switching-with-the-switch-statement)
    - [Pattern Matching with switch](#pattern-matching-with-switch)
    - [Challenge: Taking User Input from the Console](#challenge-taking-user-input-from-the-console)
    - [One Solution](#one-solution)
    - [Throwing Exceptions](#throwing-exceptions)
    - [Catching Exceptions](#catching-exceptions)
    - [Summary](#summary-5)
  - [Building Types](#building-types)
    - [Introduction](#introduction-6)
    - [Overloading Methods](#overloading-methods)
    - [Defining Properties](#defining-properties)
    - [Defining Property 1s and Setters](#defining-property-getters-and-setters)
    - [Defining readonly Members](#defining-readonly-members)
    - [Defining const Members](#defining-const-members)
    - [Introducing Events and Delegates](#introducing-events-and-delegates)
    - [Defining a Delegate](#defining-a-delegate)
    - [Using Multi-cast Delegates](#using-multi-cast-delegates)
    - [Defining an Event](#defining-an-event)
    - [Subscribing to an Event](#subscribing-to-an-event)
    - [Summary](#summary-6)
  - [Object-oriented Programming with C](#object-oriented-programming-with-c)
    - [Introduction](#introduction-7)
    - [The Pillars of OOP](#the-pillars-of-oop)
    - [Deriving from a Base Class](#deriving-from-a-base-class)
    - [Chaining Constructors](#chaining-constructors)
    - [Deriving from System.Object](#deriving-from-systemobject)
    - [Setting up a Scenario](#setting-up-a-scenario)
    - [Defining an Abstract Class](#defining-an-abstract-class)
    - [Defining an Interface](#defining-an-interface)
    - [Writing Grades to a File](#writing-grades-to-a-file)
    - [Using IDisposable](#using-idisposable)
    - [A Statistical Challenge](#a-statistical-challenge)
    - [Refactoring Statistics](#refactoring-statistics)
    - [Summary](#summary-7)
  - [Catching up with the Latest in C](#catching-up-with-the-latest-in-c)
    - [Introduction](#introduction-8)
    - [Working with Non-nullable Reference Types](#working-with-non-nullable-reference-types)
    - [Summary](#summary-8)
  - [Going Further with C](#going-further-with-c)
    - [Introduction](#introduction-9)
    - [Generics](#generics)
    - [Async C#](#async-c)
    - [LINQ](#linq)
    - [Effective C#](#effective-c)

## Course Overview

### [Course Overview](https://app.pluralsight.com/course-player?courseId=0096b00d-2398-435a-82f7-3f5401408ab1)

## Introducing C# and .NET

### [Introduction](https://app.pluralsight.com/course-player?clipId=a378cd76-5548-4933-8f1c-b233c7b8afae)

### [Downloading .NET for Windows, macOS, and Linux](https://app.pluralsight.com/course-player?clipId=8cef35a5-f454-451d-9491-deb7f63e5490)

- Download .NET Core SDK.

  ```sh
  brew install --cask dotnet-sdk
  ```

  - This course will use .NET Core 2.2 and Visual Studio Code.

### [Understanding .NET and .NET Core](https://app.pluralsight.com/course-player?clipId=4c54ddad-471d-4bfe-8090-311d38545017)

- Two different .NETs:
  - ".NET" or ".NET Framework"
    - Works only on Windows (pre-installed).
    - Since around 2001.
  - ".NET Core"
    - Completely open source
    - Works across platforms (Linux, Mac, Windows, ARM)
    - Preferable for new projects.

### [Understanding the .NET Runtime and Framework](https://app.pluralsight.com/course-player?clipId=38c37661-0267-47f0-b1a6-0ae28c7d7e09)

- 2 pieces comprise .NET
  - CLR (Common Language **Runtime**)
    - Also supports
      - Visual Basic .NET
      - F#
      - Others
  - FCL (Framework Class **Library**)

### [Using the .NET Command Line Interface](https://app.pluralsight.com/course-player?clipId=261da5d1-79c0-4f07-968a-1ee68e7f88c1)

- Command Prompt or terminal

  ```sh
  dotnet
  # Helpful environment troubleshooting information:
  dotnet --info
  # View SDK commands:
  dotnet --help
  ```

  - ![](2021-03-10-20-19-37.png)
  - ![](2021-03-10-20-22-22.png)
  - ASP.NET Core
    - Web framework build on top of .NET Core
  - We'll create a console application

### [Creating the First C# Project](https://app.pluralsight.com/course-player?clipId=6f7ace43-04f7-46c0-8d7a-daf731e14c5f)

```bat
dotnet new
mkdir gradebook
cd gradebook
dir
mkdir src
mkdir test
cd src
mkdir GradeBook
cd Gradebook
dotnet new console
```

- Creates a set of files
  - `GradeBook.csproj`
    - `.csproj` indicates this is a C# project.
  - `Program.cs`
    - Contains C# source code that's already part of the console application.
- Running `dotnet run`:
  - Looks inside the current directory for a `.csproj` file.
  - Attempts to execute code in project.

### [Editing C# Code with Visual Studio Code](https://app.pluralsight.com/course-player?clipId=69fab3ca-7372-4b67-8cd0-80d91c1fa005)

```bat
..\..\
code .
```

- Add extension
  - Add `C#` extension.
  - Should receive prompt: `Required assets to build and debug are missing from 'gradebook'. Add them?`
    - Click `Yes`.
- Open `Program.cs`:

  ```cs
  using System;

  namespace GradeBook
  {
      class Program
      {
          static void Main(string[] args)
          {
              Console.WriteLine("Hello World!");
          }
      }
  }
  ```

  ```cs
  using System;

  namespace GradeBook
  {
      class Program
      {
          static void Main(string[] args)
          {
              Console.WriteLine("Hello Eric!");
          }
      }
  }
  ```

  ```sh
  dotnet run --project src/GradeBook
  ```

  ```bat
  dotnet run --project src\GradeBook
  ```

### [Running and Building Your Project](https://app.pluralsight.com/course-player?clipId=14bf9a2b-63b9-4873-a1c0-4c507e9790be)

- When doing a `dotnet run`:
  - Behind the scenes, a `dotnet restore` runs.
    - Get dependencies.
    - Package system: NuGet
    - Packages are available via a package feed.
    - The `.csproj` file records these packages.
  - Then: `dotnet build`.
    - Compile source code (to binary `.dll` file) into `bin/Debug`.
      - Not a dynamic link library. Better to think of it as an assembly.
- `obj` folder: Temporary object files from restore/build process.
- If we try to execute the `.dll` file in Windows, it encounters an error: `Could not load file or assembly`.
  - We need the runtime.
  - Could pass `.dll` file as argument to `dotnet`.

### [Saying Hello with C#](https://app.pluralsight.com/course-player?clipId=886b9135-7167-448b-a8ef-85028dab676c)

- Goal: Be able to pass name as a parameter to the console application.

```cs
using System;

namespace GradeBook
{
  class Program
  {
    // Main method: conventional entry point.
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Eric!");
    }
  }
}
```

```cs
using System;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      // Concatenation:
      //   Console.WriteLine("Hello " + args[0] + "!");
      // String interpolation:
      Console.WriteLine($"Hello, {args[0]}!");
    }
  }
}
```

- Note that passing an argument to `dotnet run` passes it to the CLI, not to the application.
  - Argument passed to CLI:
    - `dotnet run Eric`
  - Argument passed to application:
    - `dotnet run -- Eric`

```sh
dotnet run --project src/GradeBook Eric
```

### [Debugging a C# Application](https://app.pluralsight.com/course-player?clipId=f18927ec-476a-482a-b692-d5f3d3512fca)

- .NET runtime crashes for unhandled exceptions.
  - Add breakpoint for `Console.WriteLine($"Hello, {args[0]}!");`.
  - Navigate to `Debug` (or `Run`)> `Start Debugging`.
    - Shortcut: F5.
    - Shortcut to stop debugging: Shift + F5

```cs
using System;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length > 0)
      {
        Console.WriteLine($"Hello, {args[0]}!");
      }
      else
      {
        Console.WriteLine("Hello!");
      }
    }
  }
}
```

- In `.vscode/launch.json`, note `configuration.args`. Can use to pass args while debugging.

  ```json
  {
    "version": "0.2.0",
    "configurations": [
      {
        // Use IntelliSense to find out which attributes exist for C# debugging
        // Use hover for the description of the existing attributes
        // For further information visit https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md
        "name": ".NET Core Launch (console)",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "build",
        // If you have changed target frameworks, make sure to update the program path.
        "program": "${workspaceFolder}/c#/pluralsight/c#-fundamentals/gradebook/src/GradeBook/bin/Debug/net5.0/GradeBook.dll",
        "args": [],
        "cwd": "${workspaceFolder}/c#/pluralsight/c#-fundamentals/gradebook/src/GradeBook",
        // For more information about the 'console' field, see https://aka.ms/VSCode-CS-LaunchJson-Console
        "console": "internalConsole",
        "stopAtEntry": false
      },
      {
        "name": ".NET Core Attach",
        "type": "coreclr",
        "request": "attach",
        "processId": "${command:pickProcess}"
      }
    ]
  }
  ```

### [Summary](https://app.pluralsight.com/course-player?clipId=d889e0b6-67ec-41c1-b47f-e84c927367b0)

## Learning the C# Syntax

### [Introduction](https://app.pluralsight.com/course-player?clipId=0fc3d387-1e0d-4b88-a382-22efd53e7e6b)

### [Reviewing Your Assignment](https://app.pluralsight.com/course-player?clipId=f2a753fd-4a09-4c4c-a413-dcce3600ef58)

### [Working with Code Blocks and Statements](https://app.pluralsight.com/course-player?clipId=bf07edc2-f7d6-4812-8311-f648c97aaa02)

- Implicit typing (with initialization) &rarr; `var`
- Look up VS Code C# snippets.

### Adding Numbers and Creating Arrays

### [Looping through Arrays](https://app.pluralsight.com/course-player?clipId=3f7b7f5e-8a98-418c-8733-45ebdfcf094c)

- Array initialization syntax:
  - `var numbers = new double[3] { 12.7, 10.3, 6.11 };`
  - `var numbers = new[] { 12.7, 10.3, 6.11 };`
- `foreach`:

  ```cs
  var numbers = new[] { 12.7, 10.3, 6.11 };

  var result = 0.0;
  foreach (double number in numbers)
  {
    result += number;
  }
  ```

### [Using a List](https://app.pluralsight.com/course-player?clipId=3b8df66f-fd24-45c5-86b3-208b16106710)

- Access VS Code suggested fixed: Cmd + . (or Windows: Control + .).
- Arrays are fixed-length.
  - Data structures (list, stack, queue):
    - `Systems.Collections.Generic`
- List initialization:
  - `List<double> grades = new List<double>();`
  - `var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };`

### [Computing and Formatting the Result](https://app.pluralsight.com/course-player?clipId=c5be9427-7586-4cc9-8f83-dc4aa4206352)

- Format as number with 1 digit after decimal:
  - `Console.WriteLine($"The average grade is {result:N1}");`

### [Summary](https://app.pluralsight.com/course-player?clipId=a45d2ba2-b1f4-4d7e-b249-85bb19ca9748)

```cs
using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
      grades.Add(56.1);

      var result = 0.0;
      foreach (double number in grades)
      {
        result += number;
      }
      result /= grades.Count;
      Console.WriteLine($"The average grade is {result:N1}");

      if (args.Length > 0)
      {
        Console.WriteLine($"Hello, {args[0]}!");
      }
      else
      {
        Console.WriteLine("Hello!");
      }
    }
  }
}
```

## Working with Classes and Objects

### [Introduction](https://app.pluralsight.com/course-player?clipId=1acccfd3-3a64-4719-9bbb-8dc3a43b1c64)

### [Creating a Class](https://app.pluralsight.com/course-player?clipId=893b69a0-e3a1-4807-a1fb-0d966614fcd1)

- Code should almost always be inside a defined `namespace`; otherwise, we're in the global namespace.

  ```cs
  namespace GradeBook
  {
    class Program
    {
      // ...
    }
  }
  ```

- Microsoft libraries are often in the `System` namespace.
- Allen prefers to never see namespaces in the code.

### [Adding State and Behavior](https://app.pluralsight.com/course-player?clipId=219579ef-110d-476a-ba4e-ef31d97a1b8f)

- Convention: 1 class per file
  - Class: state + behavior
- Add `src/GradeBook/Book.cs`:

  ```cs
  namespace GradeBook {
      class Book {

    }
  }
  ```

### [Defining a Method](https://app.pluralsight.com/course-player?clipId=a0d44461-bcb4-4c65-be0c-ba202e7abe4d)

- `src/GradeBook/Program.cs`:

  ```cs
  using System;
  using System.Collections.Generic;

  namespace GradeBook
  {
    class Program
    {
      static void Main(string[] args)
      {
        var book = new Book();
        book.AddGrade(89.1);

        var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
        grades.Add(56.1);

        var result = 0.0;
        foreach (double number in grades)
        {
          result += number;
        }
        result /= grades.Count;
        Console.WriteLine($"The average grade is {result:N1}");
      }
    }
  }
  ```

- `src/GradeBook/Book.cs`

  ```cs
  namespace GradeBook
  {
    class Book
    {
      public void AddGrade(double grade)
      {

      }
    }
  }
  ```

### [Defining a Field](https://app.pluralsight.com/course-player?clipId=4e7eb476-1b9f-4f81-8eee-f81365bc0c13)

- Note that a field cannot use implicit typing.

### [Adding a Constructor](https://app.pluralsight.com/course-player?clipId=a96054ab-76de-4a61-869f-89d38afcc278)

- We'll define an explicit constructor (vs. an implicit constructor provided by the complier).

```cs

using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {
    public Book()
    {
      grades = new List<double>();
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    List<double> grades;
  }
}
```

### [Requiring Constructor Parameters](https://app.pluralsight.com/course-player?clipId=a6b14802-c5e7-4952-a99b-a6c1e3f642f7)

- Access modifiers
  - `public`
  - `private`
- `this` is an implicit variable always available inside constructors and methods.

### [Working with Static Members](https://app.pluralsight.com/course-player?clipId=6ceaa039-c943-4408-b637-a7b9b8c7c792)

- Opposite of a static method: An instance member.
- Statics are not associate with an object instance; they're associated with the type they're defined inside of.

### [Computing Statistics](https://app.pluralsight.com/course-player?clipId=619ab8b5-efb5-4540-a025-18b431dd5b0d)

### [Solving the Statistics Challenge](https://app.pluralsight.com/course-player?clipId=15d69e29-75ff-4639-b1c8-24f6f4a9e3fe)

### [Summary](https://app.pluralsight.com/course-player?clipId=8ac5b526-98e5-4e00-b4d7-bce718d504a8)

- `Program.cs`:

  ```cs
  namespace GradeBook
  {
    class Program
    {
      static void Main(string[] args)
      {

        var book = new Book("Scott's Grade Book");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.5);
        book.ShowStatistics();
      }
    }
  }
  ```

- `Book.cs`:

  ```cs
  using System;
  using System.Collections.Generic;

  namespace GradeBook
  {
    class Book
    {
      public Book(string name)
      {
        grades = new List<double>();
        this.name = name;
      }

      public void AddGrade(double grade)
      {
        grades.Add(grade);
      }

      public void ShowStatistics()
      {
        var result = 0.0;
        var lowestGrade = double.MaxValue;
        var highestGrade = double.MinValue;
        foreach (double number in grades)
        {
          lowestGrade = Math.Min(number, lowestGrade);
          highestGrade = Math.Max(number, highestGrade);
          result += number;
        }
        result /= grades.Count;
        Console.WriteLine($"The highest grade is {highestGrade:N1}");
        Console.WriteLine($"The lowest grade is {lowestGrade:N1}");
        Console.WriteLine($"The average grade is {result:N1}");
      }

      private List<double> grades;
      private string name;
    }
  }
  ```

## Testing Your Code

### [Introduction](https://app.pluralsight.com/course-player?clipId=54eb1aab-f19e-4828-b4cd-761873608479)

### [The Many Benefits of Unit Testing](https://app.pluralsight.com/course-player?clipId=6c9113dd-8203-4108-842f-3dc749b6282c)

- We'll use xUnit.net

### [Creating a Unit Test Project](https://app.pluralsight.com/course-player?clipId=0d26192f-9623-411c-b325-a0ea09e3f33c)

- Convention: Write tests in a separate project.

  ```sh
  cd test
  mkdir GradeBook.Tests
  cd GradeBook.Tests
  dotnet new xunit
  ```

  - xUnit is a NuGet package; not part of .NET Core.

    - Using `dotnet new xunit` handled this already for us:

      - https://www.nuget.org/packages/xunit/

        ```sh
        dotnet add package xunit --version 2.4.1
        ```

- `test/GradeBook.Tests/GradeBook.Tests.csproj`:

  ```xml
  <Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
      <TargetFramework>net5.0</TargetFramework>

      <IsPackable>false</IsPackable>
    </PropertyGroup>

    <ItemGroup>
      <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.7.1" />
      <PackageReference Include="xunit" Version="2.4.1" />
      <PackageReference Include="xunit.runner.visualstudio" Version="2.4.3">
        <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
        <PrivateAssets>all</PrivateAssets>
      </PackageReference>
      <PackageReference Include="coverlet.collector" Version="1.3.0">
        <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
        <PrivateAssets>all</PrivateAssets>
      </PackageReference>
    </ItemGroup>

  </Project>
  ```

### [Writing and Running a Test](https://app.pluralsight.com/course-player?clipId=13461d51-f9df-422d-95a9-98da47b1c741)

- The new xUnit project created `test/GradeBook.Tests/UnitTest1.cs`:

  ```cs
  using System;
  // Bring in Xunit namespace.
  using Xunit;

  namespace GradeBook.Tests
  {
      public class UnitTest1
      {
          // `[Fact]` is an attribute. It's attached to the following symbol. xUnit looks for methods with the [Fact] attribute.
          [Fact]
          public void Test1()
          {

          }
      }
  }
  ```

- Install .NET Core unit text extension.
- .NET CLI includes a test runner:

  ```cs
  dotnet test
  ```

- Unit test essence:

  ```cs
  using System;
  using Xunit;

  namespace GradeBook.Tests
  {
    public class UnitTest1
    {
      [Fact]
      public void Test1()
      {
        // arrange
        var x = 5;
        var y = 2;
        var expected = 7;

        // act
        var actual = x + y;

        // assert
        Assert.Equal(expected, actual);
      }
    }
  }
  ```

### [Referencing Projects and Packages](https://app.pluralsight.com/course-player?clipId=2dfff216-dc41-4d34-87e5-8e2d3d783b3a)

- Convention: File name should match test (class) name.
- CLI: Add a project-to-project reference (so we can pull Book into the test project).

  ```sh
  dotnet add reference ../../src/GradeBook/GradeBook.csproj
  ```

- Adds a project reference to `GradeBook.Tests.csproj`:

  ```xml
  <Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
      <TargetFramework>net5.0</TargetFramework>

      <IsPackable>false</IsPackable>
    </PropertyGroup>

    <ItemGroup>
      <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.7.1" />
      <PackageReference Include="xunit" Version="2.4.1" />
      <PackageReference Include="xunit.runner.visualstudio" Version="2.4.3">
        <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
        <PrivateAssets>all</PrivateAssets>
      </PackageReference>
      <PackageReference Include="coverlet.collector" Version="1.3.0">
        <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
        <PrivateAssets>all</PrivateAssets>
      </PackageReference>
    </ItemGroup>

    <ItemGroup>
      <ProjectReference Include="..\..\src\GradeBook\GradeBook.csproj" />
    </ItemGroup>

  </Project>
  ```

- Default class access: `internal` (can only be used within the same project).
  - Need to add `public` so test can access `Book`.
- Because we are in a namespace underneath the `Book`'s namespace (i.e., `namespace GradeBook.Tests` is under `namespace GradeBook`), we don't need a `using` statement.

### [Refactoring for Testability](https://app.pluralsight.com/course-player?clipId=114ffe93-dcd9-4b40-bede-7ef7e17ad580)

- `ShowStatistics` currently computes grades and displays the result of the calculations.
- Note that the .NET runtime sets all fields of a class to 'all bits off' - so, for a floating point field, to `0.0`.
- Add `gradebook/src/GradeBook/Statistics.cs`:

  ```cs
  namespace GradeBook
  {
    public class Statistics
    {
      public double Average;
      public double High;
      public double Low;
    }
  }
  ```

- `gradebook/src/GradeBook/Book.cs`:

  ```cs

  using System;
  using System.Collections.Generic;

  namespace GradeBook
  {
    public class Book
    {
      public Book(string name)
      {
        grades = new List<double>();
        this.name = name;
      }

      public void AddGrade(double grade)
      {
        grades.Add(grade);
      }

      public Statistics GetStatistics()
      {
        var result = new Statistics();
        result.Average = 0.0;
        result.High = double.MinValue;
        result.Low = double.MaxValue;
        foreach (double grade in grades)
        {
          result.Low = Math.Min(grade, result.Low);
          result.High = Math.Max(grade, result.High);
          result.Average += grade;
        }
        result.Average /= grades.Count;

        return result;
      }

      private List<double> grades;
      private string name;
    }
  }
  ```

- `gradebook/src/GradeBook/Program.cs`:

  ```cs
  using System;
  namespace GradeBook
  {
    class Program
    {
      static void Main(string[] args)
      {

        var book = new Book("Scott's Grade Book");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.5);
        var stats = book.GetStatistics();

        Console.WriteLine($"The highest grade is {stats.High:N1}");
        Console.WriteLine($"The lowest grade is {stats.Low:N1}");
        Console.WriteLine($"The average grade is {stats.Average:N1}");
      }
    }
  }
  ```

- `gradebook/test/GradeBook.Tests/BookTests.cs`:

  ```cs
  using System;
  using Xunit;

  namespace GradeBook.Tests
  {
    public class BookTests
    {
      [Fact]
      public void Test1()
      {
        // arrange
        var book = new Book("");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

        // act
        var result = book.GetStatistics();

        // assert
        // Assert.Equal to 1 decimal point of precision.
        Assert.Equal(85.6, result.Average, 1);
        Assert.Equal(90.5, result.High, 1);
        Assert.Equal(77.3, result.Low, 1);
      }
    }
  }
  ```

- Test with `dotnet test` from within `gradebook/test/GradeBook.Tests`.

### [Summary](https://app.pluralsight.com/course-player?clipId=f67b23bc-1c46-4ecf-9744-7f67bb8867fd)

## Working with Reference Types and Value Types

### [Introduction](https://app.pluralsight.com/course-player?clipId=da67bd8b-7dec-4347-ab62-da09aa2dc70f)

### [Reference Types and Value Types](https://app.pluralsight.com/course-player?clipId=7a6a9615-37d8-4c58-aacf-4b5bb26125ec)

- Reference type vs. value type
  - Any use of a class: A reference type
  - The variable stores a reference to the value.
- For a value type: The variable stores the value, rather than a pointer to the value.

### [Creating a Solution File](https://app.pluralsight.com/course-player?clipId=a3b92bcd-7f18-41af-bc7a-49dbad97f120)

- A solution file: A file that keeps track of multiple projects.
  - Understood by Visual Studio and the CLI.
- Create solution in `gradebook`:

```sh
# Create solution file.
dotnet new sln
# Add projects to solution file.
dotnet sln add src/GradeBook/GradeBook.csproj
dotnet sln add test/GradeBook.Tests/GradeBook.Tests.csproj
# Looks for solution file in current directory.
dotnet build
```

### [Testing Object References](https://app.pluralsight.com/course-player?clipId=e2efdb6f-c54b-4c08-b40d-78ae5a1601c6)

- In `src/GradeBook/Book.cs`:

  - Change name from `private` to `public` for ease of testing.
    - Convention in C#: A public member always has an uppercase name.
    - We also don't need `this` anymore, since the case differs.

  ```cs

  using System;
  using System.Collections.Generic;

  namespace GradeBook
  {
    public class Book
    {
      public Book(string name)
      {
        grades = new List<double>();
        Name = name;
      }

      public void AddGrade(double grade)
      {
        grades.Add(grade);
      }

      public Statistics GetStatistics()
      {
        var result = new Statistics();
        result.Average = 0.0;
        result.High = double.MinValue;
        result.Low = double.MaxValue;
        foreach (double grade in grades)
        {
          result.Low = Math.Min(grade, result.Low);
          result.High = Math.Max(grade, result.High);
          result.Average += grade;
        }
        result.Average /= grades.Count;

        return result;
      }

      private List<double> grades;
      public string Name;
    }
  }
  ```

- In `test/GradeBook.Tests`:
  - Rename `Test1` to `BookCalculatesAnAverageGrade`
- Create `test/GradeBook.TypeTest.cs`:

  ```cs
  using System;
  using Xunit;

  namespace GradeBook.Tests
  {
    public class TypeTests
    {
      [Fact]
      public void GetBookReturnsDifferentObjects()
      {
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
      }

      Book GetBook(string name)
      {
        return new Book(name);
      }
    }
  }
  ```

### [Referencing Different Objects](https://app.pluralsight.com/course-player?clipId=7ee97500-84c5-4d8c-a68d-11746614a144)

```sh
dotnet test
```

- `test/GradeBook.Tests/TypeTests.cs`:

  ```cs
  using System;
  using Xunit;

  namespace GradeBook.Tests
  {
    public class TypeTests
    {
      [Fact]
      public void GetBookReturnsDifferentObjects()
      {
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);
      }

      [Fact]
      public void TwoVarsCanReferenceSameObject()
      {
        var book1 = GetBook("Book 1");
        var book2 = book1;

        // Under the hood: Assert.True(Object.ReferenceEquals(book1, book2));
        Assert.Same(book1, book2);
      }

      Book GetBook(string name)
      {
        return new Book(name);
      }
    }
  }
  ```

### [Passing Parameters by Value](https://app.pluralsight.com/course-player?clipId=c982cb1e-eecf-4153-b58c-8b42a4b56f53)

- Note that `var book2 = book1` does _not_ make a copy. It takes the value (the reference, the pointer) inside `book1` and copies that to `book2`, leading us to the same memory location.
- `test/GradeBook.Tests/TypeTests.cs`:

  ```cs
  using System;
  using Xunit;

  namespace GradeBook.Tests
  {
    public class TypeTests
    {
      [Fact]
      public void CanSetNameFromReference()
      {
        var book1 = GetBook("Book 1");
        SetName(book1, "New Name");

        Assert.Equal("New Name", book1.Name);
      }

      private void SetName(Book book, string name)
      {
        book.Name = name;
      }

      [Fact]
      public void GetBookReturnsDifferentObjects()
      {
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);
      }

      [Fact]
      public void TwoVarsCanReferenceSameObject()
      {
        var book1 = GetBook("Book 1");
        var book2 = book1;

        // Under the hood: Assert.True(Object.ReferenceEquals(book1, book2));
        Assert.Same(book1, book2);
      }

      Book GetBook(string name)
      {
        return new Book(name);
      }
    }
  }
  ```

### [Returning Object References](https://app.pluralsight.com/course-player?clipId=654696f3-26b9-4011-aa67-24d2b868b39f)

- Passing a parameter: In C#, you are always passing by _value_.
  - ![](2021-03-22-21-07-01.png)

### [Passing Parameters by Reference](https://app.pluralsight.com/course-player?clipId=d8476418-6861-4720-b0b9-f818632e2189)

- ![](2021-03-22-21-12-42.png)
- ![](2021-03-22-21-15-46.png)
- Difference between `ref` and `out`: With `out`, the C# compiler assumes the incoming reference has not been an initialized.
- `test/GradeBook.Tests/TypeTests.cs`:

  ```cs
  using System;
  using Xunit;

  namespace GradeBook.Tests
  {
    public class TypeTests
    {
      [Fact]
      public void CSharpCanPassByRef()
      {
        var book1 = GetBook("Book 1");
        // GetBookSetName(ref book1, "New Name");
        GetBookSetName(out book1, "New Name");

        Assert.Equal("New Name", book1.Name);
      }

      // private void GetBookSetName(ref Book book, string name)
      private void GetBookSetName(out Book book, string name)
      {
        book = new Book(name);
      }

      [Fact]
      public void CSharpIsPassByValue()
      {
        var book1 = GetBook("Book 1");
        GetBookSetName(book1, "New Name");

        Assert.Equal("Book 1", book1.Name);
      }

      private void GetBookSetName(Book book, string name)
      {
        book = new Book(name);
        book.Name = name;
      }
      [Fact]
      public void CanSetNameFromReference()
      {
        var book1 = GetBook("Book 1");
        SetName(book1, "New Name");

        Assert.Equal("New Name", book1.Name);
      }

      private void SetName(Book book, string name)
      {
        book.Name = name;
      }

      [Fact]
      public void GetBookReturnsDifferentObjects()
      {
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);
      }

      [Fact]
      public void TwoVarsCanReferenceSameObject()
      {
        var book1 = GetBook("Book 1");
        var book2 = book1;

        // Under the hood: Assert.True(Object.ReferenceEquals(book1, book2));
        Assert.Same(book1, book2);
      }

      Book GetBook(string name)
      {
        return new Book(name);
      }
    }
  }
  ```

### [Working with Value Types](https://app.pluralsight.com/course-player?clipId=9c87cba7-afa8-41d5-a02a-7250f81c79ea)

- Add an additional test in `test/GradeBook.Tests/TypeTests.cs`:

  ```cs
  [Fact]
  public void Test1()
  {
    var x = GetInt();

    Assert.Equal(3, x);
  }

  public int GetInt()
  {
    return 3;
  }
  ```

- Value types: integers, floating point numbers, datetimes, and booleans
  - What you see is what you get,
  - The variable holds the value (vs. a reference to the object, which is somewhere else in memory).
- Add an additional test in `test/GradeBook.Tests/TypeTests.cs`:

  ```cs
  [Fact]
  public void Test1()
  {
    var x = GetInt();
    Assert.Equal(3, x);

    SetInt(x);
    Assert.Equal(3, x);
  }

  private void SetInt(int x)
  {
    x = 42;
  }
  ```

### [Value Type Parameters](https://app.pluralsight.com/course-player?clipId=c7932ad1-3008-4180-96e8-a418d3e1fe70)

```cs
[Fact]
public void Test1()
{
  var x = GetInt();
  Assert.Equal(3, x);

  // SetInt(x);
  // Assert.Equal(3, x);
  SetInt(ref x);
  Assert.Equal(42, x);
}

// private void SetInt(int x)
// {
//   x = 42;
// }
private void SetInt(ref int z)
{
  z = 42;
}
```

### [Looking for Reference Types and Value Types](https://app.pluralsight.com/course-player?clipId=3a67526d-af7e-48f0-b896-5483e8da1200)

- How to differentiate between a reference type and a value type:
  - Whenever you are working with something that has been defined by a class, you are working with a reference type.
  - Another way to define a type in C# is via `struct`.
    - Needs to behave like a value type; typically very small.
    - Can be more efficient than reference types for certain scenarios.
    - Can have fields and methods; but some limitations.
  - If you place your cursor on a type and press F12, we can see a metadata view.
    - ![](2021-03-23-19-54-41.png)
    - Note: int is a `struct`.
      - Note that `int` is actually an alias for `Int32`.
    - Similarly, `double` is actually a `Double` `struct`.
    - `bool` &rarr; `Boolean`.
    - Not all value types have a shortcut.
      - `DateTime`.
  - One special type: `string` (`String`)
    - Always a reference type.
    - But it often _behaves_ like a value type.

### [The Special Case of Strings in .NET](https://app.pluralsight.com/course-player?clipId=1feddee0-38d4-4a52-a8e0-6f03f447972b)

- Strings are immutable in C#.

  ```cs
  [Fact]
  public void StringsBehaveLikeValueTypes()
  {
    string name = "Scott";
    var upper = MakeUpperCase(name);

    Assert.Equal("Scott", name);
    Assert.Equal("SCOTT", upper);
  }

  private string MakeUpperCase(string parameter)
  {
    return parameter.ToUpper();
  }
  ```

### [Taking Advantage of Garbage Collection](https://app.pluralsight.com/course-player?clipId=ce967f1b-b7c2-416c-b0e2-7917d832a46a)

- The C# runtime garbage collector keeps track of objects and frees up memory accordingly.

### [Summary](https://app.pluralsight.com/course-player?clipId=f66e31d9-1951-418e-aad1-370d6b34d79b)

- ![](2021-03-23-20-04-53.png)

## Controlling the Flow of Execution

### [Introduction](https://app.pluralsight.com/course-player?clipId=1428326e-49f9-4067-a655-900c87d8253d)

### [Branching with if Statements](https://app.pluralsight.com/course-player?clipId=b0bed4f5-32cf-4e87-a476-3a4c4dffcacf)

### [Looping with for, foreach, do, and while](https://app.pluralsight.com/course-player?clipId=428476f7-0c85-489f-838c-7361c464bce4)

```cs
foreach (double grade in grades)
{
  result.Low = Math.Min(grade, result.Low);
  result.High = Math.Max(grade, result.High);
  result.Average += grade;
}
```

```cs
var index = 0;
// Loop will always execute at least once.
do
{
  result.Low = Math.Min(grades[index], result.Low);
  result.High = Math.Max(grades[index], result.High);
  result.Average += grades[index];
  index += 1;
} while (index < grades.Count);
```

```cs
var index = 0;
while (index < grades.Count)
{
  result.Low = Math.Min(grades[index], result.Low);
  result.High = Math.Max(grades[index], result.High);
  result.Average += grades[index];
  index += 1;
}
```

```cs
for (int index = 0; index < grades.Count; index += 1)
{
  result.Low = Math.Min(grades[index], result.Low);
  result.High = Math.Max(grades[index], result.High);
  result.Average += grades[index];
}
```

### [Jumping with break and continue](https://app.pluralsight.com/course-player?clipId=83f514dd-e6e8-441e-a9e7-19243615ddbd)

- `break`:
  - Exit loop.
- `continue`:
  - Skip over the remaining lines of code, but continue to the next iteration.
- `goto`:
  - Go to an arbitrary label (e.g., `goto done;` and `done`)

### [Switching with the switch Statement](https://app.pluralsight.com/course-player?clipId=5b6155b3-d2ed-42ed-aa1a-3a0103210b37)

- Note: `char`, for a single character, is a struct (value type).
  - Use single quotes with a `char`; double quotes would lead to the compiler treating it as a string.
- In a `switch` statement, the C# compiler requires specific flow control (e.g., `break`).
- In `gradebook/src/GradeBook/Book.cs`:

  ```cs
  public void AddLetterGrade(char letter)
  {
    switch (letter)
    {
      case 'A':
        AddGrade(90);
        break;

      case 'B':
        AddGrade(80);
        break;

      case 'C':
        AddGrade(70);
        break;

      default:
        AddGrade(0);
        break;
    }
  }
  ```

### [Pattern Matching with switch](https://app.pluralsight.com/course-player?clipId=49a8adcf-51f5-416c-8220-32405415e59f)

- As of C# 7, `switch` can match patterns.
- In `gradebook/src/GradeBook/Statistics.cs`:

  ```cs
  namespace GradeBook
  {
    public class Statistics
    {
      public double Average;
      public double High;
      public double Low;
      // Add Letter.
      public char Letter;
    }
  }
  ```

- In `gradebook/src/GradeBook/Program.cs`:

  ```cs
  using System;
  namespace GradeBook
  {
    class Program
    {
      static void Main(string[] args)
      {

        var book = new Book("Scott's Grade Book");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.5);
        var stats = book.GetStatistics();

        Console.WriteLine($"The highest grade is {stats.High:N1}");
        Console.WriteLine($"The lowest grade is {stats.Low:N1}");
        Console.WriteLine($"The average grade is {stats.Average:N1}");
        // Print stats.Letter.
        Console.WriteLine($"The letter is {stats.Letter}");
      }
    }
  }
  ```

- In `gradebook/src/GradeBook/Book.cs`:

  ```cs
  public Statistics GetStatistics()
  {
    var result = new Statistics();
    result.Average = 0.0;
    result.High = double.MinValue;
    result.Low = double.MaxValue;

    foreach (double grade in grades)
    {
      result.Low = Math.Min(grade, result.Low);
      result.High = Math.Max(grade, result.High);
      result.Average += grade;
    }

    result.Average /= grades.Count;

    switch (result.Average)
    {
      case var d when d >= 90.0:
        result.Letter = 'A';
        break;
      case var d when d >= 80.0:
        result.Letter = 'B';
        break;
      case var d when d >= 70.0:
        result.Letter = 'C';
        break;
      case var d when d >= 60.0:
        result.Letter = 'D';
        break;
      default:
        result.Letter = 'F';
        break;
    }

    return result;
  }
  ```

### [Challenge: Taking User Input from the Console](https://app.pluralsight.com/course-player?clipId=2c1a1640-aad1-432a-b175-5531772bafaf)

### [One Solution](https://app.pluralsight.com/course-player?clipId=ad8821e5-b4d5-4070-9b18-5af1de1663c2)

- In `gradebook/src/GradeBook/Program.cs`:

  ```cs
  using System;
  namespace GradeBook
  {
    class Program
    {
      static void Main(string[] args)
      {

        var book = new Book("Scott's Grade Book");

        while (true)
        {
          Console.WriteLine("Enter a grade or 'q' to quit");
          var input = Console.ReadLine();

          if (input == "q")
          {
            break;
          }

          var grade = double.Parse(input);
          book.AddGrade(grade);
        }

        var stats = book.GetStatistics();

        Console.WriteLine($"The highest grade is {stats.High:N1}");
        Console.WriteLine($"The lowest grade is {stats.Low:N1}");
        Console.WriteLine($"The average grade is {stats.Average:N1}");
        Console.WriteLine($"The letter is {stats.Letter}");
      }
    }
  }
  ```

- Run:

```sh
dotnet run --project src/GradeBook/GradeBook.csproj
```

### [Throwing Exceptions](https://app.pluralsight.com/course-player?clipId=d8377fb8-bba3-49f2-9f85-b2ddd237791d)

- In `gradebook/src/GradeBook/Book.cs`:

  ```cs
  public void AddGrade(double grade)
  {
    if (grade >= 0 && grade <= 100)
    {
      grades.Add(grade);
    }
    else
    {
      throw new ArgumentException($"Invalid {nameof(grade)}");
    }
  }
  ```

### [Catching Exceptions](https://app.pluralsight.com/course-player?clipId=482048a9-05ef-493f-a052-5cfaf3c466ab)

- In `gradebook/src/GradeBook/Program.cs`:

  ```cs
  using System;
  namespace GradeBook
  {
    class Program
    {
      static void Main(string[] args)
      {

        var book = new Book("Scott's Grade Book");

        while (true)
        {
          Console.WriteLine("Enter a grade or 'q' to quit");
          var input = Console.ReadLine();

          if (input == "q")
          {
            break;
          }

          try
          {
            var grade = double.Parse(input);
            book.AddGrade(grade);
          }
          catch (ArgumentException ex)
          {
            Console.WriteLine(ex.Message);
          }
          catch (FormatException ex)
          {
            Console.WriteLine(ex.Message);
          }
          finally
          {
            Console.WriteLine("**");
          }
        }

        var stats = book.GetStatistics();

        Console.WriteLine($"The highest grade is {stats.High:N1}");
        Console.WriteLine($"The lowest grade is {stats.Low:N1}");
        Console.WriteLine($"The average grade is {stats.Average:N1}");
        Console.WriteLine($"The letter is {stats.Letter}");
      }
    }
  }
  ```

### [Summary](https://app.pluralsight.com/course-player?clipId=4520b2c1-2b67-499a-8243-ffa14a8e2642)

## Building Types

### [Introduction](https://app.pluralsight.com/course-player?clipId=36877d9c-72dd-4c46-a883-8538f5de1c54)

### [Overloading Methods](https://app.pluralsight.com/course-player?clipId=b918a7cd-c3a6-41bb-8a68-13b12a18679a)

- Method overloading
  - Remember that the return type is _not_ part of the method signature.
- In `gradebook/src/GradeBook/Book.cs`:

  ```cs
  public void AddGrade(char letter)
  {
    switch (letter)
    {
      case 'A':
        AddGrade(90);
        break;

      case 'B':
        AddGrade(80);
        break;

      case 'C':
        AddGrade(70);
        break;

      default:
        AddGrade(0);
        break;
    }
  }

  public void AddGrade(double grade)
  {
    if (grade >= 0 && grade <= 100)
    {
      grades.Add(grade);
    }
    else
    {
      throw new ArgumentException($"Invalid {nameof(grade)}");
    }
  }
  ```

### [Defining Properties](https://app.pluralsight.com/course-player?clipId=e0ce1ce1-3ad7-4890-979f-7ca77c162497)

- Differences from fields:
  - Making a field public: Control is lost (e.g., opportunity to validate before changing a value).
- Field

  ```cs
  public string Name;
  ```

- Property

  ```cs
  public string Name
  {
    get
    {
      return name;
    }
    set
    {
      // implicit variable: `value`
      if (!String.IsNullOrEmpty(value))
      {
        name = value;
      }
    }
  }
  private string name;
  ```

  - Enables:

    ```cs
    // Uses set property method.
    book.Name = "some name";
    // Uses get property method.
    Console.WriteLine($"For the book named {book.Name}");
    ```

### [Defining Property Getters and Setters](https://app.pluralsight.com/course-player?clipId=7fe05210-7dfb-46d0-898f-690c8669aa78)

- Originally, C# required the private 'backing field' - the field backing the property.
- Now, an auto-property:

  ```cs
  public string Name
  {
    get; set;
  }
  ```

  - Transparent to the client code - no difference for field vs. property.
  - But can affect reflection and serialization.
  - Can apply different access modifiers to `get` vs. `set`.

    ```cs
    public string Name
    {
      get;
      private set;
    }
    ```

### [Defining readonly Members](https://app.pluralsight.com/course-player?clipId=36bbca95-96bb-4e5b-8efd-4bb324e68d85)

- Ways to declare a constant in C#:

  - `readonly` keyword.

    - Can only initialize or assign in a constructor.

    ```cs
    readonly string category = "Science";
    ```

### [Defining const Members](https://app.pluralsight.com/course-player?clipId=c482ae82-d6e4-40d0-98a6-44b629faa390)

- `const`

  ```cs
  const string category = "Science";
  ```

  - Stronger semantics than `readonly`.
  - Cannot write to even in a constructor.
  - Can declare local variables as `const`.
  - Can make public:

    ```cs
    public const string CATEGORY = "Science";
    ```

  - Note that `const` fields are treated as static members of the class.

    ```cs
    Console.WriteLine(Book.CATEGORY);
    ```

### I[ntroducing Events and Delegates](https://app.pluralsight.com/course-player?clipId=e5af514f-da5e-400e-9b4d-04b8937a03e8)

- Events have been around since the beginning of C# - but not used as often in today's frameworks (e.g., ASP.NET).
  - Though popular in forms and desktop programming.
  - Require 'delegates'.
- Events are also difficult to understand.

### [Defining a Delegate](https://app.pluralsight.com/course-player?clipId=44337a13-acca-456b-a25c-5045baa22c36)

- A delegate defines a new type, describing what a method will look like (return type, parameter types, parameter number).
- In `gradebook/test/GradeBook.Tests/TypeTests.cs`:

  ```cs
  using System;
  using Xunit;

  namespace GradeBook.Tests
  {
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
      [Fact]
      public void WriteLogDelegateCanPointToMethod()
      {
        WriteLogDelegate log;

        // Initialize WriteLogDelegate with ReturnMessage.
        // log = new WriteLogDelegate(ReturnMessage);
        // Shorthand:
        log = ReturnMessage;

        var result = log("Hello!");
        Assert.Equal("Hello!", result);
      }

      string ReturnMessage(string message)
      {
        return message;
      }
    }
  }
  ```

  - Could point WriteLogDelegate variable to any variable that returns a string and takes a string.

### [Using Multi-cast Delegates](https://app.pluralsight.com/course-player?clipId=251f9345-3c0b-4e85-9dc3-46cedb20c5ef)

- Delegates can invoke multiple methods (multi-cast delegates).

  - E.g., via `+=`

  ```cs
  int count = 0;
  [Fact]
  public void WriteLogDelegateCanPointToMethod()
  {
    WriteLogDelegate log = ReturnMessage;
    log += ReturnMessage;
    log += IncrementCount;

    var result = log("Hello!");
    Assert.Equal(3, count);
  }

  string IncrementCount(string message)
  {
    count++;
    return message.ToLower();
  }
  string ReturnMessage(string message)
  {
    count++;
    return message;
  }
  ```

### [Defining an Event](https://app.pluralsight.com/course-player?clipId=9c83e349-e0c6-412e-a766-d5785fea760f)

- Convention: Events typically have 2 parameters
  - `object sender` (base type)
  - `EventArgs args`
- In `gradebook/src/GradeBook/Book.cs`:

  ```cs
  using System;
  using System.Collections.Generic;

  namespace GradeBook
  {
    // Would normally place additional types in a separate file.
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class Book
    {
      // ...

      public void AddGrade(double grade)
      {
        if (grade >= 0 && grade <= 100)
        {
          grades.Add(grade);
          // Only invoke if there are listeners.
          if (GradeAdded != null)
          {
            GradeAdded(this, new EventArgs());
          }
        }
        else
        {
          throw new ArgumentException($"Invalid {nameof(grade)}");
        }
      }

      public event GradeAddedDelegate GradeAdded;

      // ...
    }
  }
  ```

### [Subscribing to an Event](https://app.pluralsight.com/course-player?clipId=4d04688d-abf0-4eae-94fe-de1f60b3a79d)

- Handling an event: Adding a method we want invoked when the class raises the event (invokes the delegate).
- Marking the field as an `event` prevents assigning `null` (for instance).
  - Can use `+=` or `-=`, but not `=`.
- In `gradebook/src/GradeBook/Program.cs`:

  ```cs
  using System;
  namespace GradeBook
  {
    class Program
    {
      static void Main(string[] args)
      {

        var book = new Book("Scott's Grade Book");
        book.GradeAdded += OnGradeAdded;
        book.GradeAdded += OnGradeAdded;
        // Can remove:
        book.GradeAdded -= OnGradeAdded;
        book.GradeAdded += OnGradeAdded;

        while (true)
        {
          Console.WriteLine("Enter a grade or 'q' to quit");
          var input = Console.ReadLine();

          if (input == "q")
          {
            break;
          }

          try
          {
            var grade = double.Parse(input);
            book.AddGrade(grade);
          }
          catch (ArgumentException ex)
          {
            Console.WriteLine(ex.Message);
          }
          catch (FormatException ex)
          {
            Console.WriteLine(ex.Message);
          }
          finally
          {
            Console.WriteLine("**");
          }
        }

        var stats = book.GetStatistics();

        Console.WriteLine(Book.CATEGORY);
        Console.WriteLine($"For the book named {book.Name}");
        Console.WriteLine($"The highest grade is {stats.High:N1}");
        Console.WriteLine($"The lowest grade is {stats.Low:N1}");
        Console.WriteLine($"The average grade is {stats.Average:N1}");
        Console.WriteLine($"The letter is {stats.Letter}");
      }

      static void OnGradeAdded(object sender, EventArgs e)
      {
        Console.WriteLine("A grade was added.");
      }
    }
  }
  ```

  ```txt
  ➜  gradebook git:(main) ✗ dotnet run --project src/GradeBook/GradeBook.csproj
  Enter a grade or 'q' to quit
  93
  A grade was added.
  A grade was added.
  **
  Enter a grade or 'q' to quit
  103
  Invalid grade
  **
  Enter a grade or 'q' to quit
  q
  Science
  For the book named Scott's Grade Book
  The highest grade is 93.0
  The lowest grade is 93.0
  The average grade is 93.0
  The letter is A
  ```

### [Summary](https://app.pluralsight.com/course-player?clipId=c0b6893a-b6f1-4070-91f5-3dbe00cdb1de)

## Object-oriented Programming with C#

### [Introduction](https://app.pluralsight.com/course-player?clipId=ed2f27d7-b95a-42d6-8530-8af424d25a90)

### [The Pillars of OOP](https://app.pluralsight.com/course-player?clipId=801404f6-f3ef-4b18-8d07-09e1a49f35ed)

- 3 pillars of OOP
  - Encapsulation
    - Hiding details.
    - Most important pillar.
  - Inheritance
    - Enables code reuse across similar classes
    - Often overrated for use in solving day-to-day problems.
  - Polymorphism
    - Objects of the same type that behave differently

### [Deriving from a Base Class](https://app.pluralsight.com/course-player?clipId=bb1119b1-add2-46fa-a8e7-7606bac7c2ae)

- A class contains members (representing the state and behavior of the class).
  - Base class members can be inherited by a derived class.
- Example use case: A number of objects require a `name`.
  - Rather than adding a `name` property to a large number of classes, create a `NamedObject`.
  - `Book` _is_ a `NamedObject`.
- In `gradebook\src\GradeBook\Book.cs`:

  ```cs

  using System;
  using System.Collections.Generic;

  namespace GradeBook
  {
      public delegate void GradeAddedDelegate(object sender, EventArgs args);

      // Best practice: Place classes in their own dedicated files.
      // Left here for convenience.
      public class NamedObject
      {
          public string Name
          {
              get; set;
          }
      }

      public class Book : NamedObject
      {
          public Book(string name)
          {
              grades = new List<double>();
              Name = name;
          }

          // ...

          // Remove `Name` property.
      }
  }
  ```

- Then, in `gradebook\src\GradeBook\Program.cs`, for instance, we could use `book.Name` without knowing whether it was inherited.
- Note that the `Book`'s constructor requires a `Name`; it is not currently required for `NamedObject`.

### [Chaining Constructors](https://app.pluralsight.com/course-player?clipId=f68834f1-f6fe-4fab-8e7c-e2d652bed6fb)

- One way to generate a constructor:

  - Place cursor on class &rarr; Ctrl + `.` &rarr; Generate Constructor.
    - Works in both VS and VS Code.

  ```cs
  public class NamedObject
  {
      public NamedObject(string name)
      {
          Name = name;
      }

      public string Name
      {
          get; set;
      }
  }
  ```

- Then `Book` presents an error:

  ```txt
  There is no argument given that corresponds to the required formal parameter 'name' of 'NamedObject.NamedObject(string)' [GradeBook]csharp(CS7036)
  ```

  - The base class requires a `name`; but we haven't specified how to construct the base class.
  - We can use `: base()` to call the base class's constructor.

    ```cs
    using System;
    using System.Collections.Generic;

    namespace GradeBook
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public class NamedObject
        {
            public NamedObject(string name)
            {
                Name = name;
            }

            public string Name
            {
                get; set;
            }
        }

        public class Book : NamedObject
        {
            public Book(string name) : base(name)
            {
                grades = new List<double>();
                Name = name;
            }

            // ...
        }
    }
    ```

### [Deriving from System.Object](https://app.pluralsight.com/course-player?clipId=99e63e4a-d97c-4821-8aa8-c07f6864cc24)

- Every class in C# has a base class: `Object` (`System.Object`).
  - View: Cursor -> F12 to view metadata.
  - Note static methods.
  - Keyword: `object` (maps to `System.Object`).

### [Setting up a Scenario](https://app.pluralsight.com/course-player?clipId=77e84a7b-024e-4339-a99f-f4b3f35ab795)

- Extract `EnterGrades` method in `Program.cs`:

  ```cs
  using System;
  namespace GradeBook
  {
      class Program
      {
          static void Main(string[] args)
          {

              var book = new Book("Scott's Grade Book");
              book.GradeAdded += OnGradeAdded;

              EnterGrades(book);

              var stats = book.GetStatistics();

              Console.WriteLine(Book.CATEGORY);
              Console.WriteLine($"For the book named {book.Name}");
              Console.WriteLine($"The highest grade is {stats.High:N1}");
              Console.WriteLine($"The lowest grade is {stats.Low:N1}");
              Console.WriteLine($"The average grade is {stats.Average:N1}");
              Console.WriteLine($"The letter is {stats.Letter}");
          }

          private static void EnterGrades(Book book)
          {
              while (true)
              {
                  Console.WriteLine("Enter a grade or 'q' to quit");
                  var input = Console.ReadLine();

                  if (input == "q")
                  {
                      break;
                  }

                  try
                  {
                      var grade = double.Parse(input);
                      book.AddGrade(grade);
                  }
                  catch (ArgumentException ex)
                  {
                      Console.WriteLine(ex.Message);
                  }
                  catch (FormatException ex)
                  {
                      Console.WriteLine(ex.Message);
                  }
                  finally
                  {
                      Console.WriteLine("**");
                  }
              }
          }

          static void OnGradeAdded(object sender, EventArgs e)
          {
              Console.WriteLine("A grade was added.");
          }
      }
  }
  ```

### [Defining an Abstract Class](https://app.pluralsight.com/course-player?clipId=c57a51c6-d2e8-4fa0-a316-7e3eb53b85bf)

- C# only allows single inheritance.
- Can only overwrite abstract or virtual methods.
- `gradebook\src\GradeBook\Book.cs`:

  ```cs
  using System;
  using System.Collections.Generic;

  namespace GradeBook
  {
      public delegate void GradeAddedDelegate(object sender, EventArgs args);

      public class NamedObject
      {
          public NamedObject(string name)
          {
              Name = name;
          }

          public string Name
          {
              get; set;
          }
      }

      public abstract class Book : NamedObject
      {
          protected Book(string name) : base(name)
          {
          }

          public abstract void AddGrade(double grade);
      }

      public class InMemoryBook : Book
      {
          public InMemoryBook(string name) : base(name)
          {
              grades = new List<double>();
              Name = name;
          }

          public void AddGrade(char letter)
          {
              switch (letter)
              {
                  case 'A':
                      AddGrade(90);
                      break;

                  case 'B':
                      AddGrade(80);
                      break;

                  case 'C':
                      AddGrade(70);
                      break;

                  default:
                      AddGrade(0);
                      break;
              }
          }

          public override void AddGrade(double grade)
          {
              if (grade >= 0 && grade <= 100)
              {
                  grades.Add(grade);
                  // Only invoke if there are listeners.
                  if (GradeAdded != null)
                  {
                      GradeAdded(this, new EventArgs());
                  }
              }
              else
              {
                  throw new ArgumentException($"Invalid {nameof(grade)}");
              }
          }

          public event GradeAddedDelegate GradeAdded;

          public Statistics GetStatistics()
          {
              var result = new Statistics();
              result.Average = 0.0;
              result.High = double.MinValue;
              result.Low = double.MaxValue;

              foreach (double grade in grades)
              {
                  result.Low = Math.Min(grade, result.Low);
                  result.High = Math.Max(grade, result.High);
                  result.Average += grade;
              }

              result.Average /= grades.Count;

              switch (result.Average)
              {
                  case var d when d >= 90.0:
                      result.Letter = 'A';
                      break;
                  case var d when d >= 80.0:
                      result.Letter = 'B';
                      break;
                  case var d when d >= 70.0:
                      result.Letter = 'C';
                      break;
                  case var d when d >= 60.0:
                      result.Letter = 'D';
                      break;
                  default:
                      result.Letter = 'F';
                      break;
              }

              return result;
          }

          private List<double> grades;

          public const string CATEGORY = "Science";
      }
  }
  ```

- `gradebook\src\GradeBook\Program.cs`:

  ```cs
  using System;
  namespace GradeBook
  {
      class Program
      {
          static void Main(string[] args)
          {

              var book = new InMemoryBook("Scott's Grade Book");
              book.GradeAdded += OnGradeAdded;

              EnterGrades(book);

              var stats = book.GetStatistics();

              Console.WriteLine(InMemoryBook.CATEGORY);
              Console.WriteLine($"For the book named {book.Name}");
              Console.WriteLine($"The highest grade is {stats.High:N1}");
              Console.WriteLine($"The lowest grade is {stats.Low:N1}");
              Console.WriteLine($"The average grade is {stats.Average:N1}");
              Console.WriteLine($"The letter is {stats.Letter}");
          }

          private static void EnterGrades(Book book)
          {
              while (true)
              {
                  Console.WriteLine("Enter a grade or 'q' to quit");
                  var input = Console.ReadLine();

                  if (input == "q")
                  {
                      break;
                  }

                  try
                  {
                      var grade = double.Parse(input);
                      book.AddGrade(grade);
                  }
                  catch (ArgumentException ex)
                  {
                      Console.WriteLine(ex.Message);
                  }
                  catch (FormatException ex)
                  {
                      Console.WriteLine(ex.Message);
                  }
                  finally
                  {
                      Console.WriteLine("**");
                  }
              }
          }

          static void OnGradeAdded(object sender, EventArgs e)
          {
              Console.WriteLine("A grade was added.");
          }
      }
  }
  ```

### [Defining an Interface](https://app.pluralsight.com/course-player?clipId=5cdfef6b-e963-4246-8396-489a5dffeb81)

- Another approach to encapsulation & polymorphism: Interfaces.
- An interface definition is 'pure', containing no implementation details (only defining members).
- C# convention: Interface type begins with `I`.
- In an abstract class:
  - An abstract method is implicitly virtual. It must be overridden.
  - A `virtual` method _may_ be overridden.
- `Book.cs`:

  ```cs
  using System;
  using System.Collections.Generic;

  namespace GradeBook
  {
      public delegate void GradeAddedDelegate(object sender, EventArgs args);

      public class NamedObject
      {
          public NamedObject(string name)
          {
              Name = name;
          }

          public string Name
          {
              get; set;
          }
      }

      public interface IBook
      {
          void AddGrade(double grade);
          Statistics GetStatistics();
          string Name { get; }
          event GradeAddedDelegate GradeAdded;
      }

      public abstract class Book : NamedObject, IBook
      {
          protected Book(string name) : base(name)
          {
          }

          public virtual event GradeAddedDelegate GradeAdded;

          public abstract void AddGrade(double grade);

          public virtual Statistics GetStatistics()
          {
              throw new NotImplementedException();
          }
      }

      public class InMemoryBook : Book
      {
          public InMemoryBook(string name) : base(name)
          {
              grades = new List<double>();
              Name = name;
          }

          public void AddGrade(char letter)
          {
              switch (letter)
              {
                  case 'A':
                      AddGrade(90);
                      break;

                  case 'B':
                      AddGrade(80);
                      break;

                  case 'C':
                      AddGrade(70);
                      break;

                  default:
                      AddGrade(0);
                      break;
              }
          }

          public override void AddGrade(double grade)
          {
              if (grade >= 0 && grade <= 100)
              {
                  grades.Add(grade);
                  // Only invoke if there are listeners.
                  if (GradeAdded != null)
                  {
                      GradeAdded(this, new EventArgs());
                  }
              }
              else
              {
                  throw new ArgumentException($"Invalid {nameof(grade)}");
              }
          }

          public override event GradeAddedDelegate GradeAdded;

          public override Statistics GetStatistics()
          {
              var result = new Statistics();
              result.Average = 0.0;
              result.High = double.MinValue;
              result.Low = double.MaxValue;

              foreach (double grade in grades)
              {
                  result.Low = Math.Min(grade, result.Low);
                  result.High = Math.Max(grade, result.High);
                  result.Average += grade;
              }

              result.Average /= grades.Count;

              switch (result.Average)
              {
                  case var d when d >= 90.0:
                      result.Letter = 'A';
                      break;
                  case var d when d >= 80.0:
                      result.Letter = 'B';
                      break;
                  case var d when d >= 70.0:
                      result.Letter = 'C';
                      break;
                  case var d when d >= 60.0:
                      result.Letter = 'D';
                      break;
                  default:
                      result.Letter = 'F';
                      break;
              }

              return result;
          }

          private List<double> grades;

          public const string CATEGORY = "Science";
      }
  }
  ```

- `Program.cs`:

  ```cs
  using System;
  namespace GradeBook
  {
      class Program
      {
          static void Main(string[] args)
          {

              var book = new InMemoryBook("Scott's Grade Book");
              book.GradeAdded += OnGradeAdded;

              EnterGrades(book);

              var stats = book.GetStatistics();

              Console.WriteLine(InMemoryBook.CATEGORY);
              Console.WriteLine($"For the book named {book.Name}");
              Console.WriteLine($"The highest grade is {stats.High:N1}");
              Console.WriteLine($"The lowest grade is {stats.Low:N1}");
              Console.WriteLine($"The average grade is {stats.Average:N1}");
              Console.WriteLine($"The letter is {stats.Letter}");
          }

          private static void EnterGrades(IBook book)
          {
              while (true)
              {
                  Console.WriteLine("Enter a grade or 'q' to quit");
                  var input = Console.ReadLine();

                  if (input == "q")
                  {
                      break;
                  }

                  try
                  {
                      var grade = double.Parse(input);
                      book.AddGrade(grade);
                  }
                  catch (ArgumentException ex)
                  {
                      Console.WriteLine(ex.Message);
                  }
                  catch (FormatException ex)
                  {
                      Console.WriteLine(ex.Message);
                  }
                  finally
                  {
                      Console.WriteLine("**");
                  }
              }
          }

          static void OnGradeAdded(object sender, EventArgs e)
          {
              Console.WriteLine("A grade was added.");
          }
      }
  }
  ```

### [Writing Grades to a File](https://app.pluralsight.com/course-player?clipId=85223d24-bf03-4d67-89c9-a42079be4ce2)

- `Book.cs`:

  ```cs
  using System;
  using System.Collections.Generic;
  using System.IO;

  namespace GradeBook
  {
      public delegate void GradeAddedDelegate(object sender, EventArgs args);

      public class NamedObject
      {
          public NamedObject(string name)
          {
              Name = name;
          }

          public string Name
          {
              get; set;
          }
      }

      public interface IBook
      {
          void AddGrade(double grade);
          Statistics GetStatistics();
          string Name { get; }
          event GradeAddedDelegate GradeAdded;
      }

      public abstract class Book : NamedObject, IBook
      {
          protected Book(string name) : base(name)
          {
          }

          public abstract event GradeAddedDelegate GradeAdded;
          public abstract void AddGrade(double grade);
          public abstract Statistics GetStatistics();
      }

      public class DiskBook : Book
      {
          public DiskBook(string name) : base(name)
          {
          }

          public override event GradeAddedDelegate GradeAdded;

          public override void AddGrade(double grade)
          {
              var writer = File.AppendText($"{Name}.txt");
              writer.WriteLine(grade);
          }

          public override Statistics GetStatistics()
          {
              throw new System.NotImplementedException();
          }
      }

      public class InMemoryBook : Book
      {
          public InMemoryBook(string name) : base(name)
          {
              grades = new List<double>();
              Name = name;
          }

          public void AddGrade(char letter)
          {
              switch (letter)
              {
                  case 'A':
                      AddGrade(90);
                      break;

                  case 'B':
                      AddGrade(80);
                      break;

                  case 'C':
                      AddGrade(70);
                      break;

                  default:
                      AddGrade(0);
                      break;
              }
          }

          public override void AddGrade(double grade)
          {
              if (grade >= 0 && grade <= 100)
              {
                  grades.Add(grade);
                  // Only invoke if there are listeners.
                  if (GradeAdded != null)
                  {
                      GradeAdded(this, new EventArgs());
                  }
              }
              else
              {
                  throw new ArgumentException($"Invalid {nameof(grade)}");
              }
          }

          public override event GradeAddedDelegate GradeAdded;

          public override Statistics GetStatistics()
          {
              var result = new Statistics();
              result.Average = 0.0;
              result.High = double.MinValue;
              result.Low = double.MaxValue;

              foreach (double grade in grades)
              {
                  result.Low = Math.Min(grade, result.Low);
                  result.High = Math.Max(grade, result.High);
                  result.Average += grade;
              }

              result.Average /= grades.Count;

              switch (result.Average)
              {
                  case var d when d >= 90.0:
                      result.Letter = 'A';
                      break;
                  case var d when d >= 80.0:
                      result.Letter = 'B';
                      break;
                  case var d when d >= 70.0:
                      result.Letter = 'C';
                      break;
                  case var d when d >= 60.0:
                      result.Letter = 'D';
                      break;
                  default:
                      result.Letter = 'F';
                      break;
              }

              return result;
          }

          private List<double> grades;

          public const string CATEGORY = "Science";
      }
  }
  ```

- `Program.cs`:

  ```cs
  using System;
  namespace GradeBook
  {
      class Program
      {
          static void Main(string[] args)
          {

              IBook book = new DiskBook("Scott's Grade Book");
              book.GradeAdded += OnGradeAdded;

              EnterGrades(book);

              var stats = book.GetStatistics();

              Console.WriteLine($"For the book named {book.Name}");
              Console.WriteLine($"The highest grade is {stats.High:N1}");
              Console.WriteLine($"The lowest grade is {stats.Low:N1}");
              Console.WriteLine($"The average grade is {stats.Average:N1}");
              Console.WriteLine($"The letter is {stats.Letter}");
          }

          private static void EnterGrades(IBook book)
          {
              while (true)
              {
                  Console.WriteLine("Enter a grade or 'q' to quit");
                  var input = Console.ReadLine();

                  if (input == "q")
                  {
                      break;
                  }

                  try
                  {
                      var grade = double.Parse(input);
                      book.AddGrade(grade);
                  }
                  catch (ArgumentException ex)
                  {
                      Console.WriteLine(ex.Message);
                  }
                  catch (FormatException ex)
                  {
                      Console.WriteLine(ex.Message);
                  }
                  finally
                  {
                      Console.WriteLine("**");
                  }
              }
          }

          static void OnGradeAdded(object sender, EventArgs e)
          {
              Console.WriteLine("A grade was added.");
          }
      }
  }
  ```

- Run:

```ps1
dotnet run --project src\GradeBook
```

- We can enter a single grade, but attempting to write a second grade produces: `Unhandled exception. System.IO.IOException: The process cannot access the file 'C:\Users\eric.helander\repo\personal\microsoft-stack\csharp\pluralsight\csharp-fundamentals\gradebook\Scott's Grade Book.txt' because it is being used by another process.`.

### [Using IDisposable](https://app.pluralsight.com/course-player?clipId=62889348-4e3d-41a7-b3d5-79be3650c6df)

- Currently, we open a file for writing - but then it's locked for writing and cannot be accessed a second time.
- 2 solutions:
  - Keep the file open (make the `writer` a member so we can access it again).
    - But a bigger issue: Want to close a file when you open it. We could use `.Close()` - but if an exception were thrown while writing, it would remain open.
  - Use `using`.
- Go to metadata definition of `.AppendText()` (`F12`). Then `StreamWriter`. Then `TextWriter`.

  - `TextWriter` implements `IDisposable` &rarr; `Dispose()`.
    - ![](2021-05-11-13-16-49.png)
    - Tells the OS to clean up these object as quickly as possible. Many classes implement this interface, indicating they have something to clean up (free/release).
    - So we could use `writer.Dispose();`.
      - Often `Dispose()` does the same thing as `Close()`.
    - To make sure it's always called: `using`.
      - The C# compiler essentially generates a try-finally.

- `Book.cs`

  ```cs

  using System;
  using System.Collections.Generic;
  using System.IO;

  namespace GradeBook
  {
      public delegate void GradeAddedDelegate(object sender, EventArgs args);

      public class NamedObject
      {
          public NamedObject(string name)
          {
              Name = name;
          }

          public string Name
          {
              get; set;
          }
      }

      public interface IBook
      {
          void AddGrade(double grade);
          Statistics GetStatistics();
          string Name { get; }
          event GradeAddedDelegate GradeAdded;
      }

      public abstract class Book : NamedObject, IBook
      {
          protected Book(string name) : base(name)
          {
          }

          public abstract event GradeAddedDelegate GradeAdded;
          public abstract void AddGrade(double grade);
          public abstract Statistics GetStatistics();
      }

      public class DiskBook : Book
      {
          public DiskBook(string name) : base(name)
          {
          }

          public override event GradeAddedDelegate GradeAdded;

          public override void AddGrade(double grade)
          {
              using (var writer = File.AppendText($"{Name}.txt"))
              {
                  writer.WriteLine(grade);
                  if (GradeAdded != null)
                  {
                      GradeAdded(this, new EventArgs());
                  }
              }
          }

          public override Statistics GetStatistics()
          {
              throw new System.NotImplementedException();
          }
      }

      public class InMemoryBook : Book
      {
          public InMemoryBook(string name) : base(name)
          {
              grades = new List<double>();
              Name = name;
          }

          public void AddGrade(char letter)
          {
              switch (letter)
              {
                  case 'A':
                      AddGrade(90);
                      break;

                  case 'B':
                      AddGrade(80);
                      break;

                  case 'C':
                      AddGrade(70);
                      break;

                  default:
                      AddGrade(0);
                      break;
              }
          }

          public override void AddGrade(double grade)
          {
              if (grade >= 0 && grade <= 100)
              {
                  grades.Add(grade);
                  // Only invoke if there are listeners.
                  if (GradeAdded != null)
                  {
                      GradeAdded(this, new EventArgs());
                  }
              }
              else
              {
                  throw new ArgumentException($"Invalid {nameof(grade)}");
              }
          }

          public override event GradeAddedDelegate GradeAdded;

          public override Statistics GetStatistics()
          {
              var result = new Statistics();
              result.Average = 0.0;
              result.High = double.MinValue;
              result.Low = double.MaxValue;

              foreach (double grade in grades)
              {
                  result.Low = Math.Min(grade, result.Low);
                  result.High = Math.Max(grade, result.High);
                  result.Average += grade;
              }

              result.Average /= grades.Count;

              switch (result.Average)
              {
                  case var d when d >= 90.0:
                      result.Letter = 'A';
                      break;
                  case var d when d >= 80.0:
                      result.Letter = 'B';
                      break;
                  case var d when d >= 70.0:
                      result.Letter = 'C';
                      break;
                  case var d when d >= 60.0:
                      result.Letter = 'D';
                      break;
                  default:
                      result.Letter = 'F';
                      break;
              }

              return result;
          }

          private List<double> grades;

          public const string CATEGORY = "Science";
      }
  }
  ```

### [A Statistical Challenge](https://app.pluralsight.com/course-player?clipId=39d08795-7ae5-42fa-be08-c9aab7868cdd)

- Remember: Separate deciding from doing. Right now, `GetStatistics()` is deciding and doing, and cannot be accessed from other classes.

### [Refactoring Statistics](https://app.pluralsight.com/course-player?clipId=211d9a42-ab66-451e-8199-df52ff41ad39)

- `Statistics.cs`:

  ```cs
  using System;

  namespace GradeBook
  {
      public class Statistics
      {
          public double Average
          {
              get
              {
                  return Sum / Count;
              }
          }
          public double High;
          public double Low;
          public double Sum;
          public int Count;
          public char Letter
          {
              get
              {
                  switch (Average)
                  {
                      case var d when d >= 90.0:
                          return 'A';
                      case var d when d >= 80.0:
                          return 'B';
                      case var d when d >= 70.0:
                          return 'C';
                      case var d when d >= 60.0:
                          return 'D';
                      default:
                          return 'F';
                  }
              }
          }

          public void Add(double number)
          {
              Sum += number;
              Count += 1;

              Low = Math.Min(number, Low);
              High = Math.Max(number, High);
          }

          public Statistics()
          {
              Count = 0;
              Sum = 0.0;
              High = double.MinValue;
              Low = double.MaxValue;
          }
      }
  }
  ```

- `Book.cs`:

  ```cs
  using System;
  using System.Collections.Generic;
  using System.IO;

  namespace GradeBook
  {
      public delegate void GradeAddedDelegate(object sender, EventArgs args);

      public class NamedObject
      {
          public NamedObject(string name)
          {
              Name = name;
          }

          public string Name
          {
              get; set;
          }
      }

      public interface IBook
      {
          void AddGrade(double grade);
          Statistics GetStatistics();
          string Name { get; }
          event GradeAddedDelegate GradeAdded;
      }

      public abstract class Book : NamedObject, IBook
      {
          protected Book(string name) : base(name)
          {
          }

          public abstract event GradeAddedDelegate GradeAdded;
          public abstract void AddGrade(double grade);
          public abstract Statistics GetStatistics();
      }

      public class DiskBook : Book
      {
          public DiskBook(string name) : base(name)
          {
          }

          public override event GradeAddedDelegate GradeAdded;

          public override void AddGrade(double grade)
          {
              // Open a file; append to the end.
              using (var writer = File.AppendText($"{Name}.txt"))
              {
                  writer.WriteLine(grade);
                  if (GradeAdded != null)
                  {
                      GradeAdded(this, new EventArgs());
                  }
              }
          }

          public override Statistics GetStatistics()
          {
              var result = new Statistics();

              // Open a file for reading.
              using (var reader = File.OpenText($"{Name}.txt"))
              {
                  var line = reader.ReadLine();
                  while (line != null)
                  {
                      var number = double.Parse(line);
                      result.Add(number);
                      line = reader.ReadLine();
                  }
              }

              return result;
          }
      }

      public class InMemoryBook : Book
      {
          public InMemoryBook(string name) : base(name)
          {
              grades = new List<double>();
              Name = name;
          }

          public void AddGrade(char letter)
          {
              switch (letter)
              {
                  case 'A':
                      AddGrade(90);
                      break;

                  case 'B':
                      AddGrade(80);
                      break;

                  case 'C':
                      AddGrade(70);
                      break;

                  default:
                      AddGrade(0);
                      break;
              }
          }

          public override void AddGrade(double grade)
          {
              if (grade >= 0 && grade <= 100)
              {
                  grades.Add(grade);
                  // Only invoke if there are listeners.
                  if (GradeAdded != null)
                  {
                      GradeAdded(this, new EventArgs());
                  }
              }
              else
              {
                  throw new ArgumentException($"Invalid {nameof(grade)}");
              }
          }

          public override event GradeAddedDelegate GradeAdded;

          public override Statistics GetStatistics()
          {
              var result = new Statistics();

              foreach (double grade in grades)
              {
                  result.Add(grade);
              }

              return result;
          }

          private List<double> grades;

          public const string CATEGORY = "Science";
      }
  }
  ```

- ![](2021-05-11-13-38-54.png)

### [Summary](https://app.pluralsight.com/course-player?clipId=85155d6c-e8c9-4c6c-aba9-078014fb9a0b)

## Catching up with the Latest in C#

### [Introduction](https://app.pluralsight.com/course-player?clipId=de17f22f-d2bd-468a-9eff-81f27094f7eb)

### [Working with Non-nullable Reference Types](https://app.pluralsight.com/course-player?clipId=9cd83fb8-c353-4756-ba6c-32144da115d2)

- We received a NullReferenceException at runtime.
- A feature was added to the C# compiler to aggressively search the program to avoid NullReferenceExceptions at runtime.
- After commenting out the `grades` initialization in `Book.cs`...

  ```cs
  public InMemoryBook(string name) : base(name)
  {
      // grades = new List<double>();
      Name = name;
  }
  ```

- ...and doing a `dotnet build`, we now receive a warning:
  - ![](2021-05-11-14-12-12.png)
- In .NET 8, can create types that are non-nullable by default.
  - Before enabled by default, can specify whether reference types should be non-nullable by default:
    - ![](2021-05-11-14-22-25.png)
- To allow assigning null, use `Book? book`.

### [Summary](https://app.pluralsight.com/course-player?clipId=ac7795be-9508-4fda-bdd8-03bdb5f0e9cd)

## Going Further with C#

### [Introduction](https://app.pluralsight.com/course-player?clipId=ed16df3a-a550-4a32-9f52-affdbcb30904)

### [Generics](https://app.pluralsight.com/course-player?clipId=df507506-72f0-4099-b035-1b667dafff07)

- ![](2021-05-11-14-31-16.png)

### [Async C#](https://app.pluralsight.com/course-player?clipId=16f3ffc4-267e-4e59-999b-9dd8cecc94e7)

- ![](2021-05-11-14-31-53.png)

### [LINQ](https://app.pluralsight.com/course-player?clipId=afce4f4a-9956-45a7-96c4-5c37d5b85459)

- ![](2021-05-11-14-32-13.png)

### [Effective C#](https://app.pluralsight.com/course-player?clipId=12291494-5b2e-406b-b9ee-0256328d9aa7)

- ![](2021-05-11-14-32-37.png)
