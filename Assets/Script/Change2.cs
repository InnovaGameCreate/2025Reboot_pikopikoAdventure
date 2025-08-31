using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
         void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Stage2");
        }
    
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("OP");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Stage3");
           
        }
    }
}
