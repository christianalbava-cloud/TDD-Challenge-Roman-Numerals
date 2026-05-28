# Roman Number Converter

A small .NET library that converts integers to Roman numerals.

This project was developed using Test-Driven Development (TDD), following the red-green-refactor cycle with incremental commits and high test coverage.

---

## Features

* Integer to Roman numeral conversion
* Validation for zero and negative numbers
* Unit tests with xUnit
* FluentAssertions integration
* Code coverage support
* Incremental TDD workflow implementation

---

## Tech Stack

* .NET 9
* xUnit
* FluentAssertions
* Coverlet.collector
* ReportGenerator

---

## Project Structure

```text
RomanNumbers/
│
├── src/
│   └── RomanNumbers.Core/
│
├── tests/
│   └── RomanNumbers.Tests/
│
├── README.md
└── RomanNumbers.sln
```

---

## Roman Numeral Rules

| Symbol | Value |
| ------ | ----- |
| I      | 1     |
| V      | 5     |
| X      | 10    |
| L      | 50    |
| C      | 100   |
| D      | 500   |
| M      | 1000  |

### Edge Cases

| Roman | Value |
| ----- | ----- |
| IV    | 4     |
| IX    | 9     |
| XL    | 40    |
| XC    | 90    |
| CD    | 400   |
| CM    | 900   |

---

## Validation Rules

The converter currently validates:

* Zero numbers
* Negative numbers

Invalid values throw an `ArgumentOutOfRangeException`.

---

## Restore Packages

```bash
dotnet restore
```

---

## Build

```bash
dotnet build
```

---

## Run Tests

```bash
dotnet test
```

---

## Generate Code Coverage

```bash
dotnet test --collect:"XPlat Code Coverage"
```

---

## Generate HTML Coverage Report

Install ReportGenerator:

```bash
dotnet tool install -g dotnet-reportgenerator-globaltool
```

Generate the report:

```bash
reportgenerator -reports:"**/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```

---

## Open Coverage Report

Open:

```text
coveragereport/RomanNumbers.Core_RomanNumberConverter.html
```

---

## Example Usage

```csharp
var converter = new RomanNumberConverter();

converter.ToRoman(4);
// IV
```

---

## TDD Process

This project follows the TDD cycle:

1. Write a failing test (RED)
2. Implement the minimum code to pass (GREEN)
3. Refactor safely while tests remain green

Each feature was implemented incrementally using small commits following the red-green-refactor workflow.

---

## Coverage

This project targets high line coverage using Coverlet and ReportGenerator.
