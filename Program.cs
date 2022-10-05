internal class Program
{
    //Näin voi hakea ja laittaa muuttujille "faker arvot"
    //var nimi = Faker.Name.FullName();
    //var osoite = Faker.Address.City();
    //var sosnumero = Faker.Identification.SocialSecurityNumber();


    private static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++) 
        {
            Console.WriteLine($"Terve, nimeni on {Faker.Name.FullName()}, asun {Faker.Address.City()}, ja sosiaaliturvatunnukseni on {Faker.Identification.SocialSecurityNumber()}");
        }
    }
}