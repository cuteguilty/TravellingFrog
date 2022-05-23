using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    NewBehaviourScript froggy;
    void Start()
    {
        froggy = FindObjectOfType<NewBehaviourScript>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Weight>())
        {
            froggy.count++;
            Destroy(gameObject);
        }

    }
}

