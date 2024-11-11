using AutoMapper;
using AutomapperVsMapperly.Dto;

namespace AutomapperVsMapperly.Mappers;

public class MapWithAutomapper
{
    public MapperConfiguration Config = null!;
    
    public MapWithAutomapper()
    {
        Config = new MapperConfiguration(cfg => cfg.CreateMap<ClassOne, ClassTwo>());
    }
}