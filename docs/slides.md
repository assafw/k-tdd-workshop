# TDD Workshop
## String calculator kata
---
## What is TDD?
**T**est **D**riven **D**evelopment
---
## How does it work?
* <span style="color:red">**Red**</span> Write a test that fails
* <span style="color:lime">**Green**</span> Write just enough code to make that test pass
* <span style="color:lightblue">**Refactor**</span> Clean up the code
* **Repeat** until you're done
---
## Why should we do it?
It's all about **confidence**
---
* You implement your functional requirements
* You have coverage
* YAGNI (**Y**ou **A**in't **G**onna **N**eed **I**t)
* Safer to make changes
---
## Tests should be
* Small
* Fast
* Stable (not-flaky)
* Test exactly one thing
* Clearly named

Recommended read: [The art of unit-testing (book)](http://artofunittesting.com/)
---
## Before we start
* Clone the repo from: https://github.com/assafw/k-tdd-workshop
* Don’t read a head
* Implement one piece of functionality at a time
* We only do “happy path” cases today, no need to test wrong input
* Refactor! Refactor! Refactor!
---
## Let's check everything works
* Make sure eveything build:
<br />if using `make`:
```
make build
make test
```

* Else use `dotnet` commands:
```
dotnet restore <project>
dotnet build <project>
dotnet test <test project>
```
---
## Let's write a string calculator
* Write a function that takes string as an input, that contains 0-2 numbers, delimited by a **','** and return their sum

Input examples:

```
 ""    -> 0
 "1"   -> 1
 "1,2" -> 3
```
---
## More numbers
Allow the input string to contain more than 2 numbers

```
"1,2,3"         -> 6
"1,1,1,1,1,1,1" -> 7
```
---
## Multiple Delimiters
Allow the input to contain `\n` (newline) as a valid separator

```
"1\n2"   -> 3
"1,2\n3" -> 6
```
---
## Custom Delimiter
Allow the input string to specify a custom delimiter
* First line of the input will be `//<delimiter>\n`
* Next line will contain the numbers separated by the custom delimiter

**This is optional, previous scenarios should be supported!!!**

```
"//!\n1!2!3"  -> 6"
"//+\n1+1"    -> 2"
```
---
## Negative numbers
Calling the calculator with input that contains a negative number should throw an exception, with the message **negatives not allowed** and include all negative numbers that were part of the input

```
"1,-1"     -> "Negatives not allowed: -1"
"1,-2,-3"  -> "Negatives not allowed: -2,-3"
```
---
# Part 1 completed!
#### keep going if you're interested
---
## Ignore large numbers
Numbers that are bigger than 1000 should be ignored

```
"1,1001" -> 1
"1,1000" -> 1001
```
---
## More delimiters
Allow to define delimiters of any length with the following format: `//[delimiter]\n`

```
"//[___]\n1___2___3" -> 6
```
---
Allow to define multiple delimiters that are valid in the input string with the following format: `//[delimiter1][delimiter2]\n`

```
"//[**][--]\n1**2--3" -> 6
```
---
# Done!