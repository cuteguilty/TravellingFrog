using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
     public void PlayAgain(int scene){
       
        SceneManager.LoadScene(scene);
    }

     public void MainMenu(int scene){
       
        SceneManager.LoadScene(scene);
    }

     public void Next(int scene){
       
        SceneManager.LoadScene(scene);
    }
}
