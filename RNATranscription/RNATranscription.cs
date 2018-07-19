using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            //throw new NotImplementedException("You need to implement this function.");
            //implementing the function
            string OutputNucleotide="";
            for (int i = 0; i < nucleotide.Length; i++)
            {
                switch (nucleotide[i])
                {
                    case 'G':
                        OutputNucleotide += 'C';
                        break;
                    case 'C':
                        OutputNucleotide += 'G';
                        break;
                    case 'T':
                        OutputNucleotide += 'A';
                        break;
                    case 'A':
                        OutputNucleotide += 'U';
                        break;
                }
            }
            return OutputNucleotide;
        }
    }
}
