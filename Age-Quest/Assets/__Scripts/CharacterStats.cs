
using UnityEngine;
using System;
public class CharacterStats : MonoBehaviour
{
    // character health
    public int health {get;set;}
    // character damage strength
    public int damage{get;set;}

    // deal damage to opponent 
    public void DealDamage(CharacterStats opponent){
        // decrease opponent health based on our damage 
        opponent.health = opponent.health - damage;
    }

    // set stats based on tag 
    public void setStats(GameObject obj){
        if (obj.tag == "Cleo"){
            health = 150;
            damage = 10;
        }
        if (obj.tag == "Dakota"){
            health = 80;
            damage = 40;
        }
        if (obj.tag == "Paula"){
            health = 100;
            damage = 10;
        }
        if (obj.tag == "Enemy1"){
            health = 200;
            damage = 10;
        }
        if (obj.tag == "Enemy2"){
            health = 100;
            damage = 10;
        }
        if (obj.tag == "Enemy3"){
            health = 400;
            damage = 40;
        }

    }
}
