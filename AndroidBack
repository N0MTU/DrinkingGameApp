using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AndroidBack : MonoBehaviour
{
    public GameObject playerList;
    
    // Update is called once per frame
    void Update()
    {
  
           //Android back button response 
            if (Input.GetKey(KeyCode.Escape))
            {
                if (playerList.activeInHierarchy == true)
                {
                    playerList.SetActive(false);
                }
               // else
               // {
                //    SceneManager.LoadScene("GamesList", LoadSceneMode.Single);
              //  }
            }
        if (Input.GetKey(KeyCode.Menu))
        {
            if (playerList.activeInHierarchy == true)
            {
                playerList.SetActive(false);
            }
            else if (playerList.activeInHierarchy == false)
            {
                playerList.SetActive(true);
            }
        }

       // }
    }
}
