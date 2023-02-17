string[] snacks = { "Sushi", "Pizza", "Burger", "Ice cream", "Pasta" };

Random rnd= new Random();

int randomIndex = rnd.Next(snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}");

