using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControl : MonoBehaviour
{
    public float speed = 1f;
    public float jumpHeight = 10f;
    public bool jumpValue = true;
    private Rigidbody rigid; 
    public Vector3 home = new Vector3(3,4,-3);

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            rigid.AddForce(Vector3.right * speed);
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            rigid.AddForce(-Vector3.right * speed);
        }
        if(Input.GetAxis("Vertical") > 0)
        {
            rigid.AddForce(Vector3.forward * speed);
        }
        if(Input.GetAxis("Vertical") < 0)
        {
            rigid.AddForce(-Vector3.forward * speed);
        }
        if(transform.position.y < -10)
        {
          transform.position = home;
        }
        if((jumpValue) && (Input.GetAxis("Jump") > 0))
        {
            rigid.AddForce(new Vector3(0, jumpHeight,0), ForceMode.Impulse); 
            jumpValue = false;
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
       //Debug.Log(collisionInfo.collider.tag);
        if (collisionInfo.collider.tag == "floor")
        {
            //Debug.Log("Hello");
            jumpValue = true;
        }
    }
}
