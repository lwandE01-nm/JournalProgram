# Eternal Quest

## Overview

Eternal Quest is a goal-tracking program written in C# that helps users create, manage, and accomplish goals while earning points. The program demonstrates the principles of object-oriented programming, including inheritance, abstraction, encapsulation, and polymorphism.

## Features

- Create different types of goals:
  - Simple Goals
  - Eternal Goals
  - Checklist Goals
- Record progress on goals
- Earn points for completing goals
- Display current score
- Save goals and score to a file
- Load goals and score from a file
- Menu-driven user interface

## Classes

### BaseClass
The abstract base class that contains common properties and methods shared by all goal types.

### SimpleGoal
A goal that can be completed once.

### EternalGoal
A goal that can be completed repeatedly and never becomes fully complete.

### ChecklistGoal
A goal that must be completed a specified number of times before it is considered complete and awards a bonus.

### GoalManager
Handles menu options, goal management, score tracking, saving, and loading.

### Saving
Provides functionality for storing and retrieving goal data from files.

## Concepts Demonstrated

- Abstraction
- Encapsulation
- Inheritance
- Polymorphism
- File Input/Output
- Collections (Lists)

## How to Run

1. Open the project in Visual Studio Code or Visual Studio.
2. Navigate to the project directory.
3. Build the project:

```bash
dotnet build
```

4. Run the project:

```bash
dotnet run
```

## Author

Nothando Mabaso

## Course

CSE 210 Programming with Classes
Brigham Young University–Idaho
