using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Race {

    List<Horse> entryList;
    int entryLimit;

    List<Competitor> Player;

    public Race(List<Horse> entryList,int entryLimit){
        this.entryList = entryList;
        this.entryLimit = entryLimit;
    }
    
    public List<Horse> Entry(){
        Entry entry = new Entry();
        return entry.FrameOrder(entryList,entryLimit);
    }

    public void FinalEntry(List<Competitor> competitorList){
        this.Player = competitorList;
    }

    public void Hold(){
        StartDash();
        PositionalStrife();
        Trace();
        Cornering();
        LastSpurt();
    }

    public void Result(){
        var calcResult = Player.OrderByDescending(p => p.getPerformance());
        string result = "";
        int order = 1;
        foreach(var competitor in calcResult){
            result += order.ToString() + "着:" + ((Competitor)competitor).getHorseName() + "\n";
            order++;
        }
        Debug.Log(result);
    }

    void StartDash(){Debug.Log("StartDash");
        foreach(Competitor player in Player){
            player.StartDash();Debug.Log(player.getHorseName() + ":" + player.getPerformance());
        }
    }

    void PositionalStrife(){Debug.Log("PositionalStrife");
        foreach(Competitor player in Player){
            player.PositionalStrife();Debug.Log(player.getHorseName() + ":" + player.getPerformance());
        }
    }

    void Trace(){Debug.Log("Trace");
        foreach(Competitor player in Player){
            player.Trace();Debug.Log(player.getHorseName() + ":" + player.getPerformance());
        }
    }

    void Cornering(){Debug.Log("Cornering");
        foreach(Competitor player in Player){
            player.Cornering();Debug.Log(player.getHorseName() + ":" + player.getPerformance());
        }
    }

    void LastSpurt(){Debug.Log("LastSpurt");
        foreach(Competitor player in Player){
            player.LastSpurt();Debug.Log(player.getHorseName() + ":" + player.getPerformance());
        }
    }


}