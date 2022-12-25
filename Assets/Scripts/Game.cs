using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class Game : MonoBehaviour
{
    public void StartGame()
    {
        Application.LoadLevel(1);
    }
    public void Options()
    {
        Application.LoadLevel(2);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
