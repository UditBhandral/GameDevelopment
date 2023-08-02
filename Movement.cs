using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public float zSpeed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x=0.0f;
        float y=0.0f;
        float z=0.0f;

        if(Input.GetKey("w")){
            z=z+zSpeed;
        }
        if(Input.GetKey("s")){
            z=z-zSpeed;
        }
        if(Input.GetKey("a")){
            x=x-xSpeed;
        }
        if(Input.GetKey("d")){
            x=x+xSpeed;
        }
        if(Input.GetKey("j")){
            y=y+ySpeed;
        }
        rb.AddForce(x,y,z);

    }
}
