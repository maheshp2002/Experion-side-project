var db = new ApplicationDbContext();

//db.Customers.Add(new Customer()
//{
//    Name = "Vijitha",
//    Email = "vijitha@mail.com",
//    Dob = new DateTime(2000, 11, 7)
//});

//db.Customers.Add(new Customer()
//{
//    Name = "Vijitha",
//    Email = "vijitha@mail.com",
//    Dob = new DateTime(2000, 11, 7)
//});
//db.SaveChanges();

//var result = db.Customers;

//var result = db.Customers.OrderByDescending(m => m.Name).Take(2).ToList();

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.Id} - {item.Name}");
//}

//var recordOne = db.Customers.Find(2);
//Console.WriteLine($"Id: {recordOne.Id}, Name: {recordOne.Name}");

//var recordOne = db.Customers.Where(m=>m.Name == "Vijitha");
//foreach(var record in recordOne)
//{
//    Console.WriteLine(record.Dob);
//}

// Causes a error if has no data so always use FirstDefault
//var recordOne = db.Customers.First(m => m.Name == "Vijitha");
//Console.WriteLine(recordOne.Dob);

//var recordOne = db.Categories.FirstOrDefault(m => m.Name == "Vijitha");

//if (recordOne != null)
//{
//    Console.WriteLine(recordOne.Dob);
//}

//var category = new Category
//{
//    Name = "Laptops",
//    Description = "Asus, MacBook..."
//};
//db.Categories.Add(category);
//db.SaveChanges();
//Console.WriteLine(category.Id);

//var products = db.Products.Include(m => m.Category).ToList();

//foreach (var item in products)
//{
//    Console.WriteLine($"Name: {item.Name} | {item.Category.Name}");
//}

//var categories = db.Categories.Include(m=>m.Products).ToList();
//foreach (var category in categories)
//{
//    Console.WriteLine(new string('-', 25));
//    Console.WriteLine(category.Name);
//    Console.WriteLine(new string('-', 25));

//    foreach (var product in category.Products)
//    {
//        Console.WriteLine("Name: {0, 20}|", product.Name);
//    }
//}

db.Remove(new Category { Id = 1 });
db.SaveChanges();