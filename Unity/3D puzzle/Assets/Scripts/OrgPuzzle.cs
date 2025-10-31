using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrgPuzzle : MonoBehaviour
{
    public float Timer = 5;

    // Update is called once per frame
    void Update()
    {
        Timer = Timer - Time.deltaTime;
        if (Timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
