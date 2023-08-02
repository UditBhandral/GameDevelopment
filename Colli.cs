using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colli : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if(collision.transform.name == "Sphere"){
            Score.scoreValue += 10;
            Destroy(gameObject);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
