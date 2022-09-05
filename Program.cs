using System;
using System.Collections.Generic;

namespace OOPClassesIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Mavericks = new Team(); //In this instance, 'Team' is what is referred to as a constructor. A constructor is defined as a special member method.
                                        //'Team' is helping us to create a new team. 'Team' is a constructor that belongs to a class -- the 'Team' class, because that's
            Mavericks.Name = "Mavericks";   //what we decided to call it, even though the name of the file it's in is called, 'Teams'. Therefore a constructor and the class
            Mavericks.Description = "one of the most offensive teams in the NBA"; //it belongs to must have the same name. Or else, the constructor won't know what class it's calling.
            Mavericks.City = "Dallas";
            Mavericks.State = "Texas";
            Mavericks.Colors = new string[] { "blue", "white" }; //make sure brackets are placed right after the string, so that the array function is interpreted in the script.
            Mavericks.TeamSize = 14;
            Mavericks.Mascot = "Horse"; //the '.' usage here refers to what is known as dot notation. This is how we describe what variables we call based on the constructor.

            Mavericks.Draft("Someone", 4.7); //These are all also examples of what is called, instantiation, or creating new instances a class. When we craft a constructor
            Console.WriteLine();             //more than once, from the same class, all subsequent constructors from the first would be considered new instances of the same class.
            Mavericks.Play();
            Console.WriteLine();      //'Team' represents a blueprint for building a team. The same goes for 'Product', 'Service', and anything else we wish to craft a blueprint for.
            Mavericks.Announcement(); //Thinking of a class as an outline for how something needs to be built or constructed, would be an accurate analogy.
            Console.WriteLine();      //if you were to build a house, how would you want it built? Would the requirements for this house meet the criteria of an actual house?

            var Wizards = new Team(); //even though we're using the same constructor as above, and calling upon the same class, we can still have the output of different variables
            Wizards.Name = "Wizards"; //stored in different 'objects'.

            var Pistons = new Team(); //so now after having built a new place for other information or characteristics to be stored, all of the same attributes defined in the constructor
            Pistons.Name = "Pistons"; //'Team' will be stored in 'Pistons'.

            var cellPhone = new Product();
            cellPhone.Name = "Motorola Z4";
            cellPhone.Price = 404.00;
            
            var autoVehicle = new Product();
            autoVehicle.Name = "Honda CRV 2021";
            autoVehicle.Price = 27301.99;

            var deskTower = new Product();
            deskTower.Name = "HP Pavilion Model T-3001";
            deskTower.Price = 649.00;

            var Fan = new Product();
            Fan.Name = "Lasko Air Fan";
            Fan.Price = 23.98;

            var items = new List<Product>(); //here, a new list is being defined, but it's not using integers. It's calling a previously defined method, Product, which we
            items.Add(cellPhone);            //scripted in another cs file called, Products. This is also another example of a constructor being formed that calls back to
            items.Add(autoVehicle);          //the class in which its based from.
            items.Add(deskTower);
            items.Add(Fan);

            Console.WriteLine("On a random note, there's a few products being listed for sale this evening.");
            Console.WriteLine();

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} ${item.Price}");
            }

            Console.WriteLine();
            Console.WriteLine("A local venue just around the corner has recently listed some of its available services.");
            Console.WriteLine();

            var Massage = new Service();
            Massage.Name = "Swedish Massage";
            Massage.Price = 61.99;
            Massage.Type = "Oil Based";
            Massage.Time = 60.00;

            var OilChange = new Service();
            OilChange.Name = "Standard Oil Change";
            OilChange.Price = 41.99;
            OilChange.Type = "Non Synthetic";
            OilChange.Time = 36.75;

            Service FastFood = new Service() {Name = "Quick Eats Burger", Price = 3.99, Type = "Microwaveable", Time = 2}; //Condensing code, syntax sugar.

            var services = new List<Service>(); //now, we've created a new feature to be called into play; service, from the services file. This one, however, incorporates
            services.Add(Massage);              //different elements in its code to be utilized here in the main file.
            services.Add(OilChange);
            services.Add(FastFood);

            foreach (var service in services)
            {
                Console.WriteLine($"{service.Name}. ${service.Price}. {service.Type}. Expected service time will be about {service.Time} minutes.");
            }
            Console.WriteLine();
        }
    }
}
