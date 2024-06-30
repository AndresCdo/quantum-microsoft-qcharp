namespace QuantumRandomBitGenerator {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    
    @EntryPoint()
    operation GenerateRandomBit() : Result {
        use q = Qubit();
        
        H(q);

        let result = M(q);

        Reset(q);

        return result;
    }
}