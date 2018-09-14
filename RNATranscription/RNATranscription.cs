using System;
using  System.Text;
namespace RNATranscriptionModule 
{
    public static class RnaTranscription 
    {
        public static string ToRna (string nucleotide) 
        {
            StringBuilder input=new StringBuilder();
            for (int i = 0; i < nucleotide.Length; i++) 
            {

                {
                    switch (nucleotide[i]) 
                    {
                        case 'G':
                            input.Append('C');
                            break;
                        case 'C':
                            input.Append('G');
                            break;
                        case 'T':
                            input.Append('A');
                            break;
                        case 'A':
                            input.Append('U');
                            break;
                        default:
                            break;
                    }
                }
            } //testingfkjnnjknv
            return input.ToString();
            
        }
    }
}