using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    Vector3 positionDepart;
    Quaternion rotationDepart;
    
    [SerializeField] bool keepRotation;

    // Start is called before the first frame update
    void Start()
    {
        positionDepart = transform.position;
        rotationDepart = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            transform.position = positionDepart;
            if (keepRotation == true)
            {
                transform.rotation = rotationDepart;
            }
        }
    }
}
