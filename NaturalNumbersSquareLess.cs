using System;

namespace NumericalSequences
{
    class NaturalNumbersSquareLess : INumbersSequence
    {
        public int Length { get; }

        public NaturalNumbersSquareLess(int number)
        {
            Length = (int)Math.Sqrt(number - 1);
        }

        public int this[int index]
        {
            get
            {
                if (index < Length)
                {
                    return ++index;
                }

                throw new IndexOutOfRangeException();
            }
        }
    }
}
