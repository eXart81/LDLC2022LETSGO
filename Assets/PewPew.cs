using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PewPew : MonoBehaviour
{
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Mouse.current.leftButton.wasPressedThisFrame) return;
        var ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
        RaycastHit hitInfo;
        if (!Physics.Raycast(ray, out hitInfo)) return;
        
        if (hitInfo.transform.CompareTag("Enemy"))
        {
            Debug.Log("letsgo");
            hitInfo.collider.GetComponent<Enemy>().Throwback(transform.position);
        }
        else
        {
            Debug.Log("nogo");

        }
    }
}