using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {
    public Game_Manager game_Manager;
    bool trigger = false;
    void OnTriggerEnter () {
        if (trigger == false) {
            trigger = true;
            game_Manager.CompleteLevel ();
        }

    }
}