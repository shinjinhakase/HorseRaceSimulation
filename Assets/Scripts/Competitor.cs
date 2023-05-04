using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Competitor {
    
    Horse horse;
    Jockey jockey;
    int performance;

    public Competitor(Horse horse,Jockey jockey){
        this.horse = horse;
        this.jockey = jockey;
    }

    public void StartDash(){
        performance += horse.getMental() + jockey.getTechnic();
    }

    public string getHorseName(){
        return horse.getName();
    }

    public string getJockeyName(){
        return jockey.getName();
    }

    public int getPerformance(){
        return performance;
    }
    
}
