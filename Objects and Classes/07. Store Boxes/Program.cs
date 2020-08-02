using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForABox
        {
            get
            {
                return Item.Price * ItemQuantity;
            }
        }
    }
    class Item
    {

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] InputInfo = input.Split();

                string serialNumber = InputInfo[0];
                string itemName = InputInfo[1];

                int itemQuantity = int.Parse(InputInfo[2]);
                decimal itemPrice = decimal.Parse(InputInfo[3]);
                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.Item = item;

                boxes.Add(box);

                input = Console.ReadLine();
            }

            
            var resultSet = boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach (var currentBox in resultSet)
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:f2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.PriceForABox:f2}");
            }


        }
    }
}

