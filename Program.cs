using netcore.inheritance;

var car = new Car();

car.Brand = "Mustang";
car.Model = "Sedan";
car.Year = 1996;

car.NumberOfDoors = 4;
car.NumberOfWheels = 4;

car.Start();
car.Stop();

var bike = new Bike();
bike.Brand = "Ducatti";
bike.Model = "Sport";
bike.Year = 2024;
bike.NumberOfWheels = 2;

bike.Start();
bike.Stop();
