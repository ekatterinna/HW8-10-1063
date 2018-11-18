using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12
{
    class FloatToBin
    {
        static void Main()
        {
            float signedFloatNum = float.Parse(Console.ReadLine());
            int exponentDec = 0;
            char sign = '0';

            float normalizationLimit = 1;
            for (int i = 0; i < 126; i++)
            {
                normalizationLimit /= 2;
            }

            if (signedFloatNum < 0)
            {
                sign = '1';
                signedFloatNum = -signedFloatNum;
            }

            string exponentBin = "";
            string mantissaBin = "";

            if (signedFloatNum == 0)
            {
                exponentBin = "00000000";
                mantissaBin = "00000000000000000000000";
            }
            else if (signedFloatNum >= normalizationLimit)
            {
                if (signedFloatNum >= 2)
                {
                    while (signedFloatNum >= 2)
                    {
                        exponentDec++;
                        signedFloatNum /= 2;
                    }
                }
                if (signedFloatNum < 1)
                {
                    while (signedFloatNum < 1)
                    {
                        exponentDec--;
                        signedFloatNum *= 2;
                    }
                }

                float mantissaDec = signedFloatNum - 1;
                float tmpN = 0;
                float dN = 0.5f;

                for (int i = 0; i < 23; i++)
                {
                    if (mantissaDec >= tmpN + dN)
                    {
                        tmpN += dN;
                        mantissaBin = mantissaBin + '1';
                    }
                    else
                    {
                        mantissaBin += '0';
                    }
                    dN /= 2;
                }

                int exponentDecShift = exponentDec + 127;
                for (int i = 0; i < 8; i++)
                {
                    if (exponentDecShift % 2 == 1)
                    {
                        exponentBin = "1" + exponentBin;
                    }
                    else
                    {
                        exponentBin = "0" + exponentBin;
                    }
                    exponentDecShift /= 2;
                }
            }

            else
            {
                exponentBin = "00000000";
                signedFloatNum /= normalizationLimit;
                float mantissaDec = signedFloatNum;
                float tmpN = 0;
                float dN = 0.5f;

                for (int i = 0; i < 23; i++)
                {
                    if (mantissaDec >= tmpN + dN)
                    {
                        tmpN += dN;
                        mantissaBin = mantissaBin + '1';
                    }
                    else
                    {
                        mantissaBin += '0';
                    }
                    dN /= 2;
                }
            }

            Console.WriteLine("{0} {1} {2}", sign, exponentBin, mantissaBin);
        }
    }
}

