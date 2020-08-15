using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject self;
    public HingeJoint[] wheel;
    public GameObject[] wheelColliders;
    

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            
                wheelColliders[i].transform.localRotation = Quaternion.Euler(-Input.GetAxis("Vertical") * 10, 0, 0);
            
        }
        self.transform.localRotation = Quaternion.Euler(-Input.GetAxis("Vertical") * 4, 0, 0);
        self.transform.localRotation = Quaternion.Euler(0, Input.GetAxis("Horizontal") * 10, 0);


    }
}

