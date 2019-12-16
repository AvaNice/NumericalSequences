namespace NumericalSequences
{
    interface INumbersSequence
    {
        int Length { get; }

        int this[int index] { get; }
    }
}