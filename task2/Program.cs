using GenericsHomework;
using task2;

EntityStorage<User> userStorage = new EntityStorage<User>();
userStorage.Add(new User(1, "Алина", "alina@mail.com"));
userStorage.Add(new User(2, "Бакыт", "bakyt@mail.com"));
userStorage.Add(new User(3, "Саида", "dima!mail.com"));

User found = userStorage.GetById(2);
Console.WriteLine(found.Name + " " + found.Email);

User notFound = userStorage.GetById(99);
//if (notFound == null)
//{
//    Console.WriteLine("Пользователь с Id=99 не найден");
//}

EntityStorage<Product> productStorage = new EntityStorage<Product>();
productStorage.Add(new Product(1, "SSD 512GB", 4500m));
productStorage.Add(new Product(2, "Мышка", 800m));

foreach (Product p in productStorage.GetAll())
{
    Console.WriteLine(p.Id + ": " + p.Name + " - " + p.Price);
}
//EntityStorage<string> bad = new EntityStorage<string>();
// Ошибка, потому что string не наследуется от Entity, а EntityStorage принимает только Entity и его наследников (User, Product).


//по третьему заданию
ObjectFactory<User> userFactory = new ObjectFactory<User>();
ObjectFactory<Product> productFactory = new ObjectFactory<Product>();

User oneUser = userFactory.Create();
Console.WriteLine("Создан User, Id = " + oneUser.Id);

List<Product> products = productFactory.CreateMany(3);
Console.WriteLine("Создано товаров: " + products.Count);

List<Product> negative = productFactory.CreateMany(-5);
Console.WriteLine("Создано при -5: " + negative.Count);//возвращает пустой список, так как количество объектов не может быть отрицательным  и из-за условия в цикле

//по четвертому заданию
Console.WriteLine();
Console.WriteLine("Выводы по четвертому заданию");
UserRepository userRepo = new UserRepository();
userRepo.Add(new User(1, "Алина", "alina@mail.com"));
userRepo.Add(new User(2, "Бакыт", "bakyt@mail.com"));

User byEmail = userRepo.GetByEmail("bakyt@mail.com");
Console.WriteLine("Нашли по email: " + byEmail.Name);
Console.WriteLine("Всего пользователей: " + userRepo.GetAll().Count);

ProductRepository productRepo = new ProductRepository();
productRepo.Add(new Product(1, "SSD 512GB", 4500));
productRepo.Add(new Product(2, "Мышка", 800));
productRepo.Add(new Product(3, "Клавиатура", 1500));

List<Product> cheap = productRepo.GetCheaperThan(2000);

Console.WriteLine("Дешевле 2000:");
foreach (Product p in cheap)
{
    Console.WriteLine(p.Name + "-" + p.Price);
}