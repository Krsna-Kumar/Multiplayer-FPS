using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;


namespace Com.Kawaiisun.SimpleHostile
{
    public class Pause : MonoBehaviour
    {
        public static bool paused = true;
        private bool disconnecting = false;

        public void TogglePause()
        {
            if (disconnecting) return;

            
                paused = !paused;

                transform.GetChild(0).gameObject.SetActive(false);
                Cursor.lockState = (paused) ? CursorLockMode.None : CursorLockMode.Confined;

                Cursor.visible = paused;
            
        }

        public void Quit()
        {
            disconnecting = true;
            PhotonNetwork.LeaveRoom();
            SceneManager.LoadScene(0);
        }
    }
}
