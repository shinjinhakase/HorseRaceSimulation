using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jockey {
    
    private string name;
    private string gender;
    private int age;
    private int technic;

    public Jockey(string name){
        this.name = name;
    }

    public void levelUp(int level){
        technic += level;
    }

}