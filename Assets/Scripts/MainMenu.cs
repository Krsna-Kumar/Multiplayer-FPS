using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Com.Kawaiisun.SimpleHostile
{
    public class MainMenu : MonoBehaviour
    {
        public Launcher launcher;

        /*private void Start()
        {
            Pause.paused = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false; 
        }*/
        public void JoiningMatch()
        {
            launcher.Join();
           
        }

        public void CreateMatch()
        {
            launcher.Create();
            
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
