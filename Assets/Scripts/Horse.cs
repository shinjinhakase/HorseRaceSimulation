using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse {

    private string name;
    private string sex;
    private int age;
    private string father;
    private string mother;
    private int winnings;
    private int speed;
    private int stamina;
    private int mental;
    private int spurt;
    private Color32 color;

    public Horse(string name){
        this.name = name;
    }

    public void Earn(int getMoney){
        winnings += getMoney;
    }

    public string getName(){
        return name;
    }
    
    public int getWinnings(){
        return winnings;
    }
    
}