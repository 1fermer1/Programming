using System;

namespace Проблема_33
{
    class NonTrivialExamples
    {
        public decimal Numerator = 0;
        public decimal Denominator = 0;
        private decimal removeNumerator = 0;
        private decimal removeDenominator = 0;
        private string tempN = null;
        private string tempD = null;
        private bool nonTrivialExamplesNumber = true;

        public bool NonTrivialExamplesNumber()
        {
            nonTrivialExamplesNumber = false;
            tempN = Convert.ToString(Numerator);
            tempD = Convert.ToString(Denominator);
            for (int i = 1; i < 10; i++)
            {
                for (int n = 0; n < 2; n++)
                {
                    if ((Convert.ToInt32(tempN[n]) - 48) == i)
                    {
                        for (int p = 0; p < 2; p++)
                        {
                            if ((Convert.ToInt32(tempD[p]) - 48) == i)
                            {
                                removeNumerator = Convert.ToInt32(tempN.Remove(n, 1));
                                removeDenominator = Convert.ToInt32(tempD.Remove(p, 1));
                                if ((Numerator / Denominator) == (removeNumerator / removeDenominator))
                                {
                                    nonTrivialExamplesNumber = true;
                                }
                            }
                        }
                    }
                }
            }
            return nonTrivialExamplesNumber;
        }
    }
}
