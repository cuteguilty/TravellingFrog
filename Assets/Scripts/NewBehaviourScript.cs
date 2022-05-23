using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  NewBehaviourScript : MonoBehaviour
{
    public int count;
    public string level;
    public bool goal;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Weight>())
        {
            
            int prev = PlayerPrefs.GetInt("best_" + level);
            goal = true;
            count = count + 1;
            int now = prev - count;
            if (now < 0 || prev == 0) {
                PlayerPrefs.SetInt("best_" + level, count);
                int totalprev = prev != 0 ? PlayerPrefs.GetInt("total") : PlayerPrefs.GetInt("total") - 1;
                int totalnow = totalprev - now;
                PlayerPrefs.SetInt("best_" + level, count);
                PlayerPrefs.SetInt("total", totalnow);
            }
            PlayerPrefs.SetInt(level, count);
            Destroy(col.gameObject);
        }
    }
}
