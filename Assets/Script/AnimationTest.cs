using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationTest : MonoBehaviour
{
    private Animator anim;
    private int life = 3;
    private Animator _anim = null;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        anim.SetInteger("Life", life);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.F))
        {
            _anim.SetBool("walk", true);
        }
        else
        {
            _anim.SetBool("walk", false);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            _anim.SetBool("jump", true);
        }
        else
        {
            _anim.SetBool("jump", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            life = Mathf.Max(life - 1, 0);
            anim.SetInteger("Life", life);

            // ライフをシーン間で共有（次のシーンで表示するため）
            PlayerPrefs.SetInt("Life", life);

            // シーン遷移（例：LifeLostScene）
            SceneManager.LoadScene("LifeLostScene");
        }
    }
}

