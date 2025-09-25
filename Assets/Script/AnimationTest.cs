using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    private Animator _anim = null;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
     
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
}
