using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_SandwichCollider : MonoBehaviour
{

    public GameObject Mouth;
    public GameObject TestSandwich;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //should attach the Sandwich to the raccoon upon collision
        Debug.Log("Sandwich detected");
        TestSandwich.GetComponent<FixedJoint>().connectedBody = Mouth.GetComponent<Rigidbody>();
    }
}