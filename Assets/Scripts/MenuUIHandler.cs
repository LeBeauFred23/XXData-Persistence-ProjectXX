using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour

{
    //This is the handler of the main menu scene

    [SerializeField] Text PlayerNameInput;

        public void StartNew()
{
    SceneManager.LoadScene(1);
}

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

     public void SetPlayerName()
    {
        PlayerDataHandler.Instance.PlayerName = PlayerNameInput.text;
    }
    // Start is called before the first frame update
   public void Exit()
{
 
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
}
}
