//Abstraction:   Hiding complexity and showing only the necessary details.

//Explanation: Abstraction is about hiding unnecessary details
//hiding unnecessary details and showing only what's relevant
//showing only what's relevant.
//You define the "what"define the "what", but not the "how".
//It's like an interface or a remote control—
//you know what it does but not how it works inside

using AbstractionExample;

Animal dog = new Dog();

dog.MakeSound();

Animal cat = new Cat();

cat.MakeSound();

Console.ReadLine();
