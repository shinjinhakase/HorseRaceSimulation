using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Race {

    List<Horse> entryList;
    int entryLimit;

    public Race(List<Horse> entryList,int entryLimit){
        this.entryList = entryList;
        this.entryLimit = entryLimit;
    }
    
    public List<Horse> Entry(){
        Entry entry = new Entry();
        return entry.FrameOrder(entryList,entryLimit);
    }

}