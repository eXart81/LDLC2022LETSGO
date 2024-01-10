using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Projectiles : MonoBehaviour
{
    Vector3 direction;

    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        direction = Camera.main.transform.forward;
        transform.position = Camera.main.transform.position + direction * 2 ;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 currentPosition = transform.position;

        float speed = 5f;

        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;
        

        rigidbody.MovePosition(newPosition);
    }
}

