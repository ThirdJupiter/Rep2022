using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Together : MonoBehaviour
{
   
    [SerializeField] Rigidbody[] bodies;

    // Start is called before the first frame update
    void Start()
    {
        //bodies = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < length; i++)
            {
                bodies[i].AddForce(Vector3.up * 200);
            }
        }
    }
}
