using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Xunit;
using System.Threading.Tasks;

namespace QuantumRandomBitGenerator.Tests
{
    public class QuantumTests
    {
        [Fact]
        public async Task TestRandomBitGenerator()
        {
            using var sim = new QuantumSimulator();
            var result = await GenerateRandomBit.Run(sim);
            Assert.True(result == Result.Zero || result == Result.One);
        }

        [Fact]
        public async Task TestRandomBitGeneratorMultiple()
        {
            using var sim = new QuantumSimulator();
            for (int i = 0; i < 100; i++)
            {
                var result = await GenerateRandomBit.Run(sim);
                Assert.True(result == Result.Zero || result == Result.One);
            }
        }
    }
}