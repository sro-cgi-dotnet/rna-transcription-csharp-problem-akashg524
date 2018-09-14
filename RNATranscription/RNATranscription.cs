using System;

namespace RNATranscriptionModule 
{
    public static class RnaTranscription 
    {
        public static string ToRna (string nucleotide) 
        {
            string input = "";
            for (int i = 0; i < nucleotide.Length; i++) 
            {

                {
                    switch (nucleotide[i]) 
                    {
                        case 'G':
                            input += 'C';
                            break;
                        case 'C':
                            input += 'G';
                            break;
                        case 'T':
                            input += 'A';
                            break;
                        case 'A':
                            input += 'U';
                            break;
                        default:
                            break;
                    }
                }
            } //testingfkjnnjknv
            return input;
            
        }
    }
}