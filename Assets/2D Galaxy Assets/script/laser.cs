using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10f;
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if(transform.position.y >= 5.55f)
        {
            Destroy(gameObject);
        }
    }
   
}
