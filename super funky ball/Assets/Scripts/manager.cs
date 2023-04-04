using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    int level = 1;

    public void win()
    {
        level++;
        Debug.Log("WIN");
    }

}
