using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Race {

    List<Horse> entryList;
    int entryLimit;

    List<Competitor> entry;

    public Race(List<Horse> entryList,int entryLimit){
        this.entryList = entryList;
        this.entryLimit = entryLimit;
    }
    
    public List<Horse> Entry(){
        Entry entry = new Entry();
        return entry.FrameOrder(entryList,entryLimit);
    }

    public void FinalEntry(List<Competitor> competitorList){
        this.entry = competitorList;
    }

}