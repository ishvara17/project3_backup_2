using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letters : MonoBehaviour
{
    private float spinSpeed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
        if (transform.position.y < -100)
        {
            Destroy(gameObject);
        }
    }
}
