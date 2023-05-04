using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent {
    
    public List<Competitor> CompetitorList(List<Horse> horseList,List<Jockey> jockeyList,int numberOfEntry){
        
        List<Competitor> answer = new List<Competitor>();

        for(int i = 0; i < numberOfEntry; i++){
            Competitor competitor = new Competitor(horseList[i],jockeyList[i]);
            answer.Add(competitor);
        }

        return answer;

    }
    
}