using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    

    
    public void load()
     {
        
         Debug.Log("Loading The GameBallScene");
         SceneManager.LoadSceneAsync(SceneManager.sceneCountInBuildSettings - 1);
     }
    

}
