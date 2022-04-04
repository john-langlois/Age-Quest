
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
        if (health <= 0){
            Debug.Log("Player Dead");
            CharacterDeath();
        }
    }
    public virtual void CharacterDeath(){
        Debug.Log("enemy has been slain");
    }

    public void regenerateHealth(){

    }
}
