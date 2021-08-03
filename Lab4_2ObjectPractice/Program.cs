using System;

namespace Lab4_2ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Out MenuItem Class
            MenuItem item1 = new MenuItem(1, "Pizza", "Cheesy and delicious", 12.50m);
            MenuItem item2 = new MenuItem(2, "Ham and Cheese Sandwich", "Cheesy, but not as delicious", 8.50m);
            MenuItem item3 = new MenuItem(3, "Fruit Salad", "Sweet and fresh", 0.30m);
            MenuItem item4 = new MenuItem(4, "Burger", 10.01m);
            Console.WriteLine(item1);
            Console.WriteLine(item2);
            Console.WriteLine(item3);
            Console.WriteLine(item4);
            item4.SetDescription("Juicy");
            Console.WriteLine(item4);

            // Creating an instance of MenuItem with default constructor
            // MenuItem item5 = new MenuItem();
            // Error Received: 'MenuItem' does not contain a constructor that takes 0 arguments
        }
    }

    class MenuItem
    {
        // FIELDS
        private int ID;
        private string Name;
        private string Description;
        private decimal Price;

        // CONSTRUCTORS
        public MenuItem(int id, string name, string description, decimal price)
        {
            SetID(id);
            SetName(name);
            SetDescription(description);
            SetPrice(price);
        }

        public MenuItem(int id, string name, decimal price)
        {
            SetID(id);
            SetName(name);
            SetDescription("");
            SetPrice(price);
        }

        // GETTERS AND SETTERS
        public void SetID(int id)
        {
            ID = id;
        }

        public int GetID()
        {
            return ID;
        }

        public void SetName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                Name = "EMPTY";
            }
            else
            {
                Name = name;
            }
        }

        public string GetName()
        {
            return Name;
        }

        public void SetDescription(string description)
        {
            if (String.IsNullOrEmpty(description))
            {
                Description = "EMPTY";
            }
            else
            {
                Description = description;
            }
        }

        public string GetDescription()
        {
            return Description;
        }

        public void SetPrice(decimal price)
        {
            if (price < 0.50m)
            {
                Price = 0.50m;
            }
            else if (price > 10.00m)
            {
                Price = 10.00m;
            }
            else
            {
                Price = price;
            }
        }

        public decimal GetPrice()
        {
            return Price;
        }

        // TOSTRING METHOD
        public override string ToString()
        {
            return $"\n------------Menu Item Instance------------\nID: {ID}\nName: {Name}\nDescription: {Description}\nPrice: ${Price}";
        }
    }
}
