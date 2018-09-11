using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string input="";
            foreach(char ch in nucleotide)
            {
                switch (ch)
                {
                    case 'G' : input +='C';
                    break;
                    case 'C' : input +='G';
                    break;
                    case 'T' : input +='A';
                    break;
                    case 'A' : input +='U';
                    break;
                    default: break;
                }
            }
            return input;
        }
    }
}
