# CalculatorApp Documentation

## Introduction
The CalculatorApp is a simple command-line calculator application written in C#. It allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division. This documentation provides an overview of the application's features, how to use it, and its underlying code structure.

## Features
The CalculatorApp offers the following features:

1. Addition (+): Add two numbers.
2. Subtraction (-): Subtract one number from another.
3. Multiplication (*): Multiply two numbers.
4. Division (/): Divide one number by another.
5. Exit: Quit the calculator application.

## Usage
To use the CalculatorApp, follow these steps:

1. Launch the application.

2. The main menu will display the available operations and prompt you to enter your choice.

3. Enter a valid choice by typing the corresponding number (1, 2, 3, 4) for the desired operation, or type 5 to exit the calculator.

4. If you choose an arithmetic operation (1, 2, 3, 4), you will be prompted to enter two numbers for the calculation.

5. After entering the numbers, the calculator will display the result of the operation.

6. You can continue to perform calculations or choose option 5 to exit the calculator.

7. The application handles invalid inputs and division by zero scenarios.

## Code Structure
The CalculatorApp is built using C# and consists of the following components:

- `Main()` method: The entry point of the application, responsible for displaying the menu, accepting user input, and performing calculations.

- `GetOperationSymbol(string choice)`: A helper method that returns the symbol corresponding to the chosen operation for display in the result.

- User Input Handling: The application uses `Console.ReadLine()` to capture user input and `double.TryParse()` to parse input as numbers.

- Arithmetic Operations: The application uses a `switch` statement to perform the selected arithmetic operation based on user input.

## Error Handling
The CalculatorApp includes error handling to ensure a smooth user experience. It checks for invalid inputs and prevents division by zero, providing appropriate error messages.

## Conclusion
The CalculatorApp is a simple yet functional calculator application written in C#. It offers basic arithmetic operations and handles common user input errors. This documentation provides an overview of its features and how to use it effectively. Feel free to explore the source code to understand the implementation details further.