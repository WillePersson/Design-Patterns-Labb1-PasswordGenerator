# Explanation
I have Used Factory Method Pattern, Singelton Pattern and Strategy Pattern in this labb
Also Made a Simple Password Generator for this example to inmplement the Patterns

## Program.cs
Contains the entry point (Main method) and calls the Run method for UserInterface.

## UserInterface.cs
Handles user interaction, coordinates password generation, includes a loop to allow multiple password generations, and clears the console before each run.

## PasswordGenerator.cs
Implements the Singleton pattern to ensure a single instance and uses the Strategy pattern for password generation.

## ICharacterSet.cs and CharacterSets.cs
Define character sets using the Factory Method pattern.

## CharacterSetFactory.cs
Factory class for creating instances of character sets.

## IPasswordStrategy.cs and RandomPasswordStrategy.cs
Define and implement the Strategy pattern for password generation.

This structure allows the user to generate multiple passwords and clear the console between each attempt to keep the interface clean.
