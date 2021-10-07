using System;

namespace Hacker_Rank
{
    public class SequenceEquation
    {
        //4 3 5 1 2
       public static void permutationEquation(int[] p) {
        int[] index = new int[p.Length];
        for(int i =1;i<(p.Length+1);i++)
        {   
        int count =0;

            for(int j=0;j<(p.Length);j++)
            {
                 if(p[j] == i)
                 {
                    index[count]= j+1;
                    count++;
                 }     
            }
                  
        }


        int[] ind = new int[p.Length];
        
        for(int i =1;i<(p.Length);i++)
        {   
        int counts =0;

            for(int j=0;j<(p.Length);j++)
            {
                 if(p[j] == ind[i])
                 {
                    ind[counts] = p[j]; 
                    counts++;
                 }     
            }
                  
        }
        foreach(var i in ind)
        {
            Console.WriteLine(i);
        }
        }
    }
}