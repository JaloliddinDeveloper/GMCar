using GMCar.Classes;

var Damas = new Car(model: "Damas", year: 2003, price: 10000000, speed: 180);
var Nexia = new Car(model: "Nexia", year: 2004, price: 20000000, speed: 200);
var Lasetti = new Car(model: "Lasetti", year: 2006, price: 25000000, speed: 220);

Console.WriteLine(Damas.GetCarInfo());
Console.WriteLine(Nexia.GetCarInfo());
Console.WriteLine(Lasetti.GetCarInfo());

Console.WriteLine();

Console.WriteLine($"Damasning chiqarilgandan 3 yildan keyingi narxi:" +
    $" {Damas.CalculateDepreciation(3)} ");

Console.WriteLine($"Nexianing chiqarilgandan 5 yildan keyingi narxi: " +
    $"{Nexia.CalculateDepreciation(5)} ");

Console.WriteLine($"Lasettining chiqarilgandan 7 yildan keyingi narxi:" +
    $" {Lasetti.CalculateDepreciation(7)} ");


