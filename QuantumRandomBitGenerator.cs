using System;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.Core;

namespace QuantumRandomBitGenerator {
    public class QuantumRandomGenerator {
        private QuantumSimulator simulator;

        public QuantumRandomGenerator() {
            simulator = new QuantumSimulator();
        }

        public bool GenerateBit() {
            var result = GenerateRandomBit.Run(simulator).Result;
            return result == Result.One;
        }
    }
}