using AutomapperVsMapperly.Dto;
using Riok.Mapperly.Abstractions;

namespace AutomapperVsMapperly.Mappers;

[Mapper]
public partial class MapWithMapperly
{
    public partial ClassTwo OneToTwo(ClassOne one);
}