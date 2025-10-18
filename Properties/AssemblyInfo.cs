using System.Reflection;
using System.Runtime.InteropServices;
using NUnit.Compatibility;

[assembly: Parallelizable(ParallelScope.Children)]
[assembly: LevelOfParallelism(4)]