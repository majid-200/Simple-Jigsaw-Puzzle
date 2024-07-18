using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapObjects : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("puzzlePiece")){
            Debug.Log("test");
            other.GetComponent<Rigidbody>().MovePosition(transform.position);
        }
    }
}
