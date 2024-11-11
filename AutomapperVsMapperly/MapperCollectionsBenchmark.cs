using AutomapperVsMapperly.Dto;
using AutomapperVsMapperly.Mappers;
using BenchmarkDotNet.Attributes;

namespace AutomapperVsMapperly;

[MemoryDiagnoser]
public class MapperCollectionsBenchmark
{
    private List<ClassOne> _classOnes;
    private MapWithAutomapper _mapper;
    
    [Params(50,100,200)]
    public int N { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        var faker = Faker.ClassOneFaker();
        _classOnes = faker.Generate(N);
        _mapper = new();
    }

    [Benchmark]
    public List<ClassTwo> MapperMapCollection()
    {
        var mapper = _mapper.Config.CreateMapper();

        var result = _classOnes.Select(x => mapper.Map<ClassTwo>(x));
        return result.ToList();
    }

    [Benchmark]
    public List<ClassTwo> MapperlyMapCollection()
    {
        var mapper = new Mappers.MapWithMapperly();

        var result = _classOnes.Select(x => mapper.OneToTwo(x));
        return result.ToList();
    }

    [Benchmark]
    public List<ClassTwo> CustomMapCollection()
    {
        var result = _classOnes.Select(x => MapWithCustomMapper.MapToClassTwo(x));
        return result.ToList();
    }
}