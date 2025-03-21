﻿using System;
namespace carvedrock.bl.principles.Solid.LiskovSubstitution
{
    public class LiskovSubstitution
    {
        public LiskovSubstitution()
        {
            TShirt summerShirt = new("Hello Summer T-Shirt", 5.99, "cotton", new List<string>() { "S", "L", "XL" });
            TShirt mountainShirt = new("Hiking T-Shirt", 9.99, "polyester", new List<string>() { "M", "XL", "XXL" });

            Backpack winterBackPack = new("Waterproof Backpack Heavy Duty", 15.99, 35, 5);
            Backpack summerBackPack = new("Waterproof Surf Backpack", 20.99, 25, 2.5);

            List<Product> productList = new(){ summerShirt, mountainShirt};

            foreach(var product in productList)
            {
                Console.WriteLine(product.GetDescription());
            }
            


        }
    }
}

