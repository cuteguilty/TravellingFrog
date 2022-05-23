using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLvl1 : MonoBehaviour
{
      public void Level1(int scene){
      
        SceneManager.LoadScene(scene);
    }

    public void Level12(int scene){
      
        SceneManager.LoadScene(scene);
    }
}
