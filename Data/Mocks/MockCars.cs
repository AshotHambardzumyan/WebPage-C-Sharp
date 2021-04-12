using Shop1.Data.Interface;
using Shop1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla",
                        ShortDesc = "Fast Car",
                        LongDesc = "Nice, Fast, and very silent Car from 'Tesla' Company",
                        Img = "/img/TeslaModelX.jpg",
                        Price = 78000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "Ford",
                        ShortDesc = "Middle Car",
                        LongDesc = "Nice and Big Car from 'Ford' Company",
                        Img = "/img/Ford.jpg",
                        Price = 45000,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Porsche",
                        ShortDesc = "Fast Car",
                        LongDesc = "Nice, Fast, and very silent Car from 'Porsche' Company",
                        Img = "/img/PorscheTaycan.jpg",
                        Price = 125000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "BMW",
                        ShortDesc = "Middle Fast Car",
                        LongDesc = "Nice, Fast, and very noisy Car from 'BMW' Company",
                        Img = "/img/BMW.jpg",
                        Price = 39000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
