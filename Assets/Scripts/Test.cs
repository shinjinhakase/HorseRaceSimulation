using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    
    void Start(){
        
        List<Horse> horseList = SampleHorses();

        foreach(Horse horse in horseList){
            horse.Earn(Random.Range(1,10000));
        }

        foreach(Horse horse in horseList){
            Debug.Log(horse.getName() + ":" + horse.getWinnings());
        }

        Race race = new Race(horseList,5);
        horseList = race.Entry();
        Debug.Log("Frame Ordered!");
        foreach(Horse horse in horseList){
            Debug.Log(horse.getName() + ":" + horse.getWinnings());
        }

    }

    List<Horse> SampleHorses(){

        Horse horse1 = new Horse("サクラバクシンオー");
        Horse horse2 = new Horse("ディープインパクト");
        Horse horse3 = new Horse("キタサンブラック");
        Horse horse4 = new Horse("ホウライ");
        Horse horse5 = new Horse("ユグドラシル");
        Horse horse6 = new Horse("エリュシオン");
        Horse horse7 = new Horse("シャングリラ");

        return new List<Horse>(){horse1,horse2,horse3,horse4,horse5,horse6,horse7};

    }

}