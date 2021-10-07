using System.Collections.Generic;
using System.Linq;

namespace Hacker_Rank
{
    public static class ClimbingLeaderboard
    {
     public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
       List<int> pos = new List<int>();
        int index = 0;
        ranked = ranked.Distinct().Reverse().ToList();
        for(int i = 0 ; i < player.Count() ; i++){
            for(int j = index ; j < ranked.Count() ; j++){
                if(player[i] < ranked[j]){
                    pos.Add(ranked.Count()-j+1);
                    index = j;
                    break;
                }else if(j==ranked.Count()-1){
                    pos.Add(ranked.Count()-j);
                }
            }
        }
        
        return pos.ToList();
    }

    }
}