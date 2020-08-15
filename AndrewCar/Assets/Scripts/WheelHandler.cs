using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelHandler : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.localRotation = Quaternion.Euler(Input.GetAxis("Horizontal"), Input.GetAxis("Horizontal") * 10, 90);




    }
}
