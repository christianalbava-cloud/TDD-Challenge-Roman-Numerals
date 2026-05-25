# Roman Number Converter

A small .NET library that converts integers to Roman numerals 

This project was developed using Test-Driven Development (TDD), following the red-green-refactor cycle with incremental commits and high test coverage.

## Features

- Integer to Roman numeral conversion
- Validation for zero and negative numbers
- Using FluentAssertions
- Unit tests with xUnit
- Code coverage support
- TDD workflow implementation

## Tech Stack

- .NET 9
- xUnit
- FluentAssertions
- Coverlet.collector
- ReportGenerator
---

## Roman Numeral Edge cases
```
| Roman | Value |
|---|---|
| IV | 4 |
| IX | 9 |
| XL | 40 |
| XC | 90 |
| CD | 400 |
| CM | 900 |
```

## Validation Rules

The converter validates:

- Validate zero and negative numbers
- Cover with exception the zero and negative numbers

## Restore Packages

```bash
dotnet restore
```
## Build
```bash
dotnet build
```
## Run Tests
```bash
dotnet test
```
## Generate Code Coverage
```bash
dotnet test --collect:"XPlat Code Coverage"
```
## HTML Coverage Report

Install ReportGenerator:

```bash
dotnet tool install -g dotnet-reportgenerator-globaltool
```
To execute report generator
```bash
reportgenerator -reports:"**/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```
## Open Coverage Report

Open:
coveragereport/RomanNumbers.Core_RomanNumberConverter.html

## TDD Process

This project follows the TDD cycle:

1. Write a failing test (RED)
2. Implement the minimum code to pass (GREEN)
3. Refactor safely while tests remain green

Each feature was developed incrementally using small commits.

## Choose TDD over other

- Choose a domain with clear business rules
- Start small and simple
- Focus on behavior, not implementation
- Each rule should become a test
- Prefer domains with edge cases
- Use meaningful business names
- Good TDD domains grow incrementally
- The domain should be easy to test
