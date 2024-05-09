using Leistungserfassung.Data;
using Leistungserfassung.Models;
using Microsoft.Extensions.Configuration;


using LeistungserfassungContext context = new LeistungserfassungContext();

// Products veggieSpecial = new Products()
// {
//     Name = "veggie Special",
//     Price = 0.69M
// };
// context.Add(veggieSpecial);
//
// Products somethingToEat = new Products()
// {
//     Name = "huge shit",
//     Price = 9996
// };
// context.Add(somethingToEat);
//
// context.SaveChanges();


var data = context.Products
    .Where(p => p.Price > 2)
    .OrderBy(p => p.Name);


// same as this:
// var data = from product in context.Products
//     where product.Price > 2
//     orderby product.Name
//     select product;



foreach (var product in data)
{
    Console.WriteLine($"ID: {product.Id}");
    Console.WriteLine($"NAME: {product.Name}");
    Console.WriteLine($"PRICE: {product.Price}");
    Console.WriteLine("-----------------------");
    
}

