# Employee Age Analyzer (C#)

A small university programming assignment that counts the number of **distinct employee ages** from employee records. Salaries are read as part of the input but do not affect the result.

## Tech stack
- C#
- .NET 8 console application
- Arrays and nested loops

## Run
Install the .NET 8 SDK, then from this repository's directory run:

```bash
dotnet run --project BigCodingProj.csproj
```

## Input format
The first line contains the number of employees (`1 <= n <= 100`). Each of the next `n` lines contains an employee's age and salary, separated by whitespace.

Example input:
```text
5
24 180000
31 250000
24 210000
45 320000
31 190000
```

Expected output:
```text
3
```

## Algorithm
For each employee, compare their age with all earlier employees' ages. Count it only if it has not appeared before. Time complexity: **O(n²)**; extra space: **O(n)** for the input arrays.

## Notes
- This is a learning project rather than a production application.
- The original solution assumes valid input and does not yet implement defensive input validation.

## Context
Created for a university programming assignment. The original source and project files are preserved.