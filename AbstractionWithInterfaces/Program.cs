


using AbstractionWithInterfaces;

IAnimal dog3 = new Dog();

Jungle jungle = new Jungle(new Dog());


Dog dog1 = new Dog();

jungle.ForceAnimalsToMakeSound(dog1);


IAnimal dog2 = new Dog();
dog2.MakeSound();

new Dog().MakeSound();

jungle.MakeAnimalMakeSound();



    
Console.ReadKey();





