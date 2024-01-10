using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateform : MonoBehaviour
{
    Rigidbody rigidbody;
    private Vector3 positionDeDepart;
    float sens = 1f;

    [SerializeField]
    float speed = 10.0f;
    void Start()
    {
        positionDeDepart = transform.position;
        rigidbody = GetComponent<Rigidbody>();
    }

    void InvertSens(float resetPosY)
    {
        sens *= -1f;
        Vector3 resetPos = positionDeDepart;
        resetPos.y = resetPosY;
        transform.position = resetPos;
    }

    void FixedUpdate()
    {
        if (transform.position.y > positionDeDepart.y + 10)
        {
            InvertSens(positionDeDepart.y+10);
        }
        else if (transform.position.y < positionDeDepart.y)
        {
            InvertSens(positionDeDepart.y);
        }

        Vector3 currentPosition = transform.position;
        Vector3 direction = new Vector3(0f, sens, 0f);
     

        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;
        rigidbody.MovePosition(newPosition);
    }
}
