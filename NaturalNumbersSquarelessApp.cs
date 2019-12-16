namespace NumericalSequences
{
    class NaturalNumbersSquarelessApp
    {
        private ISequenceUI _userInterface;

        public NaturalNumbersSquarelessApp(ISequenceUI userInterface)
        {
            _userInterface = userInterface;
        }

        public void RunApp(int number)
        {
            INaturalNumbersSquareless seq = new NaturalNumbersSquareLess(number);

            for (int index = 0; index < seq.Length; index++)
            {
                _userInterface.ShowResult($"{seq[index]} ");
            }
        }
    }
}
