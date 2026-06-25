using DesignPatterns.Models;
using System;

namespace DesignPatterns.ModelBuilders
{
    public class CarBuilder
    {
        private string color = "red";
        private string model = "Mustang";
        private string brand = "Ford";
        
        private int year; 

        public CarBuilder setColor(string color)
        {
            this.color = color;
            return this;
        }

        public CarBuilder setBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarBuilder setModel(string model)
        {
            this.model = model;
            return this;
        }
        
        public CarBuilder SetCurrentYear()
        {
            this.year = DateTime.Now.Year; 
            return this;
        }

        public Vehicle Build()
        {
            Vehicle car = new Car(color, brand, model);
            
            // 4. Le asignamos el año
            car.Year = this.year;
            
            return car;
        }
    }
}