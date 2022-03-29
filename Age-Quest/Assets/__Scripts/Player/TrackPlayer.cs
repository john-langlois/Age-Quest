using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    #region Singleton 

    public static TrackPlayer instance;

    void Awake(){
        // refer to the player being tracked 
        instance = this;
    }

    #endregion

    public GameObject player;


}
