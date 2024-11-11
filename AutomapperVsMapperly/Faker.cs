using AutomapperVsMapperly.Dto;
using Bogus;

namespace AutomapperVsMapperly;

public static class Faker
{
    public static Faker<ClassOne> ClassOneFaker()
    {
        var faker = new Faker<ClassOne>()
            .RuleFor(x => x.AccountExpirationDate, f => f.Date.Future(10))
            .RuleFor(x => x.Address, f => f.Random.Word())
            .RuleFor(x => x.Department, f => f.PickRandom<Department>())
            .RuleFor(x => x.Age, f => f.Random.Number(99))
            .RuleFor(x => x.Email, f => f.Internet.Email())
            .RuleFor(x => x.Id, f => Guid.NewGuid())
            .RuleFor(x => x.City, f => f.Address.City())
            .RuleFor(x => x.Country, f => f.Address.Country())
            .RuleFor(x => x.Salary, f => f.Random.Number(300000))
            .RuleFor(x => x.State, f => f.Address.State())
            .RuleFor(x => x.Username, f => f.Internet.UserName())
            .RuleFor(x => x.CreditScore, f => f.PickRandom<CreditRating>())
            .RuleFor(x => x.DateOfBirth, f => f.Date.Past(99));

        return faker;
    }
}