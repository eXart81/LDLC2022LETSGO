using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaquePression : MonoBehaviour
{
    [SerializeField] int nombreRandom;
    [SerializeField] private GameObject door;
    [SerializeField] AudioSource audioData;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Il y a eu collision !!!");
        audioData.Play(0);
    }

    private void Update()
    {
        
    }

    void OnTriggerStay(Collider collider)
    {
        door.SetActive(false);
    }
    
    
    void OnTriggerExit(Collider collider)
    {
        door.SetActive(true);
        

    }
}
