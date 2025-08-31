using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S1ChangeScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Stage2");

        }
    }

         void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Stage1");
        }
    
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("OP");
        }
    }

}
