using AutomapperVsMapperly.Dto;
using AutomapperVsMapperly.Mappers;
using BenchmarkDotNet.Attributes;

namespace AutomapperVsMapperly;

[MemoryDiagnoser]
public class MapperBenchmark
{
    private MapWithAutomapper _mapper;
    
    [GlobalSetup]
    public void Setup()
    {
        _mapper = new();
    }

    [Benchmark]
    public ClassTwo Map()
    {
        var mapper = _mapper.Config.CreateMapper();

        var one = Get();
        return mapper.Map<ClassTwo>(one);
    }

    [Benchmark]
    public ClassTwo MapperlyMap()
    {
        var mapper = new Mappers.MapWithMapperly();
        var one = Get();

        return mapper.OneToTwo(one);
    }

    [Benchmark]
    public ClassTwo CustomMap()
    {
        var one = Get();
        return MapWithCustomMapper.MapToClassTwo(one);
    }

    private static ClassOne Get()
    {
        var instance = new ClassOne
        {
            Id = Guid.NewGuid(),
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            Address = "123 Main St",
            City = "Edmonton",
            State = "Alberta",
            Country = "Canada",
            ZipCode = "12345",
            PhoneNumber = "123-456-7890",
            Username = "johndoe",
            Age = 30,
            Salary = 60000,
            HouseNumber = 123,
            PostalCode = 12345,
            NumberOfDependents = 2,
            HoursWorked = 40,
            Department = Department.Engineering,
            CreditScore = CreditRating.Good,
            DateOfBirth = new DateTime(1993, 5, 15),
            HireDate = new DateTime(2020, 8, 1),
            LastPromotionDate = null,
            LastLoginDate = DateTime.Now,
            AccountExpirationDate = DateTime.Now.AddYears(1)
        };
        return instance;
    }
}