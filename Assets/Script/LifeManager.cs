using UnityEngine;

public class LifeManager : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[3];

    void Start()
    {
        for (int i = 0; i < lifeArray.Length; i++)
        {
            lifeArray[i].SetActive(i < LifeData.lifePoint);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && LifeData.lifePoint < 3)
        {
            lifeArray[LifeData.lifePoint].SetActive(true);
            LifeData.lifePoint++;
        }
        else if (Input.GetMouseButtonDown(1) && LifeData.lifePoint > 0)
        {
            LifeData.lifePoint--;
            lifeArray[LifeData.lifePoint].SetActive(false);
        }
    }
}
