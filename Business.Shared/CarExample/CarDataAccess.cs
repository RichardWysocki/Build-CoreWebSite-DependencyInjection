using System.Collections.Generic;

namespace Business.Shared.CarExample
{
    public class CarDataAccess : ICarDataAccess
    {
        private readonly string _country;

        public CarDataAccess(string country)
        {
            this._country = country;
        }

        public List<Car> GetCars()
        {
            List<Car> response;
            switch (_country)
            {
                case "US":
                    
                    response = new List<Car>()
                    {
                        new Car() {Brand = "Ford", Make = "Mustang", Model = "EcoBoost FastBack", },
                        new Car() {Brand = "Ford", Make = "Mustang", Model = "GT FastBack", },
                        new Car() {Brand = "Ford", Make = "Mustang", Model = "Shelby GT350", },
                        new Car() {Brand = "Chevrolet", Make = "Equinox", Model = "LS", },
                       new Car() {Brand = "Chevrolet", Make = "Equinox", Model = "LT", },
                       new Car() {Brand = "Chevrolet", Make = "Malibu", Model = "LS", },
                       new Car() {Brand = "Chevrolet", Make = "Malibu", Model = "LT", },
                       new Car() {Brand = "Chevrolet", Make = "Malibu", Model = "Premier", },
                       new Car() {Brand = "Chrysler", Make = "Pacifica", Model = "Touring", },
                       new Car() {Brand = "Chrysler", Make = "Pacifica", Model = "Touring L", }
                    };
                    break;
                case "Europe":
                     response = new List<Car>()
                    {
                        new Car() {Model = "A222222222222", Make = "1"},
                        new Car() {Model = "A", Make = "2"},
                        new Car() {Model = "B", Make = "3"},
                        new Car() {Model = "B", Make = "4"},
                        new Car() {Model = "C", Make = "5"},
                        new Car() {Model = "C", Make = "6"},
                        new Car() {Model = "D", Make = "7"},
                        new Car() {Model = "D", Make = "8"},
                        new Car() {Model = "E", Make = "9"},
                        new Car() {Model = "E", Make = "10"}
                    };
                    break;
                default:
                    response =  new List<Car>();
                    break;
            }

            return response;
        }
    }
}
