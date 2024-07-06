namespace GMCar.Classes
{
    public class Car
    {
        private string Model { get; set; }
        private int Year { get; set; }
        private decimal Price { get; set; }
        private decimal Speed { get; set; }

        public Car(string model, int year, decimal price, decimal speed)
        {
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Speed = speed;
        }

        public string GetCarInfo() =>
             $"Medel is {Model}, Year is {Year}, Price is {Price}, Speed is {Speed}";

        public decimal CalculateDepreciation(int years)
        {
            if (years <= 10)
            {
                return Price - Price * years / 10;
            }
            else 
                return 0;
        }
    }
}
        
       
