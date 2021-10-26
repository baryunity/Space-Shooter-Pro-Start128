using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadSinglePlayerGame()
    {
        print("Single Player Game Loading...");
        SceneManager.LoadScene("Single_Player");
    }    
    
    public void LoadCoopMode()
    {
        print("Coop Mode Loading...");
        SceneManager.LoadScene("Co-Op_Mode");
    }

    public void LoadGame()
    {
        //print("LoadGame 1");
        SceneManager.LoadScene(1);      // Game Scene
        //print("LoadGame 22");
    }
}
