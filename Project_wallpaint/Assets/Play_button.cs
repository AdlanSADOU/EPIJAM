using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Play_button : MonoBehaviour
{

    public Button play_button;

    public void Load_Game()
    {
        SceneManager.LoadScene("GameScene");
    }

   public void quit_game()
   {
       Application.Quit(0);
   }

}