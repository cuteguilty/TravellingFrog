using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
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
