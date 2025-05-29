# OldPhonePadApp

**OldPhonePadApp** is a beginner-friendly .NET console application that simulates the old mobile-phone keypad.  
Type sequences of digits (2–9) to enter letters, `0` for space, `*` to delete the last character, and end your message with `#`. The app converts your input into readable text.

---

## Table of Contents

- [Description](#description)  
- [Prerequisites](#prerequisites)  
- [Installation](#installation)  
- [Usage](#usage)  
- [Running Tests](#running-tests)  
- [Project Structure](#project-structure)  
- [Contributing](#contributing)  
- [License](#license)  

---

## Description

OldPhonePadApp reads your key-press sequence and applies the following mapping:

- `2` → ABC  
- `3` → DEF  
- `4` → GHI  
- `5` → JKL  
- `6` → MNO  
- `7` → PQRS  
- `8` → TUV  
- `9` → WXYZ  
- `0` → space  
- `*` → backspace (delete last character)  
- `#` → end of sequence  

Consecutive presses are grouped (e.g., `222` → `C`), and the final string is displayed. Invalid runs produce a `?`.

---

## Prerequisites

- **.NET SDK 6.0** or later  
- A code editor or IDE (Visual Studio, VS Code, Rider, etc.)

---

## Installation

1. **Clone** this repository:
   ```bash
   git clone https://github.com/LeinerCorderoV/OldPhonePadApp.git
   cd OldPhonePadApp

2.Restore packages and build the solution:

dotnet restore
dotnet build 

## Usage

1. **Run** the application:

dotnet run --project OldPhonePadApp/OldPhonePadApp.csproj

You will see instructions like:

Keys: 2=ABC 3=DEF 4=GHI 5=JKL 6=MNO 7=PQRS 8=TUV 9=WXYZ 0=space  
Use #: end, *: back, space: pause, q: quit

1.Type your sequence (e.g., 23*3#).
2.Press Enter to see the converted text.
3.Repeat or type q + Enter to quit.

Input> 234#
Output> ADG

## Running Tests

This project includes xUnit tests to verify that OldPhonePad works correctly in all main scenarios.

1.Navigate to the test project:
cd OldPhonePadApp.Tests

2.Run all tests:
dotnet test

You should see 12 passing tests, covering cases such as 2#, 55555#, *2#, #, and more.

## Project Structure

OldPhonePadApp/
├── OldPhonePadApp/           # Main console application
│   └── Program.cs            # Contains Main loop and OldPhonePad method
└── OldPhonePadApp.Tests/     # xUnit test project
    └── ProgramTests.cs       # Theory tests for OldPhonePad


---

## Contributing

We welcome contributions to OldPhonePadApp! Please follow these steps:

1. **Fork** the repository.  
2. **Clone** your fork and navigate into it:
   ```bash
   1. git clone https://github.com/LeinerCorderoV/OldPhonePadApp.git
   2. cd OldPhonePadApp

3. Create a new branch for your feature or fix:
   ```bash
   git checkout -b feature/your-feature-name
   ```
4.Implement your changes, following the existing coding style and conventions.

5.Add or update tests in OldPhonePadApp.Tests to cover your changes.

6.Commit your work with a clear message:

git commit -m "Add: brief description of your feature or fix"

7.Push your branch to your fork:

git push origin feature/your-feature-name

8. Open a Pull Request against the main branch of this repository:

Describe the problem you’re solving.
Reference any related issues.
Include screenshots or logs if applicable.

Before submitting your PR, please ensure:

All tests pass (dotnet test).
New code is properly documented.
No unrelated changes are included.

## License

This project is licensed under the MIT License.
See the LICENSE file for full details.
© 2025 Leiner Cordero V.