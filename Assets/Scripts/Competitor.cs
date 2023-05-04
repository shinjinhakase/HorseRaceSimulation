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

    public void PositionalStrife(){
        performance += (int)(horse.getMental() * 1.5) + (int)(jockey.getTechnic() * 0.5);
    }

    public void Trace(){
        performance += (int)(horse.getSpeed() * 1.2) + (int)(horse.getStamina() * 0.8);
    }
    
    public void Cornering(){
        performance += (int)(horse.getSpeed() * 1.5) + horse.getMental();
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
