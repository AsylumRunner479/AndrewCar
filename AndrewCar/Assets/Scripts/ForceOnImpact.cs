using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceOnImpact : MonoBehaviour
{
    //public Transform replace;
    public float Maxforce = 500;
    public ParticleSystem blood;
    public int impact = 1000;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.y >= Maxforce)
        {
            
            blood.Emit(impact);
        }
        if (-collision.relativeVelocity.y <= Maxforce)
        {

            blood.Emit(impact);
        }
        if (collision.relativeVelocity.x >= Maxforce)
        {

            blood.Emit(impact);
        }
        if (-collision.relativeVelocity.x <= Maxforce)
        {

            blood.Emit(impact);
        }
        if (collision.relativeVelocity.z >= Maxforce)
        {

            blood.Emit(impact);
        }
        if (-collision.relativeVelocity.z <= Maxforce)
        {

            blood.Emit(impact);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
