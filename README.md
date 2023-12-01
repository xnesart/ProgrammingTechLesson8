# ProgrammingTechLesson8
Task. Arrays, Collections, Exceptions
In all tasks, use the necessary collection type from the System.Collections class.
Part 1
To demonstrate the operation of the collection, use all the basic methods and properties of the corresponding class. The collection should consist of arbitrary values of type Double.
• Implement an array-list (ArrayList).
• Implement a queue (Queue).
• Implement a hash table (Hashtable).
For the created program, implement exception handling blocks wherever possible. Handle at least three different exceptions. Use the available exception classes declared in System. Alternatively, implement custom exceptions.
For the created program, implement a method that uses the previously created instance of collections as an argument. The method calculates the arithmetic mean among all values and sets to zero all collection elements that are less than the found value. Organize the transfer of the collection to the method using the ref modifier.
Part 2
Using System.Collections.Stack, write a program that determines whether the entered bracket structure is correct. Examples of correct bracket expressions: (), (())(), ()(), ((())), incorrect ones — )(, ())((), (, )))), ((()).
Solution methodology: Examine each symbol of the specified quantity sequentially from left to right. If the current symbol is a left bracket, place it in the stack. If it's a right bracket, extract an element from the stack (it must be a left bracket). After examining the entire string, if everything is correct, the stack should be empty.
Part 3
Student information includes the following: last name, first name, course, grades for subjects (mathematics, physics, computer science). Create an array of records (6-10 elements) and fill it with data. Find the last name and first name of the second-year student who performs worse than the others. Solve the same task using a queue instead of an array.
