/*----------------------------------------
File Name: ResetScene.cs
Purpose: Loads orginal scene
Author: Tarn Cooper
Modified: 16 September 2019
------------------------------------------
Copyright 2019 Tarn Cooper.
-----------------------------------*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    //Resets to original scene
    public void Reset()
    {
        Scene scene = SceneManager.GetActiveScene(); //Gets scene
        SceneManager.LoadScene(scene.name); //loads scene again
    }
}
