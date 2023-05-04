using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Entry {
    
    public List<Horse> FrameOrder(List<Horse> entryList,int entryLimit){
        entryList = EntryRestriction(entryList,entryLimit);
        entryList = entryList.OrderBy(a => Guid.NewGuid()).ToList();
        return entryList;
    }

    List<Horse> EntryRestriction(List<Horse> entryList,int entryLimit){

        if(entryList.Count <= entryLimit) return entryList;

        var entryAvailable = entryList.OrderByDescending(p => p.getWinnings()).Take(entryLimit);

        List<Horse> answer = new List<Horse>();
        foreach(var entry in entryAvailable){
            answer.Add((Horse)entry);
        }
        
        return answer;

    }

}