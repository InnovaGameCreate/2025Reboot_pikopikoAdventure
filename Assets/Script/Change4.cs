using UnityEngine;
using UnityEngine.SceneManagement;

public class Change4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Stage4");
        }
    
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("OP");
        }
    }
}
