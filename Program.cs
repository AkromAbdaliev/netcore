
using netcore.polymorphism;

var lion = new Lion();
lion.Family = "Mammals";
lion.Type = "Wild";
lion.Status = "Predator";
lion.Pride = "Western";
// lion.AnimalSound();
// lion.AnimalEats();

var hyena = new Hyena();
hyena.Family = "Mammals";
hyena.Type = "Wild";
hyena.Status = "Predator";
hyena.Clan = "Eastern";
// hyena.AnimalSound();
// hyena.AnimalEats();

var zebra = new Zebra();
zebra.Family = "Mammals";
zebra.Type = "Wild";
zebra.Status = "Herbivores";
zebra.Group = "Lakeside";
// zebra.AnimalSound();
// zebra.AnimalEats();

List<Animal> animals = new List<Animal>();
animals.Add(lion);
animals.Add(hyena);
animals.Add(zebra);

foreach (var animal in animals)
{
    animal.AnimalSound();
}