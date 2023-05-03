using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scene2MovePillar : MonoBehaviour
{

    public float speed = 1f;
    private Rigidbody rigid;
    public Transform obstical;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (obstical.position.x > 10f) {
            rigid.AddForce(new Vector3(10, 0, 0), ForceMode.Impulse);
            Debug.Log("Heading right");
        }
        if (obstical.position.x < -10f)
        {
            rigid.AddForce(new Vector3(-10, 0, 0), ForceMode.Impulse);
            Debug.Log("Heading left");
        }

    }
}
