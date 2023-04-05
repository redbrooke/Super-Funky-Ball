using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winner : MonoBehaviour
{
    public manager manager;

    void OnTriggerEnter () 
    {
        Debug.Log("big old win");
        manager.win();
    }

}
