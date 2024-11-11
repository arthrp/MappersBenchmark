using AutoMapper;
using AutomapperVsMapperly.Dto;
using BenchmarkDotNet.Running;
using Bogus;
using Microsoft.CodeAnalysis.FlowAnalysis;

namespace AutomapperVsMapperly;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<MapperCollectionsBenchmark>();
    }
}