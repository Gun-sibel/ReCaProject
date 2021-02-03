using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=152950, Description="Manuel Vites"},
                new Car{CarId=2, BrandId=1, ColorId=2, ModelYear=2020, DailyPrice=161350, Description="Otomatik Vites"},
                new Car{CarId=3, BrandId=2, ColorId=1, ModelYear=2019, DailyPrice=189740, Description="Manuel Vites"},
                new Car{CarId=4, BrandId=2, ColorId=1, ModelYear=2020, DailyPrice=194470, Description="Otomatik Vites"},
                new Car{CarId=5, BrandId=2, ColorId=2, ModelYear=2020, DailyPrice=202120, Description="Otomatik Vites"},

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c=>c.BrandId==brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
