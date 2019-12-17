namespace NumericalSequences
{
    class NaturalNumbersSquareLessApp
    {
        private readonly ISequenceUI _userInterface;

        public NaturalNumbersSquareLessApp(ISequenceUI userInterface)
        {
            _userInterface = userInterface;
        }

        public void RunApp(int number)
        {
            INumbersSequence seq = new NaturalNumbersSquareLess(number);

            for (int index = 0; index < seq.Length; index++)
            {
                _userInterface.ShowResult($"{seq[index]} ");
            }
        }
    }
}
