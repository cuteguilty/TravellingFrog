using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_Trigger : MonoBehaviour
{
    public bool goal;

    private void OnTriggerEnter2D(Collider2D col)
    {
        // froggy.count++;
        if (col.GetComponent<Weight>())
        {
            goal = true;
            Destroy(gameObject);
        }

    }
}
