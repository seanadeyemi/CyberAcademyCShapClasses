

using PolymorphismExample;

Car car = new Car();

car.Drive();//Car is being driven


//Vehicle vehicle = new Vehicle();





//Polymorpism
//A vehicle can be a Car, A boat or a Truck as long as they inherit from Vehicle


Vehicle myVehicle = new Car();


myVehicle.Drive();//Car is being driven


myVehicle = new Truck();
myVehicle.Drive();//Truck is being driven


myVehicle = new Boat();
myVehicle.Drive();//Boat is being driven



//Victor victor = new Victor();


//parent can be used to create an object of the child because the child inherits from that parent
//Oriahi victor = new Victor();




Console.ReadKey();