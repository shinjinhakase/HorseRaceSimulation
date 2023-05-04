using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Competitor {
    
    Horse horse;
    Jockey jockey;

    public Competitor(Horse horse,Jockey jockey){
        this.horse = horse;
        this.jockey = jockey;
    }

    public string getHorseName(){
        return horse.getName();
    }

    public string getJockeyName(){
        return jockey.getName();
    }
    
}
