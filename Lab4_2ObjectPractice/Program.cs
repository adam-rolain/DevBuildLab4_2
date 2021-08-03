using System;

namespace Lab4_2ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing out MenuItem class
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

            // Testing out Rectangle class
                // Different Lengths and Widths
            Rectangle r1 = new Rectangle(10, 20);
            Rectangle r2 = new Rectangle(10, 10);
            if (r1 == r2)
            {
                Console.WriteLine("\nSame");
            }
            else
            {
                Console.WriteLine("\nDifferent");
            }

                // Same Lengths and Widths
            Rectangle r3 = new Rectangle(10, 10);
            Rectangle r4 = new Rectangle(10, 10);
            if (r3 == r4)
            {
                Console.WriteLine("\nSame");
            }
            else
            {
                Console.WriteLine("\nDifferent");
            }

                // Setting second rectangle as equal to the first
            Rectangle r5 = new Rectangle(10, 10);
            Rectangle r6 = r5;
            if (r5 == r6)
            {
                Console.WriteLine("\nSame");
            }
            else
            {
                Console.WriteLine("\nDifferent");
            }

            // Conclusions from the above Rectangle Tests:
            // The first two tests both return "Different" because each of the variables
            // are pointing to a different instance of the Rectangle class in the heap.
            // The third test returns "Same" because when I set "r6 = r5" that is storing
            // the instance of Rectangle that was created in r5 to r6 as well. Basically,
            // r5 and r6 are both pointing to the same instance of the Rectangle class in 
            // the heap.
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

    class Rectangle
    {
        // FIELDS
        public int Length;
        public int Width;

        // CONSTRUCTOR
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
    }
}
