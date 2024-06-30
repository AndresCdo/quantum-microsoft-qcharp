using System;
using QuantumRandomBitGenerator;

namespace QuantumRandomBitGenerator {
    class Program {
        static void Main(string[] args) {
            var generator = new QuantumRandomBitGenerator.QuantumRandomGenerator();
            Console.WriteLine("Random bit: " + generator.GenerateBit());
        }
    }
}