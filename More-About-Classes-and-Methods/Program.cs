using System;

namespace MoreAboutClassesandMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //method reffered to as constructor, many purposes, puts object in valid state
            Car myCar = new Car();

            //set Properties

            Car myOtherCar = myCar;

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");


            myOtherCar = null;
            myCar = null;

            //tabor never puts in my method and i dont know why.
            //Car.

        }



    }
    class Car
    {
        public string Make { get; set; }
        public string Model{ get; set;}
        public int Year { get; set; }
        public string Color { get; set; }
        public Double OriginalPrice { get; set; }

        public Car()
        {
            //You could this from a configuration file, database, etc..
            //ill just hardcode it in this instance

            this.Make = "Nissan";

        }
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        //have to have different parameter data types, names dont matter, only number and type.
		
        /*public Car(string someOtherImputParameter, string model, int year, string color)
		{
			Make = someOtherImputParameter;
			Model = model;
			Year = year;
			Color = color;
		}
		*/
        public static void MyMethod()
        {
            
        }
    }

}


