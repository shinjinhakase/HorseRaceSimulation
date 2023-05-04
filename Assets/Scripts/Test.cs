using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    
    void Start(){
        
        List<Horse> horseList = SampleHorses();
        List<Jockey> jockeyList = SampleJockies();

        Race race = new Race(horseList,5);
        horseList = race.Entry();

        Agent agent = new Agent();
        List<Competitor> competitorList = agent.CompetitorList(horseList,jockeyList,5);

        race.FinalEntry(competitorList);

        race.Hold();
        race.Result();

    }

    List<Horse> SampleHorses(){

        Horse horse1 = new Horse("サクラバクシンオー");
        Horse horse2 = new Horse("ディープインパクト");
        Horse horse3 = new Horse("キタサンブラック");
        Horse horse4 = new Horse("ホウライ");
        Horse horse5 = new Horse("ユグドラシル");
        Horse horse6 = new Horse("エリュシオン");
        Horse horse7 = new Horse("シャングリラ");

        List<Horse> answer = new List<Horse>(){horse1,horse2,horse3,horse4,horse5,horse6,horse7};
        foreach(Horse horse in answer){
            horse.Earn(Random.Range(1,10000));
            horse.levelUp(Random.Range(1,20),Random.Range(1,10),Random.Range(1,20),Random.Range(1,20));
        }

        return answer;

    }

    List<Jockey> SampleJockies(){

        Jockey jockey1 = new Jockey("武豊");
        Jockey jockey2 = new Jockey("横山典弘");
        Jockey jockey3 = new Jockey("C・ルメール");
        Jockey jockey4 = new Jockey("福永祐一");
        Jockey jockey5 = new Jockey("川田将雅");

        List<Jockey> answer = new List<Jockey>(){jockey1,jockey2,jockey3,jockey4,jockey5};
        foreach(Jockey jockey in answer){
            jockey.levelUp(Random.Range(1,10));
        }

        return answer;

    }

}