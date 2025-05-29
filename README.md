﻿# OldPhonePadApp

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

   git clone https://github.com/LeinerCorderoV/OldPhonePadApp.git

   cd OldPhonePadApp


2. **Restore**  packages and build the solution:

   dotnet restore
   dotnet build 


## Usage

1. **Run** the application:

   dotnet run --project OldPhonePadApp/OldPhonePadApp.csproj


**You will see instructions like:** 

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

```plaintext
OldPhonePadApp/
├── OldPhonePadApp/           # Main console application
│   └── Program.cs            # Contains Main loop and OldPhonePad logic
└── OldPhonePadApp.Tests/     # xUnit test project
    └── ProgramTests.cs       # Theory tests for OldPhonePad

```

---

## Contributing

We welcome contributions to OldPhonePadApp! Please follow these steps:

1. **Fork** the repository.

2. **Clone** your fork and navigate into it:

   git clone https://github.com/LeinerCorderoV/OldPhonePadApp.git
   cd OldPhonePadApp

3. **Create** a new branch for your feature or fix:

   git checkout -b feature/your-feature-name

4. **Implement** your changes and update tests in `OldPhonePadApp.Tests`.

5. **Stage & commit** with a clear message:

    git add . git commit -m "feat: brief description of your change"

6. **Push** your branch:

    git push origin feature/your-feature-name

7. **Open** a Pull Request against `main`, describing:
   - The problem you’re solving  
   - Related issue numbers  
   - Screenshots or logs (if applicable)

---

## License

This project is licensed under the MIT License.  
See the `LICENSE` file for details.  
© 2025 Leiner Cordero V.