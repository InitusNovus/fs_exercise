# fs_exercise

The exercise problems for F# practice suggested by ChatGPT

## Problem 1. Fibonacci Sequence
### Subject 
Recursion, Tail Recursion

### Problem
Write a function that takes a positive integer n as input and returns the nth number in the Fibonacci sequence. The Fibonacci sequence is defined as follows:

$$F(0) = 0$$

$$F(1) = 1$$

$$F(n) = F(n-1) + F(n-2)\quad \sf for \it \quad  n > 1$$


### Task
Implement a recursive function fibonacci that calculates the nth Fibonacci number.

Here's a template to get you started:
```F#
let rec fibonacci n =
    match n with
    | // Your code here

// Test your implementation
printfn "%d" (fibonacci 10) // Should print 55
```
To solve this problem, you'll need to use pattern matching to handle the base cases (```n = 0``` and ```n = 1```) and the recursive case (```n > 1```). When you've completed your implementation, test it with various input values to ensure it produces the correct Fibonacci numbers.

## Problem 2. Squares of Odd Numbers
### Subject
Higher-Order Functions, List Processing, Pattern Matching

### Problem
Write a function that takes a list of integers and returns a new list containing the squares of the odd numbers in the input list.

### Task
Implement a function squaresOfOdds that filters the odd numbers from the input list, squares them, and returns the resulting list.

Here's a template to get you started:

```F#
let squaresOfOdds numbers =
    // Your code here

// Test your implementation
let testNumbers = [1; 2; 3; 4; 5; 6; 7; 8; 9]
printfn "%A" (squaresOfOdds testNumbers) // Should print [1; 9; 25; 49; 81]
```
To solve this problem, consider using the ```List.filter``` and ```List.map``` functions. The ```List.filter``` function filters elements from a list based on a predicate (a function that returns ```true``` or ```false```), and the ```List.map``` function applies a given function to each element of a list and returns a new list with the transformed elements.

Additionally, you can use pattern matching to identify odd numbers. Once you've completed your implementation, test it with various input lists to ensure it produces the correct output.

## Problem 3. Palindrome Checker
### Subject
String Manipulation, Pattern Matching
### Task
Implement a function isPalindrome that checks whether a given string is a palindrome or not.

## Problem 4. Group Elements
### Subject
List Processing, Recursion
### Task
Implement a function groupElements that takes a list of integers and an integer n as arguments, and returns a list of lists, where each inner list contains n elements from the input list.

## Problem 5. Person Type and Functions
### Subject
Record Types, Function Composition
### Task
Define a Person record type with properties FirstName, LastName, and Age. Create the following functions: createPerson, fullName, and isAdult.

## Problem 6. File I/O with Simple Text Database
### Subject
File I/O, List Processing
### Task
Create a simple program that reads and writes records (e.g., people's names and ages) from a text file. Implement the following functions: readRecords, writeRecords, and addRecord.

## Problem 7. CSV Average Calculator (upcoming)
### Subject
File I/O, CSV Processing
### Task
Create a function that reads a CSV file and calculates the average of numbers in a specified column.

## Problem 8. Contact List Manager (upcoming)
###Subject
Command-line interface, Data Manipulation
###Task
Create a command-line application that takes user input to perform various operations on a list of contacts (add, delete, search, etc.).

## Project Idea: Simple Command-Line Todo List Application (upcoming)
### Subject
Application Structure, File I/O, Command-Line Interface
### Task
Create a simple command-line todo list application that allows users to manage their tasks. Implement functions to handle each operation (e.g., addTask, listTasks, markTaskComplete, removeTask, saveTasks, and loadTasks).

## Problem 9. Find Prime Numbers (upcoming)
### Subject
Math and prime numbers
### Task
Implement a function that finds all prime numbers up to a given limit.

## Problem 10. Reverse a List (upcoming)
### Subject
List processing and recursion
### Task
Implement a function that reverses a list using recursion.

## Problem 11. Flatten Nested Lists (upcoming)
### Subject
List processing and recursion
###Task
Implement a function that flattens a nested list structure.

## Problem 12. Merge Sort (upcoming)
### Subject
Sorting algorithms and recursion
### Task
Implement the merge sort algorithm for a list of integers.

## Problem 13. Combination Generator (upcoming)
### Subject
Combinatorics and recursion
### Task
Implement a function that generates all combinations of a given length from a list of elements.

## Problem 14. Simple Expression Evaluator (upcoming)
### Subject
Parsing and expression evaluation
### Task
Implement a function that evaluates simple arithmetic expressions.
