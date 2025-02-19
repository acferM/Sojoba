using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] 
public class PlayerData 
{
    public float[] position;
    public int health;
    public int coin;
    public int strength;
   

    public PlayerData(PlayerBehaviour player)
    {
       position = new float[3];
       position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
       position[2] = player.transform.position.z;

        health = PlayerBehaviour.health;
        coin = player.coin;
        strength = PlayerBehaviour.strength;
        
    }
    


}
