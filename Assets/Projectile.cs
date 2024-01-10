using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float speed = 5f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        Vector3 direction = transform.forward;

        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;

        rigidbody.MovePosition(newPosition);
   
    }
    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();

    }

}
