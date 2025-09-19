using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuruhashiUI : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[3];
    private int Turuhashi = 3;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Turuhashi < 3)
        {
            Turuhashi++;
            lifeArray[Turuhashi - 1].SetActive(true);
        }

        else if (Input.GetMouseButtonDown(1) && Turuhashi > 0)
        {
            lifeArray[Turuhashi - 1].SetActive(false);
            Turuhashi--;
        }
    }
}
